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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        public string tc; //giriş ekranından çekebilmek için
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lbldurum.Text = "0";            
            lbltc.Text = tc; //giriş ekranından tc yi çekme

            //giriş ekranından isim soyisim çekme
            SqlCommand komut1 = new SqlCommand("Select Sekreteradsoyad from Tbl_Sekreterler where Sekretertc=" + lbltc.Text, bgl.baglanti());
            //komut.Parameters.AddWithValue("@tc", lbltc.Text);     =lbltc.text yaptık
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();


            //branşları görüntüleme DataGridView de
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns[0].HeaderText = "Branş ID";
            dataGridView1.Columns[1].HeaderText = "Branş";
            dataGridView1.Columns[0].Width = 55;


            //doktorları görüntüleme DataGridView de
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select *From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //kolonları(sütunları) sıralama
            /*dataGridView2.Columns[1].DisplayIndex = 0;
            dataGridView2.Columns[2].DisplayIndex = 1;
            dataGridView2.Columns[3].DisplayIndex = 2;
            dataGridView2.Columns[4].DisplayIndex = 3;
            dataGridView2.Columns[5].DisplayIndex = 4;*/
            dataGridView2.Columns[0].DisplayIndex = 5;

            //kolonları isimlendirme
            dataGridView2.Columns[0].HeaderText = "ID";           
            dataGridView2.Columns[1].HeaderText = "İsim";           
            dataGridView2.Columns[2].HeaderText = "Soyisim";          
            dataGridView2.Columns[3].HeaderText = "Branş";           
            dataGridView2.Columns[4].HeaderText = "TC";            
            dataGridView2.Columns[5].HeaderText = "Şifre";



            //branşları çekme combobox a
            SqlCommand komut3 = new SqlCommand("select Bransad from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader(); //veri okuyucuyu çalıştırıyor
            while (dr3.Read())
            {
                cmbbrans.Items.Add(dr3[0]); //dr[0] id leri tutuyor ama bransad olunca adlar 0
            }
            bgl.baglanti().Close();
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

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if(checkBoxDurum.Checked==true) //doktor dolu olacak ise hasta tc istiyor
            {
                if (msktarih.Text == "  .  ." || msksaat.Text == "  :" || cmbbrans.Text == "" || cmbdoktor.Text == "" || msktc.Text == "")
                {
                    MessageBox.Show("Eksik var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    msktarih.Focus();
                }
                else
                {
                    SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (Randevutarih, Randevusaat, Randevubrans, " +
                                                            "Randevudoktor, Randevudurum, Hastatc) " +
                                                            "values (@r1, @r2, @r3, @r4,@r5, @r6)", bgl.baglanti());
                    komutkaydet.Parameters.AddWithValue("@r1", msktarih.Text);
                    komutkaydet.Parameters.AddWithValue("@r2", msksaat.Text);
                    komutkaydet.Parameters.AddWithValue("@r3", cmbbrans.Text);
                    komutkaydet.Parameters.AddWithValue("@r4", cmbdoktor.Text);
                    komutkaydet.Parameters.AddWithValue("@r5", lbldurum.Text);
                    komutkaydet.Parameters.AddWithValue("@r6", msktc.Text);

                    komutkaydet.ExecuteNonQuery(); //insert komutu old. değişiklikleri kaydetmek için
                    bgl.baglanti().Close();
                    MessageBox.Show("Randevu Tmm", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    msktarih.Text = "";
                    msksaat.Text = "";
                    cmbbrans.Text = "";
                    cmbdoktor.Text = "";
                    msktc.Text = "";
                    msktarih.Focus();
                }
            }
            else //doktor durumu 0 ise doktor boş olcak ve hasta tc girmeye gerek yok
            {
                if (msktarih.Text == "  .  ." || msksaat.Text == "  :" || cmbbrans.Text == "" || cmbdoktor.Text == "")
                {
                    MessageBox.Show("Eksik var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    msktarih.Focus();
                }
                else if(msktc.Text != "")
                {
                    MessageBox.Show("Boş randevu için hasta tc girmeyin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    msktc.Focus();
                }
                else
                {
                    SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (Randevutarih, Randevusaat, Randevubrans, " +
                                                            "Randevudoktor, Randevudurum) " +
                                                            "values (@r1, @r2, @r3, @r4,@r5)", bgl.baglanti());
                    komutkaydet.Parameters.AddWithValue("@r1", msktarih.Text);
                    komutkaydet.Parameters.AddWithValue("@r2", msksaat.Text);
                    komutkaydet.Parameters.AddWithValue("@r3", cmbbrans.Text);
                    komutkaydet.Parameters.AddWithValue("@r4", cmbdoktor.Text);
                    komutkaydet.Parameters.AddWithValue("@r5", lbldurum.Text);

                    komutkaydet.ExecuteNonQuery(); //insert komutu old. değişiklikleri kaydetmek için
                    bgl.baglanti().Close();
                    MessageBox.Show("Boş Randevu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    msktarih.Text = "";
                    msksaat.Text = "";
                    cmbbrans.Text = "";
                    cmbdoktor.Text = "";
                    msktc.Text = "";
                    msktarih.Focus();
                }
            }
            
        }

        private void checkBoxDurum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDurum.Checked)
            {
                lbldurum.Text = "1";
            }
            else
            {
                lbldurum.Text = "0";
            }
        }

        private void btndoktor_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frd = new FrmDoktorPaneli();
            frd.Show();
        }

        private void btnbranspaneli_Click(object sender, EventArgs e)
        {
            FrmBrans frb = new FrmBrans();
            frb.Show();
        }

        private void btnrandevulistesi_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frr = new FrmRandevuListesi();
            frr.Show();
        }

        private void btnduyuruolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", richTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluştu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            richTextBox1.Text = null;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            //randevu listesinden veri gelecek
        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular frd = new FrmDuyurular();
            frd.Show();
        }
    }
}