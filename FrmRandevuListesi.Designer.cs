
namespace HastaneKayit
{
    partial class FrmRandevuListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.cmbdoktor = new System.Windows.Forms.ComboBox();
            this.txtidguncelle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richtxtsikayet = new System.Windows.Forms.RichTextBox();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.msksaat = new System.Windows.Forms.MaskedTextBox();
            this.lblsaat = new System.Windows.Forms.Label();
            this.lbldakika = new System.Windows.Forms.Label();
            this.lbltarih = new System.Windows.Forms.Label();
            this.lblgun = new System.Windows.Forms.Label();
            this.lblay = new System.Windows.Forms.Label();
            this.lblyil = new System.Windows.Forms.Label();
            this.lblryil = new System.Windows.Forms.Label();
            this.lblray = new System.Windows.Forms.Label();
            this.lblrgun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(163, 351);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(52, 20);
            this.txtid.TabIndex = 1;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(221, 351);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(74, 20);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "İşlem Yapılacak Randevu ID:";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(695, 318);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(156, 23);
            this.btnguncelle.TabIndex = 5;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(713, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(708, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Branş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(703, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Doktor:";
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(751, 152);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(100, 20);
            this.txttc.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(690, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hasta TC:";
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(751, 100);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(100, 21);
            this.cmbbrans.TabIndex = 16;
            this.cmbbrans.SelectedIndexChanged += new System.EventHandler(this.cmbbrans_SelectedIndexChanged);
            // 
            // cmbdoktor
            // 
            this.cmbdoktor.FormattingEnabled = true;
            this.cmbdoktor.Location = new System.Drawing.Point(751, 126);
            this.cmbdoktor.Name = "cmbdoktor";
            this.cmbdoktor.Size = new System.Drawing.Size(100, 21);
            this.cmbdoktor.TabIndex = 17;
            // 
            // txtidguncelle
            // 
            this.txtidguncelle.Enabled = false;
            this.txtidguncelle.Location = new System.Drawing.Point(751, 22);
            this.txtidguncelle.Name = "txtidguncelle";
            this.txtidguncelle.Size = new System.Drawing.Size(100, 20);
            this.txtidguncelle.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(724, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(690, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Hasta Şikayet:";
            // 
            // richtxtsikayet
            // 
            this.richtxtsikayet.Location = new System.Drawing.Point(695, 194);
            this.richtxtsikayet.Name = "richtxtsikayet";
            this.richtxtsikayet.Size = new System.Drawing.Size(156, 118);
            this.richtxtsikayet.TabIndex = 21;
            this.richtxtsikayet.Text = "";
            // 
            // msktarih
            // 
            this.msktarih.Location = new System.Drawing.Point(751, 48);
            this.msktarih.Mask = "00.00.0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(100, 20);
            this.msktarih.TabIndex = 22;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // msksaat
            // 
            this.msksaat.Location = new System.Drawing.Point(751, 74);
            this.msksaat.Mask = "00:00";
            this.msksaat.Name = "msksaat";
            this.msksaat.Size = new System.Drawing.Size(100, 20);
            this.msksaat.TabIndex = 23;
            this.msksaat.Text = "1561";
            this.msksaat.ValidatingType = typeof(System.DateTime);
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.Location = new System.Drawing.Point(695, 354);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(59, 13);
            this.lblsaat.TabIndex = 24;
            this.lblsaat.Text = "saat kontol";
            this.lblsaat.Visible = false;
            // 
            // lbldakika
            // 
            this.lbldakika.AutoSize = true;
            this.lbldakika.Location = new System.Drawing.Point(768, 354);
            this.lbldakika.Name = "lbldakika";
            this.lbldakika.Size = new System.Drawing.Size(74, 13);
            this.lbldakika.TabIndex = 25;
            this.lbldakika.Text = "dakika kontrol";
            this.lbldakika.Visible = false;
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Location = new System.Drawing.Point(789, 6);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(35, 13);
            this.lbltarih.TabIndex = 26;
            this.lbltarih.Text = "label9";
            // 
            // lblgun
            // 
            this.lblgun.AutoSize = true;
            this.lblgun.Location = new System.Drawing.Point(575, 354);
            this.lblgun.Name = "lblgun";
            this.lblgun.Size = new System.Drawing.Size(25, 13);
            this.lblgun.TabIndex = 27;
            this.lblgun.Text = "gün";
            this.lblgun.Visible = false;
            // 
            // lblay
            // 
            this.lblay.AutoSize = true;
            this.lblay.Location = new System.Drawing.Point(625, 354);
            this.lblay.Name = "lblay";
            this.lblay.Size = new System.Drawing.Size(18, 13);
            this.lblay.TabIndex = 28;
            this.lblay.Text = "ay";
            this.lblay.Visible = false;
            // 
            // lblyil
            // 
            this.lblyil.AutoSize = true;
            this.lblyil.Location = new System.Drawing.Point(665, 355);
            this.lblyil.Name = "lblyil";
            this.lblyil.Size = new System.Drawing.Size(16, 13);
            this.lblyil.TabIndex = 29;
            this.lblyil.Text = "yil";
            this.lblyil.Visible = false;
            // 
            // lblryil
            // 
            this.lblryil.AutoSize = true;
            this.lblryil.Location = new System.Drawing.Point(511, 358);
            this.lblryil.Name = "lblryil";
            this.lblryil.Size = new System.Drawing.Size(58, 13);
            this.lblryil.TabIndex = 32;
            this.lblryil.Text = "randevu yıl";
            this.lblryil.Visible = false;
            // 
            // lblray
            // 
            this.lblray.AutoSize = true;
            this.lblray.Location = new System.Drawing.Point(446, 358);
            this.lblray.Name = "lblray";
            this.lblray.Size = new System.Drawing.Size(60, 13);
            this.lblray.TabIndex = 31;
            this.lblray.Text = "randevu ay";
            this.lblray.Visible = false;
            // 
            // lblrgun
            // 
            this.lblrgun.AutoSize = true;
            this.lblrgun.Location = new System.Drawing.Point(373, 354);
            this.lblrgun.Name = "lblrgun";
            this.lblrgun.Size = new System.Drawing.Size(67, 13);
            this.lblrgun.TabIndex = 30;
            this.lblrgun.Text = "randevu gün";
            this.lblrgun.Visible = false;
            // 
            // FrmRandevuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 377);
            this.Controls.Add(this.lblryil);
            this.Controls.Add(this.lblray);
            this.Controls.Add(this.lblrgun);
            this.Controls.Add(this.lblyil);
            this.Controls.Add(this.lblay);
            this.Controls.Add(this.lblgun);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.lbldakika);
            this.Controls.Add(this.lblsaat);
            this.Controls.Add(this.msksaat);
            this.Controls.Add(this.msktarih);
            this.Controls.Add(this.richtxtsikayet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtidguncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbdoktor);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmRandevuListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Listesi";
            this.Load += new System.EventHandler(this.FrmRandevuListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.ComboBox cmbdoktor;
        private System.Windows.Forms.TextBox txtidguncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richtxtsikayet;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private System.Windows.Forms.MaskedTextBox msksaat;
        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.Label lbldakika;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.Label lblgun;
        private System.Windows.Forms.Label lblay;
        private System.Windows.Forms.Label lblyil;
        private System.Windows.Forms.Label lblryil;
        private System.Windows.Forms.Label lblray;
        private System.Windows.Forms.Label lblrgun;
    }
}