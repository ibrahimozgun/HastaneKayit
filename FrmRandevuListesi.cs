using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneKayit
{
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        public void Temizle()
        {
            txtidguncelle.Clear();
            cmbsaat.Text = null;
            cmbbrans.Text = null;
            cmbdoktor.Text = null;
            dateTimePicker1.ResetText();
            richtxtsikayet.Clear();
            txthastaid.Clear();
            lblizinbas.Text = null;
            lblizinbit.Text = null;
            txtid.Text = null;
        }
        public void SaatYenile() //aynısı FrmHastaDetay da var
        {
            cmbsaat.Items.Clear();
            for(int i=8; i < 10; i++)
            {
                cmbsaat.Items.Add("0"+i + ":00");
                cmbsaat.Items.Add("0"+i + ":30");
            }
            for (int j = 10; j < 18; j++)
            {
                cmbsaat.Items.Add(j + ":00");
                cmbsaat.Items.Add(j + ":30");
            }
        }
        public void Randevu_Guncelle()
        {
            SqlCommand komut = new SqlCommand("Update Randevu set Randevutarih=@p1, Randevusaat=@p2, " +
                                                          "Randevudoktorid=@p3, Randevuhastaid=@p4, Hastasikayet=@p5 where " +
                                                          "Randevuid=" + txtidguncelle.Text, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@p2", cmbsaat.Text);
            komut.Parameters.AddWithValue("@p3", lbldoktor.Text);
            komut.Parameters.AddWithValue("@p4", txthastaid.Text);
            komut.Parameters.AddWithValue("@p5", richtxtsikayet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("guncellendi", "İnfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
        }
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            richtxtsikayet.MaxLength = 150;
            cmbbrans.Items.Clear();
            lbltarih.Text = DateTime.Now.ToString("dd.MM.yyyy"); // sadece tarih
            //branşları çekme combobox a
            SqlCommand komut3 = new SqlCommand("select Bransisim from Brans", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader(); //veri okuyucuyu çalıştırıyor
            while (dr3.Read())
            {
                cmbbrans.Items.Add(dr3[0]); //dr[0] id leri tutuyor ama bransad olunca adlar 0
            }
            bgl.baglanti().Close();
            //datagridview e Aktif randevulari listeleme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Randevuid as 'ID', Randevutarih as 'Tarih', Randevusaat as 'Saat', Bransisim as 'Branş', " +
                "Doktorad +' '+ Doktorsoyad as 'Doktor',Hastaid as 'H.ID', Hastaisim as 'Hasta', Hastatc as 'Hasta TC', Hastatelefon, Hastasikayet as 'Şikayet' From Randevu " +
                "inner join Doktor on Randevu.Randevudoktorid=Doktor.Doktorid " +
                "inner join Brans on Doktor.Doktorbransid=Brans.Bransid " +
                "inner join Hasta on Randevu.Randevuhastaid=Hasta.Hastaid where Randevu.Randevutarih >= getdate()-1 ORDER BY Randevutarih", bgl.baglanti());
            da.Fill(dt);
            dataGridAktif.DataSource = dt;
            bgl.baglanti().Close();
            // Hastaları Listeleme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select Hastaid as 'HastaID', Hastaisim as 'Hasta Isim', Hastatc as 'Hasta TCKN', Hastacinsiyet as 'Hasta Cinsiyet' From Hasta", bgl.baglanti());
            da2.Fill(dt2);
            dataGridHastalar.DataSource = dt2;
            bgl.baglanti().Close();
            dataGridHastalar.Columns[0].Width = 50;
            // Gecmis randevulari listeleme
            DataTable dtt = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter("Select Randevuid as 'ID', Randevutarih as 'Tarih', Randevusaat as 'Saat', Bransisim as 'Branş', " +
                "Doktorad +' '+ Doktorsoyad as 'Doktor',Hastaid as 'Hasta ID', Hastaisim as 'Hasta', Hastatc as 'Hasta TC', Hastatelefon, Hastasikayet as 'Şikayet' From Randevu " +
                "inner join Doktor on Randevu.Randevudoktorid=Doktor.Doktorid " +
                "inner join Brans on Doktor.Doktorbransid=Brans.Bransid " +
                "inner join Hasta on Randevu.Randevuhastaid=Hasta.Hastaid where Randevu.Randevutarih < getdate()-1 ORDER BY Randevutarih DESC", bgl.baglanti());
            daa.Fill(dtt);
            dataGridGecmis.DataSource = dtt;
            bgl.baglanti().Close();
            dataGridGecmis.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnguncelle.Enabled = true;
            int secilen = dataGridAktif.SelectedCells[0].RowIndex;
            txtidguncelle.Text = dataGridAktif.Rows[secilen].Cells[0].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridAktif.Rows[secilen].Cells[1].Value);
            cmbsaat.Text = dataGridAktif.Rows[secilen].Cells[2].Value.ToString();
            cmbbrans.Text = dataGridAktif.Rows[secilen].Cells[3].Value.ToString();
            cmbdoktor.Text = dataGridAktif.Rows[secilen].Cells[4].Value.ToString();
            txthastaid.Text = dataGridAktif.Rows[secilen].Cells[5].Value.ToString();
            richtxtsikayet.Text = dataGridAktif.Rows[secilen].Cells[9].Value.ToString();
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnguncelle.Enabled = false;
            int secilen = dataGridGecmis.SelectedCells[0].RowIndex;
            txtidguncelle.Text = dataGridGecmis.Rows[secilen].Cells[0].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridGecmis.Rows[secilen].Cells[1].Value);
            cmbsaat.Text = dataGridGecmis.Rows[secilen].Cells[2].Value.ToString();
            cmbbrans.Text = dataGridGecmis.Rows[secilen].Cells[3].Value.ToString();
            cmbdoktor.Text = dataGridGecmis.Rows[secilen].Cells[4].Value.ToString();
            txthastaid.Text = dataGridGecmis.Rows[secilen].Cells[5].Value.ToString();
            richtxtsikayet.Text = dataGridGecmis.Rows[secilen].Cells[9].Value.ToString();
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz randevuyu girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtid.Focus();
            }
            else
            {
                SqlCommand komutx = new SqlCommand("SELECT Count(*) FROM Randevu where Randevuid='" + txtid.Text + "'", bgl.baglanti());
                int sonuc = (int)komutx.ExecuteScalar(); //tc yoksa 0 varsa 1
                if (sonuc > 0)
                {
                    //randevu silincek ama messageBox da eveti seçmeli
                    if (MessageBox.Show("Randevuyu silmek istediğinize emin misiniz?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SqlCommand komutsil = new SqlCommand("delete From Randevu where Randevuid=@id", bgl.baglanti());
                        komutsil.Parameters.AddWithValue("@id", txtid.Text);
                        komutsil.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show(txtid.Text + " ID'li randevu silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtid.Clear();
                        FrmRandevuListesi_Load(sender, e);
                    }
                    else //messageBox da evet'e basmazsa silinmiyor
                    {
                        txtid.Clear();
                    }
                }
                else //sonuc=0 ve randevu bulunmadı
                {
                    MessageBox.Show("Girmiş olduğunuz ID de randevu bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtid.Clear();
                }
                bgl.baglanti().Close();
            }
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            DateTime dun = dateTime.AddDays(-1);

            if (txtidguncelle.Text == "" || cmbbrans.Text == "" || cmbdoktor.Text == "" || cmbsaat.Text == "" || txthastaid.Text == "")
            {
                MessageBox.Show("Eksik alan var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dateTimePicker1.Value < dun)
            {
                MessageBox.Show("İleri bir tarih seç", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string hastaid = txthastaid.Text;
                int hata2 = 0;

                foreach (DataGridViewRow row in dataGridHastalar.Rows)
                {
                    if (hastaid == Convert.ToString(row.Cells[0].Value))
                    {
                        hata2 = 0;
                        break;
                    }
                    else
                    {
                        hata2 = 1;
                    }
                }
                if (hata2 == 0)
                {
                    if (lblizinbas.Text != "")
                    {
                        if (Convert.ToDateTime(lblizinbas.Text) <= dateTimePicker1.Value && dateTimePicker1.Value < Convert.ToDateTime(lblizinbit.Text)) //izin  basşangıc tarihinde izinli oluyor ama bitiş tarihinde izin bitiyor
                        {
                            MessageBox.Show("Doktor izinli\n" + lblizinbas.Text + " - " + lblizinbit.Text + " Tarihleri arası randevu almayın", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //if içine evet hayır sorma
                            if (MessageBox.Show("Randevuyu güncellemek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                Randevu_Guncelle();
                                FrmRandevuListesi_Load(sender, e);

                            }
                            else //messageBox da evet'e basmazsa if’e girmiyor
                            {
                                txtid.Clear();
                            }

                        }
                    }
                    else
                    {
                        //if içine evet hayır sorma
                        if (MessageBox.Show("Randevuyu güncellemek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Randevu_Guncelle();
                            FrmRandevuListesi_Load(sender, e);
                        }
                        else //messageBox da evet'e basmazsa if’e girmiyor
                        {
                            txtid.Clear();
                        }
                    }
                }
                else if (hata2 == 1)
                {
                    MessageBox.Show("Bu ID li hasta yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txthastaid.Clear();
                    txthastaid.Focus();
                }
            }
        }
        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DropDownStyle = DropDownList özelliklerden bunu yaparak klavyeden veri girişini engelledik
            cmbdoktor.Items.Clear();
            lbldoktor.Text = null;
            //brasş seçinde labela id si yazma
            SqlCommand komut3 = new SqlCommand("Select Bransid from Brans where Bransisim=@id", bgl.baglanti());
            komut3.Parameters.AddWithValue("@id", cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            lblbrans.Text = null;
            while (dr3.Read())
            {
                lblbrans.Text = dr3[0].ToString();
            }
            bgl.baglanti().Close();
            ////////bir bransa tıklanınca doktorlar combobox a yüklenir
            SqlCommand komut = new SqlCommand("Select Doktorad, Doktorsoyad, Doktorid From Doktor d, Brans b where b.Bransid='" + lblbrans.Text + "' and d.Doktorbransid=b.Bransid", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbdoktor.Items.Add(Convert.ToString(dr[0] + " " + dr[1]));
            }
            bgl.baglanti().Close();
            cmbsaat.Enabled = true;
        }
        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e) //comboBox da tıklanılan doktorun doktorid'sini labela atıyor
        {
            SqlCommand komut = new SqlCommand("Select Doktorid from Doktor where Doktorad+' '+Doktorsoyad=@dr", bgl.baglanti());
            komut.Parameters.AddWithValue("@dr", cmbdoktor.Text);
            SqlDataReader dr = komut.ExecuteReader();
            lbldoktor.Text = null;
            while (dr.Read())
            {
                lbldoktor.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
            //seçilen doktorun izin baslangıc ve bitiş tarihini label a yazdırma
            SqlCommand komutt = new SqlCommand("Select Doktorizinbas, Doktorizinson From Doktor where Doktorid=" + lbldoktor.Text, bgl.baglanti());
            SqlDataReader drr = komutt.ExecuteReader();
            while (drr.Read())
            {
                lblizinbas.Text = drr[0].ToString();
                lblizinbit.Text = drr[1].ToString();
            }
            bgl.baglanti().Close();
            //label'lara tarih yazılırsa bu tarihleri kısa tarihe çevir
            if (lblizinbas.Text != "")
            {
                DateTime timeizin = Convert.ToDateTime(lblizinbas.Text);
                DateTime timeson = Convert.ToDateTime(lblizinbit.Text);
                lblizinbas.Text = timeizin.ToShortDateString();
                lblizinbit.Text = timeson.ToShortDateString();
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridHastalar.SelectedCells[0].RowIndex;
            txthastaid.Text = dataGridHastalar.Rows[secilen].Cells[0].Value.ToString();
        }
        private void btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            btnguncelle.Enabled = true;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cmbsaat.Text = null;
        }
        private void cmbsaat_MouseClick(object sender, MouseEventArgs e)
        {
            // burada saate tıklanrak doktorun seçili tarihteki randevularının saaatleri comboBox tan kaldırılıyor // sql e or ekleyerek hastanın randevuları da gitti
            //doktor veya branş seçili değilken patladıgı için if ekledim
            if (cmbbrans.Text == "" || cmbdoktor.Text == "")
            {
                MessageBox.Show("Henüz branş veya doktor seçmedin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbsaat.Text = null;
            }
            else if (txthastaid.Text == "")
            {
                MessageBox.Show("Saati Hasta ID'yi girdikten sonra seçin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbsaat.Text = null;
            }
            else
            {
                SaatYenile();
                SqlCommand komutx = new SqlCommand("select Randevusaat from Randevu where Randevutarih=@tarih and (Randevudoktorid=@doktor or Randevuhastaid=@hasta)", bgl.baglanti());
                komutx.Parameters.AddWithValue("@doktor", lbldoktor.Text);
                komutx.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.Date);
                komutx.Parameters.AddWithValue("@hasta", txthastaid.Text);
                SqlDataReader drx = komutx.ExecuteReader();
                while (drx.Read())
                {
                    cmbsaat.Items.Remove(Convert.ToString(drx["Randevusaat"]));
                }
                bgl.baglanti().Close();
            }
        }
    }
}