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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Sekreterler where " +
                                              "Sekretertc=@p1 and Sekretersifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                FrmSekreterDetay frms = new FrmSekreterDetay();
                frms.tc = msktc.Text;
                frms.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsifre.Text = null;
                msktc.Focus();
            }
            bgl.baglanti().Close();
        }
        private void btngeri_Click(object sender, EventArgs e)
        {
            FrmGirisler frmm = new FrmGirisler();
            frmm.Show();
            this.Close();
        }
    }
}
