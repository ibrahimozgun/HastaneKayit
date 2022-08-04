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
    public partial class FrmSifre_Degistir : Form
    {
        public FrmSifre_Degistir()
        {
            InitializeComponent();
        }
        public int Perid;
        public void Sorgula()
        {
            if (txtPassYeni1.Text.Trim() == txtPassYeni2.Text.Trim())
            {
                btnKaydet.Enabled = true;
                errorProvider1.SetError(txtPassYeni1, null);
                errorProvider1.SetError(txtPassYeni2, null);
            }
            else
            {
                btnKaydet.Enabled = false;
                errorProvider1.SetError(txtPassYeni1, "Şifreler Uyuşmuyor");
                errorProvider1.SetError(txtPassYeni2, "Şifreler Uyuşmuyor");
            }
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        HashCode hc = new HashCode();
        public void Kontrol()
        {
            int kucuk_harf = 0;
            int buyuk_harf = 0;
            int sayi = 0;
            int noktalama = 0;// bölme* '% gibi
            int isaret = 0;//$+<> gibi
            int sayac = 0;
            string password = txtPassYeni1.Text.ToString();

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
                    MessageBox.Show("Şifre içinde boşluk olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            }
            if (sayac == 4)
            {
                lblbilgi.Visible = false;
            }
        }
        private void Sifre_Degistir_Load(object sender, EventArgs e)
        {
            lblid.Text = Perid.ToString();
            txtPassYeni1.MaxLength = 10;
            txtPassYeni2.MaxLength = 10;
        }
        private void txtPassYeni1_TextChanged(object sender, EventArgs e)
        {
            Kontrol();
            Sorgula();
        }
        private void txtPassYeni2_TextChanged(object sender, EventArgs e)
        {
            Kontrol();
            Sorgula();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select *From Personel where Personelid=@p1 and Personelsifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblid.Text);
            komut.Parameters.AddWithValue("@p2", hc.PassHash(txtPassEski.Text));
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) //ID ile eski şifreyi karşılaştırıyor. okuma gerçekleşir ise şifre değiştirilebilecek
            {
                if (lblbilgi.Visible == false)
                {
                    try
                    {
                        SqlCommand komutx = new SqlCommand("update Personel set Personelsifre=@p1 where Personelid=" + lblid.Text, bgl.baglanti());
                        komutx.Parameters.AddWithValue("@p1", hc.PassHash(txtPassYeni1.Text));
                        komutx.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("şifre değiştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassEski.Clear();
                        txtPassYeni1.Clear();
                        txtPassYeni2.Clear();
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata");
                    }
                }
                else
                {
                    MessageBox.Show("Yeni oluşturulan parolada büyük harf, küçük harf, sembol veya rakam eksik", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eski şifreyi yanlış girdin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassEski.Clear();
                txtPassEski.Focus();
            }
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked == true)
            {
                txtPassEski.UseSystemPasswordChar = false;
                txtPassYeni1.UseSystemPasswordChar = false;
                txtPassYeni2.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassEski.UseSystemPasswordChar = true;
                txtPassYeni1.UseSystemPasswordChar = true;
                txtPassYeni2.UseSystemPasswordChar = true;
            }
        }
    }
}