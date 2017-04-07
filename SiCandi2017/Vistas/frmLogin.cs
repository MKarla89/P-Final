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
using SiCandi2017.Controlador.Helpers;

namespace SiCandi2017.Vistas
{
    public partial class frmLogin : Form
    {
        UsuarioHelper uHelper;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            uHelper = ManejoUsuario.Autentificar(Convert.ToInt32(txtNoEmpleado.Text),
               txtContraseña.Text);
            if (uHelper.esValido)
            {
                frmMenu.uHelper = uHelper;
                this.Close();
            }
            else
            {
                MessageBox.Show(uHelper.sMensaje, "Autentificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoEmpleado.Text = "";
                txtContraseña.Text = "";
                txtNoEmpleado.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
