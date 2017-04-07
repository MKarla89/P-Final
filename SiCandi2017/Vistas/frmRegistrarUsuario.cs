using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiCandi2017.Controlador;
using SiCandi_Library.Modelo;
using System.Text.RegularExpressions;
using AForge.Video;
using AForge.Video.DirectShow;
using SiCandi2017.Comun;

namespace SiCandi2017.Vistas
{
    public partial class frmRegistrarUsuario : Form
    {
        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Insert(0, "Seleccione Opcion");
            comboBox1.Items.Insert(1, "CAPTURISTA");
            comboBox1.SelectedIndex = 0;
        }

        private void btbAceptarAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                Usuario nu = new Usuario();

                int iEmpleadoUsuario = Convert.ToInt32(txtEmailAgregarUsuario.Text);
                nu.sPassword = LoginTool.GetMD5(txtContrasenaAgregarUsuario.Text);
                int fkRoles = Convert.ToInt32(comboBox1.SelectedIndex.ToString());


                MessageBox.Show("!Usuario Registrado¡");
                txtEmailAgregarUsuario.Clear();
                txtContrasenaAgregarUsuario.Clear();
                ManejoUsuario.guardar(nu, fkRoles, iEmpleadoUsuario);

            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscarUsuario frm = new frmBuscarUsuario();
            frm.ShowDialog();
        }

        private void btnCancelarAgregarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmailAgregarUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
