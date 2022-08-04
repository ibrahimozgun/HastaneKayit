
namespace HastaneKayit
{
    partial class FrmSekreterKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifre1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSifre2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.checkBoxSifre = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(101, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(119, 20);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(101, 38);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(119, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC:";
            // 
            // txtSifre1
            // 
            this.txtSifre1.Location = new System.Drawing.Point(101, 90);
            this.txtSifre1.Name = "txtSifre1";
            this.txtSifre1.Size = new System.Drawing.Size(119, 20);
            this.txtSifre1.TabIndex = 4;
            this.txtSifre1.UseSystemPasswordChar = true;
            this.txtSifre1.TextChanged += new System.EventHandler(this.txtSifre1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şifre:";
            // 
            // txtSifre2
            // 
            this.txtSifre2.Location = new System.Drawing.Point(101, 116);
            this.txtSifre2.Name = "txtSifre2";
            this.txtSifre2.Size = new System.Drawing.Size(119, 20);
            this.txtSifre2.TabIndex = 5;
            this.txtSifre2.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tekrar Şifre";
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(101, 64);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(119, 20);
            this.mskTC.TabIndex = 3;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKayit.Location = new System.Drawing.Point(101, 166);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(119, 32);
            this.btnKayit.TabIndex = 6;
            this.btnKayit.Text = "KAYIT";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // checkBoxSifre
            // 
            this.checkBoxSifre.AutoSize = true;
            this.checkBoxSifre.Location = new System.Drawing.Point(101, 142);
            this.checkBoxSifre.Name = "checkBoxSifre";
            this.checkBoxSifre.Size = new System.Drawing.Size(86, 17);
            this.checkBoxSifre.TabIndex = 9;
            this.checkBoxSifre.Text = "Şifreyi göster";
            this.checkBoxSifre.UseVisualStyleBackColor = true;
            this.checkBoxSifre.CheckedChanged += new System.EventHandler(this.checkBoxSifre_CheckedChanged);
            // 
            // FrmSekreterKayit
            // 
            this.AcceptButton = this.btnKayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(282, 210);
            this.Controls.Add(this.checkBoxSifre);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.txtSifre2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSifre1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSekreterKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Kayıt";
            this.Load += new System.EventHandler(this.FrmSekreterKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifre1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSifre2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.CheckBox checkBoxSifre;
    }
}