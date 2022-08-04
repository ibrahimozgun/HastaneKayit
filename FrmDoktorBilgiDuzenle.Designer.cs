
namespace HastaneKayit
{
    partial class FrmDoktorBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDuzenle));
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.lblbrans = new System.Windows.Forms.Label();
            this.txtdoktorid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtperid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabelPass = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(77, 64);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(148, 20);
            this.msktc.TabIndex = 3;
            this.msktc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tc:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(77, 116);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(148, 20);
            this.txtsoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Soyad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(77, 90);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(148, 20);
            this.txtad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad:";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(77, 221);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(148, 35);
            this.btnguncelle.TabIndex = 29;
            this.btnguncelle.Text = "Güncelle";
            this.toolTip2.SetToolTip(this.btnguncelle, "Günceller");
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // cmbbrans
            // 
            this.cmbbrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(77, 142);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(148, 21);
            this.cmbbrans.TabIndex = 4;
            this.cmbbrans.SelectedIndexChanged += new System.EventHandler(this.cmbbrans_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Branş:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(77, 195);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(148, 20);
            this.txtemail.TabIndex = 35;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "E-Mail:";
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(77, 169);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(148, 20);
            this.msktelefon.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Telefon:";
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Bilgilendirme";
            // 
            // lblbrans
            // 
            this.lblbrans.AutoSize = true;
            this.lblbrans.Location = new System.Drawing.Point(15, 243);
            this.lblbrans.Name = "lblbrans";
            this.lblbrans.Size = new System.Drawing.Size(47, 13);
            this.lblbrans.TabIndex = 37;
            this.lblbrans.Text = "brans ID";
            this.lblbrans.Visible = false;
            // 
            // txtdoktorid
            // 
            this.txtdoktorid.Enabled = false;
            this.txtdoktorid.Location = new System.Drawing.Point(77, 12);
            this.txtdoktorid.Name = "txtdoktorid";
            this.txtdoktorid.Size = new System.Drawing.Size(148, 20);
            this.txtdoktorid.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Doktor ID:";
            // 
            // txtperid
            // 
            this.txtperid.Enabled = false;
            this.txtperid.Location = new System.Drawing.Point(77, 38);
            this.txtperid.Name = "txtperid";
            this.txtperid.Size = new System.Drawing.Size(148, 20);
            this.txtperid.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Personel ID:";
            // 
            // linkLabelPass
            // 
            this.linkLabelPass.AutoSize = true;
            this.linkLabelPass.Location = new System.Drawing.Point(184, 268);
            this.linkLabelPass.Name = "linkLabelPass";
            this.linkLabelPass.Size = new System.Drawing.Size(66, 13);
            this.linkLabelPass.TabIndex = 42;
            this.linkLabelPass.TabStop = true;
            this.linkLabelPass.Text = "Şifre Değiştir";
            this.linkLabelPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPass_LinkClicked);
            // 
            // FrmDoktorBilgiDuzenle
            // 
            this.AcceptButton = this.btnguncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 290);
            this.Controls.Add(this.linkLabelPass);
            this.Controls.Add(this.txtperid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdoktorid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblbrans);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDoktorBilgiDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Bilgi Düzenle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label lblbrans;
        private System.Windows.Forms.TextBox txtdoktorid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtperid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabelPass;
    }
}