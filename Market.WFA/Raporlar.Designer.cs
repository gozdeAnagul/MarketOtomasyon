namespace Market.WFA
{
    partial class Raporlar
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
            this.dgvmRapor = new System.Windows.Forms.DataGridView();
            this.btnGunlukRapor = new System.Windows.Forms.Button();
            this.btnAylıkRapor = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.lblOdemeKartAy = new System.Windows.Forms.Label();
            this.lblOdemeNakitAy = new System.Windows.Forms.Label();
            this.lblToplamCiroAy = new System.Windows.Forms.Label();
            this.lblKartGun = new System.Windows.Forms.Label();
            this.lblNakitGun = new System.Windows.Forms.Label();
            this.lblToplamCiroGun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmRapor
            // 
            this.dgvmRapor.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvmRapor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvmRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmRapor.Location = new System.Drawing.Point(0, 0);
            this.dgvmRapor.Margin = new System.Windows.Forms.Padding(2);
            this.dgvmRapor.Name = "dgvmRapor";
            this.dgvmRapor.RowTemplate.Height = 24;
            this.dgvmRapor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmRapor.Size = new System.Drawing.Size(956, 300);
            this.dgvmRapor.TabIndex = 0;
            // 
            // btnGunlukRapor
            // 
            this.btnGunlukRapor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGunlukRapor.Location = new System.Drawing.Point(1029, 86);
            this.btnGunlukRapor.Margin = new System.Windows.Forms.Padding(2);
            this.btnGunlukRapor.Name = "btnGunlukRapor";
            this.btnGunlukRapor.Size = new System.Drawing.Size(141, 32);
            this.btnGunlukRapor.TabIndex = 1;
            this.btnGunlukRapor.Text = "Günlük Satış Raporları";
            this.btnGunlukRapor.UseVisualStyleBackColor = true;
            this.btnGunlukRapor.Click += new System.EventHandler(this.btnGunlukRapor_Click);
            // 
            // btnAylıkRapor
            // 
            this.btnAylıkRapor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAylıkRapor.Location = new System.Drawing.Point(1029, 141);
            this.btnAylıkRapor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAylıkRapor.Name = "btnAylıkRapor";
            this.btnAylıkRapor.Size = new System.Drawing.Size(141, 35);
            this.btnAylıkRapor.TabIndex = 2;
            this.btnAylıkRapor.Text = "Aylık Satış Raporları";
            this.btnAylıkRapor.UseVisualStyleBackColor = true;
            this.btnAylıkRapor.Click += new System.EventHandler(this.btnAylıkRapor_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(1029, 38);
            this.dtpTarih.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(158, 20);
            this.dtpTarih.TabIndex = 3;
            this.dtpTarih.Value = new System.DateTime(2019, 1, 13, 0, 0, 0, 0);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnUrunler.Location = new System.Drawing.Point(1029, 198);
            this.btnUrunler.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(141, 32);
            this.btnUrunler.TabIndex = 4;
            this.btnUrunler.Text = "Kategorilere Göre Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // lblOdemeKartAy
            // 
            this.lblOdemeKartAy.AutoSize = true;
            this.lblOdemeKartAy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdemeKartAy.Location = new System.Drawing.Point(40, 319);
            this.lblOdemeKartAy.Name = "lblOdemeKartAy";
            this.lblOdemeKartAy.Size = new System.Drawing.Size(51, 21);
            this.lblOdemeKartAy.TabIndex = 5;
            this.lblOdemeKartAy.Text = "Label";
            // 
            // lblOdemeNakitAy
            // 
            this.lblOdemeNakitAy.AutoSize = true;
            this.lblOdemeNakitAy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdemeNakitAy.Location = new System.Drawing.Point(40, 359);
            this.lblOdemeNakitAy.Name = "lblOdemeNakitAy";
            this.lblOdemeNakitAy.Size = new System.Drawing.Size(51, 21);
            this.lblOdemeNakitAy.TabIndex = 6;
            this.lblOdemeNakitAy.Text = "Label";
            // 
            // lblToplamCiroAy
            // 
            this.lblToplamCiroAy.AutoSize = true;
            this.lblToplamCiroAy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamCiroAy.Location = new System.Drawing.Point(40, 399);
            this.lblToplamCiroAy.Name = "lblToplamCiroAy";
            this.lblToplamCiroAy.Size = new System.Drawing.Size(51, 21);
            this.lblToplamCiroAy.TabIndex = 7;
            this.lblToplamCiroAy.Text = "Label";
            // 
            // lblKartGun
            // 
            this.lblKartGun.AutoSize = true;
            this.lblKartGun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKartGun.Location = new System.Drawing.Point(40, 399);
            this.lblKartGun.Name = "lblKartGun";
            this.lblKartGun.Size = new System.Drawing.Size(51, 21);
            this.lblKartGun.TabIndex = 8;
            this.lblKartGun.Text = "Label";
            // 
            // lblNakitGun
            // 
            this.lblNakitGun.AutoSize = true;
            this.lblNakitGun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNakitGun.Location = new System.Drawing.Point(40, 359);
            this.lblNakitGun.Name = "lblNakitGun";
            this.lblNakitGun.Size = new System.Drawing.Size(51, 21);
            this.lblNakitGun.TabIndex = 9;
            this.lblNakitGun.Text = "Label";
            // 
            // lblToplamCiroGun
            // 
            this.lblToplamCiroGun.AutoSize = true;
            this.lblToplamCiroGun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamCiroGun.Location = new System.Drawing.Point(40, 319);
            this.lblToplamCiroGun.Name = "lblToplamCiroGun";
            this.lblToplamCiroGun.Size = new System.Drawing.Size(51, 21);
            this.lblToplamCiroGun.TabIndex = 10;
            this.lblToplamCiroGun.Text = "Label";
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 439);
            this.Controls.Add(this.lblToplamCiroGun);
            this.Controls.Add(this.lblNakitGun);
            this.Controls.Add(this.lblKartGun);
            this.Controls.Add(this.lblToplamCiroAy);
            this.Controls.Add(this.lblOdemeNakitAy);
            this.Controls.Add(this.lblOdemeKartAy);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.btnAylıkRapor);
            this.Controls.Add(this.btnGunlukRapor);
            this.Controls.Add(this.dgvmRapor);
            this.Name = "Raporlar";
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.Raporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmRapor;
        private System.Windows.Forms.Button btnGunlukRapor;
        private System.Windows.Forms.Button btnAylıkRapor;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Label lblOdemeKartAy;
        private System.Windows.Forms.Label lblOdemeNakitAy;
        private System.Windows.Forms.Label lblToplamCiroAy;
        private System.Windows.Forms.Label lblKartGun;
        private System.Windows.Forms.Label lblNakitGun;
        private System.Windows.Forms.Label lblToplamCiroGun;
    }
}