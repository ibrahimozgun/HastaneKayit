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
            if(txtad.Text=="" || txtsoyad.Text=="" || txtsifre.Text=="" || cmbbrans.Text == "")
            {
                MessageBox.Show("Eksik var","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtad.Focus();
            }
            else
            {
                SqlCommand komutg = new SqlCommand("Update Tbl_Doktorlar Set " +
                "Doktorad=@g1, Doktorsoyad=@g2, Doktorbrans=@g3, Doktorsifre=@g4 " +
                "where Doktortc=" + msktc.Text, bgl.baglanti());
                komutg.Parameters.AddWithValue("@g1", txtad.Text);
                komutg.Parameters.AddWithValue("@g2", txtsoyad.Text);
                komutg.Parameters.AddWithValue("@g3", cmbbrans.Text);
                komutg.Parameters.AddWithValue("@g4", txtsifre.Text);
                komutg.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show(msktc.Text + " TC Numaralı doktorun bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Windows.Forms.Application.Exit(); //uygulama kapanır
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
            }
        }
    }
}
