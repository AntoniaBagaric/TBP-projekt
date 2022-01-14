
namespace Projekt___TBP
{
    partial class FrmEvidencijaIObracun
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
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnDohvatiObracun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AllowUserToAddRows = false;
            this.dgvZaposlenici.AllowUserToDeleteRows = false;
            this.dgvZaposlenici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvZaposlenici.Location = new System.Drawing.Point(24, 42);
            this.dgvZaposlenici.MultiSelect = false;
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.ReadOnly = true;
            this.dgvZaposlenici.RowHeadersWidth = 51;
            this.dgvZaposlenici.RowTemplate.Height = 29;
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(757, 312);
            this.dgvZaposlenici.TabIndex = 0;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(24, 9);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(250, 27);
            this.dtpDatum.TabIndex = 2;
            // 
            // btnDohvatiObracun
            // 
            this.btnDohvatiObracun.Location = new System.Drawing.Point(290, 9);
            this.btnDohvatiObracun.Name = "btnDohvatiObracun";
            this.btnDohvatiObracun.Size = new System.Drawing.Size(142, 27);
            this.btnDohvatiObracun.TabIndex = 3;
            this.btnDohvatiObracun.Text = "Dohvati evidenciju";
            this.btnDohvatiObracun.UseVisualStyleBackColor = true;
            this.btnDohvatiObracun.Click += new System.EventHandler(this.btnDohvatiObracun_Click);
            // 
            // FrmEvidencijaIObracun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDohvatiObracun);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.dgvZaposlenici);
            this.Name = "FrmEvidencijaIObracun";
            this.Text = "Evidencija rada";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnDohvatiObracun;
    }
}