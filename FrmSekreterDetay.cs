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
            richTextBox1.MaxLength = 250;
            txtduyuruid.MaxLength = 4;
            lbltc.Text = tc; //giriş ekranından tc yi çekme

            //giriş ekranından isim soyisim çekme
            SqlCommand komut1 = new SqlCommand("Select Sekreterisim from Sekreter inner join Personel " +
                "on Sekreter.Sekreterpersonelid=Personel.Personelid where Personeltc=" + lbltc.Text, bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString(); //doktor paneline sekreterin adı gidiyor
            }
            bgl.baglanti().Close();
            //branşları görüntüleme DataGridView de
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from Brans", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns[0].HeaderText = "Branş ID";
            dataGridView1.Columns[1].HeaderText = "Branş";
            dataGridView1.Columns[0].Width = 55;
            //doktorları görüntüleme DataGridView de
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select Doktorid, Doktorad as 'Ad', Doktorsoyad as 'Soyad', Bransisim as 'Branş', Personeltc, Doktortelefon as 'Telefon', Doktormail as 'Mail'," +
                " Doktorkayittarih as 'Kayıt Tarihi', Doktorsekreter as 'Sorumlu Sekreter', Doktorizinbas as 'İzin başlangıç tarihi', Doktorizinson as 'İzin bitiş tarihi'" +
                "  From Doktor inner join Brans on Doktor.Doktorbransid=Brans.Bransid inner join Personel on Doktor.Doktorpersonelid=Personel.Personelid", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[0].Width = 35; //ıd nın uzunluğu
        }
        private void btndoktor_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frd = new FrmDoktorPaneli();
            frd.sekreterisim = lbladsoyad.Text;
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
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Boş duyuru oluşturulamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                richTextBox1.Focus();
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into Duyuru (Duyuruicerik) values (@p1)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", richTextBox1.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Duyuru oluştu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Text = null;
            }
        }
        private void btnduyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular frd = new FrmDuyurular();
            frd.Show();
        }

        private void btnanaekran_Click(object sender, EventArgs e)
        {
            FrmGirisler frm = new FrmGirisler();
            this.Close();
            frm.Show();
        }
        private void btnduyurusil_Click(object sender, EventArgs e)
        {
            if (txtduyuruid.Text == "" || txtduyuruid.Text == null)
            {
                MessageBox.Show("Silmek istediğin duyurunun ID'sini gir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komutx = new SqlCommand("SELECT Count(*) FROM Duyuru where Duyuruid='" + txtduyuruid.Text + "'", bgl.baglanti());
                int sonuc = (int)komutx.ExecuteScalar(); //tc yoksa 0 varsa 1
                if (sonuc > 0) //sonuc=1 oldu kayıt var
                {
                    SqlCommand komutsil = new SqlCommand("delete From Duyuru where Duyuruid=@p1", bgl.baglanti());
                    komutsil.Parameters.AddWithValue("@p1", txtduyuruid.Text);
                    komutsil.ExecuteNonQuery();
                    MessageBox.Show(txtduyuruid.Text + " ID numaralı duyuru silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtduyuruid.Clear();
                    bgl.baglanti().Close();
                }
                else //sonuc=0 ve tc vt nında bulunmadı
                {
                    MessageBox.Show("Silinmek istenen randevu bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtduyuruid.Clear();
                }
                bgl.baglanti().Close();
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int u = richTextBox1.TextLength;
            lblduyuru.Text = "Yazılan Karakter Sayısı: " + richTextBox1.TextLength.ToString();
            if (u == 250)
            {
                MessageBox.Show("Maksimum sınıra ulaştınız!");
            }
        }
        private void linkLabelSifreDeg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSekreterBilgiDuzenle frm = new FrmSekreterBilgiDuzenle();
            frm.TC = lbltc.Text;
            frm.Show();
        }
    }
}