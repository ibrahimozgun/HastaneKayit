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
    public partial class FrmSekreterBilgiDuzenle : Form
    {
        public FrmSekreterBilgiDuzenle()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        public string TC;
        private void FrmSekreterBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = TC;

            //giriş ekranından isim soyisim çekme
            SqlCommand komut1 = new SqlCommand("Select Sekreterpersonelid, Sekreterid, Sekreterisim from Personel inner join Sekreter " +
                "on Sekreter.Sekreterpersonelid=Personel.Personelid where Personeltc=" + TC, bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                txtPerID.Text = dr1[0].ToString();
                txtSekreterID.Text = dr1[1].ToString();
                txtAd.Text = dr1[2].ToString(); //doktor paneline sekreterin adı gidiyor
            }
            bgl.baglanti().Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || mskTC.Text=="")
            {
                MessageBox.Show("Eksik bilgiler var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //if içine evet hayır sorma
                if (MessageBox.Show("Sekreter bilgilerini güncellemek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlCommand komut = new SqlCommand("Update Personel set Personeltc=@tc From Personel p, Sekreter s where p.Personelid=s.Sekreterpersonelid and p.Personeltc='" + TC + "'; " +
                    "Update Sekreter set Sekreterisim=@isim From Sekreter s, Personel p where s.Sekreterpersonelid=p.Personelid and p.Personeltc=" + TC, bgl.baglanti());
                    komut.Parameters.AddWithValue("@tc", mskTC.Text);
                    komut.Parameters.AddWithValue("@isim", txtAd.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Bilgiler başarı ile güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifre_Degistir frm = new FrmSifre_Degistir();
            frm.Perid = Convert.ToInt32(txtPerID.Text);
            this.Close();
            frm.Show();
        }
    }
}