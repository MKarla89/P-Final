using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiCandi2017.Vistas
{
    public partial class frmMenuReportes : Form
    {
        public frmMenuReportes()
        {
            InitializeComponent();

      
        }

        public void ProcesarPermisos()
        {
            int permisos = 0;

            foreach (var obj in this.gbxButtons.Controls)
            {
                if (obj is Button)
                {
                    Button btn = (Button)obj;
                    permisos = Convert.ToInt32(btn.Tag);
                    btn.Enabled = frmMenu.uHelper.TienePermiso(permisos);
                }
            }
        }

        private void btnCandiporConvo_Click(object sender, EventArgs e)
        {
            Reports.FrmReporteCandidataConvocatoria r = new Reports.FrmReporteCandidataConvocatoria();
            r.ShowDialog();
        }

        private void btnCandiporMuni_Click(object sender, EventArgs e)
        {
            Reports.frmCandidataPorMunicipio r = new Reports.frmCandidataPorMunicipio();
            r.ShowDialog();

        }

        private void btnCandiPuntuAlta_Click(object sender, EventArgs e)
        {
            Reports.frmCandidatasMasLike r = new Reports.frmCandidatasMasLike();
            r.ShowDialog();

        }

        private void btnCandiGanaMuni_Click(object sender, EventArgs e)
        {
            Reports.frmGanadoraPorMunicipio r = new Reports.frmGanadoraPorMunicipio();
            r.ShowDialog();
        }

        private void btnCandiCaptuCapturi_Click(object sender, EventArgs e)
        {
            Reports.frmCandidataPorCapturista r = new Reports.frmCandidataPorCapturista();
            r.ShowDialog();
        }

        private void frmMenuReportes_Activated(object sender, EventArgs e)
        {
            this.ProcesarPermisos();
        }

        private void b(object sender, EventArgs e)
        {

        }
    }
}
