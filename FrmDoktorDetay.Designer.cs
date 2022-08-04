
namespace HastaneKayit
{
    partial class FrmDoktorDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnbilgiduzenle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnanaekran = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnduyurular = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.richtxt = new System.Windows.Forms.RichTextBox();
            this.btnrandevukaydet = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbtarihler = new System.Windows.Forms.ComboBox();
            this.btnfiltretemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbladsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbltc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgiler";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(66, 42);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(46, 13);
            this.lbladsoyad.TabIndex = 7;
            this.lbladsoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad Soyad:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(65, 26);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(73, 13);
            this.lbltc.TabIndex = 5;
            this.lbltc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(200, 93);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Bir randevuya tıkla";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(230, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 270);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnbilgiduzenle
            // 
            this.btnbilgiduzenle.Location = new System.Drawing.Point(6, 19);
            this.btnbilgiduzenle.Name = "btnbilgiduzenle";
            this.btnbilgiduzenle.Size = new System.Drawing.Size(95, 33);
            this.btnbilgiduzenle.TabIndex = 1;
            this.btnbilgiduzenle.Text = "Bilgi Düzenle";
            this.btnbilgiduzenle.UseVisualStyleBackColor = true;
            this.btnbilgiduzenle.Click += new System.EventHandler(this.btnbilgiduzenle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnanaekran);
            this.groupBox4.Controls.Add(this.btncikis);
            this.groupBox4.Controls.Add(this.btnduyurular);
            this.groupBox4.Controls.Add(this.btnbilgiduzenle);
            this.groupBox4.Location = new System.Drawing.Point(12, 216);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Help";
            // 
            // btnanaekran
            // 
            this.btnanaekran.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnanaekran.Location = new System.Drawing.Point(7, 58);
            this.btnanaekran.Name = "btnanaekran";
            this.btnanaekran.Size = new System.Drawing.Size(94, 33);
            this.btnanaekran.TabIndex = 4;
            this.btnanaekran.Text = "ANA EKRAN";
            this.btnanaekran.UseVisualStyleBackColor = false;
            this.btnanaekran.Click += new System.EventHandler(this.btnanaekran_Click);
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(111, 58);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(95, 33);
            this.btncikis.TabIndex = 3;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnduyurular
            // 
            this.btnduyurular.Location = new System.Drawing.Point(111, 19);
            this.btnduyurular.Name = "btnduyurular";
            this.btnduyurular.Size = new System.Drawing.Size(95, 33);
            this.btnduyurular.TabIndex = 2;
            this.btnduyurular.Text = "Duyurular";
            this.btnduyurular.UseVisualStyleBackColor = true;
            this.btnduyurular.Click += new System.EventHandler(this.btnduyurular_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(80, 22);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(83, 20);
            this.txtid.TabIndex = 5;
            // 
            // richtxt
            // 
            this.richtxt.Location = new System.Drawing.Point(6, 56);
            this.richtxt.Name = "richtxt";
            this.richtxt.Size = new System.Drawing.Size(203, 106);
            this.richtxt.TabIndex = 6;
            this.richtxt.Text = "";
            // 
            // btnrandevukaydet
            // 
            this.btnrandevukaydet.Location = new System.Drawing.Point(6, 168);
            this.btnrandevukaydet.Name = "btnrandevukaydet";
            this.btnrandevukaydet.Size = new System.Drawing.Size(83, 38);
            this.btnrandevukaydet.TabIndex = 7;
            this.btnrandevukaydet.Text = "Kaydet";
            this.btnrandevukaydet.UseVisualStyleBackColor = true;
            this.btnrandevukaydet.Click += new System.EventHandler(this.btnrandevukaydet_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtid);
            this.groupBox5.Controls.Add(this.richtxt);
            this.groupBox5.Controls.Add(this.btnrandevukaydet);
            this.groupBox5.Location = new System.Drawing.Point(779, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 217);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Muayene sonrası durum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Randevu ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Randevu Tarihi: ";
            // 
            // cmbtarihler
            // 
            this.cmbtarihler.FormattingEnabled = true;
            this.cmbtarihler.Location = new System.Drawing.Point(514, 19);
            this.cmbtarihler.Name = "cmbtarihler";
            this.cmbtarihler.Size = new System.Drawing.Size(175, 21);
            this.cmbtarihler.TabIndex = 11;
            this.cmbtarihler.SelectedIndexChanged += new System.EventHandler(this.cmbtarihler_SelectedIndexChanged);
            // 
            // btnfiltretemizle
            // 
            this.btnfiltretemizle.Location = new System.Drawing.Point(695, 17);
            this.btnfiltretemizle.Name = "btnfiltretemizle";
            this.btnfiltretemizle.Size = new System.Drawing.Size(75, 23);
            this.btnfiltretemizle.TabIndex = 12;
            this.btnfiltretemizle.Text = "Filtre temizle";
            this.btnfiltretemizle.UseVisualStyleBackColor = true;
            this.btnfiltretemizle.Click += new System.EventHandler(this.btnfiltretemizle_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 329);
            this.Controls.Add(this.btnfiltretemizle);
            this.Controls.Add(this.cmbtarihler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDoktorDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnbilgiduzenle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnduyurular;
        private System.Windows.Forms.Button btnanaekran;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.RichTextBox richtxt;
        private System.Windows.Forms.Button btnrandevukaydet;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbtarihler;
        private System.Windows.Forms.Button btnfiltretemizle;
    }
}