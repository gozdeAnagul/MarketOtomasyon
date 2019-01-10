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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKoliIciAdet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKdv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstKategori
            // 
            this.lstKategori.FormattingEnabled = true;
            this.lstKategori.ItemHeight = 16;
            this.lstKategori.Location = new System.Drawing.Point(47, 15);
            this.lstKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstKategori.Name = "lstKategori";
            this.lstKategori.Size = new System.Drawing.Size(417, 180);
            this.lstKategori.TabIndex = 0;
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 16;
            this.lstUrunler.Location = new System.Drawing.Point(595, 55);
            this.lstUrunler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(507, 180);
            this.lstUrunler.TabIndex = 2;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(261, 270);
            this.txtKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(203, 22);
            this.txtKategori.TabIndex = 3;
            // 
            // btnKatEkle
            // 
            this.btnKatEkle.Location = new System.Drawing.Point(201, 390);
            this.btnKatEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKatEkle.Name = "btnKatEkle";
            this.btnKatEkle.Size = new System.Drawing.Size(264, 52);
            this.btnKatEkle.TabIndex = 6;
            this.btnKatEkle.Text = "Ekle";
            this.btnKatEkle.UseVisualStyleBackColor = true;
            this.btnKatEkle.Click += new System.EventHandler(this.btnKatEkle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(691, 401);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(412, 52);
            this.btnUrunEkle.TabIndex = 7;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtKategoriAciklama
            // 
            this.txtKategoriAciklama.Location = new System.Drawing.Point(261, 311);
            this.txtKategoriAciklama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKategoriAciklama.Name = "txtKategoriAciklama";
            this.txtKategoriAciklama.Size = new System.Drawing.Size(205, 58);
            this.txtKategoriAciklama.TabIndex = 9;
            this.txtKategoriAciklama.Text = "";
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(595, 22);
            this.cmbKategoriler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(507, 24);
            this.cmbKategoriler.TabIndex = 12;
            this.cmbKategoriler.Text = "Kategori Seciniz";
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged_1);
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Location = new System.Drawing.Point(691, 300);
            this.txtUrunAciklama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.Size = new System.Drawing.Size(203, 68);
            this.txtUrunAciklama.TabIndex = 13;
            this.txtUrunAciklama.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Açıklama:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Açıklama";
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(1009, 266);
            this.txtAlisFiyati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(92, 22);
            this.txtAlisFiyati.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(935, 270);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Alış Fiyatı:";
            // 
            // txtKoliIciAdet
            // 
            this.txtKoliIciAdet.Location = new System.Drawing.Point(1009, 336);
            this.txtKoliIciAdet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKoliIciAdet.Name = "txtKoliIciAdet";
            this.txtKoliIciAdet.Size = new System.Drawing.Size(92, 22);
            this.txtKoliIciAdet.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(917, 340);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Koli İçiAdet:";
            // 
            // txtKdv
            // 
            this.txtKdv.Location = new System.Drawing.Point(1009, 304);
            this.txtKdv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.Size = new System.Drawing.Size(92, 22);
            this.txtKdv.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(967, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Kdv:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(691, 262);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(203, 22);
            this.txtUrunAdi.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(615, 266);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ürün Adı:";
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 577);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKoliIciAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKdv);
            this.Controls.Add(this.txtAlisFiyati);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrunAciklama);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.txtKategoriAciklama);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnKatEkle);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.lstKategori);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CRUD";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.CRUD_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKoliIciAdet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKdv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label11;
    }
}