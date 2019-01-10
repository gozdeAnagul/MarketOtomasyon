namespace Market.WFA
{
    partial class CRUD
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
            this.lstKategori = new System.Windows.Forms.ListBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.btnKatEkle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtKategoriAciklama = new System.Windows.Forms.RichTextBox();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.txtUrunAciklama = new System.Windows.Forms.RichTextBox();
            this.nuKoliAdet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKoliIciAdet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUrunAdet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKdv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuKoliAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // lstKategori
            // 
            this.lstKategori.FormattingEnabled = true;
            this.lstKategori.Location = new System.Drawing.Point(35, 12);
            this.lstKategori.Name = "lstKategori";
            this.lstKategori.Size = new System.Drawing.Size(198, 147);
            this.lstKategori.TabIndex = 0;
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(446, 45);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(381, 147);
            this.lstUrunler.TabIndex = 2;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(80, 176);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(153, 20);
            this.txtKategori.TabIndex = 3;
            // 
            // btnKatEkle
            // 
            this.btnKatEkle.Location = new System.Drawing.Point(35, 274);
            this.btnKatEkle.Name = "btnKatEkle";
            this.btnKatEkle.Size = new System.Drawing.Size(198, 42);
            this.btnKatEkle.TabIndex = 6;
            this.btnKatEkle.Text = "Ekle";
            this.btnKatEkle.UseVisualStyleBackColor = true;
            this.btnKatEkle.Click += new System.EventHandler(this.btnKatEkle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(518, 405);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(309, 42);
            this.btnUrunEkle.TabIndex = 7;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtKategoriAciklama
            // 
            this.txtKategoriAciklama.Location = new System.Drawing.Point(80, 210);
            this.txtKategoriAciklama.Name = "txtKategoriAciklama";
            this.txtKategoriAciklama.Size = new System.Drawing.Size(155, 48);
            this.txtKategoriAciklama.TabIndex = 9;
            this.txtKategoriAciklama.Text = "";
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(446, 18);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(381, 21);
            this.cmbKategoriler.TabIndex = 12;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged_1);
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Location = new System.Drawing.Point(518, 244);
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.Size = new System.Drawing.Size(153, 56);
            this.txtUrunAciklama.TabIndex = 13;
            this.txtUrunAciklama.Text = "";
            // 
            // nuKoliAdet
            // 
            this.nuKoliAdet.Location = new System.Drawing.Point(586, 306);
            this.nuKoliAdet.Name = "nuKoliAdet";
            this.nuKoliAdet.Size = new System.Drawing.Size(85, 20);
            this.nuKoliAdet.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Açıklama:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Açıklama";
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(757, 216);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(70, 20);
            this.txtAlisFiyati.TabIndex = 20;
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(757, 247);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(70, 20);
            this.txtSatisFiyati.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(691, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Alış Fiyatı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(691, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Satış Fiyatı";
            // 
            // txtKoliIciAdet
            // 
            this.txtKoliIciAdet.Location = new System.Drawing.Point(601, 362);
            this.txtKoliIciAdet.Name = "txtKoliIciAdet";
            this.txtKoliIciAdet.Size = new System.Drawing.Size(70, 20);
            this.txtKoliIciAdet.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(535, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Koli İçiAdet";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(535, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Ürün Adeti";
            // 
            // txtUrunAdet
            // 
            this.txtUrunAdet.Location = new System.Drawing.Point(601, 336);
            this.txtUrunAdet.Name = "txtUrunAdet";
            this.txtUrunAdet.Size = new System.Drawing.Size(70, 20);
            this.txtUrunAdet.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(531, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Koli Adet";
            // 
            // txtKdv
            // 
            this.txtKdv.Location = new System.Drawing.Point(757, 273);
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.Size = new System.Drawing.Size(70, 20);
            this.txtKdv.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Kdv";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(518, 213);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(153, 20);
            this.txtUrunAdi.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(461, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ürün Adı:";
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 469);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUrunAdet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKoliIciAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKdv);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.txtAlisFiyati);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nuKoliAdet);
            this.Controls.Add(this.txtUrunAciklama);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.txtKategoriAciklama);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnKatEkle);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.lstKategori);
            this.Name = "CRUD";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuKoliAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKategori;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Button btnKatEkle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.RichTextBox txtKategoriAciklama;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.RichTextBox txtUrunAciklama;
        private System.Windows.Forms.NumericUpDown nuKoliAdet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKoliIciAdet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUrunAdet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKdv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label11;
    }
}