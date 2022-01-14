
namespace Projekt___TBP
{
    partial class FrmIzbornik
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
            this.btnDodajRadnika = new System.Windows.Forms.Button();
            this.btnEvidentiraj = new System.Windows.Forms.Button();
            this.btnObracunajPlacu = new System.Windows.Forms.Button();
            this.btnPromSatnicu = new System.Windows.Forms.Button();
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.btnObracun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDodajRadnika
            // 
            this.btnDodajRadnika.Location = new System.Drawing.Point(32, 209);
            this.btnDodajRadnika.Name = "btnDodajRadnika";
            this.btnDodajRadnika.Size = new System.Drawing.Size(316, 62);
            this.btnDodajRadnika.TabIndex = 0;
            this.btnDodajRadnika.Text = "Dodaj novog radnika";
            this.btnDodajRadnika.UseVisualStyleBackColor = true;
            this.btnDodajRadnika.Click += new System.EventHandler(this.btnDodajRadnika_Click);
            // 
            // btnEvidentiraj
            // 
            this.btnEvidentiraj.Location = new System.Drawing.Point(34, 59);
            this.btnEvidentiraj.Name = "btnEvidentiraj";
            this.btnEvidentiraj.Size = new System.Drawing.Size(316, 62);
            this.btnEvidentiraj.TabIndex = 1;
            this.btnEvidentiraj.Text = "Evidentiraj radno vrijeme";
            this.btnEvidentiraj.UseVisualStyleBackColor = true;
            this.btnEvidentiraj.Click += new System.EventHandler(this.btnEvidentiraj_Click);
            // 
            // btnObracunajPlacu
            // 
            this.btnObracunajPlacu.Location = new System.Drawing.Point(32, 298);
            this.btnObracunajPlacu.Name = "btnObracunajPlacu";
            this.btnObracunajPlacu.Size = new System.Drawing.Size(316, 62);
            this.btnObracunajPlacu.TabIndex = 2;
            this.btnObracunajPlacu.Text = "Evidencija rada";
            this.btnObracunajPlacu.UseVisualStyleBackColor = true;
            this.btnObracunajPlacu.Click += new System.EventHandler(this.btnObracunajPlacu_Click);
            // 
            // btnPromSatnicu
            // 
            this.btnPromSatnicu.Location = new System.Drawing.Point(389, 209);
            this.btnPromSatnicu.Name = "btnPromSatnicu";
            this.btnPromSatnicu.Size = new System.Drawing.Size(314, 64);
            this.btnPromSatnicu.TabIndex = 3;
            this.btnPromSatnicu.Text = "Promijeni satnicu";
            this.btnPromSatnicu.UseVisualStyleBackColor = true;
            this.btnPromSatnicu.Click += new System.EventHandler(this.btnPromSatnicu_Click);
            // 
            // btnZaposlenici
            // 
            this.btnZaposlenici.Location = new System.Drawing.Point(389, 296);
            this.btnZaposlenici.Name = "btnZaposlenici";
            this.btnZaposlenici.Size = new System.Drawing.Size(314, 64);
            this.btnZaposlenici.TabIndex = 4;
            this.btnZaposlenici.Text = "Zaposlenici";
            this.btnZaposlenici.UseVisualStyleBackColor = true;
            this.btnZaposlenici.Click += new System.EventHandler(this.btnZaposlenici_Click);
            // 
            // btnObracun
            // 
            this.btnObracun.Location = new System.Drawing.Point(378, 59);
            this.btnObracun.Name = "btnObracun";
            this.btnObracun.Size = new System.Drawing.Size(316, 62);
            this.btnObracun.TabIndex = 5;
            this.btnObracun.Text = "Moj obracun";
            this.btnObracun.UseVisualStyleBackColor = true;
            this.btnObracun.Click += new System.EventHandler(this.btnObracun_Click);
            // 
            // FrmIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 493);
            this.Controls.Add(this.btnObracun);
            this.Controls.Add(this.btnZaposlenici);
            this.Controls.Add(this.btnPromSatnicu);
            this.Controls.Add(this.btnObracunajPlacu);
            this.Controls.Add(this.btnEvidentiraj);
            this.Controls.Add(this.btnDodajRadnika);
            this.Name = "FrmIzbornik";
            this.Text = "Izbornik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajRadnika;
        private System.Windows.Forms.Button btnEvidentiraj;
        private System.Windows.Forms.Button btnObracunajPlacu;
        private System.Windows.Forms.Button btnPromSatnicu;
        private System.Windows.Forms.Button btnZaposlenici;
        private System.Windows.Forms.Button btnObracun;
    }
}