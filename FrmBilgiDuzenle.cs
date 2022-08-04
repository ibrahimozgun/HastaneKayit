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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }
        sqlbaglantısı bg = new sqlbaglantısı();

        public string id;
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            txtid.Text = id;
            SqlCommand komut1 = new SqlCommand("select *from Hasta where Hastaid=@p1", bg.baglanti());
            komut1.Parameters.AddWithValue("@p1", txtid.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                txtad.Text = dr1[1].ToString();
                msktc.Text = dr1[2].ToString();
                msktelefon.Text = dr1[3].ToString();
                cmbcinsiyet.Text = dr1[4].ToString();
            }
            bg.baglanti().Close();
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "" || msktc.Text == "" || cmbcinsiyet.Text == "")
            {
                MessageBox.Show("Kaydedilmedi\nBoş bir alan var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (msktc.MaskFull)
                {
                    SqlCommand komut = new SqlCommand("update Hasta set Hastaisim=@p1, Hastatc=@p2, " +
                    "Hastatelefon=@p3, Hastacinsiyet=@p4 where Hastaid=" + txtid.Text, bg.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtad.Text);
                    komut.Parameters.AddWithValue("@p2", msktc.Text);
                    komut.Parameters.AddWithValue("@p3", msktelefon.Text);
                    komut.Parameters.AddWithValue("@p4", cmbcinsiyet.Text);
                    komut.ExecuteNonQuery();
                    bg.baglanti().Close();
                    MessageBox.Show("Kayıt Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Kaydedilmedi\nTC Kimlik numaranı eksik girdin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bg.baglanti().Close();
        }
    }
}
