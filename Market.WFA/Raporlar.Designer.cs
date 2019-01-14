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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGunlukRapor = new System.Windows.Forms.Button();
            this.btnAylıkRapor = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.lblOdeme = new System.Windows.Forms.Label();
            this.dgvmRapor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGunlukRapor
            // 
            this.btnGunlukRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunlukRapor.Location = new System.Drawing.Point(1052, 59);
            this.btnGunlukRapor.Margin = new System.Windows.Forms.Padding(2);
            this.btnGunlukRapor.Name = "btnGunlukRapor";
            this.btnGunlukRapor.Size = new System.Drawing.Size(141, 52);
            this.btnGunlukRapor.TabIndex = 1;
            this.btnGunlukRapor.Text = "Günlük Satış Raporları";
            this.btnGunlukRapor.UseVisualStyleBackColor = true;
            this.btnGunlukRapor.Click += new System.EventHandler(this.btnGunlukRapor_Click);
            // 
            // btnAylıkRapor
            // 
            this.btnAylıkRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAylıkRapor.Location = new System.Drawing.Point(1052, 132);
            this.btnAylıkRapor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAylıkRapor.Name = "btnAylıkRapor";
            this.btnAylıkRapor.Size = new System.Drawing.Size(141, 52);
            this.btnAylıkRapor.TabIndex = 2;
            this.btnAylıkRapor.Text = "Aylık Satış Raporları";
            this.btnAylıkRapor.UseVisualStyleBackColor = true;
            this.btnAylıkRapor.Click += new System.EventHandler(this.btnAylıkRapor_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(1052, 11);
            this.dtpTarih.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(158, 26);
            this.dtpTarih.TabIndex = 3;
            this.dtpTarih.Value = new System.DateTime(2019, 1, 13, 0, 0, 0, 0);
            // 
            // btnYazdır
            // 
            this.btnYazdır.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdır.Location = new System.Drawing.Point(1052, 201);
            this.btnYazdır.Margin = new System.Windows.Forms.Padding(2);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(141, 52);
            this.btnYazdır.TabIndex = 4;
            this.btnYazdır.Text = "Yazdır";
            this.btnYazdır.UseVisualStyleBackColor = true;
            // 
            // lblOdeme
            // 
            this.lblOdeme.AutoSize = true;
            this.lblOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdeme.Location = new System.Drawing.Point(741, 318);
            this.lblOdeme.Name = "lblOdeme";
            this.lblOdeme.Size = new System.Drawing.Size(61, 24);
            this.lblOdeme.TabIndex = 5;
            this.lblOdeme.Text = "Label";
            // 
            // dgvmRapor
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvmRapor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvmRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvmRapor.Location = new System.Drawing.Point(0, 0);
            this.dgvmRapor.Margin = new System.Windows.Forms.Padding(2);
            this.dgvmRapor.Name = "dgvmRapor";
            this.dgvmRapor.RowTemplate.Height = 24;
            this.dgvmRapor.Size = new System.Drawing.Size(1244, 450);
            this.dgvmRapor.TabIndex = 0;
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 450);
            this.Controls.Add(this.lblOdeme);
            this.Controls.Add(this.btnYazdır);
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
        private System.Windows.Forms.Button btnGunlukRapor;
        private System.Windows.Forms.Button btnAylıkRapor;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.Label lblOdeme;
        private System.Windows.Forms.DataGridView dgvmRapor;
    }
}