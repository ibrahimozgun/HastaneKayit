
namespace HastaneKayit
{
    partial class FrmAdminDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminDetay));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dataGridPer = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassYeni = new System.Windows.Forms.TextBox();
            this.groupBoxSifreDegis = new System.Windows.Forms.GroupBox();
            this.checkBoxSifre = new System.Windows.Forms.CheckBox();
            this.pictureBoxCarpi = new System.Windows.Forms.PictureBox();
            this.pictureBoxTik = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.linkSifreDegis = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxYeniHesap = new System.Windows.Forms.GroupBox();
            this.pictureBoxCarpi2 = new System.Windows.Forms.PictureBox();
            this.btnYeniKaydet = new System.Windows.Forms.Button();
            this.txtYeniNick = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYeniPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linkYeniHesap = new System.Windows.Forms.LinkLabel();
            this.btnAnaEkran = new System.Windows.Forms.Button();
            this.linkParolaSifirla = new System.Windows.Forms.LinkLabel();
            this.groupBoxPerSil = new System.Windows.Forms.GroupBox();
            this.txtPerSilUnvan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBoxCarpi3 = new System.Windows.Forms.PictureBox();
            this.btnPerSil = new System.Windows.Forms.Button();
            this.txtPerSilid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.linkPerSil = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLoad = new System.Windows.Forms.LinkLabel();
            this.linkSekreterEkle = new System.Windows.Forms.LinkLabel();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPer)).BeginInit();
            this.groupBoxSifreDegis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarpi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTik)).BeginInit();
            this.groupBoxYeniHesap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarpi2)).BeginInit();
            this.groupBoxPerSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarpi3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dataGridPer);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(584, 206);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "PERSONELLER";
            // 
            // dataGridPer
            // 
            this.dataGridPer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPer.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPer.Location = new System.Drawing.Point(3, 16);
            this.dataGridPer.Name = "dataGridPer";
            this.dataGridPer.ReadOnly = true;
            this.dataGridPer.Size = new System.Drawing.Size(578, 187);
            this.dataGridPer.TabIndex = 0;
            this.dataGridPer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPer_CellClick);
            this.dataGridPer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPer_CellDoubleClick);
            // 
            // txtNick
            // 
            this.txtNick.Enabled = false;
            this.txtNick.Location = new System.Drawing.Point(94, 41);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(100, 20);
            this.txtNick.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(73, 186);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(102, 39);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtPass1
            // 
            this.txtPass1.Location = new System.Drawing.Point(94, 67);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.Size = new System.Drawing.Size(100, 20);
            this.txtPass1.TabIndex = 3;
            this.txtPass1.UseSystemPasswordChar = true;
            this.txtPass1.TextChanged += new System.EventHandler(this.txtPass1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Eski Şifre";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(94, 15);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(55, 20);
            this.txtid.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yeni Şifre";
            // 
            // txtPassYeni
            // 
            this.txtPassYeni.Location = new System.Drawing.Point(94, 119);
            this.txtPassYeni.Name = "txtPassYeni";
            this.txtPassYeni.Size = new System.Drawing.Size(100, 20);
            this.txtPassYeni.TabIndex = 8;
            this.txtPassYeni.UseSystemPasswordChar = true;
            this.txtPassYeni.TextChanged += new System.EventHandler(this.txtPassYeni_TextChanged);
            // 
            // groupBoxSifreDegis
            // 
            this.groupBoxSifreDegis.BackColor = System.Drawing.Color.Honeydew;
            this.groupBoxSifreDegis.Controls.Add(this.checkBoxSifre);
            this.groupBoxSifreDegis.Controls.Add(this.pictureBoxCarpi);
            this.groupBoxSifreDegis.Controls.Add(this.pictureBoxTik);
            this.groupBoxSifreDegis.Controls.Add(this.btnKaydet);
            this.groupBoxSifreDegis.Controls.Add(this.label5);
            this.groupBoxSifreDegis.Controls.Add(this.label4);
            this.groupBoxSifreDegis.Controls.Add(this.txtPass2);
            this.groupBoxSifreDegis.Controls.Add(this.txtPassYeni);
            this.groupBoxSifreDegis.Controls.Add(this.txtid);
            this.groupBoxSifreDegis.Controls.Add(this.label3);
            this.groupBoxSifreDegis.Controls.Add(this.txtNick);
            this.groupBoxSifreDegis.Controls.Add(this.label2);
            this.groupBoxSifreDegis.Controls.Add(this.label1);
            this.groupBoxSifreDegis.Controls.Add(this.txtPass1);
            this.groupBoxSifreDegis.Location = new System.Drawing.Point(370, 224);
            this.groupBoxSifreDegis.Name = "groupBoxSifreDegis";
            this.groupBoxSifreDegis.Size = new System.Drawing.Size(226, 242);
            this.groupBoxSifreDegis.TabIndex = 10;
            this.groupBoxSifreDegis.TabStop = false;
            this.groupBoxSifreDegis.Text = "Şifre Değiştir";
            this.groupBoxSifreDegis.Visible = false;
            // 
            // checkBoxSifre
            // 
            this.checkBoxSifre.AutoSize = true;
            this.checkBoxSifre.Location = new System.Drawing.Point(94, 145);
            this.checkBoxSifre.Name = "checkBoxSifre";
            this.checkBoxSifre.Size = new System.Drawing.Size(81, 17);
            this.checkBoxSifre.TabIndex = 12;
            this.checkBoxSifre.Text = "Şifre Göster";
            this.checkBoxSifre.UseVisualStyleBackColor = true;
            this.checkBoxSifre.CheckedChanged += new System.EventHandler(this.checkBoxSifre_CheckedChanged);
            // 
            // pictureBoxCarpi
            // 
            this.pictureBoxCarpi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarpi.Image")));
            this.pictureBoxCarpi.Location = new System.Drawing.Point(205, 9);
            this.pictureBoxCarpi.Name = "pictureBoxCarpi";
            this.pictureBoxCarpi.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCarpi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCarpi.TabIndex = 15;
            this.pictureBoxCarpi.TabStop = false;
            this.pictureBoxCarpi.Click += new System.EventHandler(this.pictureBoxCarpi_Click);
            // 
            // pictureBoxTik
            // 
            this.pictureBoxTik.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTik.Image")));
            this.pictureBoxTik.Location = new System.Drawing.Point(198, 80);
            this.pictureBoxTik.Name = "pictureBoxTik";
            this.pictureBoxTik.Size = new System.Drawing.Size(22, 20);
            this.pictureBoxTik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTik.TabIndex = 11;
            this.pictureBoxTik.TabStop = false;
            this.pictureBoxTik.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Eski Şifre Tekrar";
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(94, 93);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Size = new System.Drawing.Size(100, 20);
            this.txtPass2.TabIndex = 8;
            this.txtPass2.UseSystemPasswordChar = true;
            this.txtPass2.TextChanged += new System.EventHandler(this.txtPass2_TextChanged);
            // 
            // linkSifreDegis
            // 
            this.linkSifreDegis.AutoSize = true;
            this.linkSifreDegis.Location = new System.Drawing.Point(6, 30);
            this.linkSifreDegis.Name = "linkSifreDegis";
            this.linkSifreDegis.Size = new System.Drawing.Size(66, 13);
            this.linkSifreDegis.TabIndex = 11;
            this.linkSifreDegis.TabStop = true;
            this.linkSifreDegis.Text = "Şifre Değiştir";
            this.linkSifreDegis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSifreDegis_LinkClicked);
            // 
            // groupBoxYeniHesap
            // 
            this.groupBoxYeniHesap.Controls.Add(this.pictureBoxCarpi2);
            this.groupBoxYeniHesap.Controls.Add(this.btnYeniKaydet);
            this.groupBoxYeniHesap.Controls.Add(this.txtYeniNick);
            this.groupBoxYeniHesap.Controls.Add(this.label6);
            this.groupBoxYeniHesap.Controls.Add(this.txtYeniPass);
            this.groupBoxYeniHesap.Controls.Add(this.label7);
            this.groupBoxYeniHesap.Location = new System.Drawing.Point(164, 389);
            this.groupBoxYeniHesap.Name = "groupBoxYeniHesap";
            this.groupBoxYeniHesap.Size = new System.Drawing.Size(200, 139);
            this.groupBoxYeniHesap.TabIndex = 12;
            this.groupBoxYeniHesap.TabStop = false;
            this.groupBoxYeniHesap.Text = "Yeni Admin Hesabı Oluştur";
            this.groupBoxYeniHesap.Visible = false;
            // 
            // pictureBoxCarpi2
            // 
            this.pictureBoxCarpi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarpi2.Image")));
            this.pictureBoxCarpi2.Location = new System.Drawing.Point(179, 9);
            this.pictureBoxCarpi2.Name = "pictureBoxCarpi2";
            this.pictureBoxCarpi2.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCarpi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCarpi2.TabIndex = 16;
            this.pictureBoxCarpi2.TabStop = false;
            this.pictureBoxCarpi2.Click += new System.EventHandler(this.pictureBoxCarpi2_Click);
            // 
            // btnYeniKaydet
            // 
            this.btnYeniKaydet.Location = new System.Drawing.Point(80, 93);
            this.btnYeniKaydet.Name = "btnYeniKaydet";
            this.btnYeniKaydet.Size = new System.Drawing.Size(100, 36);
            this.btnYeniKaydet.TabIndex = 14;
            this.btnYeniKaydet.Text = "OLUŞTUR";
            this.btnYeniKaydet.UseVisualStyleBackColor = true;
            this.btnYeniKaydet.Click += new System.EventHandler(this.btnYeniKaydet_Click);
            // 
            // txtYeniNick
            // 
            this.txtYeniNick.Location = new System.Drawing.Point(80, 31);
            this.txtYeniNick.Name = "txtYeniNick";
            this.txtYeniNick.Size = new System.Drawing.Size(100, 20);
            this.txtYeniNick.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Şifre";
            // 
            // txtYeniPass
            // 
            this.txtYeniPass.Location = new System.Drawing.Point(80, 57);
            this.txtYeniPass.Name = "txtYeniPass";
            this.txtYeniPass.Size = new System.Drawing.Size(100, 20);
            this.txtYeniPass.TabIndex = 15;
            this.txtYeniPass.UseSystemPasswordChar = true;
            this.txtYeniPass.TextChanged += new System.EventHandler(this.txtYeniPass_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kullanıcı Adı";
            // 
            // linkYeniHesap
            // 
            this.linkYeniHesap.AutoSize = true;
            this.linkYeniHesap.Location = new System.Drawing.Point(6, 70);
            this.linkYeniHesap.Name = "linkYeniHesap";
            this.linkYeniHesap.Size = new System.Drawing.Size(98, 13);
            this.linkYeniHesap.TabIndex = 13;
            this.linkYeniHesap.TabStop = true;
            this.linkYeniHesap.Text = "Yeni Hesap Oluştur";
            this.linkYeniHesap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkYeniHesap_LinkClicked);
            // 
            // btnAnaEkran
            // 
            this.btnAnaEkran.Location = new System.Drawing.Point(433, 492);
            this.btnAnaEkran.Name = "btnAnaEkran";
            this.btnAnaEkran.Size = new System.Drawing.Size(131, 26);
            this.btnAnaEkran.TabIndex = 14;
            this.btnAnaEkran.Text = "Ana Ekran";
            this.btnAnaEkran.UseVisualStyleBackColor = true;
            this.btnAnaEkran.Click += new System.EventHandler(this.btnAnaEkran_Click);
            // 
            // linkParolaSifirla
            // 
            this.linkParolaSifirla.AutoSize = true;
            this.linkParolaSifirla.Location = new System.Drawing.Point(6, 150);
            this.linkParolaSifirla.Name = "linkParolaSifirla";
            this.linkParolaSifirla.Size = new System.Drawing.Size(109, 13);
            this.linkParolaSifirla.TabIndex = 1;
            this.linkParolaSifirla.TabStop = true;
            this.linkParolaSifirla.Text = "Personel Parola Sıfırla";
            this.linkParolaSifirla.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkParolaSifirla_LinkClicked);
            // 
            // groupBoxPerSil
            // 
            this.groupBoxPerSil.Controls.Add(this.txtPerSilUnvan);
            this.groupBoxPerSil.Controls.Add(this.label10);
            this.groupBoxPerSil.Controls.Add(this.label8);
            this.groupBoxPerSil.Controls.Add(this.pictureBoxCarpi3);
            this.groupBoxPerSil.Controls.Add(this.btnPerSil);
            this.groupBoxPerSil.Controls.Add(this.txtPerSilid);
            this.groupBoxPerSil.Controls.Add(this.label9);
            this.groupBoxPerSil.Location = new System.Drawing.Point(164, 224);
            this.groupBoxPerSil.Name = "groupBoxPerSil";
            this.groupBoxPerSil.Size = new System.Drawing.Size(200, 159);
            this.groupBoxPerSil.TabIndex = 15;
            this.groupBoxPerSil.TabStop = false;
            this.groupBoxPerSil.Text = "Personel Sil";
            this.groupBoxPerSil.Visible = false;
            // 
            // txtPerSilUnvan
            // 
            this.txtPerSilUnvan.Enabled = false;
            this.txtPerSilUnvan.Location = new System.Drawing.Point(61, 45);
            this.txtPerSilUnvan.Name = "txtPerSilUnvan";
            this.txtPerSilUnvan.Size = new System.Drawing.Size(100, 20);
            this.txtPerSilUnvan.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Unvan";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(58, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 38);
            this.label8.TabIndex = 17;
            this.label8.Text = "Silmek istediğin kullanıcıya tablodan tıkla";
            // 
            // pictureBoxCarpi3
            // 
            this.pictureBoxCarpi3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarpi3.Image")));
            this.pictureBoxCarpi3.Location = new System.Drawing.Point(179, 9);
            this.pictureBoxCarpi3.Name = "pictureBoxCarpi3";
            this.pictureBoxCarpi3.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxCarpi3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCarpi3.TabIndex = 16;
            this.pictureBoxCarpi3.TabStop = false;
            this.pictureBoxCarpi3.Click += new System.EventHandler(this.pictureBoxCarpi3_Click);
            // 
            // btnPerSil
            // 
            this.btnPerSil.Location = new System.Drawing.Point(61, 113);
            this.btnPerSil.Name = "btnPerSil";
            this.btnPerSil.Size = new System.Drawing.Size(100, 36);
            this.btnPerSil.TabIndex = 14;
            this.btnPerSil.Text = "SİL";
            this.btnPerSil.UseVisualStyleBackColor = true;
            this.btnPerSil.Click += new System.EventHandler(this.btnPerSil_Click);
            // 
            // txtPerSilid
            // 
            this.txtPerSilid.Enabled = false;
            this.txtPerSilid.Location = new System.Drawing.Point(61, 19);
            this.txtPerSilid.Name = "txtPerSilid";
            this.txtPerSilid.Size = new System.Drawing.Size(100, 20);
            this.txtPerSilid.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "ID";
            // 
            // linkPerSil
            // 
            this.linkPerSil.AutoSize = true;
            this.linkPerSil.Location = new System.Drawing.Point(6, 110);
            this.linkPerSil.Name = "linkPerSil";
            this.linkPerSil.Size = new System.Drawing.Size(60, 13);
            this.linkPerSil.TabIndex = 16;
            this.linkPerSil.TabStop = true;
            this.linkPerSil.Text = "Kullanıcı Sil";
            this.linkPerSil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPerSil_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLoad);
            this.groupBox1.Controls.Add(this.linkSekreterEkle);
            this.groupBox1.Controls.Add(this.linkSifreDegis);
            this.groupBox1.Controls.Add(this.linkPerSil);
            this.groupBox1.Controls.Add(this.linkYeniHesap);
            this.groupBox1.Controls.Add(this.linkParolaSifirla);
            this.groupBox1.Location = new System.Drawing.Point(15, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 304);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Erişim Paneli";
            // 
            // linkLoad
            // 
            this.linkLoad.AutoSize = true;
            this.linkLoad.Location = new System.Drawing.Point(6, 230);
            this.linkLoad.Name = "linkLoad";
            this.linkLoad.Size = new System.Drawing.Size(73, 13);
            this.linkLoad.TabIndex = 19;
            this.linkLoad.TabStop = true;
            this.linkLoad.Text = "Sayfayı Yenile";
            this.linkLoad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLoad_LinkClicked);
            // 
            // linkSekreterEkle
            // 
            this.linkSekreterEkle.AutoSize = true;
            this.linkSekreterEkle.Location = new System.Drawing.Point(6, 190);
            this.linkSekreterEkle.Name = "linkSekreterEkle";
            this.linkSekreterEkle.Size = new System.Drawing.Size(71, 13);
            this.linkSekreterEkle.TabIndex = 17;
            this.linkSekreterEkle.TabStop = true;
            this.linkSekreterEkle.Text = "Sekreter Ekle";
            this.linkSekreterEkle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSekreterEkle_LinkClicked);
            // 
            // FrmAdminDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(605, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxPerSil);
            this.Controls.Add(this.groupBoxYeniHesap);
            this.Controls.Add(this.btnAnaEkran);
            this.Controls.Add(this.groupBoxSifreDegis);
            this.Controls.Add(this.groupBox);
            this.Name = "FrmAdminDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMİN PANELİ";
            this.Load += new System.EventHandler(this.FrmAdminDetay_Load);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPer)).EndInit();
            this.groupBoxSifreDegis.ResumeLayout(false);
            this.groupBoxSifreDegis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarpi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTik)).EndInit();
            this.groupBoxYeniHesap.ResumeLayout(false);
            this.groupBoxYeniHesap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarpi2)).EndInit();
            this.groupBoxPerSil.ResumeLayout(false);
            this.groupBoxPerSil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarpi3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridPer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassYeni;
        private System.Windows.Forms.GroupBox groupBoxSifreDegis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.PictureBox pictureBoxTik;
        private System.Windows.Forms.LinkLabel linkSifreDegis;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBoxYeniHesap;
        private System.Windows.Forms.LinkLabel linkYeniHesap;
        private System.Windows.Forms.Button btnYeniKaydet;
        private System.Windows.Forms.TextBox txtYeniNick;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYeniPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxSifre;
        private System.Windows.Forms.Button btnAnaEkran;
        private System.Windows.Forms.LinkLabel linkParolaSifirla;
        private System.Windows.Forms.PictureBox pictureBoxCarpi;
        private System.Windows.Forms.PictureBox pictureBoxCarpi2;
        private System.Windows.Forms.GroupBox groupBoxPerSil;
        private System.Windows.Forms.PictureBox pictureBoxCarpi3;
        private System.Windows.Forms.Button btnPerSil;
        private System.Windows.Forms.TextBox txtPerSilid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkPerSil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPerSilUnvan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkSekreterEkle;
        private System.Windows.Forms.LinkLabel linkLoad;
    }
}