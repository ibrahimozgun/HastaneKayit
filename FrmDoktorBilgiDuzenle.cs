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
        public string doktortc;
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
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = doktortc;
            //branşları ComboBox'a
            SqlCommand komut1 = new SqlCommand("Select Bransad From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                cmbbrans.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Select *From Tbl_Doktorlar where Doktortc=" + msktc.Text, bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                txtad.Text = dr2[1].ToString();
                txtsoyad.Text = dr2[2].ToString();
                txtsifre.Text = dr2[5].ToString();
                cmbbrans.Text = dr2[3].ToString();
                msktelefon.Text = dr2[6].ToString();
                txtemail.Text = dr2[7].ToString();
            }
        }
        private void txtsifre_TextChanged(object sender, EventArgs e)
        {
            int kucuk_harf = 0;
            int buyuk_harf = 0;
            int sayi = 0;
            int noktalama = 0;// bölme* '% gibi
            int isaret = 0;//$+<> gibi
            int sayac = 0;
            string password = txtsifre.Text.ToString();


            for (int i = 0; i < password.Length; i++)
            {
                char car = Convert.ToChar(password.Substring(i, 1));
                if (char.IsLower(car))
                {
                    kucuk_harf++;

                }
                if (char.IsUpper(car))
                {
                    buyuk_harf++;

                }
                if (char.IsNumber(car))
                {
                    sayi++;                  
                }
                if (char.IsPunctuation(car))
                {
                    noktalama++;  // İçerisinde */,. diğer noktalama işsaretleri(sembollerharici)
                }
                if (char.IsSymbol(car))
                {
                    isaret++; // İçerisinde + $ <>  gibi semboller
                }
                if (char.IsWhiteSpace(car))
                {
                    MessageBox.Show("Şifre içinde boşluk olamaz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    SendKeys.Send("{BS}");
                }
            }

            if (kucuk_harf >= 1) { sayac += 1; }
            if (buyuk_harf >= 1) { sayac += 1; }
            if (sayi >= 1) { sayac += 1; }
            if (isaret + noktalama >= 1) { sayac += 1; }

            if (sayac < 4)
            {
                lblbilgi.Visible = true;
                btnguncelle.Enabled = false;
            }
            if (sayac == 4)
            {
                lblbilgi.Visible = false;
                btnguncelle.Enabled = true;
            }
        }
    }
}