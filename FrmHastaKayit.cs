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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        private void FrmHastaKayit_Load(object sender, EventArgs e)
        {
            txtad.MaxLength = 20;
            txtsoyad.MaxLength = 20;
        }
        private void btnkayityap_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "" || txtsoyad.Text == "" || msktc.Text == "" || msktelefon.Text == "" || cmbcinsiyet.Text == "")
            {
                MessageBox.Show("Eksik alan var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtad.Focus();
            }
            else
            {
                if (msktc.MaskFull && msktelefon.MaskFull)
                {
                    SqlCommand kmtsor = new SqlCommand("SELECT Count(*) FROM Hasta where Hastatc='" + msktc.Text + "'", bgl.baglanti());
                    int sonuc = (int)kmtsor.ExecuteScalar(); //tc yoksa 0 varsa 1
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Girdiğiniz TCKN 'nda kayıt bulundu.\nKendi TCKN'nızı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else //sonuc=0 ve tc vt nında bulunmadı
                    {
                        SqlCommand komut = new SqlCommand("insert into Hasta (Hastaisim, Hastatc, Hastatelefon, Hastacinsiyet) values (@p1, @p2, @p3, @p4)", bgl.baglanti());
                        komut.Parameters.AddWithValue("@p1", txtad.Text + " " + txtsoyad.Text);
                        komut.Parameters.AddWithValue("@p2", msktc.Text);
                        komut.Parameters.AddWithValue("@p3", msktelefon.Text);
                        komut.Parameters.AddWithValue("@p4", cmbcinsiyet.Text);
                        komut.ExecuteNonQuery(); //sorguyu çalıştırma
                        bgl.baglanti().Close();
                        MessageBox.Show("Kayıt Tamamlandı\nTC'niz: " + msktc.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    bgl.baglanti().Close();
                }
                else
                    MessageBox.Show("TC veya Tel.No. hatalı", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frm = new FrmHastaGiris();
            frm.Show();
            this.Close();
        }
    }
}