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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }

        sqlbaglantısı bgl = new sqlbaglantısı();
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            btnguncelle.Enabled = false;
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select *From Tbl_Branslar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns[0].Width = 55;
            txtad.Focus();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnguncelle.Enabled = true;
            int secilen = dataGridView1.SelectedCells[0].RowIndex; //seçilen hücrenin 0ıncı indexinin data gridini alır 
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString(); //row=satır cell=hücre
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "")
            {
                MessageBox.Show("Branş eklenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtad.Focus();
            }
            else
            {
                SqlCommand komutekle = new SqlCommand("insert into Tbl_Branslar (Bransad) values (@p1)", bgl.baglanti());
                komutekle.Parameters.AddWithValue("@p1", txtad.Text);
                komutekle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show(txtad.Text + " Branşı Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmBrans_Load(sender, e);
                txtad.Text = null;
                txtid.Text = null;
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("ID gir","Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtid.Focus();
            }
            else
            {
                SqlCommand komut = new SqlCommand("update Tbl_Branslar set Bransad=@p1 where Bransid=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtad.Text);
                komut.Parameters.AddWithValue("@p2", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncellendi","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmBrans_Load(sender, e);
                txtad.Text = null;
                txtid.Text = null;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("ID gir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtid.Focus();
            }
            else
            {
                if(MessageBox.Show(txtid.Text+" ID'li branşı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlCommand komut = new SqlCommand("delete From Tbl_Branslar where Bransid=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtid.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    //MessageBox.Show(txtid.Text + " ID li branş silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmBrans_Load(sender, e);
                    txtad.Text = null;
                    txtid.Text = null;
                }
            }
        }
    }
}