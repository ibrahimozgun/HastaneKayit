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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        public string doktorid;
        public string doktortc;
<<<<<<< HEAD
=======
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "" || txtsoyad.Text == "" || txtsifre.Text == "" || cmbbrans.Text == "" || msktelefon.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("Eksik var ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtad.Focus();
            }
            else
            {
                if(!this.txtemail.Text.Contains('@') || !this.txtemail.Text.Contains('.'))
                {
                    MessageBox.Show("geçerli mail gir");
                }
                else
                {
                    SqlCommand komutg = new SqlCommand("Update Tbl_Doktorlar Set " +
                    "Doktorad=@g1, Doktorsoyad=@g2, Doktorbrans=@g3, Doktorsifre=@g4, " +
                    "Doktortelefon=@g5, Doktoremail=@g6 where Doktortc=" + msktc.Text, bgl.baglanti());
                    komutg.Parameters.AddWithValue("@g1", txtad.Text);
                    komutg.Parameters.AddWithValue("@g2", txtsoyad.Text);
                    komutg.Parameters.AddWithValue("@g3", cmbbrans.Text);
                    komutg.Parameters.AddWithValue("@g4", txtsifre.Text);
                    komutg.Parameters.AddWithValue("@g5", msktelefon.Text);
                    komutg.Parameters.AddWithValue("@g6", txtemail.Text);
                    komutg.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show(msktc.Text + " TC Numaralı doktorun bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Windows.Forms.Application.Exit(); //uygulama kapanır 
                }                
            }
        }
>>>>>>> fc2fa81d5b834ab0d976662dbe6ecbe014ea67ae
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            cmbbrans.Items.Clear();
            msktc.Text = doktortc;
            //branşları ComboBox'a
            SqlCommand komut1 = new SqlCommand("Select Bransisim From Brans", bgl.baglanti());
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                cmbbrans.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
            //id ye bakarak textbox lara bilgilerin yüklenmesi
            SqlCommand komut2 = new SqlCommand("Select *From Doktor where Doktorid='"+Convert.ToString(doktorid)+ "'", bgl.baglanti());;
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                txtdoktorid.Text = doktorid;
                txtperid.Text = dr2[1].ToString();
                lblbrans.Text = dr2[2].ToString();
                txtad.Text = dr2[3].ToString();
                txtsoyad.Text = dr2[4].ToString();
                msktelefon.Text = dr2[5].ToString();
                txtemail.Text = dr2[6].ToString();
            }
            bgl.baglanti().Close();
            //bransid si yazan labeldan branşın ismini comboBox a yazdık
            SqlCommand komut3 = new SqlCommand("Select Bransisim From Brans where Bransid=" + lblbrans.Text, bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            dr3.Read();
            cmbbrans.Text = Convert.ToString(dr3[0]);
            bgl.baglanti().Close();
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                //DOKTOR BİLGİLERİ GÜNCELLEME
                if (txtad.Text == "" || txtsoyad.Text == "" || cmbbrans.Text == "" || msktc.Text == "" || msktelefon.Text == "" || txtemail.Text == "")
                {
                    MessageBox.Show("Eksik alan var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtad.Focus();
                }
                else
                {
                    SqlCommand komutguncelle = new SqlCommand("update Doktor set Doktor.Doktorad=@ad, Doktor.Doktorsoyad=@soyad, Doktor.Doktorbransid=@bransid, " +
                        "Doktor.Doktortelefon=@telefon, Doktor.Doktormail=@mail From Doktor d, Personel p where d.Doktorpersonelid=p.Personelid and " +
                        "d.Doktorpersonelid='" + txtperid.Text + "'; " +
                        "update Personel set Personel.Personeltc=@tc From Personel p, Doktor d where p.Personelid=d.Doktorpersonelid and " +
                        "p.Personelid='" + txtperid.Text + "'", bgl.baglanti());

                    komutguncelle.Parameters.AddWithValue("@ad", txtad.Text);
                    komutguncelle.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                    komutguncelle.Parameters.AddWithValue("@bransid", lblbrans.Text);
                    komutguncelle.Parameters.AddWithValue("@telefon", msktelefon.Text);
                    komutguncelle.Parameters.AddWithValue("@mail", txtemail.Text);
                    komutguncelle.Parameters.AddWithValue("@tc", msktc.Text);
                    //geçersiz email yazımında hata veriyor
                    if (!this.txtemail.Text.Contains('@') || !this.txtemail.Text.Contains('.'))
                    {
                        MessageBox.Show("geçerli bir meil girin diyo", "Geçersiz Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        komutguncelle.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show(msktc.Text + " TC numaralı doktorun bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //brasş seçinde labela id si yazma
            SqlCommand komut3 = new SqlCommand("Select Bransid from Brans where Bransisim=@id", bgl.baglanti());
            komut3.Parameters.AddWithValue("@id", cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            lblbrans.Text = null;
            while (dr3.Read())
            {
                lblbrans.Text = dr3[0].ToString();
            }
            bgl.baglanti().Close();
        }
        private void linkLabelPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifre_Degistir frm = new FrmSifre_Degistir();
            frm.Perid = Convert.ToInt32(txtperid.Text);
            this.Close();
            frm.Show();
        }
        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtemail.Text.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(txtemail.Text.Substring(i, 1)))
                {
                    MessageBox.Show("Şifre içinde boşluk olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SendKeys.Send("{BS}");
                }
            }
        }
    }
}