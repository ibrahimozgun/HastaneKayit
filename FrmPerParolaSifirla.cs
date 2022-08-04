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
    public partial class FrmPerParolaSifirla : Form
    {
        public FrmPerParolaSifirla()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        HashCode hc = new HashCode();
        public string id;
        private void FrmParolaSifirla_Load(object sender, EventArgs e)
        {
            txtid.Text = id;
            txtSifre1.MaxLength = 10;
            txtSifre2.MaxLength = 10;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSifre1.Text == "" || txtSifre2.Text == "")
            {
                MessageBox.Show("Şifreyi gir");
            }
            else if (txtSifre1.Text == txtSifre2.Text)
            {
                SqlCommand komut = new SqlCommand("Update Personel set Personelsifre=@sifre where Personelid=" + txtid.Text, bgl.baglanti());
                komut.Parameters.AddWithValue("@sifre", hc.PassHash(txtSifre1.Text));
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yeni Şifre: " + txtSifre1.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSifre1.Clear();
                txtSifre2.Clear();
                txtid.Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void txtSifre2_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtSifre1.Text.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(txtSifre2.Text.Substring(i, 1)))
                {
                    MessageBox.Show("Şifre içinde boşluk olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SendKeys.Send("{BS}");
                }
            }
        }
    }
}
//deneme