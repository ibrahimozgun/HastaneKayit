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

        public string tcNo;
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = tcNo;
            SqlCommand komut1 = new SqlCommand("select *from Tbl_Hastalar where Hastatc=@p1", bg.baglanti());
            komut1.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                txtad.Text = dr1[1].ToString();
                txtsoyad.Text = dr1[2].ToString();
                msktelefon.Text = dr1[4].ToString();
                cmbcinsiyet.Text = dr1[5].ToString();
                //txtsifre.Text = dr1[5].ToString(); hastadan şifreyi kaldırdık
            }
            bg.baglanti().Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if(txtad.Text=="" || txtsoyad.Text=="" || 
               msktc.Text=="" || msktelefon.Text=="" || cmbcinsiyet.Text == "")
            {
                MessageBox.Show("Kaydedilmedi\nBoş bir alan var","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komut = new SqlCommand("update Tbl_Hastalar set Hastaad=@p1, Hastasoyad=@p2, " +
                "Hastatelefon=@p3, Hastacinsiyet=@p5 where Hastatc=@p6", bg.baglanti());
                komut.Parameters.AddWithValue("@p1", txtad.Text);
                komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
                komut.Parameters.AddWithValue("@p3", msktelefon.Text);
                //komut.Parameters.AddWithValue("@p4", txtsifre.Text);
                komut.Parameters.AddWithValue("@p5", cmbcinsiyet.Text);
                komut.Parameters.AddWithValue("@p6", msktc.Text);
                komut.ExecuteNonQuery();
                bg.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            bg.baglanti().Close();
        }
    }
}
