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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnStogaEkle = new System.Windows.Forms.Button();
            this.nudKutu = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.cmbCategoriler = new System.Windows.Forms.ComboBox();
            this.pbBarkod = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudKutu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(501, 360);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 34);
            this.btnSil.TabIndex = 52;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(411, 360);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(81, 34);
            this.btnGuncelle.TabIndex = 51;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Kategori Adı";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(480, 257);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(84, 32);
            this.btnAra.TabIndex = 44;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // btnStogaEkle
            // 
            this.btnStogaEkle.Location = new System.Drawing.Point(317, 360);
            this.btnStogaEkle.Name = "btnStogaEkle";
            this.btnStogaEkle.Size = new System.Drawing.Size(81, 34);
            this.btnStogaEkle.TabIndex = 43;
            this.btnStogaEkle.Text = "Stoğa Ekle";
            this.btnStogaEkle.UseVisualStyleBackColor = true;
            // 
            // nudKutu
            // 
            this.nudKutu.Location = new System.Drawing.Point(416, 295);
            this.nudKutu.Name = "nudKutu";
            this.nudKutu.Size = new System.Drawing.Size(148, 20);
            this.nudKutu.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(336, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Kutu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Barkod";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(39, 37);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(248, 20);
            this.txtAra.TabIndex = 36;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyUp);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(349, 55);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(215, 20);
            this.txtBarkod.TabIndex = 37;
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(39, 63);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(248, 342);
            this.lstUrunler.TabIndex = 35;
            // 
            // cmbCategoriler
            // 
            this.cmbCategoriler.FormattingEnabled = true;
            this.cmbCategoriler.Location = new System.Drawing.Point(411, 219);
            this.cmbCategoriler.Name = "cmbCategoriler";
            this.cmbCategoriler.Size = new System.Drawing.Size(153, 21);
            this.cmbCategoriler.TabIndex = 54;
            // 
            // pbBarkod
            // 
            this.pbBarkod.Location = new System.Drawing.Point(349, 81);
            this.pbBarkod.Name = "pbBarkod";
            this.pbBarkod.Size = new System.Drawing.Size(215, 111);
            this.pbBarkod.TabIndex = 56;
            this.pbBarkod.TabStop = false;
            // 
            // MalKabul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 422);
            this.Controls.Add(this.pbBarkod);
            this.Controls.Add(this.cmbCategoriler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnStogaEkle);
            this.Controls.Add(this.nudKutu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lstUrunler);
            this.Name = "MalKabul";
            this.Text = "MalKabul";
            this.Load += new System.EventHandler(this.MalKabul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKutu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnStogaEkle;
        private System.Windows.Forms.NumericUpDown nudKutu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.ComboBox cmbCategoriler;
        private System.Windows.Forms.PictureBox pbBarkod;
    }
}