namespace p13EncryptedData
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.DATA = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSifreCoz = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DATA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // DATA
            // 
            this.DATA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DATA.Controls.Add(this.dataGridView1);
            this.DATA.Location = new System.Drawing.Point(41, 215);
            this.DATA.Name = "DATA";
            this.DATA.Size = new System.Drawing.Size(1155, 255);
            this.DATA.TabIndex = 0;
            this.DATA.TabStop = false;
            this.DATA.Text = "DATA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1149, 223);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(142, 22);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(180, 33);
            this.txtAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Acc. Number:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(142, 83);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(180, 33);
            this.txtSoyad.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(142, 150);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(180, 33);
            this.txtMail.TabIndex = 8;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(494, 22);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(180, 33);
            this.txtSifre.TabIndex = 9;
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(494, 95);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(180, 33);
            this.txtHesapNo.TabIndex = 10;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.RosyBrown;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKaydet.Location = new System.Drawing.Point(727, 15);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(180, 44);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Save";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSifreCoz
            // 
            this.btnSifreCoz.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSifreCoz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSifreCoz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSifreCoz.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSifreCoz.Location = new System.Drawing.Point(727, 79);
            this.btnSifreCoz.Name = "btnSifreCoz";
            this.btnSifreCoz.Size = new System.Drawing.Size(180, 44);
            this.btnSifreCoz.TabIndex = 13;
            this.btnSifreCoz.Text = "Decrypt";
            this.btnSifreCoz.UseVisualStyleBackColor = false;
            this.btnSifreCoz.Click += new System.EventHandler(this.btnSifreCoz_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(38, 476);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1155, 251);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATA";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1149, 219);
            this.dataGridView2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1257, 764);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSifreCoz);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DATA);
            this.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DATA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DATA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSifreCoz;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

