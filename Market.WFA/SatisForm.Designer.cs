namespace Market.WFA
{
    partial class SatisForm
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
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.pbBarkod = new System.Windows.Forms.PictureBox();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.rbKrediKarti = new System.Windows.Forms.RadioButton();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParaUstu = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtAlinan = new System.Windows.Forms.TextBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunCikar = new System.Windows.Forms.Button();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.nuUrunAdet = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.nuPosetSayisi = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuUrunAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPosetSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(28, 116);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(285, 22);
            this.txtBarkod.TabIndex = 0;
            // 
            // pbBarkod
            // 
            this.pbBarkod.Location = new System.Drawing.Point(28, 148);
            this.pbBarkod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbBarkod.Name = "pbBarkod";
            this.pbBarkod.Size = new System.Drawing.Size(287, 137);
            this.pbBarkod.TabIndex = 1;
            this.pbBarkod.TabStop = false;
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 16;
            this.lstSepet.Location = new System.Drawing.Point(340, 36);
            this.lstSepet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(301, 372);
            this.lstSepet.TabIndex = 2;
           
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Location = new System.Drawing.Point(681, 36);
            this.rbNakit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNakit.Location = new System.Drawing.Point(500, 97);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(111, 21);
            this.rbNakit.TabIndex = 3;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit Ödeme";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.rbNakit_CheckedChanged);
            // 
            // rbKrediKarti
            // 
            this.rbKrediKarti.AutoSize = true;
            this.rbKrediKarti.Location = new System.Drawing.Point(805, 34);
            this.rbKrediKarti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbKrediKarti.Location = new System.Drawing.Point(593, 96);
            this.rbKrediKarti.Name = "rbKrediKarti";
            this.rbKrediKarti.Size = new System.Drawing.Size(159, 21);
            this.rbKrediKarti.TabIndex = 4;
            this.rbKrediKarti.TabStop = true;
            this.rbKrediKarti.Text = "Kredi Kartı ileÖdeme";
            this.rbKrediKarti.UseVisualStyleBackColor = true;
            this.rbKrediKarti.CheckedChanged += new System.EventHandler(this.rbKrediKarti_CheckedChanged);
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamFiyat.Location = new System.Drawing.Point(335, 438);
            this.lblToplamFiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(167, 29);
            this.lblToplamFiyat.TabIndex = 5;
            this.lblToplamFiyat.Text = "Toplam Fiyat:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtParaUstu);
            this.panel1.Controls.Add(this.txtTutar);
            this.panel1.Controls.Add(this.txtAlinan);
            this.panel1.Location = new System.Drawing.Point(679, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Location = new System.Drawing.Point(498, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 137);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Para Üstü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toplam Tutar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alınan Para";
            // 
            // txtParaUstu
            // 
            this.txtParaUstu.Location = new System.Drawing.Point(109, 85);
            this.txtParaUstu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtParaUstu.Name = "txtParaUstu";
            this.txtParaUstu.Size = new System.Drawing.Size(156, 22);
            this.txtParaUstu.TabIndex = 2;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(109, 52);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(156, 22);
            this.txtTutar.TabIndex = 1;
            // 
            // txtAlinan
            // 
            this.txtAlinan.Location = new System.Drawing.Point(109, 18);
            this.txtAlinan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlinan.Name = "txtAlinan";
            this.txtAlinan.Size = new System.Drawing.Size(156, 22);
            this.txtAlinan.TabIndex = 0;
            this.txtAlinan.TextChanged += new System.EventHandler(this.txtNakit_TextChanged);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(28, 327);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(123, 44);
            this.btnUrunEkle.TabIndex = 8;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunCikar
            // 
            this.btnUrunCikar.Location = new System.Drawing.Point(192, 327);
            this.btnUrunCikar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUrunCikar.Name = "btnUrunCikar";
            this.btnUrunCikar.Size = new System.Drawing.Size(123, 44);
            this.btnUrunCikar.TabIndex = 9;
            this.btnUrunCikar.Text = "Ürün Çıkar";
            this.btnUrunCikar.UseVisualStyleBackColor = true;
          
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(28, 68);
            this.cmbUrunler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(285, 24);
            this.cmbUrunler.TabIndex = 10;
            this.cmbUrunler.SelectedIndexChanged += new System.EventHandler(this.cmbUrunler_SelectedIndexChanged);
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(28, 34);
            this.cmbKategoriler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(285, 24);
            this.cmbKategoriler.TabIndex = 11;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged);
            // 
            // nuUrunAdet
            // 
            this.nuUrunAdet.Location = new System.Drawing.Point(155, 292);
            this.nuUrunAdet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nuUrunAdet.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nuUrunAdet.Name = "nuUrunAdet";
            this.nuUrunAdet.Size = new System.Drawing.Size(160, 22);
            this.nuUrunAdet.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ürün Adeti:";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutar.Location = new System.Drawing.Point(524, 443);
            this.lblTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutar.Location = new System.Drawing.Point(393, 360);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(0, 22);
            this.lblTutar.Size = new System.Drawing.Size(0, 18);
            this.lblTutar.TabIndex = 14;
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Location = new System.Drawing.Point(679, 208);
            this.btnOdemeYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOdemeYap.Location = new System.Drawing.Point(498, 237);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(284, 41);
            this.btnOdemeYap.TabIndex = 15;
            this.btnOdemeYap.Text = "Ödemeyi Tamamla";
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // nuPosetSayisi
            // 
            this.nuPosetSayisi.Location = new System.Drawing.Point(638, 36);
            this.nuPosetSayisi.Name = "nuPosetSayisi";
            this.nuPosetSayisi.Size = new System.Drawing.Size(73, 20);
            this.nuPosetSayisi.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Poşet Sayısı:";
            // 
            // SatisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 506);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nuPosetSayisi);
            this.ClientSize = new System.Drawing.Size(981, 623);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nuUrunAdet);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.cmbUrunler);
            this.Controls.Add(this.btnUrunCikar);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.rbKrediKarti);
            this.Controls.Add(this.rbNakit);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.pbBarkod);
            this.Controls.Add(this.txtBarkod);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SatisForm";
            this.Text = "Satıs";
            this.Load += new System.EventHandler(this.Satis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuUrunAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPosetSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.PictureBox pbBarkod;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.RadioButton rbKrediKarti;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParaUstu;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtAlinan;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunCikar;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.NumericUpDown nuUrunAdet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.NumericUpDown nuPosetSayisi;
        private System.Windows.Forms.Label label4;
    }
}