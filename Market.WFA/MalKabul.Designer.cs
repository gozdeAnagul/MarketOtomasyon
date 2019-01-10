namespace Market.WFA
{
    partial class MalKabul
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
            this.btnStogaEkle = new System.Windows.Forms.Button();
            this.nuKutu = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.pbBarkod = new System.Windows.Forms.PictureBox();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nuKutu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStogaEkle
            // 
            this.btnStogaEkle.Location = new System.Drawing.Point(488, 221);
            this.btnStogaEkle.Name = "btnStogaEkle";
            this.btnStogaEkle.Size = new System.Drawing.Size(81, 34);
            this.btnStogaEkle.TabIndex = 43;
            this.btnStogaEkle.Text = "Stoğa Ekle";
            this.btnStogaEkle.UseVisualStyleBackColor = true;
            this.btnStogaEkle.Click += new System.EventHandler(this.btnStogaEkle_Click);
            // 
            // nuKutu
            // 
            this.nuKutu.Location = new System.Drawing.Point(421, 195);
            this.nuKutu.Name = "nuKutu";
            this.nuKutu.Size = new System.Drawing.Size(148, 20);
            this.nuKutu.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Koli Adeti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Barkod";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(354, 52);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(215, 20);
            this.txtBarkod.TabIndex = 37;
            // 
            // pbBarkod
            // 
            this.pbBarkod.Location = new System.Drawing.Point(354, 78);
            this.pbBarkod.Name = "pbBarkod";
            this.pbBarkod.Size = new System.Drawing.Size(215, 111);
            this.pbBarkod.TabIndex = 56;
            this.pbBarkod.TabStop = false;
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(12, 78);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(174, 21);
            this.cmbKategoriler.TabIndex = 58;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged);
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(12, 105);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(174, 303);
            this.lstUrunler.TabIndex = 59;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // MalKabul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 422);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.pbBarkod);
            this.Controls.Add(this.btnStogaEkle);
            this.Controls.Add(this.nuKutu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBarkod);
            this.Name = "MalKabul";
            this.Text = "MalKabul";
            this.Load += new System.EventHandler(this.MalKabul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuKutu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStogaEkle;
        private System.Windows.Forms.NumericUpDown nuKutu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.PictureBox pbBarkod;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.ListBox lstUrunler;
    }
}