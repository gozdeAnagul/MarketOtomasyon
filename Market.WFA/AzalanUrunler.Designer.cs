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
            ((System.ComponentModel.ISupportInitialize)(this.nuKutu)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAzalanUrunler
            // 
            this.lstAzalanUrunler.FormattingEnabled = true;
            this.lstAzalanUrunler.ItemHeight = 16;
            this.lstAzalanUrunler.Location = new System.Drawing.Point(16, 68);
            this.lstAzalanUrunler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAzalanUrunler.Name = "lstAzalanUrunler";
            this.lstAzalanUrunler.Size = new System.Drawing.Size(412, 404);
            this.lstAzalanUrunler.TabIndex = 0;
            this.lstAzalanUrunler.SelectedIndexChanged += new System.EventHandler(this.lstAzalanUrunler_SelectedIndexChanged);
            // 
            // btnStogaEkle
            // 
            this.btnStogaEkle.Location = new System.Drawing.Point(335, 486);
            this.btnStogaEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStogaEkle.Name = "btnStogaEkle";
            this.btnStogaEkle.Size = new System.Drawing.Size(123, 36);
            this.btnStogaEkle.TabIndex = 46;
            this.btnStogaEkle.Text = "Stoğu Güncelle";
            this.btnStogaEkle.UseVisualStyleBackColor = true;
            this.btnStogaEkle.Click += new System.EventHandler(this.btnStogaEkle_Click);
            // 
            // nuKutu
            // 
            this.nuKutu.Location = new System.Drawing.Point(105, 494);
            this.nuKutu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nuKutu.Name = "nuKutu";
            this.nuKutu.Size = new System.Drawing.Size(197, 22);
            this.nuKutu.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(16, 494);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 45;
            this.label9.Text = "Koli Adeti:";
            // 
            // lblAzalanUrunler
            // 
            this.lblAzalanUrunler.AutoSize = true;
            this.lblAzalanUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAzalanUrunler.Location = new System.Drawing.Point(9, 20);
            this.lblAzalanUrunler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAzalanUrunler.Name = "lblAzalanUrunler";
            this.lblAzalanUrunler.Size = new System.Drawing.Size(207, 31);
            this.lblAzalanUrunler.TabIndex = 47;
            this.lblAzalanUrunler.Text = "Azalan Urunler";
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(556, 31);
            this.cmbKategoriler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(152, 24);
            this.cmbKategoriler.TabIndex = 48;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged);
            // 
            // lstKategoriUrunleri
            // 
            this.lstKategoriUrunleri.FormattingEnabled = true;
            this.lstKategoriUrunleri.ItemHeight = 16;
            this.lstKategoriUrunleri.Location = new System.Drawing.Point(556, 68);
            this.lstKategoriUrunleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstKategoriUrunleri.Name = "lstKategoriUrunleri";
            this.lstKategoriUrunleri.Size = new System.Drawing.Size(409, 404);
            this.lstKategoriUrunleri.TabIndex = 49;
            // 
            // lblKatUrunAdeti
            // 
            this.lblKatUrunAdeti.AutoSize = true;
            this.lblKatUrunAdeti.Location = new System.Drawing.Point(728, 34);
            this.lblKatUrunAdeti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKatUrunAdeti.Name = "lblKatUrunAdeti";
            this.lblKatUrunAdeti.Size = new System.Drawing.Size(46, 17);
            this.lblKatUrunAdeti.TabIndex = 50;
            this.lblKatUrunAdeti.Text = "label1";
            // 
            // AzalanUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 554);
            this.Controls.Add(this.lblKatUrunAdeti);
            this.Controls.Add(this.lstKategoriUrunleri);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.lblAzalanUrunler);
            this.Controls.Add(this.btnStogaEkle);
            this.Controls.Add(this.nuKutu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstAzalanUrunler);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AzalanUrunler";
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
    }
}