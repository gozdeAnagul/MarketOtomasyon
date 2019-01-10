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
            this.nuKoli = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.pbBarkod = new System.Windows.Forms.PictureBox();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.btnBarkodGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuKoli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStogaEkle
            // 
            this.btnStogaEkle.Location = new System.Drawing.Point(480, 269);
            this.btnStogaEkle.Name = "btnStogaEkle";
            this.btnStogaEkle.Size = new System.Drawing.Size(81, 34);
            this.btnStogaEkle.TabIndex = 43;
            this.btnStogaEkle.Text = "Stoğa Ekle";
            this.btnStogaEkle.UseVisualStyleBackColor = true;
            this.btnStogaEkle.Click += new System.EventHandler(this.btnStogaEkle_Click);
            // 
            // nuKoli
            // 
            this.nuKoli.Location = new System.Drawing.Point(413, 243);
            this.nuKoli.Name = "nuKoli";
            this.nuKoli.Size = new System.Drawing.Size(148, 20);
            this.nuKoli.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Koli Adeti:";
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Location = new System.Drawing.Point(430, 82);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(41, 13);
            this.lblBarkod.TabIndex = 38;
            this.lblBarkod.Text = "Barkod";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(346, 100);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(158, 20);
            this.txtBarkod.TabIndex = 37;
            // 
            // pbBarkod
            // 
            this.pbBarkod.Location = new System.Drawing.Point(346, 126);
            this.pbBarkod.Name = "pbBarkod";
            this.pbBarkod.Size = new System.Drawing.Size(215, 111);
            this.pbBarkod.TabIndex = 56;
            this.pbBarkod.TabStop = false;
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(22, 31);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(174, 21);
            this.cmbKategoriler.TabIndex = 58;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged);
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(22, 58);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(174, 303);
            this.lstUrunler.TabIndex = 59;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // btnBarkodGetir
            // 
            this.btnBarkodGetir.Location = new System.Drawing.Point(510, 98);
            this.btnBarkodGetir.Name = "btnBarkodGetir";
            this.btnBarkodGetir.Size = new System.Drawing.Size(51, 23);
            this.btnBarkodGetir.TabIndex = 60;
            this.btnBarkodGetir.Text = "Bul";
            this.btnBarkodGetir.UseVisualStyleBackColor = true;
            this.btnBarkodGetir.Click += new System.EventHandler(this.btnBarkodGetir_Click);
            // 
            // MalKabul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 422);
            this.Controls.Add(this.btnBarkodGetir);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.pbBarkod);
            this.Controls.Add(this.btnStogaEkle);
            this.Controls.Add(this.nuKoli);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.txtBarkod);
            this.Name = "MalKabul";
            this.Text = "MalKabul";
            this.Load += new System.EventHandler(this.MalKabul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuKoli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStogaEkle;
        private System.Windows.Forms.NumericUpDown nuKoli;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.PictureBox pbBarkod;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Button btnBarkodGetir;
    }
}