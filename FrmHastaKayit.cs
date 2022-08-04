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

        private void btnkayityap_Click(object sender, EventArgs e)
        {
            if(txtad.Text=="" || txtsoyad.Text=="" || 
               msktc.Text=="" || msktelefon.Text=="" || cmbcinsiyet.Text == "")
            {
                MessageBox.Show("Eksik var", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtad.Focus();
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar " +
                    "(Hastaad, Hastasoyad, Hastatc, Hastatelefon, Hastasifre, Hastacinsiyet)" +
                    "values (@p1, @p2, @p3, @p4, @p6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtad.Text);
                komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
                komut.Parameters.AddWithValue("@p3", msktc.Text);
                komut.Parameters.AddWithValue("@p4", msktelefon.Text);
                komut.Parameters.AddWithValue("@p6", cmbcinsiyet.Text);
                komut.ExecuteNonQuery(); //sorguyu çalıştırma
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Tamamlandı\nTC'niz: " + msktc.Text,
                                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}