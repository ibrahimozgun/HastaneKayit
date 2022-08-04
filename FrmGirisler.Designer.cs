
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.btnhastagirisi = new System.Windows.Forms.Button();
            this.btndoktorgirisi = new System.Windows.Forms.Button();
            this.btnsekretergirisi = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnhastagirisi
            // 
            this.btnhastagirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhastagirisi.BackgroundImage")));
            this.btnhastagirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhastagirisi.Location = new System.Drawing.Point(41, 55);
            this.btnhastagirisi.Name = "btnhastagirisi";
            this.btnhastagirisi.Size = new System.Drawing.Size(90, 90);
            this.btnhastagirisi.TabIndex = 0;
            this.btnhastagirisi.UseVisualStyleBackColor = true;
            this.btnhastagirisi.Click += new System.EventHandler(this.btnhastagirisi_Click);
            // 
            // btndoktorgirisi
            // 
            this.btndoktorgirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndoktorgirisi.BackgroundImage")));
            this.btndoktorgirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndoktorgirisi.Location = new System.Drawing.Point(137, 55);
            this.btndoktorgirisi.Name = "btndoktorgirisi";
            this.btndoktorgirisi.Size = new System.Drawing.Size(90, 90);
            this.btndoktorgirisi.TabIndex = 1;
            this.btndoktorgirisi.UseVisualStyleBackColor = true;
            this.btndoktorgirisi.Click += new System.EventHandler(this.btndoktorgirisi_Click);
            // 
            // btnsekretergirisi
            // 
            this.btnsekretergirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsekretergirisi.BackgroundImage")));
            this.btnsekretergirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsekretergirisi.Location = new System.Drawing.Point(233, 55);
            this.btnsekretergirisi.Name = "btnsekretergirisi";
            this.btnsekretergirisi.Size = new System.Drawing.Size(90, 90);
            this.btnsekretergirisi.TabIndex = 2;
            this.btnsekretergirisi.UseVisualStyleBackColor = true;
            this.btnsekretergirisi.Click += new System.EventHandler(this.btnsekretergirisi_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdmin.BackgroundImage")));
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.Location = new System.Drawing.Point(329, 55);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(90, 90);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(153, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(233, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sekreter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(112, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hastane Giriş Ekranı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(343, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Admin";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(463, 207);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnsekretergirisi);
            this.Controls.Add(this.btndoktorgirisi);
            this.Controls.Add(this.btnhastagirisi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.FrmGirisler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhastagirisi;
        private System.Windows.Forms.Button btndoktorgirisi;
        private System.Windows.Forms.Button btnsekretergirisi;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

