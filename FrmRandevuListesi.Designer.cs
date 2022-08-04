
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRandevuListesi));
            this.dataGridAktif = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txthastaid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.cmbdoktor = new System.Windows.Forms.ComboBox();
            this.txtidguncelle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richtxtsikayet = new System.Windows.Forms.RichTextBox();
            this.lbltarih = new System.Windows.Forms.Label();
            this.cmbsaat = new System.Windows.Forms.ComboBox();
            this.lbldoktor = new System.Windows.Forms.Label();
            this.dataGridHastalar = new System.Windows.Forms.DataGridView();
            this.lblbrans = new System.Windows.Forms.Label();
            this.dataGridGecmis = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btntemizle = new System.Windows.Forms.Button();
            this.lblizinbas = new System.Windows.Forms.Label();
            this.lblizinbit = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAktif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHastalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGecmis)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAktif
            // 
            this.dataGridAktif.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridAktif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAktif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAktif.Location = new System.Drawing.Point(3, 16);
            this.dataGridAktif.Name = "dataGridAktif";
            this.dataGridAktif.ReadOnly = true;
            this.dataGridAktif.Size = new System.Drawing.Size(672, 234);
            this.dataGridAktif.TabIndex = 0;
            this.dataGridAktif.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(769, 538);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(87, 20);
            this.txtid.TabIndex = 1;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(756, 564);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(109, 20);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(725, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Silinmesi istenilen Randevunun ID\'si";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(696, 321);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(226, 31);
            this.btnguncelle.TabIndex = 5;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(712, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(714, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(709, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Branş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(704, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Doktor:";
            // 
            // txthastaid
            // 
            this.txthastaid.Location = new System.Drawing.Point(752, 179);
            this.txthastaid.MaxLength = 9999;
            this.txthastaid.Name = "txthastaid";
            this.txthastaid.Size = new System.Drawing.Size(170, 20);
            this.txthastaid.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(691, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hasta ID:";
            // 
            // cmbbrans
            // 
            this.cmbbrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(752, 100);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(170, 21);
            this.cmbbrans.TabIndex = 16;
            this.cmbbrans.SelectedIndexChanged += new System.EventHandler(this.cmbbrans_SelectedIndexChanged);
            // 
            // cmbdoktor
            // 
            this.cmbdoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdoktor.FormattingEnabled = true;
            this.cmbdoktor.Location = new System.Drawing.Point(752, 126);
            this.cmbdoktor.Name = "cmbdoktor";
            this.cmbdoktor.Size = new System.Drawing.Size(170, 21);
            this.cmbdoktor.TabIndex = 17;
            this.cmbdoktor.SelectedIndexChanged += new System.EventHandler(this.cmbdoktor_SelectedIndexChanged);
            // 
            // txtidguncelle
            // 
            this.txtidguncelle.Enabled = false;
            this.txtidguncelle.Location = new System.Drawing.Point(752, 48);
            this.txtidguncelle.Name = "txtidguncelle";
            this.txtidguncelle.Size = new System.Drawing.Size(170, 20);
            this.txtidguncelle.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(725, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID:";
            // 
            // richtxtsikayet
            // 
            this.richtxtsikayet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtxtsikayet.Location = new System.Drawing.Point(3, 16);
            this.richtxtsikayet.Name = "richtxtsikayet";
            this.richtxtsikayet.Size = new System.Drawing.Size(220, 81);
            this.richtxtsikayet.TabIndex = 21;
            this.richtxtsikayet.Text = "";
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Location = new System.Drawing.Point(852, 22);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(35, 13);
            this.lbltarih.TabIndex = 26;
            this.lbltarih.Text = "label9";
            // 
            // cmbsaat
            // 
            this.cmbsaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbsaat.Location = new System.Drawing.Point(752, 153);
            this.cmbsaat.Name = "cmbsaat";
            this.cmbsaat.Size = new System.Drawing.Size(170, 21);
            this.cmbsaat.TabIndex = 34;
            this.cmbsaat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbsaat_MouseClick);
            // 
            // lbldoktor
            // 
            this.lbldoktor.AutoSize = true;
            this.lbldoktor.Location = new System.Drawing.Point(793, 452);
            this.lbldoktor.Name = "lbldoktor";
            this.lbldoktor.Size = new System.Drawing.Size(16, 13);
            this.lbldoktor.TabIndex = 35;
            this.lbldoktor.Text = "dr";
            this.lbldoktor.Visible = false;
            // 
            // dataGridHastalar
            // 
            this.dataGridHastalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHastalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridHastalar.Location = new System.Drawing.Point(3, 16);
            this.dataGridHastalar.Name = "dataGridHastalar";
            this.dataGridHastalar.ReadOnly = true;
            this.dataGridHastalar.Size = new System.Drawing.Size(666, 127);
            this.dataGridHastalar.TabIndex = 37;
            this.dataGridHastalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // lblbrans
            // 
            this.lblbrans.AutoSize = true;
            this.lblbrans.Location = new System.Drawing.Point(760, 452);
            this.lblbrans.Name = "lblbrans";
            this.lblbrans.Size = new System.Drawing.Size(27, 13);
            this.lblbrans.TabIndex = 33;
            this.lblbrans.Text = "brns";
            this.lblbrans.Visible = false;
            // 
            // dataGridGecmis
            // 
            this.dataGridGecmis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridGecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGecmis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridGecmis.Location = new System.Drawing.Point(3, 16);
            this.dataGridGecmis.Name = "dataGridGecmis";
            this.dataGridGecmis.ReadOnly = true;
            this.dataGridGecmis.Size = new System.Drawing.Size(672, 218);
            this.dataGridGecmis.TabIndex = 38;
            this.dataGridGecmis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.dataGridGecmis);
            this.groupBox1.Location = new System.Drawing.Point(12, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 237);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geçmiş Randevular";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.dataGridAktif);
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 253);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aktif Randevular";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox3.Controls.Add(this.richtxtsikayet);
            this.groupBox3.Location = new System.Drawing.Point(696, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 100);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hasta Şikayet";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(752, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker1.TabIndex = 42;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(804, 368);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(118, 23);
            this.btntemizle.TabIndex = 43;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // lblizinbas
            // 
            this.lblizinbas.AutoSize = true;
            this.lblizinbas.Location = new System.Drawing.Point(815, 452);
            this.lblizinbas.Name = "lblizinbas";
            this.lblizinbas.Size = new System.Drawing.Size(35, 13);
            this.lblizinbas.TabIndex = 44;
            this.lblizinbas.Text = "label8";
            this.lblizinbas.Visible = false;
            // 
            // lblizinbit
            // 
            this.lblizinbit.AutoSize = true;
            this.lblizinbit.Location = new System.Drawing.Point(815, 475);
            this.lblizinbit.Name = "lblizinbit";
            this.lblizinbit.Size = new System.Drawing.Size(35, 13);
            this.lblizinbit.TabIndex = 45;
            this.lblizinbit.Text = "label9";
            this.lblizinbit.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.dataGridHastalar);
            this.groupBox4.Location = new System.Drawing.Point(15, 508);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(672, 146);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hastalar";
            // 
            // FrmRandevuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(939, 666);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblizinbit);
            this.Controls.Add(this.lblizinbas);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbldoktor);
            this.Controls.Add(this.cmbsaat);
            this.Controls.Add(this.lblbrans);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.txtidguncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbdoktor);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.txthastaid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.txtid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRandevuListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Listesi";
            this.Load += new System.EventHandler(this.FrmRandevuListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAktif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHastalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGecmis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txthastaid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.ComboBox cmbdoktor;
        private System.Windows.Forms.TextBox txtidguncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richtxtsikayet;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.ComboBox cmbsaat;
        private System.Windows.Forms.Label lbldoktor;
        private System.Windows.Forms.DataGridView dataGridHastalar;
        private System.Windows.Forms.Label lblbrans;
        private System.Windows.Forms.DataGridView dataGridAktif;
        private System.Windows.Forms.DataGridView dataGridGecmis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Label lblizinbas;
        private System.Windows.Forms.Label lblizinbit;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}