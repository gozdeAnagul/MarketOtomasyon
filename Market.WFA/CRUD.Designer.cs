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
            this.components = new System.ComponentModel.Container();
            this.lstKategori = new System.Windows.Forms.ListBox();
            this.cmsKatSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kategoriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.cmsUrunSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.urunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmsKatSil.SuspendLayout();
            this.cmsUrunSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstKategori
            // 
            this.lstKategori.ContextMenuStrip = this.cmsKatSil;
            this.lstKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstKategori.FormattingEnabled = true;
            this.lstKategori.ItemHeight = 16;
            this.lstKategori.Location = new System.Drawing.Point(35, 12);
            this.lstKategori.Name = "lstKategori";
            this.lstKategori.Size = new System.Drawing.Size(314, 196);
            this.lstKategori.TabIndex = 0;
            // 
            // cmsKatSil
            // 
            this.cmsKatSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriSilToolStripMenuItem});
            this.cmsKatSil.Name = "cmsKatSil";
            this.cmsKatSil.Size = new System.Drawing.Size(136, 26);
            // 
            // kategoriSilToolStripMenuItem
            // 
            this.kategoriSilToolStripMenuItem.Name = "kategoriSilToolStripMenuItem";
            this.kategoriSilToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.kategoriSilToolStripMenuItem.Text = "Kategori_Sil";
            this.kategoriSilToolStripMenuItem.Click += new System.EventHandler(this.kategoriSilToolStripMenuItem_Click);
            // 
            // lstUrunler
            // 
            this.lstUrunler.ContextMenuStrip = this.cmsUrunSil;
            this.lstUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 15;
            this.lstUrunler.Location = new System.Drawing.Point(446, 45);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(395, 154);
            this.lstUrunler.TabIndex = 2;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // cmsUrunSil
            // 
            this.cmsUrunSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunToolStripMenuItem});
            this.cmsUrunSil.Name = "cmsUrunSil";
            this.cmsUrunSil.Size = new System.Drawing.Size(118, 26);
            // 
            // urunToolStripMenuItem
            // 
            this.urunToolStripMenuItem.Name = "urunToolStripMenuItem";
            this.urunToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.urunToolStripMenuItem.Text = "Urun_Sil";
            this.urunToolStripMenuItem.Click += new System.EventHandler(this.urunToolStripMenuItem_Click);
            // 
            // txtKategori
            // 
            this.txtKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategori.Location = new System.Drawing.Point(194, 239);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(153, 21);
            this.txtKategori.TabIndex = 3;
            // 
            // btnKatEkle
            // 
            this.btnKatEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKatEkle.Location = new System.Drawing.Point(151, 331);
            this.btnKatEkle.Name = "btnKatEkle";
            this.btnKatEkle.Size = new System.Drawing.Size(198, 42);
            this.btnKatEkle.TabIndex = 6;
            this.btnKatEkle.Text = "Kategori Ekle";
            this.btnKatEkle.UseVisualStyleBackColor = true;
            this.btnKatEkle.Click += new System.EventHandler(this.btnKatEkle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Location = new System.Drawing.Point(672, 326);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(155, 42);
            this.btnUrunEkle.TabIndex = 7;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtKategoriAciklama
            // 
            this.txtKategoriAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategoriAciklama.Location = new System.Drawing.Point(194, 273);
            this.txtKategoriAciklama.Name = "txtKategoriAciklama";
            this.txtKategoriAciklama.Size = new System.Drawing.Size(155, 48);
            this.txtKategoriAciklama.TabIndex = 9;
            this.txtKategoriAciklama.Text = "";
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(446, 18);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(395, 23);
            this.cmbKategoriler.TabIndex = 12;
            this.cmbKategoriler.Text = "Kategori Seciniz";
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged_1);
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAciklama.Location = new System.Drawing.Point(518, 244);
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.Size = new System.Drawing.Size(153, 56);
            this.txtUrunAciklama.TabIndex = 13;
            this.txtUrunAciklama.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(127, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(444, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Açıklama:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(123, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Açıklama";
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlisFiyati.Location = new System.Drawing.Point(771, 216);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(70, 21);
            this.txtAlisFiyati.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(693, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Alış Fiyatı:";
            // 
            // txtKoliIciAdet
            // 
            this.txtKoliIciAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKoliIciAdet.Location = new System.Drawing.Point(771, 273);
            this.txtKoliIciAdet.Name = "txtKoliIciAdet";
            this.txtKoliIciAdet.Size = new System.Drawing.Size(70, 21);
            this.txtKoliIciAdet.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(680, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Koli İçiAdet:";
            // 
            // txtKdv
            // 
            this.txtKdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKdv.Location = new System.Drawing.Point(771, 247);
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.Size = new System.Drawing.Size(70, 21);
            this.txtKdv.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(717, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Kdv:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(518, 213);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(153, 21);
            this.txtUrunAdi.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(446, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ürün Adı:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(464, 326);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(155, 42);
            this.btnGuncelle.TabIndex = 27;
            this.btnGuncelle.Text = "Ürün Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 469);
            this.Controls.Add(this.btnGuncelle);
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
            this.Name = "CRUD";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.CRUD_Load);
            this.cmsKatSil.ResumeLayout(false);
            this.cmsUrunSil.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ContextMenuStrip cmsKatSil;
        private System.Windows.Forms.ToolStripMenuItem kategoriSilToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsUrunSil;
        private System.Windows.Forms.ToolStripMenuItem urunToolStripMenuItem;
    }
}