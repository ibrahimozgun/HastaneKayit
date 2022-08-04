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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select *From Tbl_Doktorlar where " +
                                              "Doktortc=@p1 and Doktorsifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay frd = new FrmDoktorDetay();
                frd.TC = msktc.Text;
                frd.Show();
                this.Close();
                frd.tarihler(); //doktor detayda comboBox'a randevuların tarihlerini yüklüyor
            }
            else
            {
                MessageBox.Show("Bi şey yanlış", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsifre.Clear();
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