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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
        }
        public void fn_prbar_()
        {
            progressBar1.Increment(1);
            label2.Text = progressBar1.Value.ToString() + "%";
            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                frmMenu fm = new frmMenu();
                fm.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fn_prbar_();
        }
    }
}
