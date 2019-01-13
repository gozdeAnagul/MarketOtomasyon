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
            ((System.ComponentModel.ISupportInitialize)(this.dgvmRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmRapor
            // 
            this.dgvmRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmRapor.Location = new System.Drawing.Point(245, 59);
            this.dgvmRapor.Name = "dgvmRapor";
            this.dgvmRapor.RowTemplate.Height = 24;
            this.dgvmRapor.Size = new System.Drawing.Size(810, 369);
            this.dgvmRapor.TabIndex = 0;
            // 
            // btnGunlukRapor
            // 
            this.btnGunlukRapor.Location = new System.Drawing.Point(18, 110);
            this.btnGunlukRapor.Name = "btnGunlukRapor";
            this.btnGunlukRapor.Size = new System.Drawing.Size(188, 39);
            this.btnGunlukRapor.TabIndex = 1;
            this.btnGunlukRapor.Text = "Günlük Satış Raporları";
            this.btnGunlukRapor.UseVisualStyleBackColor = true;
            this.btnGunlukRapor.Click += new System.EventHandler(this.btnGunlukRapor_Click);
            // 
            // btnAylıkRapor
            // 
            this.btnAylıkRapor.Location = new System.Drawing.Point(18, 171);
            this.btnAylıkRapor.Name = "btnAylıkRapor";
            this.btnAylıkRapor.Size = new System.Drawing.Size(188, 43);
            this.btnAylıkRapor.TabIndex = 2;
            this.btnAylıkRapor.Text = "Aylık Satış Raporları";
            this.btnAylıkRapor.UseVisualStyleBackColor = true;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(18, 59);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(188, 22);
            this.dtpTarih.TabIndex = 3;
            this.dtpTarih.Value = new System.DateTime(2019, 1, 13, 0, 0, 0, 0);
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 554);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.btnAylıkRapor);
            this.Controls.Add(this.btnGunlukRapor);
            this.Controls.Add(this.dgvmRapor);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Raporlar";
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.Raporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmRapor;
        private System.Windows.Forms.Button btnGunlukRapor;
        private System.Windows.Forms.Button btnAylıkRapor;
        private System.Windows.Forms.DateTimePicker dtpTarih;
    }
}