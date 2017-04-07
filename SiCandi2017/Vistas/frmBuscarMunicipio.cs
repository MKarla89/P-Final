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
using SiCandi2017.Vistas;

namespace SiCandi2017.Vistas
{
    public partial class frmBuscarMunicipio : Form
    {
        public static int PKMUNICIPIO;
        public frmBuscarMunicipio()
        {
           
           
            InitializeComponent();
            this.dgvMunicipios.AutoGenerateColumns = false;
        }
        public void cargarMunicipios()
        {
            this.dgvMunicipios.DataSource = ManejoMunicipio.Buscar(txtBuscar.Text, ckbStatus.Checked);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.dgvMunicipios.RowCount >= 1)
            {
                PKMUNICIPIO = Convert.ToInt32(this.dgvMunicipios.CurrentRow.Cells[0].Value);
                frmActualizarMunicipio v = new frmActualizarMunicipio(this);
                v.ShowDialog();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.dgvMunicipios.RowCount >= 1)
            {
                if (MessageBox.Show("Realmente quiere elimar este registro?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ManejoMunicipio.Eliminar(Convert.ToInt32(this.dgvMunicipios.CurrentRow.Cells[0].Value));
                    this.cargarMunicipios();
                }
            }
        }

        private void ckbStatus_CheckedChanged(object sender, EventArgs e)
        {
            this.cargarMunicipios();
        }

        private void dgvMunicipios_DataSourceChanged(object sender, EventArgs e)
        {
            lblRegistro.Text = "Registros: " + this.dgvMunicipios.Rows.Count;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.cargarMunicipios();
        }

        private void frmBuscarMunicipio_Load(object sender, EventArgs e)
        {
            this.cargarMunicipios();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
               && e.KeyChar != 8) e.Handled = true;
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}
