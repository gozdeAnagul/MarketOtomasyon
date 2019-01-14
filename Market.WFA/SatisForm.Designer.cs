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
            this.nuPoset = new System.Windows.Forms.NumericUpDown();
            this.cbPoset = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuUrunAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPoset)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(21, 94);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(215, 21);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyUp);
            // 
            // pbBarkod
            // 
            this.pbBarkod.Location = new System.Drawing.Point(21, 120);
            this.pbBarkod.Name = "pbBarkod";
            this.pbBarkod.Size = new System.Drawing.Size(215, 111);
            this.pbBarkod.TabIndex = 1;
            this.pbBarkod.TabStop = false;
            // 
            // lstSepet
            // 
            this.lstSepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 16;
            this.lstSepet.Location = new System.Drawing.Point(264, 28);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(227, 292);
            this.lstSepet.TabIndex = 2;
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbNakit.Location = new System.Drawing.Point(509, 59);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(108, 19);
            this.rbNakit.TabIndex = 3;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit Ödeme";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.rbNakit_CheckedChanged);
            // 
            // rbKrediKarti
            // 
            this.rbKrediKarti.AutoSize = true;
            this.rbKrediKarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKrediKarti.Location = new System.Drawing.Point(602, 59);
            this.rbKrediKarti.Name = "rbKrediKarti";
            this.rbKrediKarti.Size = new System.Drawing.Size(159, 19);
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
            this.lblToplamFiyat.Location = new System.Drawing.Point(264, 347);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(136, 22);
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
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(509, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 111);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Para Üstü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toplam Tutar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alınan Para";
            // 
            // txtParaUstu
            // 
            this.txtParaUstu.Location = new System.Drawing.Point(99, 70);
            this.txtParaUstu.Name = "txtParaUstu";
            this.txtParaUstu.Size = new System.Drawing.Size(129, 21);
            this.txtParaUstu.TabIndex = 2;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(99, 43);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(129, 21);
            this.txtTutar.TabIndex = 1;
            // 
            // txtAlinan
            // 
            this.txtAlinan.Location = new System.Drawing.Point(99, 16);
            this.txtAlinan.Name = "txtAlinan";
            this.txtAlinan.Size = new System.Drawing.Size(129, 21);
            this.txtAlinan.TabIndex = 0;
            this.txtAlinan.TextChanged += new System.EventHandler(this.txtNakit_TextChanged);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Location = new System.Drawing.Point(21, 266);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(92, 36);
            this.btnUrunEkle.TabIndex = 8;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunCikar
            // 
            this.btnUrunCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunCikar.Location = new System.Drawing.Point(144, 266);
            this.btnUrunCikar.Name = "btnUrunCikar";
            this.btnUrunCikar.Size = new System.Drawing.Size(92, 36);
            this.btnUrunCikar.TabIndex = 9;
            this.btnUrunCikar.Text = "Ürün Çıkar";
            this.btnUrunCikar.UseVisualStyleBackColor = true;
            this.btnUrunCikar.Click += new System.EventHandler(this.btnUrunCikar_Click);
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(21, 55);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(215, 23);
            this.cmbUrunler.TabIndex = 10;
            this.cmbUrunler.SelectedIndexChanged += new System.EventHandler(this.cmbUrunler_SelectedIndexChanged);
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(21, 28);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(215, 23);
            this.cmbKategoriler.TabIndex = 11;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged);
            // 
            // nuUrunAdet
            // 
            this.nuUrunAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nuUrunAdet.Location = new System.Drawing.Point(116, 237);
            this.nuUrunAdet.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nuUrunAdet.Name = "nuUrunAdet";
            this.nuUrunAdet.Size = new System.Drawing.Size(120, 21);
            this.nuUrunAdet.TabIndex = 12;
            this.nuUrunAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(35, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ürün Adeti:";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutar.Location = new System.Drawing.Point(400, 350);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(0, 18);
            this.lblTutar.TabIndex = 14;
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeYap.Location = new System.Drawing.Point(510, 214);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(213, 33);
            this.btnOdemeYap.TabIndex = 15;
            this.btnOdemeYap.Text = "Ödemeyi Tamamla";
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // nuPoset
            // 
            this.nuPoset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nuPoset.Location = new System.Drawing.Point(613, 28);
            this.nuPoset.Name = "nuPoset";
            this.nuPoset.Size = new System.Drawing.Size(120, 21);
            this.nuPoset.TabIndex = 16;
            this.nuPoset.ValueChanged += new System.EventHandler(this.nuPoset_ValueChanged);
            // 
            // cbPoset
            // 
            this.cbPoset.AutoSize = true;
            this.cbPoset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbPoset.Location = new System.Drawing.Point(537, 30);
            this.cbPoset.Name = "cbPoset";
            this.cbPoset.Size = new System.Drawing.Size(70, 19);
            this.cbPoset.TabIndex = 17;
            this.cbPoset.Text = "Poşet?";
            this.cbPoset.UseVisualStyleBackColor = true;
            this.cbPoset.CheckedChanged += new System.EventHandler(this.cbPoset_CheckedChanged);
            // 
            // SatisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 506);
            this.Controls.Add(this.cbPoset);
            this.Controls.Add(this.nuPoset);
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
            this.Name = "SatisForm";
            this.Text = "Satıs";
            this.Load += new System.EventHandler(this.Satis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuUrunAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPoset)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nuPoset;
        private System.Windows.Forms.CheckBox cbPoset;
    }
}