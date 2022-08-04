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

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lbltarih.Text = DateTime.Now.ToShortDateString(); // sadece tarih
            lbltc.Text = tc;
            //komut1 ad soyad çekme
            SqlCommand komut1 = new SqlCommand("select Hastaad, Hastasoyad From Tbl_Hastalar where Hastatc="+lbltc.Text, bgl.baglanti());           
            //komut1.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut1.ExecuteReader(); //veri okuyucuyu çalıştırıyor          
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }          
            bgl.baglanti().Close();

            //branşları çekme
            SqlCommand komut2 = new SqlCommand("select Bransad from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader(); //veri okuyucuyu çalıştırıyor
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]); //dr[0] id leri tutuyor
            }
            bgl.baglanti().Close();

            //hastanın randevu geçmişi
            DataTable dt = new DataTable(); //veri tablosu oluşturuluyor
            //dataadapter; data gride veri aktarmak için kullanılan command
            SqlDataAdapter da = new SqlDataAdapter("select *from Tbl_Randevular where Hastatc='" + tc + "'", bgl.baglanti());
            da.Fill(dt); //tablodan gelecek değerle DataAdapter in içini doldurur
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].DisplayIndex = 7; //id sona aldık
            dataGridView1.Columns[5].DisplayIndex = 7; 
            dataGridView1.Columns[1].HeaderText = "Tarih"; //kolonları isimlendirme
            dataGridView1.Columns[2].HeaderText = "Saat";
            dataGridView1.Columns[3].HeaderText = "Branş";
            dataGridView1.Columns[4].HeaderText = "Doktor";
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.Columns.Clear(); //branşa tıklanınca randevular temizlenir
            cmbdoktor.Items.Clear();
            
            //brasş seçinde doktorların gelmesi
            SqlCommand komut3 = new SqlCommand("Select Doktorad, Doktorsoyad from Tbl_Doktorlar where Doktorbrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();           
            cmbdoktor.Text = null;
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0]+" "+dr3[1]);
            }
            bgl.baglanti().Close();
            txtid.Clear(); //branş değişince ekrandaki id gitsin
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // doktorun birini seçinde doktorun randevuları
            DataTable dt = new DataTable();         //randevunun durum 0 ise gösteriyor
            SqlDataAdapter da = new SqlDataAdapter("Select *From Tbl_Randevular where Randevudurum =0 and " +
                                                   "Randevudoktor='" + cmbdoktor.Text + "'", bgl.baglanti());
            //kelime baazlı aramada sql de tek tırnak
            da.Fill(dt);
            dataGridView2.DataSource= dt;
            dataGridView2.Columns[0].DisplayIndex = 6; //id yi en sona aldık
            dataGridView2.Columns[1].HeaderText = "Tarih"; //kolonları isimlendirme
            dataGridView2.Columns[2].HeaderText = "Saat";
            dataGridView2.Columns[3].HeaderText = "Branş";
            dataGridView2.Columns[4].HeaderText = "Doktor";
            txtid.Clear(); //doktor değişince id sıfırlansın
        }
        private void linkbilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.tcNo = lbltc.Text;
            fr.Show();
        }
        private void btnrandevual_Click(object sender, EventArgs e)
        {
            if(txtid.Text=="" || cmbbrans.Text=="" || cmbdoktor.Text=="" || richtxtsikayet.Text == "")
            {
                MessageBox.Show("Eksik alan var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komutr = new SqlCommand("Update Tbl_Randevular set Randevudurum=1, Hastatc=@x1, Hastasikayet=@x2 " +
                                               "where Randevuid=@x3", bgl.baglanti());
                komutr.Parameters.AddWithValue("@x1", lbltc.Text);
                komutr.Parameters.AddWithValue("@x2", richtxtsikayet.Text);
                komutr.Parameters.AddWithValue("@x3", txtid.Text);
                komutr.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Randevu alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);              
                FrmHastaDetay_Load(sender, e);
                txttemizle_Click(sender, e);
            }           
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //müsait randevulara tıklayınca bilgiler sola geliyor
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text=dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void txttemizle_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            cmbbrans.Text = null;
            cmbdoktor.Text = null;
            richtxtsikayet.Clear();
            cmbbrans.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGirisler frm = new FrmGirisler();
            this.Close();
            frm.Show();
        }
    }
}