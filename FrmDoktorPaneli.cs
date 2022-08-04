using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace HastaneKayit
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        public string sekreterisim;
        sqlbaglantısı bgl = new sqlbaglantısı();
        private static readonly HashCode hashCode = new HashCode();
        HashCode hc = hashCode;
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            cmbbrans.Items.Clear();
            txtad.MaxLength = 20;
            txtsoyad.MaxLength = 20;
            txtemail.MaxLength = 35;
            txtsifre.MaxLength = 10;
            temizle();
            //txtsekreterisim.Text = sekreterisim;
            txtsekreterisim.Text = sekreterisim;
            //doktorları görüntüleme DataGridView de
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select Personelid as 'Personel ID' , Doktorid as 'Doktor ID', Doktorad as 'Ad', Doktorsoyad as 'Soyad', " +
                "Bransisim as 'Branş', Personeltc as 'TC', Doktortelefon as 'Telefon', Doktormail as 'Mail', " +
                "Doktorsekreter as 'Kaydı yapan sekreter',Doktorkayittarih as 'Kayıt Tarihi' From Doktor " +
                "inner join Brans on Doktor.Doktorbransid=Brans.Bransid " +
                "inner join Personel on Doktor.Doktorpersonelid=Personel.Personelid", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            //dataGridView1.Columns[0].DisplayIndex = 9; .Width = 75; .HeaderText = "Ad";

            //branşları çekme combobox a
            SqlCommand komut = new SqlCommand("select Bransisim from Brans", bgl.baglanti());
            SqlDataReader dr1 = komut.ExecuteReader(); //veri okuyucuyu çalıştırıyor
            while (dr1.Read())
            {
                cmbbrans.Items.Add(dr1[0]); //dr[0] id leri tutuyor ama bransad olunca adlar 0
            }
            bgl.baglanti().Close();

            lbltarih.Text = DateTime.Now.ToShortDateString(); // sadece tarih, saat yok
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtperid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtdoktorid.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbbrans.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            msktc.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            msktelefon.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtemail.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtsifre.Enabled = false;
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            //DOKTOR EKLEME; ilk önce personel sonra doktor
            if (txtad.Text == "" || txtsoyad.Text == "" || cmbbrans.Text == "" || msktc.Text == "" || txtsifre.Text == "" ||
                msktelefon.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("Eksik alan var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtad.Focus();
            }
            else
            {
                try
                {
                    if (!this.txtemail.Text.Contains('@') || !this.txtemail.Text.Contains('.'))
                    {
                        MessageBox.Show("Geçersiz e-mail", "Geçersiz e-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtemail.Focus();
                    }
                    else if (!msktelefon.MaskFull)
                    {
                        MessageBox.Show("Telefon numarası geçersiz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!msktc.MaskFull)
                    {
                        MessageBox.Show("TCKN hatalı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        msktc.Focus();
                    }
                    else
                    {
                        int hata = 2;
                        SqlCommand komut = new SqlCommand("SELECT Personeltc FROM Personel", bgl.baglanti());
                        SqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            if (msktc.Text == dr["Personeltc"].ToString())
                            {
                                MessageBox.Show("Bu TC de bir kullanıcı kayıtlı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                msktc.Clear();
                                msktc.Focus();
                                hata = 1;
                                break;
                            }
                        }
                        bgl.baglanti().Close();
                        if (hata == 2) //girilen tc kayıtlarla eşleşmedi
                        {
                            SqlCommand komutekle = new SqlCommand("DECLARE @id smallint ; insert into Personel (Personeltc, Personelsifre, Personelunvan) " +
                                                                "values (@tc, @sifre, 'Doktor') SELECT @id = SCOPE_IDENTITY(); " +
                                                                "insert into Doktor (Doktorpersonelid, Doktorbransid, Doktorad, Doktorsoyad, Doktortelefon, Doktormail, " +
                                                                "Doktorkayittarih, Doktorsekreter, Doktorizintop) " +
                                                                "values (@id, @brans, @ad, @soyad, @telefon, @mail, GETDATE(), @sekreter, '0')", bgl.baglanti());
                            komutekle.Parameters.AddWithValue("@tc", msktc.Text);
                            komutekle.Parameters.AddWithValue("@sifre", hc.PassHash(txtsifre.Text));
                            komutekle.Parameters.AddWithValue("@unvan", "Doktor");
                            komutekle.Parameters.AddWithValue("@brans", lblbrans.Text);
                            komutekle.Parameters.AddWithValue("@ad", txtad.Text);
                            komutekle.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                            komutekle.Parameters.AddWithValue("@telefon", msktelefon.Text);
                            komutekle.Parameters.AddWithValue("@mail", txtemail.Text);
                            komutekle.Parameters.AddWithValue("@sekreter", txtsekreterisim.Text);
                            komutekle.ExecuteNonQuery();
                            bgl.baglanti().Close();
                            MessageBox.Show("Doktor Eklendi.\n\nŞifresi: " + txtsifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmDoktorPaneli_Load(sender, e); //güncellenen doktor listede yenilenir
                        }
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
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
                        txtemail.Focus();
                    }
                    if (msktc.MaskFull)
                    {
                        komutguncelle.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show(msktc.Text + " TC numaralı doktorun bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmDoktorPaneli_Load(sender, e); //güncellenen doktor listede yenilenir
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir tc girin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        msktc.Focus();
                    }
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtdoktorid.Text == "" || txtperid.Text == "")
            {
                MessageBox.Show("Silmek istediğin doktorun bilgilerine tablodan tıkla", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                msktc.Focus();
            }
            else
            {
                if (MessageBox.Show(txtad.Text + " " + txtsoyad.Text + " silmek istiyor musunuz? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlCommand komutsil = new SqlCommand("delete From Doktor where Doktorid=@drid ; " +
                                                         "delete from Personel where Personelid=@perid ; " +
                                                         "delete from Randevu where Randevudoktorid=@dr", bgl.baglanti());
                    komutsil.Parameters.AddWithValue("@drid", txtdoktorid.Text);
                    komutsil.Parameters.AddWithValue("@perid", txtperid.Text);
                    komutsil.Parameters.AddWithValue("@dr", txtdoktorid.Text);
                    komutsil.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show(txtad.Text + " " + txtsoyad.Text + " silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmDoktorPaneli_Load(sender, e);
                }
                else
                {
                    temizle();
                }
            }
        }
        private void btntemizle_Click_1(object sender, EventArgs e)
        {
            temizle();
        }
        public void temizle()
        {
            txtdoktorid.Clear();
            txtperid.Clear();
            txtad.Clear();
            txtsoyad.Clear();
            cmbbrans.Text = null;
            msktc.Clear();
            msktelefon.Clear();
            txtemail.Clear();
            txtsifre.Clear();
            txtsifre.Enabled = true;
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
        private void txtsifre_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtsifre.Text.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(txtsifre.Text.Substring(i, 1)))
                {
                    MessageBox.Show("Şifre içinde boşluk olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SendKeys.Send("{BS}");
                }
            }
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
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox || item is MaskedTextBox || item is ComboBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show(item, "boş var"); 
                    }
                }
            }
        }
    }
}