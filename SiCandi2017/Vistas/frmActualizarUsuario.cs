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

namespace SiCandi2017.Vistas
{
    public partial class frmActualizarUsuario : Form
    {
        frmBuscarUsuario vMain;
        
       
        public frmActualizarUsuario(frmBuscarUsuario vmain)
        {
            InitializeComponent();
            vMain = vmain;
            vMain.cargarUsuario();
        }
        int fkRol = 0;
        string pass;

        private void frmActualizarUsuario_Load(object sender, EventArgs e)
        {
            Usuario nUsuario = ManejoUsuario.getById(frmBuscarUsuario.PKUSU);
            txtEmailAgregarUsuario.Text = nUsuario.iEmpleadoUsuario.ToString();
            pass = nUsuario.sPassword;
        }

        private void btnCancelarAgregarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btbAceptarAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (this.txtEmailAgregarUsuario.Text == "")
            {
                this.errorProvider1.SetIconAlignment(this.txtEmailAgregarUsuario, ErrorIconAlignment.MiddleRight);
                this.errorProvider1.SetError(this.txtEmailAgregarUsuario, "Campo necesario");
                this.txtEmailAgregarUsuario.Focus();
            }
            else
            {
                Usuario nUsuario = ManejoUsuario.getById(frmBuscarUsuario.PKUSU);
                nUsuario.pkUsuario = frmBuscarUsuario.PKUSU;
                nUsuario.iEmpleadoUsuario = Convert.ToInt32(txtEmailAgregarUsuario.Text);
                fkRol = 2;
                nUsuario.sPassword = pass;

                ManejoUsuario.Modificar(nUsuario, fkRol);

                vMain.cargarUsuario();
                this.Close();
            }


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
