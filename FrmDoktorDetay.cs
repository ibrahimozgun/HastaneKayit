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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        public void tarihler() //giriş ekranındaki girişe tıklayınca yükleniyor  //loadın içine koyunca her muayene sonu kaydete basınca tarih sayısı artıyor
        {
            //tarihleri comcoBox'a çekme
            SqlCommand komut1 = new SqlCommand("select Randevutarih from Tbl_Randevular where Randevudoktor='" + lbladsoyad.Text + "'", bgl.baglanti());
            SqlDataReader dr2 = komut1.ExecuteReader(); //veri okuyucuyu çalıştırıyor
            while (dr2.Read())
            {
                cmbtarihler.Items.Add(dr2[0]); //dr[0] id leri tutuyor ama bransad olunca adlar 0
            }
            bgl.baglanti().Close();
        }
        public string TC;
        sqlbaglantısı bgl = new sqlbaglantısı();
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            btnrandevukaydet.Enabled = false;
            lbltc.Text = TC;
            SqlCommand komut = new SqlCommand("Select Doktorad , Doktorsoyad From Tbl_Doktorlar " +
                                              "where Doktortc=" + lbltc.Text, bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //ekrandanki ismin randevulaını listeler
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From Tbl_Randevular where Randevudoktor='" + lbladsoyad.Text + "'", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.baglanti().Close();
            dataGridView1.Columns[7].DisplayIndex = 3; //şikayeti tarihten sonraya taşıdık
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tarih";
            dataGridView1.Columns[2].HeaderText = "Saat";
            dataGridView1.Columns[3].HeaderText = "Branş ";
            dataGridView1.Columns[6].HeaderText = "Hasta TC'si";
            dataGridView1.Columns[7].HeaderText = "Hastanın şikayeti";
            dataGridView1.Columns[8].HeaderText = "Muayene sonrası";
            dataGridView1.Columns[4].Visible = false; //dataGridView1.Columns[4].HeaderText = "Doktor";
            dataGridView1.Columns[5].Visible = false; //dataGridView1.Columns[5].HeaderText = "Durum";
        }
        private void btnbilgiduzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle frd = new FrmDoktorBilgiDuzenle();
            frd.doktortc = lbltc.Text;
            frd.Show();
        }
        private void btnduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frd = new FrmDuyurular();
            frd.Show();
        }
        private void btncikis_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void btnanaekran_Click(object sender, EventArgs e)
        {
            FrmGirisler frm = new FrmGirisler();
            this.Close();
            frm.Show();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnrandevukaydet.Enabled = true;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            richtxt.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void btnrandevukaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Randevular set Randevusonuozet=@p1 where Randevuid=" + txtid.Text, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", richtxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("muayene sonu bilgiler eklendi");
            richtxt.Clear();
            FrmDoktorDetay_Load(sender, e);
        }

        private void cmbtarihler_SelectedIndexChanged(object sender, EventArgs e)
        {
            // doktorun birini seçinde doktorun randevuları
            DataTable dt = new DataTable();         //randevunun durum 0 ise gösteriyor
            SqlDataAdapter da = new SqlDataAdapter("Select *From Tbl_Randevular where Randevutarih='"+cmbtarihler.Text+"' and " +
                                                   "Randevudoktor='" + lbladsoyad.Text + "'", bgl.baglanti());
            //kelime baazlı aramada sql de tek tırnak
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[7].DisplayIndex = 3; //şikayeti tarihten sonraya aldık
            dataGridView1.Columns[1].HeaderText = "Tarih"; //kolonları isimlendirme
            dataGridView1.Columns[2].HeaderText = "Saat";
            dataGridView1.Columns[3].HeaderText = "Branş";
            dataGridView1.Columns[4].HeaderText = "Doktor";
        }

        private void btnfiltretemizle_Click(object sender, EventArgs e)
        {
            //dataGridView1.Columns.Clear();
            //ekrandanki ismin randevulaını listeler
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From Tbl_Randevular where Randevudoktor='" + lbladsoyad.Text + "'", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.baglanti().Close();
            dataGridView1.Columns[7].DisplayIndex = 3; //şikayeti tarihten sonraya aldık
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tarih";
            dataGridView1.Columns[2].HeaderText = "Saat";
            dataGridView1.Columns[3].HeaderText = "Branş";
            dataGridView1.Columns[4].HeaderText = "Doktor";
            dataGridView1.Columns[5].HeaderText = "Durum";
            dataGridView1.Columns[6].HeaderText = "Hasta TC'si";
            dataGridView1.Columns[7].HeaderText = "Hastanın şikayeti";
            dataGridView1.Columns[8].HeaderText = "Muayene sonrası";

            cmbtarihler.Text = "";
        }
    }
}