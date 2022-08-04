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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantısı bgl = new sqlbaglantısı();

        public void Randevu_Ekle()
        {
            SqlCommand komutr = new SqlCommand("insert into Randevu (Randevutarih, Randevusaat, Randevudoktorid, Randevuhastaid, Hastasikayet) " +
                "values (@ta, @sa, @dr, @hs, @sky)", bgl.baglanti());
            komutr.Parameters.AddWithValue("@ta", dateTimePicker1.Value);
            komutr.Parameters.AddWithValue("@sa", cmbsaat.Text);
            komutr.Parameters.AddWithValue("@dr", lbldoktor.Text);
            komutr.Parameters.AddWithValue("@hs", lblid.Text);
            komutr.Parameters.AddWithValue("@sky", richtxtsikayet.Text);
            komutr.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString() + " tarihinde\nSaat " + cmbsaat.Text + "'a Randevu alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Temizle()
        {
            txtid.Clear();
            cmbbrans.Text = null;
            cmbdoktor.Text = null;
            richtxtsikayet.Clear();
            dateTimePicker1.ResetText();
            cmbsaat.Text = null;
            cmbbrans.Focus();
            SaatYenile();
        }
        public void SaatYenile()
        {
            //eksik olan saatlerin temizlenip geri gelmesi
            cmbsaat.Items.Clear();
            cmbsaat.Items.Add("08:30");
            cmbsaat.Items.Add("09:00");
            cmbsaat.Items.Add("09:30");
            cmbsaat.Items.Add("10:00");
            cmbsaat.Items.Add("10:30");
            cmbsaat.Items.Add("11:00");
            cmbsaat.Items.Add("11:30");
            cmbsaat.Items.Add("12:00");
            cmbsaat.Items.Add("13:30");
            cmbsaat.Items.Add("14:00");
            cmbsaat.Items.Add("14:30");
            cmbsaat.Items.Add("15:00");
            cmbsaat.Items.Add("15:30");
            cmbsaat.Items.Add("16:00");
            cmbsaat.Items.Add("16:30");
        }
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            richtxtsikayet.MaxLength = 150;
            cmbbrans.Items.Clear();
            lbltarih.Text = DateTime.Now.ToShortDateString(); // sadece tarih
            lbltc.Text = tc;
            //komut1 ad soyad çekme
            SqlCommand komut1 = new SqlCommand("select Hastaid, Hastaisim From Hasta where Hastatc=" + lbltc.Text, bgl.baglanti());
            //komut1.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut1.ExecuteReader(); //veri okuyucuyu çalıştırıyor          
            while (dr.Read())
            {
                lbladsoyad.Text = Convert.ToString(dr[1]);
                lblid.Text = Convert.ToString(dr[0]);
            }
            bgl.baglanti().Close();

            //branşları çekme
            SqlCommand komut2 = new SqlCommand("select Bransisim from Brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader(); //veri okuyucuyu çalıştırıyor
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            //hastanın randevu geçmişi
            DataTable dt = new DataTable(); //veri tablosu oluşturuluyor
            //dataadapter; data gride veri aktarmak için kullanılan command
            SqlDataAdapter da = new SqlDataAdapter("select Randevuid as 'ID', Randevutarih as 'Tarih', Randevusaat as 'Saat', Bransisim as 'Brans', " +
                "Doktorad+' '+Doktorsoyad as 'Doktor', Hastasikayet as 'Sikayet', Randevuozet as 'Bilgi' from Randevu " +
                "inner join Doktor on Randevu.Randevudoktorid=Doktor.Doktorid " +
                "inner join Brans on Doktor.Doktorbransid=Brans.Bransid " +
                "where Randevuhastaid='" + lblid.Text + "'and Randevutarih < getdate()-1 ORDER BY Randevutarih DESC, Randevusaat", bgl.baglanti());
            da.Fill(dt); //tablodan gelecek değerle DataAdapter in içini doldurur
            dataGridGecmis.DataSource = dt;
            dataGridGecmis.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

            //hastanın yeni (güncel) randevuları
            DataTable dtt = new DataTable(); //veri tablosu oluşturuluyor
            //dataadapter; data gride veri aktarmak için kullanılan command
            SqlDataAdapter daa = new SqlDataAdapter("select Randevuid as 'ID', Randevutarih as 'Tarih', Randevusaat as 'Saat', Bransisim as 'Brans', " +
                "Doktorad+' '+Doktorsoyad as 'Doktor', Hastasikayet as 'Sikayet' from Randevu " +
                "inner join Doktor on Randevu.Randevudoktorid=Doktor.Doktorid " +
                "inner join Brans on Doktor.Doktorbransid=Brans.Bransid  " +
                "where Randevuhastaid='" + lblid.Text + "'and Randevutarih >= getdate()-1 ORDER BY Randevutarih, Randevusaat", bgl.baglanti());
            daa.Fill(dtt); //tablodan gelecek değerle DataAdapter in içini doldurur
            dataGridAktif.DataSource = dtt;
            dataGridAktif.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
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
        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbsaat.Text = null;
            lbl1.Text = null;
            lbl2.Text = null;
            //seçilen doktorun id sini label a yazdırma
            SqlCommand komut = new SqlCommand("Select Doktorid from Doktor where Doktorad+' '+Doktorsoyad=@dr", bgl.baglanti());
            komut.Parameters.AddWithValue("@dr", cmbdoktor.Text);
            SqlDataReader dr = komut.ExecuteReader();
            //lbldoktor.Text = null;
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
                lbl1.Text = drr[0].ToString();
                lbl2.Text = drr[1].ToString();
            }
            bgl.baglanti().Close();
            //label'lara tarih yazılırsa bu tarihleri kısa tarihe çevir
            if (lbl1.Text != "")
            {
                DateTime timeizin = Convert.ToDateTime(lbl1.Text);
                DateTime timeson = Convert.ToDateTime(lbl2.Text);
                lbl1.Text = timeizin.ToShortDateString();
                lbl2.Text = timeson.ToShortDateString();
            }
        }
        private void linkbilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.id = lblid.Text;
            fr.Show();
        }
        private void btnrandevual_Click(object sender, EventArgs e)
        {
            if (cmbbrans.Text == "" || cmbdoktor.Text == "" || richtxtsikayet.Text == "" || cmbsaat.Text == "")
            {
                MessageBox.Show("Eksik alan var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dateTimePicker1.Value <= DateTime.Now)
            {
                MessageBox.Show("İleri bir tarihten randevu alınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lbl1.Text != "")
            {
                if (Convert.ToDateTime(lbl1.Text) <= dateTimePicker1.Value && dateTimePicker1.Value < Convert.ToDateTime(lbl2.Text)) //izin  basşangıc tarihinde izinli oluyor ama bitiş tarihinde izin bitiyor
                {
                    MessageBox.Show("Doktor izinli\n" + lbl1.Text + " - " + lbl2.Text + " Tarihleri arası randevu almayın", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Randevu_Ekle();
                    FrmHastaDetay_Load(sender, e);
                    Temizle();
                }
            }
            else if (lbl1.Text == "") //deneme==1
            {
                Randevu_Ekle();
                FrmHastaDetay_Load(sender, e);
                Temizle();
            }
        }
        private void txttemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void btnanaekran_Click(object sender, EventArgs e)
        {
            FrmGirisler frm = new FrmGirisler();
            this.Close();
            frm.Show();
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
            SaatYenile();
            try
            {
                SqlCommand komutx = new SqlCommand("select Randevusaat from Randevu where Randevutarih=@tarih and (Randevudoktorid=@doktor or Randevuhastaid=@hasta)", bgl.baglanti());
                komutx.Parameters.AddWithValue("@doktor", lbldoktor.Text);
                komutx.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.Date);
                komutx.Parameters.AddWithValue("@hasta", lblid.Text);
                SqlDataReader drx = komutx.ExecuteReader();
                while (drx.Read())
                {
                    cmbsaat.Items.Remove(Convert.ToString(drx["Randevusaat"]));
                }
                bgl.baglanti().Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cmbsaat.Text = null;
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                SqlCommand komutx = new SqlCommand("SELECT Count(*) FROM Randevu where Randevuid='" + txtid.Text + "'", bgl.baglanti());
                int sonuc = (int)komutx.ExecuteScalar(); //tc yoksa 0 varsa 1
                if (sonuc > 0)
                {
                    if (MessageBox.Show("Randevuyu iptal etmek istediğinizden emin misiniz?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SqlCommand komutsil = new SqlCommand("delete From Randevu where Randevuid=@id", bgl.baglanti());
                        komutsil.Parameters.AddWithValue("@id", txtid.Text);
                        komutsil.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show(txtid.Text + " ID'li randevu iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtid.Clear();
                        FrmHastaDetay_Load(sender, e);
                    }
                    else
                    {
                        txtid.Clear();
                    }
                }
                else //sonuc=0
                {
                    MessageBox.Show("Randevu bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtid.Clear();
                }
                bgl.baglanti().Close();
            }
            else
            {
                MessageBox.Show("İptal etmek istediğiniz randevuyu tablodan seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dataGridAktif_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridAktif.SelectedCells[0].RowIndex;
            txtid.Text = dataGridAktif.Rows[secilen].Cells[0].Value.ToString();
        }

        private void dataGridGecmis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Clear();
        }
    }
}