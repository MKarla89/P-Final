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
    public partial class frmMenu : Form
    {
        public static UsuarioHelper uHelper;
        public frmMenu()
        {
            InitializeComponent();
        }
        public void ProcesarPermisos()
        {
            int permisos = 0;

            foreach (var obj in this.groupBox1.Controls)
            {
                if (obj is Button)
                {
                    Button btn = (Button)obj;
                    permisos = Convert.ToInt32(btn.Tag);
                    btn.Enabled = uHelper.TienePermiso(permisos);
                }
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (uHelper == null)
            {
                frmLogin vLogin = new frmLogin();
                vLogin.ShowDialog();
            }
            if (uHelper.esValido && uHelper != null)
            {
                //TODO: ACTIVAR TODOS LOS CONTROLES SEGUN EL PERMISO
            }
            else
            {
                MessageBox.Show("Se require se autentifique", "Eror..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCandidatas_Click(object sender, EventArgs e)
        {

            frmRegistroCandidata v = new frmRegistroCandidata();
            v.ShowDialog();
        }

        private void btnMunicipio_Click(object sender, EventArgs e)
        {
            frmRegistroMunicipio v = new frmRegistroMunicipio();
            v.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenuReportes R = new frmMenuReportes();
            R.ShowDialog();
        }

        private void frmMenu_Activated(object sender, EventArgs e)
        {
            this.ProcesarPermisos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegistrarUsuario frm = new frmRegistrarUsuario();
            frm.ShowDialog();
        }
    }
}
