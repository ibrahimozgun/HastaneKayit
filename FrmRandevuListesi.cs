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
        public void temizle()
        {
            txtidguncelle.Clear();
            msktarih.Clear();
            msksaat.Clear();
            cmbbrans.Text = "";
            cmbdoktor.Text = "";
            richtxtsikayet.Clear();
            txttc.Clear();
        }
        public void tarih()
        {
            lbltarih.Text = DateTime.Now.ToString("dd.MM.yyyy"); // sadece tarih
            int gun = Convert.ToInt32(lbltarih.Text.Substring(0, 2));
            int ay = Convert.ToInt32(lbltarih.Text.Substring(3, 2));
            int yil = Convert.ToInt32(lbltarih.Text.Substring(6, 4));
            lblgun.Text = Convert.ToString(gun);
            lblay.Text = Convert.ToString(ay);
            lblyil.Text = Convert.ToString(yil);
        }
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            tarih();
            //branşları çekme combobox a
            SqlCommand komut3 = new SqlCommand("select Bransad from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader(); //veri okuyucuyu çalıştırıyor
            while (dr3.Read())
            {
                cmbbrans.Items.Add(dr3[0]); //dr[0] id leri tutuyor ama bransad olunca adlar 0
            }
            bgl.baglanti().Close();

            //datagridview e randevu listeleme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From Tbl_Randevular", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tarih";
            dataGridView1.Columns[2].HeaderText = "Saat";
            dataGridView1.Columns[3].HeaderText = "Branş";
            dataGridView1.Columns[4].HeaderText = "Doktor";
            dataGridView1.Columns[5].HeaderText = "Durum";
            dataGridView1.Columns[6].HeaderText = "Hasta TC";
            dataGridView1.Columns[0].Width = 39; //id genişliği
        }

        //public int secilen;
        // https://www.udemy.com/course/sifirdan-ileri-seviye-csharp-programlama/learn/lecture/8388878#overview
        // tablodan bir randevuya çıft tıklayınca veriler sekreter detaya gidecek 
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //yap
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string kelime = txtid.Text;
            int hata = 0;

            if (kelime == "")
            {
                hata = 2;
            }

            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (kelime == Convert.ToString(row.Cells["Randevuid"].Value))
                    {
                        hata = 0;
                        break;
                    }
                    else
                    {
                        hata = 1;
                    }
                }
            }

            if (hata == 0)
            {
                //randevu silincek ama messageBox da eveti seçmeli
                if (MessageBox.Show("Randevuyu silmek istediğinize emin misiniz?", "Some Title", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlCommand komutsil = new SqlCommand("delete From Tbl_Randevular where Randevuid=@p1", bgl.baglanti());
                    komutsil.Parameters.AddWithValue("@p1", txtid.Text);
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
            else if (hata == 1)
            {
                MessageBox.Show("Silinecek randevu bulunamadi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtid.Clear();
                txtid.Focus();
            }
            else if (hata == 2)
            {
                MessageBox.Show("Silmek istediğin randevunun ID'sini gir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtid.Focus();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtidguncelle.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            msktarih.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            msksaat.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbdoktor.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txttc.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            richtxtsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if(msksaat.MaskFull && msktarih.MaskFull) //tarihle saat karakter eksikse hata
            {
                ////maskedTextBox dan alınan saatin 24:59 uygunluğunu kontrol ediyor
                int saat = Convert.ToInt32(msksaat.Text.Substring(0, 2));
                int dakika = Convert.ToInt32(msksaat.Text.Substring(3, 2));
                lblsaat.Text = Convert.ToString(saat);
                lbldakika.Text = Convert.ToString(dakika);

                //RANDEVU TARİHİ KONTOL
                lbltarih.Text = DateTime.Now.ToString("dd.MM.yyyy"); // sadece tarih
                int rgun = Convert.ToInt32(msktarih.Text.Substring(0, 2));
                int ray = Convert.ToInt32(msktarih.Text.Substring(3, 2));
                int ryil = Convert.ToInt32(msktarih.Text.Substring(6, 4));
                lblrgun.Text = Convert.ToString(rgun);
                lblray.Text = Convert.ToString(ray);
                lblryil.Text = Convert.ToString(ryil);

                if (saat < 24 && dakika < 60) //saat 24:59 a uymassa hata
                {
                    if (txtidguncelle.Text == "" || msksaat.Text == "" || msktarih.Text == "" ||
                        cmbbrans.Text == "" || cmbdoktor.Text == "" || txttc.Text == "" || richtxtsikayet.Text == "")
                    {
                        MessageBox.Show("Eksik alan var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        msktarih.Focus();
                    }
                    else
                    {
                        if (ryil < Convert.ToInt32(lblyil.Text))
                        {
                            MessageBox.Show("Geçmiş tarihten randevu alınamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (ryil == Convert.ToInt32(lblyil.Text) && ray < Convert.ToInt32(lblay.Text))
                        {
                            MessageBox.Show("Geçmiş tarihten randevu alınamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (ray == Convert.ToInt32(lblay.Text) && rgun < Convert.ToInt32(lblgun.Text))
                        {
                            MessageBox.Show("Geçmiş tarihten randevu alınamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (MessageBox.Show("Randevuyu güncellemek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                SqlCommand komut = new SqlCommand("Update Tbl_Randevular set Randevutarih=@p1, Randevusaat=@p2, " +
                                                                  "Randevubrans=@p3, Randevudoktor=@p4, Hastatc=@p5, Hastasikayet=@p6 where " +
                                                                  "Randevuid=" + txtidguncelle.Text, bgl.baglanti());
                                komut.Parameters.AddWithValue("@p1", msktarih.Text);
                                komut.Parameters.AddWithValue("@p2", msksaat.Text);
                                komut.Parameters.AddWithValue("@p3", cmbbrans.Text);
                                komut.Parameters.AddWithValue("@p4", cmbdoktor.Text);
                                komut.Parameters.AddWithValue("@p5", txttc.Text);
                                komut.Parameters.AddWithValue("@p6", richtxtsikayet.Text);
                                komut.ExecuteNonQuery();
                                bgl.baglanti().Close();
                                MessageBox.Show("guncellendi", "İnfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FrmRandevuListesi_Load(sender, e);
                                temizle();
                            }
                            else
                            {
                                msktarih.Focus();
                            }                           
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir saat girin");
                }
            }
            else
            {
                MessageBox.Show("Tarih veya saat hatalı","info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            //brasş seçinde doktorların gelmesi
            SqlCommand komut = new SqlCommand("Select Doktorad, Doktorsoyad From Tbl_Doktorlar where Doktorbrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            cmbdoktor.Text = null;
            while (dr.Read())
            {
                cmbdoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }
    }
}