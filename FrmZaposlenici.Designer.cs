
namespace Projekt___TBP
{
    partial class FrmZaposlenici
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
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObracunaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AllowUserToAddRows = false;
            this.dgvZaposlenici.AllowUserToDeleteRows = false;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Location = new System.Drawing.Point(25, 24);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.RowHeadersWidth = 51;
            this.dgvZaposlenici.RowTemplate.Height = 29;
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(763, 320);
            this.dgvZaposlenici.TabIndex = 0;
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(25, 367);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(203, 47);
            this.btnUredi.TabIndex = 1;
            this.btnUredi.Text = "Uredi zaposlenika";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnObracunaj
            // 
            this.btnObracunaj.Location = new System.Drawing.Point(585, 367);
            this.btnObracunaj.Name = "btnObracunaj";
            this.btnObracunaj.Size = new System.Drawing.Size(203, 47);
            this.btnObracunaj.TabIndex = 2;
            this.btnObracunaj.Text = "Obračunaj plaću";
            this.btnObracunaj.UseVisualStyleBackColor = true;
            this.btnObracunaj.Click += new System.EventHandler(this.btnObracunaj_Click);
            // 
            // FrmZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObracunaj);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.dgvZaposlenici);
            this.Name = "FrmZaposlenici";
            this.Text = "Zaposlenici";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObracunaj;
    }
}