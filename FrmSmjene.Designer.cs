
namespace Projekt___TBP
{
    partial class FrmSmjene
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
            this.dgvSmjene = new System.Windows.Forms.DataGridView();
            this.btnPromijeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSmjene)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSmjene
            // 
            this.dgvSmjene.AllowUserToAddRows = false;
            this.dgvSmjene.AllowUserToDeleteRows = false;
            this.dgvSmjene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSmjene.Location = new System.Drawing.Point(29, 29);
            this.dgvSmjene.MultiSelect = false;
            this.dgvSmjene.Name = "dgvSmjene";
            this.dgvSmjene.RowHeadersWidth = 51;
            this.dgvSmjene.RowTemplate.Height = 29;
            this.dgvSmjene.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSmjene.Size = new System.Drawing.Size(468, 313);
            this.dgvSmjene.TabIndex = 0;
            // 
            // btnPromijeni
            // 
            this.btnPromijeni.Location = new System.Drawing.Point(369, 356);
            this.btnPromijeni.Name = "btnPromijeni";
            this.btnPromijeni.Size = new System.Drawing.Size(128, 70);
            this.btnPromijeni.TabIndex = 1;
            this.btnPromijeni.Text = "Promijeni satnicu";
            this.btnPromijeni.UseVisualStyleBackColor = true;
            this.btnPromijeni.Click += new System.EventHandler(this.btnPromijeni_Click);
            // 
            // FrmSmjene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 438);
            this.Controls.Add(this.btnPromijeni);
            this.Controls.Add(this.dgvSmjene);
            this.Name = "FrmSmjene";
            this.Text = "Smjene";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSmjene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSmjene;
        private System.Windows.Forms.Button btnPromijeni;
    }
}