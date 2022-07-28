
namespace HastaneKayit
{
    partial class FrmGirisler
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
            this.btnhastagirisi = new System.Windows.Forms.Button();
            this.btndoktorgirisi = new System.Windows.Forms.Button();
            this.btnsekretergirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnhastagirisi
            // 
            this.btnhastagirisi.Location = new System.Drawing.Point(7, 83);
            this.btnhastagirisi.Name = "btnhastagirisi";
            this.btnhastagirisi.Size = new System.Drawing.Size(105, 69);
            this.btnhastagirisi.TabIndex = 0;
            this.btnhastagirisi.Text = "Hasta";
            this.btnhastagirisi.UseVisualStyleBackColor = true;
            this.btnhastagirisi.Click += new System.EventHandler(this.btnhastagirisi_Click);
            // 
            // btndoktorgirisi
            // 
            this.btndoktorgirisi.Location = new System.Drawing.Point(118, 8);
            this.btndoktorgirisi.Name = "btndoktorgirisi";
            this.btndoktorgirisi.Size = new System.Drawing.Size(105, 69);
            this.btndoktorgirisi.TabIndex = 1;
            this.btndoktorgirisi.Text = "Doktor";
            this.btndoktorgirisi.UseVisualStyleBackColor = true;
            this.btndoktorgirisi.Click += new System.EventHandler(this.btndoktorgirisi_Click);
            // 
            // btnsekretergirisi
            // 
            this.btnsekretergirisi.Location = new System.Drawing.Point(229, 83);
            this.btnsekretergirisi.Name = "btnsekretergirisi";
            this.btnsekretergirisi.Size = new System.Drawing.Size(105, 69);
            this.btnsekretergirisi.TabIndex = 2;
            this.btnsekretergirisi.Text = "Sekreter";
            this.btnsekretergirisi.UseVisualStyleBackColor = true;
            this.btnsekretergirisi.Click += new System.EventHandler(this.btnsekretergirisi_Click);
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(357, 207);
            this.Controls.Add(this.btnsekretergirisi);
            this.Controls.Add(this.btndoktorgirisi);
            this.Controls.Add(this.btnhastagirisi);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.FrmGirisler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnhastagirisi;
        private System.Windows.Forms.Button btndoktorgirisi;
        private System.Windows.Forms.Button btnsekretergirisi;
    }
}

