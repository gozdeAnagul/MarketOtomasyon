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
            this.lstUrun = new System.Windows.Forms.ListBox();
            this.lstUrunDetay = new System.Windows.Forms.ListBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.txtUrunDetay = new System.Windows.Forms.TextBox();
            this.btnKatEkle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunDetayEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstKategori
            // 
            this.lstKategori.FormattingEnabled = true;
            this.lstKategori.Location = new System.Drawing.Point(22, 12);
            this.lstKategori.Name = "lstKategori";
            this.lstKategori.Size = new System.Drawing.Size(198, 277);
            this.lstKategori.TabIndex = 0;
            // 
            // lstUrun
            // 
            this.lstUrun.FormattingEnabled = true;
            this.lstUrun.Location = new System.Drawing.Point(283, 12);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(198, 277);
            this.lstUrun.TabIndex = 1;
            // 
            // lstUrunDetay
            // 
            this.lstUrunDetay.FormattingEnabled = true;
            this.lstUrunDetay.Location = new System.Drawing.Point(544, 12);
            this.lstUrunDetay.Name = "lstUrunDetay";
            this.lstUrunDetay.Size = new System.Drawing.Size(198, 277);
            this.lstUrunDetay.TabIndex = 2;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(22, 319);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(198, 20);
            this.txtKategori.TabIndex = 3;
            // 
            // txtUrun
            // 
            this.txtUrun.Location = new System.Drawing.Point(283, 319);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(198, 20);
            this.txtUrun.TabIndex = 4;
            // 
            // txtUrunDetay
            // 
            this.txtUrunDetay.Location = new System.Drawing.Point(544, 319);
            this.txtUrunDetay.Name = "txtUrunDetay";
            this.txtUrunDetay.Size = new System.Drawing.Size(198, 20);
            this.txtUrunDetay.TabIndex = 5;
            // 
            // btnKatEkle
            // 
            this.btnKatEkle.Location = new System.Drawing.Point(66, 358);
            this.btnKatEkle.Name = "btnKatEkle";
            this.btnKatEkle.Size = new System.Drawing.Size(97, 42);
            this.btnKatEkle.TabIndex = 6;
            this.btnKatEkle.Text = "Ekle";
            this.btnKatEkle.UseVisualStyleBackColor = true;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(334, 358);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(97, 42);
            this.btnUrunEkle.TabIndex = 7;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            // 
            // btnUrunDetayEkle
            // 
            this.btnUrunDetayEkle.Location = new System.Drawing.Point(602, 358);
            this.btnUrunDetayEkle.Name = "btnUrunDetayEkle";
            this.btnUrunDetayEkle.Size = new System.Drawing.Size(97, 42);
            this.btnUrunDetayEkle.TabIndex = 8;
            this.btnUrunDetayEkle.Text = "Ekle";
            this.btnUrunDetayEkle.UseVisualStyleBackColor = true;
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.btnUrunDetayEkle);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnKatEkle);
            this.Controls.Add(this.txtUrunDetay);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.lstUrunDetay);
            this.Controls.Add(this.lstUrun);
            this.Controls.Add(this.lstKategori);
            this.Name = "CRUD";
            this.Text = "CRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKategori;
        private System.Windows.Forms.ListBox lstUrun;
        private System.Windows.Forms.ListBox lstUrunDetay;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.TextBox txtUrunDetay;
        private System.Windows.Forms.Button btnKatEkle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunDetayEkle;
    }
}