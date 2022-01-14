
namespace Projekt___TBP
{
    partial class FrmSatnica
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSmjena = new System.Windows.Forms.TextBox();
            this.txtSatnica = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Smjena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Satnica";
            // 
            // txtSmjena
            // 
            this.txtSmjena.Location = new System.Drawing.Point(112, 46);
            this.txtSmjena.Name = "txtSmjena";
            this.txtSmjena.Size = new System.Drawing.Size(166, 27);
            this.txtSmjena.TabIndex = 2;
            // 
            // txtSatnica
            // 
            this.txtSatnica.Location = new System.Drawing.Point(112, 101);
            this.txtSatnica.Name = "txtSatnica";
            this.txtSatnica.Size = new System.Drawing.Size(166, 27);
            this.txtSatnica.TabIndex = 3;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(195, 172);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(133, 41);
            this.btnSpremi.TabIndex = 4;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // FrmSatnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 238);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtSatnica);
            this.Controls.Add(this.txtSmjena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSatnica";
            this.Text = "Promjena satnice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSmjena;
        private System.Windows.Forms.TextBox txtSatnica;
        private System.Windows.Forms.Button btnSpremi;
    }
}