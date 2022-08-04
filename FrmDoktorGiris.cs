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
        HashCode hc = new HashCode();
        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select *From Personel where " +
                                              "Personeltc=@p1 and Personelsifre=@p2 and Personelunvan='doktor'", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", hc.PassHash(txtsifre.Text));
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay frd = new FrmDoktorDetay();
                frd.TC = msktc.Text;
                frd.Show();
                this.Hide();
                frd.tarihlerA(); //doktor detayda comboBox'a randevuların tarihlerini yüklüyor
                frd.tarihlerG();
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

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }
    }
}