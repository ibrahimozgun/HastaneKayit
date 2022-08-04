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
    public partial class FrmSekreterKayit : Form
    {
        public FrmSekreterKayit()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        HashCode hc = new HashCode();
        private void FrmSekreterKayit_Load(object sender, EventArgs e)
        {
            txtAd.MaxLength = 20;
            txtSoyad.MaxLength = 20;
            txtSifre1.MaxLength = 10;
            txtSifre2.MaxLength = 10;
        }
        public void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            mskTC.Clear();
            txtSifre1.Clear();
            txtSifre2.Clear();
        }
        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || mskTC.Text == "" || txtSifre1.Text == "" || txtSifre2.Text == "")
            {
                MessageBox.Show("Eksik alan var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAd.Focus();
            }
            else if (!mskTC.MaskFull)
            {
                MessageBox.Show("TCKN hatalı tuşlanmış", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTC.Focus();
            }
            else if (txtSifre1.Text != txtSifre2.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSifre1.Focus();
            }
            else
            {
                SqlCommand komutx = new SqlCommand("SELECT Count(*) FROM Personel where Personeltc='" + mskTC.Text + "'", bgl.baglanti());
                int sonuc = (int)komutx.ExecuteScalar(); //tc yoksa 0 varsa 1
                if (sonuc > 0) //sonuc=1 oldu kayıt var
                {
                    MessageBox.Show("Girdiğiniz TCKN 'nda kayıt bulundu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskTC.Focus();
                }
                else //sonuc=0
                {
                    SqlCommand komutekle = new SqlCommand("DECLARE @id smallint ; insert into Personel (Personeltc, Personelsifre, Personelunvan) " +
                            "values (@tc, @sifre, 'Sekreter') SELECT @id = SCOPE_IDENTITY(); " +
                            "insert into Sekreter (Sekreterisim, Sekreterpersonelid) values (@isim, @id)", bgl.baglanti());
                    komutekle.Parameters.AddWithValue("@tc", mskTC.Text);
                    komutekle.Parameters.AddWithValue("@sifre", hc.PassHash(txtSifre1.Text));
                    komutekle.Parameters.AddWithValue("@isim", txtAd.Text + ' ' + txtSoyad.Text);
                    komutekle.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Sekreter Eklendi.\n\nŞifresi: " + txtSifre1.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    this.Close();
                }
                bgl.baglanti().Close();
            }
        }
        private void checkBoxSifre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSifre.Checked == true)
            {
                txtSifre1.UseSystemPasswordChar = false;
                txtSifre2.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifre1.UseSystemPasswordChar = true;
                txtSifre2.UseSystemPasswordChar = true;
            }
        }
        private void txtSifre1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtSifre1.Text.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(txtSifre1.Text.Substring(i, 1)))
                {
                    MessageBox.Show("Şifre içinde boşluk olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SendKeys.Send("{BS}");
                }
            }
        }
    }
}