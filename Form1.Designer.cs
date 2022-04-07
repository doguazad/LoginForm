namespace WindowsFormsApp3
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
            this.textUserN = new System.Windows.Forms.TextBox();
            this.gonder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textUserN
            // 
            this.textUserN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUserN.Location = new System.Drawing.Point(528, 12);
            this.textUserN.Multiline = true;
            this.textUserN.Name = "textUserN";
            this.textUserN.Size = new System.Drawing.Size(263, 53);
            this.textUserN.TabIndex = 0;
            // 
            // gonder
            // 
            this.gonder.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gonder.Location = new System.Drawing.Point(308, 194);
            this.gonder.Name = "gonder";
            this.gonder.Size = new System.Drawing.Size(417, 55);
            this.gonder.TabIndex = 1;
            this.gonder.Text = "Gönder";
            this.gonder.UseVisualStyleBackColor = true;
            this.gonder.Click += new System.EventHandler(this.gonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(248, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(258, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 57);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // textSifre
            // 
            this.textSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSifre.Location = new System.Drawing.Point(528, 109);
            this.textSifre.Multiline = true;
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(263, 53);
            this.textSifre.TabIndex = 4;
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.ForeColor = System.Drawing.Color.Red;
            this.label.Location = new System.Drawing.Point(186, 194);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(699, 45);
            this.label.TabIndex = 5;
            this.label.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.gonder);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUserN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textUserN;
        private System.Windows.Forms.Button gonder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.Label label;
    }
}

