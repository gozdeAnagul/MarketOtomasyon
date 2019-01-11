namespace Market.WFA
{
    partial class SatisDialog
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
            this.txtYeniBarkod = new System.Windows.Forms.TextBox();
            this.pbBarkod = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKoliIciAdet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKdv = new System.Windows.Forms.TextBox();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUrunAciklama = new System.Windows.Forms.RichTextBox();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYeniBarkod
            // 
            this.txtYeniBarkod.Location = new System.Drawing.Point(224, 12);
            this.txtYeniBarkod.Name = "txtYeniBarkod";
            this.txtYeniBarkod.Size = new System.Drawing.Size(147, 20);
            this.txtYeniBarkod.TabIndex = 0;
            // 
            // pbBarkod
            // 
            this.pbBarkod.Location = new System.Drawing.Point(224, 38);
            this.pbBarkod.Name = "pbBarkod";
            this.pbBarkod.Size = new System.Drawing.Size(147, 84);
            this.pbBarkod.TabIndex = 1;
            this.pbBarkod.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Koli İçiAdet:";
            // 
            // txtKoliIciAdet
            // 
            this.txtKoliIciAdet.Location = new System.Drawing.Point(301, 385);
            this.txtKoliIciAdet.Name = "txtKoliIciAdet";
            this.txtKoliIciAdet.Size = new System.Drawing.Size(70, 20);
            this.txtKoliIciAdet.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Kdv:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Alış Fiyatı:";
            // 
            // txtKdv
            // 
            this.txtKdv.Location = new System.Drawing.Point(301, 359);
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.Size = new System.Drawing.Size(70, 20);
            this.txtKdv.TabIndex = 34;
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(301, 328);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(70, 20);
            this.txtAlisFiyati.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Açıklama:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Ürün Adı:";
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Location = new System.Drawing.Point(62, 356);
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.Size = new System.Drawing.Size(153, 56);
            this.txtUrunAciklama.TabIndex = 30;
            this.txtUrunAciklama.Text = "";
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(12, 131);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(359, 21);
            this.cmbKategoriler.TabIndex = 29;
            this.cmbKategoriler.Text = "Kategori Seciniz";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(62, 428);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(309, 42);
            this.btnUrunEkle.TabIndex = 28;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(62, 325);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(153, 20);
            this.txtUrunAdi.TabIndex = 27;
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(12, 158);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(359, 147);
            this.lstUrunler.TabIndex = 26;
            // 
            // SatisDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 498);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKoliIciAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKdv);
            this.Controls.Add(this.txtAlisFiyati);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtUrunAciklama);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.pbBarkod);
            this.Controls.Add(this.txtYeniBarkod);
            this.Name = "SatisDialog";
            this.Text = "SatisDialog";
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYeniBarkod;
        private System.Windows.Forms.PictureBox pbBarkod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKoliIciAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKdv;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtUrunAciklama;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.ListBox lstUrunler;
    }
}