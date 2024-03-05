namespace _18.uygulama
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskTC = new System.Windows.Forms.MaskedTextBox();
            this.masktelefon = new System.Windows.Forms.MaskedTextBox();
            this.maskdtarihi = new System.Windows.Forms.MaskedTextBox();
            this.maskkart = new System.Windows.Forms.MaskedTextBox();
            this.maskIP = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C. NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kart Numarası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "IP Adresi";
            // 
            // maskTC
            // 
            this.maskTC.Location = new System.Drawing.Point(208, 61);
            this.maskTC.Name = "maskTC";
            this.maskTC.Size = new System.Drawing.Size(132, 20);
            this.maskTC.TabIndex = 5;
            // 
            // masktelefon
            // 
            this.masktelefon.Location = new System.Drawing.Point(208, 105);
            this.masktelefon.Name = "masktelefon";
            this.masktelefon.Size = new System.Drawing.Size(132, 20);
            this.masktelefon.TabIndex = 6;
            // 
            // maskdtarihi
            // 
            this.maskdtarihi.Location = new System.Drawing.Point(208, 153);
            this.maskdtarihi.Name = "maskdtarihi";
            this.maskdtarihi.Size = new System.Drawing.Size(132, 20);
            this.maskdtarihi.TabIndex = 7;
            // 
            // maskkart
            // 
            this.maskkart.Location = new System.Drawing.Point(208, 193);
            this.maskkart.Name = "maskkart";
            this.maskkart.Size = new System.Drawing.Size(132, 20);
            this.maskkart.TabIndex = 8;
            // 
            // maskIP
            // 
            this.maskIP.Location = new System.Drawing.Point(208, 236);
            this.maskIP.Name = "maskIP";
            this.maskIP.Size = new System.Drawing.Size(132, 20);
            this.maskIP.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskIP);
            this.Controls.Add(this.maskkart);
            this.Controls.Add(this.maskdtarihi);
            this.Controls.Add(this.masktelefon);
            this.Controls.Add(this.maskTC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskTC;
        private System.Windows.Forms.MaskedTextBox masktelefon;
        private System.Windows.Forms.MaskedTextBox maskdtarihi;
        private System.Windows.Forms.MaskedTextBox maskkart;
        private System.Windows.Forms.MaskedTextBox maskIP;
    }
}

