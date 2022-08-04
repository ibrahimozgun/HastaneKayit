
namespace HastaneKayit
{
    partial class FrmPerParolaSifirla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerParolaSifirla));
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtSifre1 = new System.Windows.Forms.TextBox();
            this.lblsifre1 = new System.Windows.Forms.Label();
            this.txtSifre2 = new System.Windows.Forms.TextBox();
            this.lblsifre2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.checkBoxSifre = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(65, 30);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(89, 27);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 1;
            // 
            // txtSifre1
            // 
            this.txtSifre1.Location = new System.Drawing.Point(89, 53);
            this.txtSifre1.Name = "txtSifre1";
            this.txtSifre1.Size = new System.Drawing.Size(100, 20);
            this.txtSifre1.TabIndex = 3;
            this.txtSifre1.UseSystemPasswordChar = true;
            this.txtSifre1.TextChanged += new System.EventHandler(this.txtSifre1_TextChanged);
            // 
            // lblsifre1
            // 
            this.lblsifre1.AutoSize = true;
            this.lblsifre1.Location = new System.Drawing.Point(55, 56);
            this.lblsifre1.Name = "lblsifre1";
            this.lblsifre1.Size = new System.Drawing.Size(28, 13);
            this.lblsifre1.TabIndex = 2;
            this.lblsifre1.Text = "Şifre";
            // 
            // txtSifre2
            // 
            this.txtSifre2.Location = new System.Drawing.Point(89, 79);
            this.txtSifre2.Name = "txtSifre2";
            this.txtSifre2.Size = new System.Drawing.Size(100, 20);
            this.txtSifre2.TabIndex = 5;
            this.txtSifre2.UseSystemPasswordChar = true;
            this.txtSifre2.TextChanged += new System.EventHandler(this.txtSifre2_TextChanged);
            // 
            // lblsifre2
            // 
            this.lblsifre2.AutoSize = true;
            this.lblsifre2.Location = new System.Drawing.Point(21, 82);
            this.lblsifre2.Name = "lblsifre2";
            this.lblsifre2.Size = new System.Drawing.Size(62, 13);
            this.lblsifre2.TabIndex = 4;
            this.lblsifre2.Text = "Tekrar Şifre";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Cornsilk;
            this.btnKaydet.Location = new System.Drawing.Point(89, 128);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // checkBoxSifre
            // 
            this.checkBoxSifre.AutoSize = true;
            this.checkBoxSifre.Location = new System.Drawing.Point(89, 105);
            this.checkBoxSifre.Name = "checkBoxSifre";
            this.checkBoxSifre.Size = new System.Drawing.Size(81, 17);
            this.checkBoxSifre.TabIndex = 7;
            this.checkBoxSifre.Text = "Şifre Göster";
            this.checkBoxSifre.UseVisualStyleBackColor = true;
            this.checkBoxSifre.CheckedChanged += new System.EventHandler(this.checkBoxSifre_CheckedChanged);
            // 
            // FrmPerParolaSifirla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(234, 179);
            this.Controls.Add(this.checkBoxSifre);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSifre2);
            this.Controls.Add(this.lblsifre2);
            this.Controls.Add(this.txtSifre1);
            this.Controls.Add(this.lblsifre1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPerParolaSifirla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parola Sıfırlama";
            this.Load += new System.EventHandler(this.FrmParolaSifirla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtSifre1;
        private System.Windows.Forms.Label lblsifre1;
        private System.Windows.Forms.TextBox txtSifre2;
        private System.Windows.Forms.Label lblsifre2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckBox checkBoxSifre;
    }
}