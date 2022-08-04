
namespace HastaneKayit
{
    partial class FrmSifre_Degistir
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSifre_Degistir));
            this.txtPassEski = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassYeni1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassYeni2 = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblbilgi = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBoxPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassEski
            // 
            this.txtPassEski.Location = new System.Drawing.Point(108, 12);
            this.txtPassEski.Name = "txtPassEski";
            this.txtPassEski.Size = new System.Drawing.Size(120, 20);
            this.txtPassEski.TabIndex = 0;
            this.txtPassEski.UseSystemPasswordChar = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(108, 196);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 36);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eski Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yeni Şifre";
            // 
            // txtPassYeni1
            // 
            this.errorProvider1.SetError(this.txtPassYeni1, "Şifreler uyuşmuyor");
            this.txtPassYeni1.Location = new System.Drawing.Point(108, 61);
            this.txtPassYeni1.Name = "txtPassYeni1";
            this.txtPassYeni1.Size = new System.Drawing.Size(120, 20);
            this.txtPassYeni1.TabIndex = 4;
            this.txtPassYeni1.UseSystemPasswordChar = true;
            this.txtPassYeni1.TextChanged += new System.EventHandler(this.txtPassYeni1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yeni Şifre Tekrar";
            // 
            // txtPassYeni2
            // 
            this.errorProvider1.SetError(this.txtPassYeni2, "Şifreler uyuşmuyor");
            this.txtPassYeni2.Location = new System.Drawing.Point(108, 110);
            this.txtPassYeni2.Name = "txtPassYeni2";
            this.txtPassYeni2.Size = new System.Drawing.Size(120, 20);
            this.txtPassYeni2.TabIndex = 6;
            this.txtPassYeni2.UseSystemPasswordChar = true;
            this.txtPassYeni2.TextChanged += new System.EventHandler(this.txtPassYeni2_TextChanged);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(16, 170);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(37, 13);
            this.lblid.TabIndex = 12;
            this.lblid.Text = "Per ID";
            this.lblid.Visible = false;
            // 
            // lblbilgi
            // 
            this.lblbilgi.AutoSize = true;
            this.lblbilgi.BackColor = System.Drawing.SystemColors.Control;
            this.lblbilgi.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbilgi.ForeColor = System.Drawing.Color.Red;
            this.lblbilgi.Location = new System.Drawing.Point(105, 133);
            this.lblbilgi.MaximumSize = new System.Drawing.Size(160, 220);
            this.lblbilgi.Name = "lblbilgi";
            this.lblbilgi.Size = new System.Drawing.Size(158, 28);
            this.lblbilgi.TabIndex = 37;
            this.lblbilgi.Text = "Büyük harf, küçük harf, sembol veya rakam eksik";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 400;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // checkBoxPass
            // 
            this.checkBoxPass.AutoSize = true;
            this.checkBoxPass.Location = new System.Drawing.Point(108, 173);
            this.checkBoxPass.Name = "checkBoxPass";
            this.checkBoxPass.Size = new System.Drawing.Size(109, 17);
            this.checkBoxPass.TabIndex = 38;
            this.checkBoxPass.Text = "Şifreleri Görüntüle";
            this.checkBoxPass.UseVisualStyleBackColor = true;
            this.checkBoxPass.CheckedChanged += new System.EventHandler(this.checkBoxPass_CheckedChanged);
            // 
            // FrmSifre_Degistir
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 244);
            this.Controls.Add(this.checkBoxPass);
            this.Controls.Add(this.lblbilgi);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassYeni2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassYeni1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtPassEski);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSifre_Degistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ŞİFRE DEĞİŞTİR";
            this.Load += new System.EventHandler(this.Sifre_Degistir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassEski;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassYeni1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassYeni2;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblbilgi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox checkBoxPass;
    }
}