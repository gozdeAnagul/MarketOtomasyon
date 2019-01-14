namespace Market.WFA
{
    partial class AzalanUrunler
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
            this.lstAzalanUrunler = new System.Windows.Forms.ListBox();
            this.btnStogaEkle = new System.Windows.Forms.Button();
            this.nuKutu = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAzalanUrunler = new System.Windows.Forms.Label();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.lstKategoriUrunleri = new System.Windows.Forms.ListBox();
            this.lblKatUrunAdeti = new System.Windows.Forms.Label();
            this.lblKatToplamUrun = new System.Windows.Forms.Label();
            this.lblKolic = new System.Windows.Forms.Label();
            this.lblAdetIc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuKutu)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAzalanUrunler
            // 
            this.lstAzalanUrunler.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lstAzalanUrunler.FormattingEnabled = true;
            this.lstAzalanUrunler.ItemHeight = 15;
            this.lstAzalanUrunler.Location = new System.Drawing.Point(12, 55);
            this.lstAzalanUrunler.Name = "lstAzalanUrunler";
            this.lstAzalanUrunler.Size = new System.Drawing.Size(310, 259);
            this.lstAzalanUrunler.TabIndex = 0;
            this.lstAzalanUrunler.SelectedIndexChanged += new System.EventHandler(this.lstAzalanUrunler_SelectedIndexChanged);
            // 
            // btnStogaEkle
            // 
            this.btnStogaEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnStogaEkle.Location = new System.Drawing.Point(105, 390);
            this.btnStogaEkle.Name = "btnStogaEkle";
            this.btnStogaEkle.Size = new System.Drawing.Size(109, 48);
            this.btnStogaEkle.TabIndex = 46;
            this.btnStogaEkle.Text = "Stoğu Güncelle";
            this.btnStogaEkle.UseVisualStyleBackColor = true;
            this.btnStogaEkle.Click += new System.EventHandler(this.btnStogaEkle_Click);
            // 
            // nuKutu
            // 
            this.nuKutu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.nuKutu.Location = new System.Drawing.Point(91, 331);
            this.nuKutu.Name = "nuKutu";
            this.nuKutu.Size = new System.Drawing.Size(148, 24);
            this.nuKutu.TabIndex = 44;
            this.nuKutu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(13, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 45;
            this.label9.Text = "Koli Adeti:";
            // 
            // lblAzalanUrunler
            // 
            this.lblAzalanUrunler.AutoSize = true;
            this.lblAzalanUrunler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzalanUrunler.Location = new System.Drawing.Point(12, 24);
            this.lblAzalanUrunler.Name = "lblAzalanUrunler";
            this.lblAzalanUrunler.Size = new System.Drawing.Size(124, 21);
            this.lblAzalanUrunler.TabIndex = 47;
            this.lblAzalanUrunler.Text = "Azalan Ürünler";
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(483, 26);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(188, 23);
            this.cmbKategoriler.TabIndex = 48;
            this.cmbKategoriler.Text = "Kategori Seçiniz";
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged);
            // 
            // lstKategoriUrunleri
            // 
            this.lstKategoriUrunleri.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lstKategoriUrunleri.FormattingEnabled = true;
            this.lstKategoriUrunleri.ItemHeight = 15;
            this.lstKategoriUrunleri.Location = new System.Drawing.Point(417, 55);
            this.lstKategoriUrunleri.Name = "lstKategoriUrunleri";
            this.lstKategoriUrunleri.Size = new System.Drawing.Size(308, 259);
            this.lstKategoriUrunleri.TabIndex = 49;
            // 
            // lblKatUrunAdeti
            // 
            this.lblKatUrunAdeti.AutoSize = true;
            this.lblKatUrunAdeti.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblKatUrunAdeti.Location = new System.Drawing.Point(414, 331);
            this.lblKatUrunAdeti.Name = "lblKatUrunAdeti";
            this.lblKatUrunAdeti.Size = new System.Drawing.Size(38, 15);
            this.lblKatUrunAdeti.TabIndex = 50;
            this.lblKatUrunAdeti.Text = "label1";
            // 
            // lblKatToplamUrun
            // 
            this.lblKatToplamUrun.AutoSize = true;
            this.lblKatToplamUrun.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblKatToplamUrun.Location = new System.Drawing.Point(414, 354);
            this.lblKatToplamUrun.Name = "lblKatToplamUrun";
            this.lblKatToplamUrun.Size = new System.Drawing.Size(38, 15);
            this.lblKatToplamUrun.TabIndex = 51;
            this.lblKatToplamUrun.Text = "label1";
            // 
            // lblKolic
            // 
            this.lblKolic.AutoSize = true;
            this.lblKolic.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblKolic.Location = new System.Drawing.Point(16, 365);
            this.lblKolic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKolic.Name = "lblKolic";
            this.lblKolic.Size = new System.Drawing.Size(109, 15);
            this.lblKolic.TabIndex = 52;
            this.lblKolic.Text = "Koli İçi Ürün Adedi:";
            // 
            // lblAdetIc
            // 
            this.lblAdetIc.AutoSize = true;
            this.lblAdetIc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAdetIc.Location = new System.Drawing.Point(129, 365);
            this.lblAdetIc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdetIc.Name = "lblAdetIc";
            this.lblAdetIc.Size = new System.Drawing.Size(38, 15);
            this.lblAdetIc.TabIndex = 53;
            this.lblAdetIc.Text = "label1";
            // 
            // AzalanUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.lblAdetIc);
            this.Controls.Add(this.lblKolic);
            this.Controls.Add(this.lblKatToplamUrun);
            this.Controls.Add(this.lblKatUrunAdeti);
            this.Controls.Add(this.lstKategoriUrunleri);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.lblAzalanUrunler);
            this.Controls.Add(this.btnStogaEkle);
            this.Controls.Add(this.nuKutu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstAzalanUrunler);
            this.Name = "AzalanUrunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AzalanUrunler";
            this.Load += new System.EventHandler(this.AzalanUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuKutu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAzalanUrunler;
        private System.Windows.Forms.Button btnStogaEkle;
        private System.Windows.Forms.NumericUpDown nuKutu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAzalanUrunler;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.ListBox lstKategoriUrunleri;
        private System.Windows.Forms.Label lblKatUrunAdeti;
        private System.Windows.Forms.Label lblKatToplamUrun;
        private System.Windows.Forms.Label lblKolic;
        private System.Windows.Forms.Label lblAdetIc;
    }
}