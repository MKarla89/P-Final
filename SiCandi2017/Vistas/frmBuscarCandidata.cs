using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiCandi_Library.Modelo;
using SiCandi2017.Controlador;

namespace SiCandi2017.Vistas
{
    public partial class frmBuscarCandidata : Form
    {
        public static int PKCANDIDATA;
        public frmBuscarCandidata()
        {
            InitializeComponent();
            this.dgvDatosCandidata.AutoGenerateColumns = false;
        }
        public void cargarCandidatas()
        {
            this.dgvDatosCandidata.DataSource = ManejoCandidata.Buscar(txtBuscarCandidata.Text, ckbStatus.Checked);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBuscarCandidata_Load(object sender, EventArgs e)
        {
            this.cargarCandidatas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.dgvDatosCandidata.RowCount >= 1)
            {
                PKCANDIDATA = Convert.ToInt32(this.dgvDatosCandidata.CurrentRow.Cells[0].Value);
                frmActualizarCandidata v = new frmActualizarCandidata(this);
                v.ShowDialog();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.dgvDatosCandidata.RowCount >= 1)
            {
                if (MessageBox.Show("Realmente quiere elimar este registro?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ManejoCandidata.Eliminar(Convert.ToInt32(this.dgvDatosCandidata.CurrentRow.Cells[0].Value));
                    this.cargarCandidatas();
                }
            }
        }

        private void ckbStatus_CheckedChanged(object sender, EventArgs e)
        {
            this.cargarCandidatas();
        }

        private void txtBuscarCandidata_TextChanged(object sender, EventArgs e)
        {
            this.cargarCandidatas();
        }

        private void dgvDatosCandidata_DataSourceChanged(object sender, EventArgs e)
        {
            lblRegistros.Text = "Registros: " + this.dgvDatosCandidata.Rows.Count;
        }

        private void txtBuscarCandidata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
               && e.KeyChar != 8) e.Handled = true;
        }
    }
}
