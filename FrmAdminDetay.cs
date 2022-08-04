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
    public partial class FrmAdminDetay : Form
    {
        public FrmAdminDetay()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        public string nick;
        HashCode hc = new HashCode();
        public void Sorgula()
        {
            if (txtPass1.Text.Trim() == txtPass2.Text.Trim())
            {
                btnKaydet.Enabled = true;
                pictureBoxTik.Visible = true;
            }
            else
            {
                btnKaydet.Enabled = false;
                pictureBoxTik.Visible = false;
            }
        }
        private void FrmAdminDetay_Load(object sender, EventArgs e)
        {
            txtYeniNick.MaxLength = 15;
            txtYeniPass.MaxLength = 10;
            txtNick.Text = nick;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Personelid as 'ID', Personeltc as 'TCKN', Personelunvan as 'Unvan', " +
                "Doktorad+' '+Doktorsoyad as 'Doktor', Sekreterisim as 'Sekreter' From Personel " +
                "left join Doktor on Doktor.Doktorpersonelid=Personel.Personelid " +
                "left join Sekreter on Personel.Personelid=Sekreter.Sekreterpersonelid", bgl.baglanti());
            da.Fill(dt);
            dataGridPer.DataSource = dt;
            bgl.baglanti().Close();
            //Giriş yapılan nick'e bakarak admin ıd'sini ögrenme
            SqlCommand kmt = new SqlCommand("Select Adminid From Admin where Adminnick='" + nick + "'", bgl.baglanti());
            SqlDataReader drr = kmt.ExecuteReader();
            while (drr.Read())
            {
                txtid.Text = drr[0].ToString();
            }
            bgl.baglanti().Close();
        }
        private void txtPass1_TextChanged(object sender, EventArgs e)
        {
            Sorgula();
        }
        private void txtPass2_TextChanged(object sender, EventArgs e)
        {
            Sorgula();
        }
        private void btnYeniKaydet_Click(object sender, EventArgs e)
        {
            if (txtYeniNick.Text == "" || txtYeniPass.Text == "")
            {
                MessageBox.Show("Eksik bilgi var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komutx = new SqlCommand("SELECT Count(*) FROM Admin where Adminnick='" + txtYeniNick.Text + "'", bgl.baglanti());
                int sonuc = (int)komutx.ExecuteScalar(); //tc yoksa 0 varsa 1
                if (sonuc > 0) //sonuc=1 oldu kayıt var
                {
                    MessageBox.Show("Girmiş olduğunuz kullanıcı adında başka bir hesap bulunuyor.\nLütfen başka bir kullanıcı adı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else //sonuc=0 ve tc vt nında bulunmadı
                {
                    SqlCommand komut = new SqlCommand("insert into Admin (Adminnick, Adminsifre) values (@nick , @pass)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@nick", txtYeniNick.Text);
                    komut.Parameters.AddWithValue("@pass", hc.PassHash(txtYeniPass.Text));
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("BAŞARI İLE KAYIT OLUNDU\nKullanıcı Adı: " + txtYeniNick.Text + "\nŞifre: " + txtYeniPass.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtYeniNick.Clear();
                    txtYeniPass.Clear();
                    groupBoxYeniHesap.Visible = false;
                }
                bgl.baglanti().Close();
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select *From Admin where Adminid=@p1 and Adminsifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.Parameters.AddWithValue("@p2", hc.PassHash(txtPass1.Text));
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) //ID ile eski şifreyi karşılaştırıyor. okuma gerçekleşir ise şifre değiştirilebilecek
            {
                try
                {
                    SqlCommand komutx = new SqlCommand("update Admin set Adminsifre=@p1 where Adminid=" + txtid.Text, bgl.baglanti());
                    komutx.Parameters.AddWithValue("@p1", hc.PassHash(txtPassYeni.Text));
                    komutx.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("şifre değiştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPass1.Clear();
                    txtPass2.Clear();
                    txtPassYeni.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                }
            }
            else
            {
                MessageBox.Show("Eski şifreyi yanlış girdin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass1.Clear();
                txtPass2.Clear();
                txtPass1.Focus();
            }
        }
        private void checkBoxSifre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSifre.Checked == true)
            {
                txtPass1.UseSystemPasswordChar = false;
                txtPass2.UseSystemPasswordChar = false;
                txtPassYeni.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass1.UseSystemPasswordChar = true;
                txtPass2.UseSystemPasswordChar = true;
                txtPassYeni.UseSystemPasswordChar = true;
            }
        }
        private void btnAnaEkran_Click(object sender, EventArgs e)
        {
            FrmGirisler frm = new FrmGirisler();
            frm.Show();
            this.Hide();
        }
        private void dataGridPer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridPer.SelectedCells[0].RowIndex; //seçilen hücrenin 0ıncı indexinin data gridini alır 
            txtPerSilid.Text = dataGridPer.Rows[secilen].Cells[0].Value.ToString();
            txtPerSilUnvan.Text = dataGridPer.Rows[secilen].Cells[2].Value.ToString();
        }
        private void dataGridPer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if içine evet hayır sorma
            if (MessageBox.Show("Seçmiş olduğunuz personelin şifresini sıfırlamak istiyor musunuz?", "Şifre Sıfırlama", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int secilen = dataGridPer.SelectedCells[0].RowIndex; //seçilen hücrenin 0ıncı indexinin data gridini alır 
                FrmPerParolaSifirla frp = new FrmPerParolaSifirla();
                frp.id = dataGridPer.Rows[secilen].Cells[0].Value.ToString(); //row=satır cell=hücre
                frp.Show();
            }
        }
        private void linkParolaSifirla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBoxCarpi_Click(sender, e);
            pictureBoxCarpi2_Click(sender, e);
            pictureBoxCarpi3_Click(sender, e);
            MessageBox.Show("Parolasını sıfırlamak istediğin personele tablodan çift tıkla", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void linkSifreDegis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBoxSifreDegis.Visible = true;
            txtPassYeni.MaxLength = 10;
            pictureBoxCarpi2_Click(sender, e);
            pictureBoxCarpi3_Click(sender, e);
        }
        private void linkYeniHesap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBoxYeniHesap.Visible = true;
            txtYeniNick.MaxLength = 15;
            txtYeniPass.MaxLength = 10;
            pictureBoxCarpi_Click(sender, e);
            pictureBoxCarpi3_Click(sender, e);
        }
        private void linkPerSil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBoxPerSil.Visible = true;
            pictureBoxCarpi_Click(sender, e);
            pictureBoxCarpi2_Click(sender, e);
        }
        private void pictureBoxCarpi_Click(object sender, EventArgs e)
        {
            groupBoxSifreDegis.Visible = false;
            txtPass1.Clear();
            txtPass2.Clear();
            txtPassYeni.Clear();
            pictureBoxTik.Visible = false;
        }
        private void pictureBoxCarpi2_Click(object sender, EventArgs e)
        {
            groupBoxYeniHesap.Visible = false;
            txtYeniNick.Clear();
            txtYeniPass.Clear();
        }
        private void pictureBoxCarpi3_Click(object sender, EventArgs e)
        {
            groupBoxPerSil.Visible = false;
            txtPerSilid.Clear();
            txtPerSilUnvan.Clear();
        }
        private void btnPerSil_Click(object sender, EventArgs e)
        {
            if (txtPerSilUnvan.Text == "Doktor")
            {
                MessageBox.Show("Sistemden doktorları sadece sekreterler silebilir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPerSilid.Clear();
                txtPerSilUnvan.Clear();
            }
            else if (txtPerSilUnvan.Text == "Sekreter")
            {
                if (MessageBox.Show("Sekreterin kaydını silmek istiyor musunuz? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlCommand komut = new SqlCommand("delete From Personel where Personelid=@id; delete From Sekreter where Sekreterpersonelid=@idx", bgl.baglanti());
                    komut.Parameters.AddWithValue("@id", txtPerSilid.Text);
                    komut.Parameters.AddWithValue("@idx", txtPerSilid.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Sekreterin kaydı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmAdminDetay_Load(sender, e);
                }
                else
                {
                    txtPerSilUnvan.Clear();
                    txtPerSilid.Clear();
                }
            }
            else
                MessageBox.Show("Hata oluştu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void linkSekreterEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSekreterKayit frm = new FrmSekreterKayit();
            frm.Show();
        }

        private void linkLoad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAdminDetay_Load(sender, e);
        }

        private void txtYeniPass_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtYeniPass.Text.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(txtYeniPass.Text.Substring(i, 1)))
                {
                    MessageBox.Show("Şifre içinde boşluk olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SendKeys.Send("{BS}");
                }
            }
        }

        private void txtPassYeni_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtPassYeni.Text.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(txtPassYeni.Text.Substring(i, 1)))
                {
                    MessageBox.Show("Şifre içinde boşluk olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SendKeys.Send("{BS}");
                }
            }
        }
    }
}