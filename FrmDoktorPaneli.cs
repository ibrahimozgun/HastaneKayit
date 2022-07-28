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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantısı bgl = new sqlbaglantısı();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            //doktorları görüntüleme DataGridView de
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select *From Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns[0].DisplayIndex = 5;
            dataGridView1.Columns[0].Width = 55;

            //branşları çekme combobox a
            SqlCommand komut = new SqlCommand("select Bransad from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr1 = komut.ExecuteReader(); //veri okuyucuyu çalıştırıyor
            while (dr1.Read())
            {
                cmbbrans.Items.Add(dr1[0]); //dr[0] id leri tutuyor ama bransad olunca adlar 0
            }
            bgl.baglanti().Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            //DOKTOR EKLEME
            if (txtad.Text == "" || txtsoyad.Text == "" || cmbbrans.Text == "" || msktc.Text == "" || txtsifre.Text == "")
            {
                MessageBox.Show("Eksik alan var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtad.Focus();
            }
            else
            {
                SqlCommand komutekle = new SqlCommand("insert into Tbl_Doktorlar (Doktorad, Doktorsoyad, Doktorbrans, Doktortc, Doktorsifre) " +
                                                      "values (@d1,@d2, @d3, @d4, @d5)", bgl.baglanti());
                komutekle.Parameters.AddWithValue("@d1", txtad.Text);
                komutekle.Parameters.AddWithValue("@d2", txtsoyad.Text);
                komutekle.Parameters.AddWithValue("@d3", cmbbrans.Text);
                komutekle.Parameters.AddWithValue("@d4", msktc.Text);
                komutekle.Parameters.AddWithValue("@d5", txtsifre.Text);
                komutekle.ExecuteNonQuery();
                MessageBox.Show("Doktor Eklendi.\n\nŞifresi: " + txtsifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.baglanti().Close();
                FrmDoktorPaneli_Load(sender, e); //eklenen doktor listeye eklenir
                txtad.Text = null;
                txtsoyad.Text = null;
                cmbbrans.Text = null;
                msktc.Text = null;
                txtsifre.Text = null;
                txtad.Focus();
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            //DOKTOR BİLGİLERİ GÜNCELLEME
            if (txtad.Text == "" || txtsoyad.Text == "" || cmbbrans.Text == "" || msktc.Text == "" || txtsifre.Text == "")
            {
                MessageBox.Show("Eksik alan var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtad.Focus();
            }
            else
            {
                SqlCommand komutguncelle = new SqlCommand("Update Tbl_Doktorlar set Doktorad=@g1, Doktorsoyad=@g2, Doktorbrans=@g3, Doktorsifre=@g4" +
                                                          " where Doktortc="+msktc.Text,bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@g1", txtad.Text);
                komutguncelle.Parameters.AddWithValue("@g2", txtsoyad.Text);
                komutguncelle.Parameters.AddWithValue("@g3", cmbbrans.Text);
                komutguncelle.Parameters.AddWithValue("@g4", txtsifre.Text);
                //komutguncelle.Parameters.AddWithValue("@g5", msktc.Text);
                komutguncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show(msktc.Text + " TC numaralı doktorun bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmDoktorPaneli_Load(sender, e); //güncellenen doktor listede yenilenir
                txtad.Text = null;
                txtsoyad.Text = null;
                cmbbrans.Text = null;
                msktc.Text = null;
                txtsifre.Text = null;
                txtad.Focus();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msktc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (msktc.Text=="")
            {
                MessageBox.Show("Silmek istediğin doktorun TC'sını gir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                msktc.Focus();
            }
            else
            {
                SqlCommand komutsil = new SqlCommand("delete From Tbl_Doktorlar where Doktortc=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", msktc.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show(msktc.Text + " TC numaralı doktor silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmDoktorPaneli_Load(sender, e);
            }
        }

        private void btntemizle_Click_1(object sender, EventArgs e)
        {
            txtad.Clear();
            txtsoyad.Clear();
            cmbbrans.Text = null;
            msktc.Clear();
            txtsifre.Clear();
            txtad.Focus();
        }
    }
}