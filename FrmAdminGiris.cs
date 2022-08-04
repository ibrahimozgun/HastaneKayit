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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        HashCode hc = new HashCode();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select *From Admin where Adminnick=@p1 and Adminsifre=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtNick.Text);
                komut.Parameters.AddWithValue("@p2", hc.PassHash(txtPass.Text));
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    FrmAdminDetay frd = new FrmAdminDetay();
                    frd.nick = txtNick.Text;
                    frd.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPass.Clear();
                    txtNick.Focus();
                }
                bgl.baglanti().Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmGirisler frm = new FrmGirisler();
            frm.Show();
            this.Close();
        }
    }
}