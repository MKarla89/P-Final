namespace SiCandi2017.Vistas
{
    partial class frmMenuReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.gbxButtons = new System.Windows.Forms.GroupBox();
            this.btnCandiCaptuCapturi = new System.Windows.Forms.Button();
            this.btnCandiGanaMuni = new System.Windows.Forms.Button();
            this.btnCandiPuntuAlta = new System.Windows.Forms.Button();
            this.btnCandiporMuni = new System.Windows.Forms.Button();
            this.btnCandiporConvo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxButtons
            // 
            this.gbxButtons.Controls.Add(this.btnCandiCaptuCapturi);
            this.gbxButtons.Controls.Add(this.btnCandiGanaMuni);
            this.gbxButtons.Controls.Add(this.btnCandiPuntuAlta);
            this.gbxButtons.Controls.Add(this.btnCandiporMuni);
            this.gbxButtons.Controls.Add(this.btnCandiporConvo);
            this.gbxButtons.Location = new System.Drawing.Point(10, 36);
            this.gbxButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxButtons.Name = "gbxButtons";
            this.gbxButtons.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxButtons.Size = new System.Drawing.Size(297, 158);
            this.gbxButtons.TabIndex = 0;
            this.gbxButtons.TabStop = false;
            // 
            // btnCandiCaptuCapturi
            // 
            this.btnCandiCaptuCapturi.BackColor = System.Drawing.Color.White;
            this.btnCandiCaptuCapturi.Location = new System.Drawing.Point(4, 127);
            this.btnCandiCaptuCapturi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCandiCaptuCapturi.Name = "btnCandiCaptuCapturi";
            this.btnCandiCaptuCapturi.Size = new System.Drawing.Size(287, 23);
            this.btnCandiCaptuCapturi.TabIndex = 4;
            this.btnCandiCaptuCapturi.Tag = "4";
            this.btnCandiCaptuCapturi.Text = "Candidatas capturadas por capturista";
            this.btnCandiCaptuCapturi.UseVisualStyleBackColor = false;
            this.btnCandiCaptuCapturi.Click += new System.EventHandler(this.btnCandiCaptuCapturi_Click);
            // 
            // btnCandiGanaMuni
            // 
            this.btnCandiGanaMuni.BackColor = System.Drawing.Color.White;
            this.btnCandiGanaMuni.Location = new System.Drawing.Point(4, 100);
            this.btnCandiGanaMuni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCandiGanaMuni.Name = "btnCandiGanaMuni";
            this.btnCandiGanaMuni.Size = new System.Drawing.Size(287, 23);
            this.btnCandiGanaMuni.TabIndex = 3;
            this.btnCandiGanaMuni.Tag = "4";
            this.btnCandiGanaMuni.Text = "Candidatas ganadoras por municipio";
            this.btnCandiGanaMuni.UseVisualStyleBackColor = false;
            this.btnCandiGanaMuni.Click += new System.EventHandler(this.btnCandiGanaMuni_Click);
            // 
            // btnCandiPuntuAlta
            // 
            this.btnCandiPuntuAlta.BackColor = System.Drawing.Color.White;
            this.btnCandiPuntuAlta.Location = new System.Drawing.Point(4, 73);
            this.btnCandiPuntuAlta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCandiPuntuAlta.Name = "btnCandiPuntuAlta";
            this.btnCandiPuntuAlta.Size = new System.Drawing.Size(287, 23);
            this.btnCandiPuntuAlta.TabIndex = 2;
            this.btnCandiPuntuAlta.Tag = "4";
            this.btnCandiPuntuAlta.Text = "Candidatas con puntuacion mas alta";
            this.btnCandiPuntuAlta.UseVisualStyleBackColor = false;
            this.btnCandiPuntuAlta.Click += new System.EventHandler(this.btnCandiPuntuAlta_Click);
            // 
            // btnCandiporMuni
            // 
            this.btnCandiporMuni.BackColor = System.Drawing.Color.White;
            this.btnCandiporMuni.Location = new System.Drawing.Point(4, 46);
            this.btnCandiporMuni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCandiporMuni.Name = "btnCandiporMuni";
            this.btnCandiporMuni.Size = new System.Drawing.Size(287, 23);
            this.btnCandiporMuni.TabIndex = 1;
            this.btnCandiporMuni.Text = "Candidatas por municipio";
            this.btnCandiporMuni.UseVisualStyleBackColor = false;
            this.btnCandiporMuni.Click += new System.EventHandler(this.btnCandiporMuni_Click);
            // 
            // btnCandiporConvo
            // 
            this.btnCandiporConvo.BackColor = System.Drawing.Color.White;
            this.btnCandiporConvo.Location = new System.Drawing.Point(4, 17);
            this.btnCandiporConvo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCandiporConvo.Name = "btnCandiporConvo";
            this.btnCandiporConvo.Size = new System.Drawing.Size(287, 23);
            this.btnCandiporConvo.TabIndex = 0;
            this.btnCandiporConvo.Text = "Candidatas por convocatora";
            this.btnCandiporConvo.UseVisualStyleBackColor = false;
            this.btnCandiporConvo.Click += new System.EventHandler(this.btnCandiporConvo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reportes";
            // 
            // frmMenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(319, 203);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxButtons);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Activated += new System.EventHandler(this.frmMenuReportes_Activated);
            this.Load += new System.EventHandler(this.b);
            this.gbxButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.GroupBox gbxButtons;
        private System.Windows.Forms.Button btnCandiCaptuCapturi;
        private System.Windows.Forms.Button btnCandiGanaMuni;
        private System.Windows.Forms.Button btnCandiPuntuAlta;
        private System.Windows.Forms.Button btnCandiporMuni;
        private System.Windows.Forms.Button btnCandiporConvo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}