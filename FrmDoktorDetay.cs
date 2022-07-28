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

        public string TC;
        sqlbaglantısı bgl = new sqlbaglantısı();
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = TC;
            SqlCommand komut = new SqlCommand("Select Doktorad , Doktorsoyad From Tbl_Doktorlar " +
                                              "where Doktortc="+lbltc.Text, bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //ekrandanki ismin randevulaını listeler
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From Tbl_Randevular where Randevudoktor='" + lbladsoyad.Text +"'", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.baglanti().Close();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tarih";
            dataGridView1.Columns[2].HeaderText = "Saat";
            dataGridView1.Columns[3].HeaderText = "Branş";
            dataGridView1.Columns[4].HeaderText = "Doktor";
            dataGridView1.Columns[5].HeaderText = "Durum";
        }

        private void btnbilgiduzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle frd = new FrmDoktorBilgiDuzenle();
            frd.doktortc = lbltc.Text;
            frd.Show();
            this.Close();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
