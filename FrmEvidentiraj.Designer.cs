
namespace Projekt___TBP
{
    partial class FrmEvidentiraj
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
            this.btnZapocniSmjenu = new System.Windows.Forms.Button();
            this.btnZavrsiSmjenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGO = new System.Windows.Forms.Button();
            this.btnBolovanje = new System.Windows.Forms.Button();
            this.dtpPocGO = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpKrajGO = new System.Windows.Forms.DateTimePicker();
            this.dtpKrajBolovanje = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpPocBolovanje = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnZapocniSmjenu
            // 
            this.btnZapocniSmjenu.Location = new System.Drawing.Point(40, 45);
            this.btnZapocniSmjenu.Name = "btnZapocniSmjenu";
            this.btnZapocniSmjenu.Size = new System.Drawing.Size(257, 61);
            this.btnZapocniSmjenu.TabIndex = 0;
            this.btnZapocniSmjenu.Text = "Započela smjena";
            this.btnZapocniSmjenu.UseVisualStyleBackColor = true;
            this.btnZapocniSmjenu.Click += new System.EventHandler(this.btnZapocniSmjenu_Click);
            // 
            // btnZavrsiSmjenu
            // 
            this.btnZavrsiSmjenu.Location = new System.Drawing.Point(40, 161);
            this.btnZavrsiSmjenu.Name = "btnZavrsiSmjenu";
            this.btnZavrsiSmjenu.Size = new System.Drawing.Size(257, 61);
            this.btnZavrsiSmjenu.TabIndex = 1;
            this.btnZavrsiSmjenu.Text = "Završila smjena";
            this.btnZavrsiSmjenu.UseVisualStyleBackColor = true;
            this.btnZavrsiSmjenu.Click += new System.EventHandler(this.btnZavrsiSmjenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Smjena započela u:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Smjena završila u:";
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(442, 272);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(179, 72);
            this.btnGO.TabIndex = 4;
            this.btnGO.Text = "Evidentiraj godišnji odmor";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // btnBolovanje
            // 
            this.btnBolovanje.Location = new System.Drawing.Point(442, 373);
            this.btnBolovanje.Name = "btnBolovanje";
            this.btnBolovanje.Size = new System.Drawing.Size(179, 69);
            this.btnBolovanje.TabIndex = 5;
            this.btnBolovanje.Text = "Evidentiraj bolovanje";
            this.btnBolovanje.UseVisualStyleBackColor = true;
            this.btnBolovanje.Click += new System.EventHandler(this.btnBolovanje_Click);
            // 
            // dtpPocGO
            // 
            this.dtpPocGO.Location = new System.Drawing.Point(182, 274);
            this.dtpPocGO.Name = "dtpPocGO";
            this.dtpPocGO.Size = new System.Drawing.Size(254, 27);
            this.dtpPocGO.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Godišnji odmor od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Godišnji odmor do:";
            // 
            // dtpKrajGO
            // 
            this.dtpKrajGO.Location = new System.Drawing.Point(182, 317);
            this.dtpKrajGO.Name = "dtpKrajGO";
            this.dtpKrajGO.Size = new System.Drawing.Size(254, 27);
            this.dtpKrajGO.TabIndex = 9;
            // 
            // dtpKrajBolovanje
            // 
            this.dtpKrajBolovanje.Location = new System.Drawing.Point(155, 416);
            this.dtpKrajBolovanje.Name = "dtpKrajBolovanje";
            this.dtpKrajBolovanje.Size = new System.Drawing.Size(254, 27);
            this.dtpKrajBolovanje.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bolovanje do:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bolovanje od:";
            // 
            // dtpPocBolovanje
            // 
            this.dtpPocBolovanje.Location = new System.Drawing.Point(155, 373);
            this.dtpPocBolovanje.Name = "dtpPocBolovanje";
            this.dtpPocBolovanje.Size = new System.Drawing.Size(254, 27);
            this.dtpPocBolovanje.TabIndex = 10;
            // 
            // FrmEvidentiraj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 484);
            this.Controls.Add(this.dtpKrajBolovanje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpPocBolovanje);
            this.Controls.Add(this.dtpKrajGO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpPocGO);
            this.Controls.Add(this.btnBolovanje);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZavrsiSmjenu);
            this.Controls.Add(this.btnZapocniSmjenu);
            this.Name = "FrmEvidentiraj";
            this.Text = "Evidentiraj radno vrijeme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZapocniSmjenu;
        private System.Windows.Forms.Button btnZavrsiSmjenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Button btnBolovanje;
        private System.Windows.Forms.DateTimePicker dtpPocGO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpKrajGO;
        private System.Windows.Forms.DateTimePicker dtpKrajBolovanje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpPocBolovanje;
    }
}