
namespace HastaneKayit
{
    partial class FrmHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRandevuSil = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbldosadasd = new System.Windows.Forms.Label();
            this.cmbsaat = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txttemizle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkbilgiduzenle = new System.Windows.Forms.LinkLabel();
            this.richtxtsikayet = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnrandevual = new System.Windows.Forms.Button();
            this.cmbdoktor = new System.Windows.Forms.ComboBox();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldoktor = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridGecmis = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridAktif = new System.Windows.Forms.DataGridView();
            this.btnanaekran = new System.Windows.Forms.Button();
            this.lbltarih = new System.Windows.Forms.Label();
            this.lblbrans = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGecmis)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAktif)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.lbltc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbladsoyad);
            this.groupBox1.Location = new System.Drawing.Point(14, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgi";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(122, 42);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(15, 13);
            this.lblid.TabIndex = 7;
            this.lblid.Text = "id";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(122, 16);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(73, 13);
            this.lbltc.TabIndex = 1;
            this.lbltc.Text = "00000000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hasta ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(122, 29);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(46, 13);
            this.lbladsoyad.TabIndex = 3;
            this.lbladsoyad.Text = "Null Null";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnRandevuSil);
            this.groupBox2.Controls.Add(this.lblinfo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbldosadasd);
            this.groupBox2.Controls.Add(this.cmbsaat);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txttemizle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.linkbilgiduzenle);
            this.groupBox2.Controls.Add(this.richtxtsikayet);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnrandevual);
            this.groupBox2.Controls.Add(this.cmbdoktor);
            this.groupBox2.Controls.Add(this.cmbbrans);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(15, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 439);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu";
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.Location = new System.Drawing.Point(51, 375);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(73, 58);
            this.btnRandevuSil.TabIndex = 15;
            this.btnRandevuSil.Text = "Randevuyu İptal Et";
            this.btnRandevuSil.UseVisualStyleBackColor = true;
            this.btnRandevuSil.Click += new System.EventHandler(this.btnRandevuSil_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.ForeColor = System.Drawing.Color.Red;
            this.lblinfo.Location = new System.Drawing.Point(51, 146);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(200, 29);
            this.lblinfo.TabIndex = 15;
            this.lblinfo.Text = "Hastanın veya doktorun randevusu olduğu saatler kaldırıldı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Saat:";
            // 
            // lbldosadasd
            // 
            this.lbldosadasd.AutoSize = true;
            this.lbldosadasd.Location = new System.Drawing.Point(3, 72);
            this.lbldosadasd.Name = "lbldosadasd";
            this.lbldosadasd.Size = new System.Drawing.Size(42, 13);
            this.lbldosadasd.TabIndex = 8;
            this.lbldosadasd.Text = "Doktor:";
            // 
            // cmbsaat
            // 
            this.cmbsaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsaat.Enabled = false;
            this.cmbsaat.FormattingEnabled = true;
            this.cmbsaat.Items.AddRange(new object[] {
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30"});
            this.cmbsaat.Location = new System.Drawing.Point(51, 122);
            this.cmbsaat.Name = "cmbsaat";
            this.cmbsaat.Size = new System.Drawing.Size(200, 21);
            this.cmbsaat.TabIndex = 4;
            this.cmbsaat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbsaat_MouseClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txttemizle
            // 
            this.txttemizle.Location = new System.Drawing.Point(51, 340);
            this.txttemizle.Name = "txttemizle";
            this.txttemizle.Size = new System.Drawing.Size(73, 29);
            this.txttemizle.TabIndex = 6;
            this.txttemizle.Text = "Temizle";
            this.txttemizle.UseVisualStyleBackColor = true;
            this.txttemizle.Click += new System.EventHandler(this.txttemizle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tarih:";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(80, 16);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(171, 20);
            this.txtid.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Randevu ID:";
            // 
            // linkbilgiduzenle
            // 
            this.linkbilgiduzenle.AutoSize = true;
            this.linkbilgiduzenle.Location = new System.Drawing.Point(162, 420);
            this.linkbilgiduzenle.Name = "linkbilgiduzenle";
            this.linkbilgiduzenle.Size = new System.Drawing.Size(89, 13);
            this.linkbilgiduzenle.TabIndex = 8;
            this.linkbilgiduzenle.TabStop = true;
            this.linkbilgiduzenle.Text = "Bilgilerini Düzenle";
            this.linkbilgiduzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkbilgiduzenle_LinkClicked);
            // 
            // richtxtsikayet
            // 
            this.richtxtsikayet.Location = new System.Drawing.Point(51, 178);
            this.richtxtsikayet.Name = "richtxtsikayet";
            this.richtxtsikayet.Size = new System.Drawing.Size(200, 156);
            this.richtxtsikayet.TabIndex = 5;
            this.richtxtsikayet.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Şikayet:";
            // 
            // btnrandevual
            // 
            this.btnrandevual.Location = new System.Drawing.Point(130, 340);
            this.btnrandevual.Name = "btnrandevual";
            this.btnrandevual.Size = new System.Drawing.Size(121, 47);
            this.btnrandevual.TabIndex = 7;
            this.btnrandevual.Text = "Randevu Al";
            this.btnrandevual.UseVisualStyleBackColor = true;
            this.btnrandevual.Click += new System.EventHandler(this.btnrandevual_Click);
            // 
            // cmbdoktor
            // 
            this.cmbdoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdoktor.FormattingEnabled = true;
            this.cmbdoktor.Location = new System.Drawing.Point(51, 69);
            this.cmbdoktor.Name = "cmbdoktor";
            this.cmbdoktor.Size = new System.Drawing.Size(200, 21);
            this.cmbdoktor.TabIndex = 2;
            this.cmbdoktor.SelectedIndexChanged += new System.EventHandler(this.cmbdoktor_SelectedIndexChanged);
            // 
            // cmbbrans
            // 
            this.cmbbrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(51, 42);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(200, 21);
            this.cmbbrans.TabIndex = 1;
            this.cmbbrans.SelectedIndexChanged += new System.EventHandler(this.cmbbrans_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Branş:";
            // 
            // lbldoktor
            // 
            this.lbldoktor.AutoSize = true;
            this.lbldoktor.Location = new System.Drawing.Point(485, 530);
            this.lbldoktor.Name = "lbldoktor";
            this.lbldoktor.Size = new System.Drawing.Size(42, 13);
            this.lbldoktor.TabIndex = 2;
            this.lbldoktor.Text = "Doktor:";
            this.lbldoktor.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.dataGridGecmis);
            this.groupBox3.Location = new System.Drawing.Point(287, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 221);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridGecmis
            // 
            this.dataGridGecmis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridGecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGecmis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridGecmis.Location = new System.Drawing.Point(3, 16);
            this.dataGridGecmis.Name = "dataGridGecmis";
            this.dataGridGecmis.ReadOnly = true;
            this.dataGridGecmis.Size = new System.Drawing.Size(516, 202);
            this.dataGridGecmis.TabIndex = 0;
            this.dataGridGecmis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGecmis_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.dataGridAktif);
            this.groupBox4.Location = new System.Drawing.Point(287, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(522, 248);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevu";
            // 
            // dataGridAktif
            // 
            this.dataGridAktif.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridAktif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAktif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAktif.Location = new System.Drawing.Point(3, 16);
            this.dataGridAktif.Name = "dataGridAktif";
            this.dataGridAktif.ReadOnly = true;
            this.dataGridAktif.Size = new System.Drawing.Size(516, 229);
            this.dataGridAktif.TabIndex = 0;
            this.dataGridAktif.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAktif_CellClick);
            // 
            // btnanaekran
            // 
            this.btnanaekran.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnanaekran.Location = new System.Drawing.Point(614, 504);
            this.btnanaekran.Name = "btnanaekran";
            this.btnanaekran.Size = new System.Drawing.Size(195, 58);
            this.btnanaekran.TabIndex = 6;
            this.btnanaekran.Text = "ANA EKRAN DÖN";
            this.btnanaekran.UseVisualStyleBackColor = false;
            this.btnanaekran.Click += new System.EventHandler(this.btnanaekran_Click);
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Location = new System.Drawing.Point(737, 9);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(35, 13);
            this.lbltarih.TabIndex = 1;
            this.lbltarih.Text = "label4";
            // 
            // lblbrans
            // 
            this.lblbrans.AutoSize = true;
            this.lblbrans.Location = new System.Drawing.Point(485, 513);
            this.lblbrans.Name = "lblbrans";
            this.lblbrans.Size = new System.Drawing.Size(33, 13);
            this.lblbrans.TabIndex = 7;
            this.lblbrans.Text = "brans";
            this.lblbrans.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(376, 512);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(94, 13);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "Doktorun izin tarihi";
            this.lbl1.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(385, 528);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(74, 13);
            this.lbl2.TabIndex = 14;
            this.lbl2.Text = "iznin bitis tarihi";
            this.lbl2.Visible = false;
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(821, 572);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblbrans);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.btnanaekran);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbldoktor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHastaDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Detay";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGecmis)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAktif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnrandevual;
        private System.Windows.Forms.ComboBox cmbdoktor;
        private System.Windows.Forms.Label lbldoktor;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridGecmis;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridAktif;
        private System.Windows.Forms.RichTextBox richtxtsikayet;
        private System.Windows.Forms.LinkLabel linkbilgiduzenle;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txttemizle;
        private System.Windows.Forms.Button btnanaekran;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblbrans;
        private System.Windows.Forms.Label lbldosadasd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbsaat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btnRandevuSil;
    }
}