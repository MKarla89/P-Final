using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using SiCandi2017.Controlador;
using SiCandi_Library.Modelo;
using SiCandi2017.Comun;
using System.Text.RegularExpressions;

namespace SiCandi2017.Vistas
{
    public partial class frmRegistroCandidata : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public String ImagenString { get; set; }
        public Bitmap ImagenBitmap { get; set; }
        int indexrol;
        public frmRegistroCandidata()
        {
            InitializeComponent();
        }

        private void frmRegistroCandidata_Load(object sender, EventArgs e)
        {
            this.cargarMunicipios();

            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in videoDevices)
            {
                cmbCamara.Items.Add(device.Name);
            }
            if (cmbCamara.Items.Count > 0)
            {
                cmbCamara.SelectedIndex = 0;
                videoSource = new VideoCaptureDevice();
            }
            else
            {
                //lblError.Visible = true;
            }
        }
        public void cargarMunicipios()
        {
            //llenar combo
            cmbMunicipio.DataSource = ManejoMunicipio.getAll(true);
            cmbMunicipio.DisplayMember = "sNombre";
            cmbMunicipio.ValueMember = "pkMunicipio";
            try
            {
                cmbMunicipio.SelectedIndex = indexrol;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarCandidata v = new Vistas.frmBuscarCandidata();
            v.ShowDialog();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtNombre, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtNombre, "Campo necesario");
                this.txtNombre.Focus();
            }
            else if (this.txtCurp.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtCurp, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtCurp, "Campo necesario");
                this.txtCurp.Focus();
            }
            else if (this.txtCorreoElectronico.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtCorreoElectronico, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtCorreoElectronico, "Campo necesario");
                this.txtCorreoElectronico.Focus();
            }
            else if (this.txtNivelEstudios.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtNivelEstudios, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtNivelEstudios, "Campo necesario");
                this.txtNivelEstudios.Focus();
            }
            else if (this.txtDescripcion.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtDescripcion, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtDescripcion, "Campo necesario");
                this.txtDescripcion.Focus();
            }
            else
            {
                Candidata nCandidata = new Candidata();

                nCandidata.dtAnioConvocatoria = dtpAnioConvocatoria.Value.Date;
                nCandidata.sNombreCompleto = txtNombre.Text;
                nCandidata.dtFechaNacimiento = dtpFechaNacimiento.Value.Date;
                nCandidata.sDescripcion = txtDescripcion.Text;
                nCandidata.sCorreoElectronico = txtCorreoElectronico.Text;
                nCandidata.sCurp = txtCurp.Text;
                nCandidata.sNivelEstudios = txtNivelEstudios.Text;
                nCandidata.sFotografiaRostro = ImagenString;
                int fkMunicipio = Convert.ToInt32(cmbMunicipio.SelectedValue.ToString());
                int fkUsuario = 1;
                ManejoCandidata.Guardar(nCandidata, fkMunicipio, fkUsuario);

                MessageBox.Show("!Candidata Registrada¡");
                txtCorreoElectronico.Clear();
                txtCurp.Clear();
                txtDescripcion.Clear();
                txtNivelEstudios.Clear();
                txtNombre.Clear();
                txtNombre.Focus();
                picImagen.Image = null;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtCurp_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtCorreoElectronico_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtNivelEstudios_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }
        private void videoSource_newFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ImagenBitmap = (Bitmap)eventArgs.Frame.Clone();
            ImagenString = ToolImagen.ToBase64String(ImagenBitmap, ImageFormat.Jpeg);
            picImagen.Image = ImagenBitmap;
        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                //this.picImagen.Image = null;
                this.picImagen.Image = ImagenBitmap;
                picImagen.Invalidate();
            }
            else
            {
                videoSource = new VideoCaptureDevice(videoDevices[cmbCamara.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_newFrame);
                videoSource.Start();
            }
        }
        public void FinalizarControles()
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
            }
        }

        public void PonerFotografia(String pathImagen)
        {
            ImagenBitmap = new System.Drawing.Bitmap(pathImagen);
            ImagenString = ToolImagen.ToBase64String(ImagenBitmap, ImageFormat.Jpeg);
            picImagen.Image = ImagenBitmap;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
               && e.KeyChar != 8) e.Handled = true;
        }

        private void txtCorreoElectronico_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCurp_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNivelEstudios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
               && e.KeyChar != 8) e.Handled = true;
        }

        private void frmRegistroCandidata_Leave(object sender, EventArgs e)
        {

        }
        public static bool ValidarEmail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// evento que llama mandar el metodo de validar correo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /// <summary>
        /// metodo que valida el curp
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>

        public static bool ValidarCurp(string curp)
        {
            string expresion = "^.*(?=.{18})(?=.*[0-9])(?=.*[A-ZÑ]).*$";
            if (Regex.IsMatch(curp, expresion))
            {
                if (Regex.Replace(curp, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtCorreoElectronico_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(txtCorreoElectronico.Text))
            {

            }
            else
            {
                MessageBox.Show("Direccion De Correo Electronico No Valido Debe de tener el formato : correo@gmail.com, " +
                    "Favor Sellecione Un Correo Valido", "Validacion De Correo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreoElectronico.SelectAll();
                txtCorreoElectronico.Focus();
            }
        }

        private void txtCurp_Leave(object sender, EventArgs e)
        {
            if (ValidarCurp(txtCurp.Text))
            {

            }
            else
            {
                MessageBox.Show("Curp No Valida Debe de tener el formato : BOMC870421HDGRLS05, " +
                    "Favor Sellecione Un Curp Valido", "Validacion De Curp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreoElectronico.SelectAll();
                txtCorreoElectronico.Focus();
            }
        }

        private void picImagen_Click(object sender, EventArgs e)
        {

        }
    }
}

    
    

