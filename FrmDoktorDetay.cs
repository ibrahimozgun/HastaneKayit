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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        public void tarihlerA() //giriş ekranındaki girişe tıklayınca yükleniyor  //loadın içine koyunca her muayene sonu kaydete basınca tarih sayısı artıyor
        {
            //tarihleri comcoBox'a çekme
            SqlCommand komut = new SqlCommand("select DISTINCT Randevutarih from Randevu where Randevudoktorid='" + lbldrid.Text + "' and " +
                                                "Randevu.Randevutarih >= getdate()-1 ORDER BY Randevutarih", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader(); //veri okuyucuyu çalıştırıyor
            while (dr.Read())
            {
                cmbtarihlerA.Items.Add(dr["Randevutarih"]); //dr[0] id leri tutuyor ama bransad olunca adlar 0
            }
            bgl.baglanti().Close();
        }
        public void tarihlerG()
        {
            SqlCommand komut = new SqlCommand("select DISTINCT Randevutarih from Randevu where Randevudoktorid='" + lbldrid.Text + "' and " +
                                                "Randevu.Randevutarih < getdate()-1 ORDER BY Randevutarih DESC", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader(); //veri okuyucuyu çalıştırıyor
            while (dr.Read())
            {
                cmbtarihlerG.Items.Add(dr[0]); //dr[0] id leri tutuyor ama bransad olunca adlar 0
            }
            bgl.baglanti().Close();
        }
        public void Aktif_Randevu()
        {
            //AKTIF RANDEVULAR
            DataTable dtx = new DataTable();
            SqlDataAdapter dax = new SqlDataAdapter("Select Randevuid as 'ID', Randevutarih as 'Tarih', Randevusaat as 'Saat', Doktorad +' '+ Doktorsoyad as 'Doktor', " +
                "Hastaid as 'H.ID', Hastaisim as 'Hasta', Hastatc as 'Hasta TC', Hastatelefon, Hastasikayet as 'Şikayet', Randevuozet as 'Muayene Sonrası' From Randevu " +
                "inner join Doktor on Randevu.Randevudoktorid=Doktor.Doktorid " +
                "inner join Hasta on Randevu.Randevuhastaid=Hasta.Hastaid where Randevudoktorid='" + lbldrid.Text + "' and Randevu.Randevutarih >= getdate()-1 " +
                "ORDER BY Randevutarih, Randevusaat", bgl.baglanti());
            dax.Fill(dtx);
            dataGridAktif.DataSource = dtx;
            bgl.baglanti().Close();
            dataGridAktif.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridAktif.Columns[4].DisplayIndex = 9;
        }
        public void Gecmis_Randevu()
        {
            //GECMIS RANDEVULAR
            DataTable dty = new DataTable();
            SqlDataAdapter day = new SqlDataAdapter("Select Randevuid as 'ID', Randevutarih as 'Tarih', Randevusaat as 'Saat', Doktorad +' '+ Doktorsoyad as 'Doktor', " +
                "Hastaid as 'H.ID', Hastaisim as 'Hasta', Hastatc as 'Hasta TC', Hastatelefon, Hastasikayet as 'Şikayet', Randevuozet as 'Muayene Sonrası' From Randevu " +
                "inner join Doktor on Randevu.Randevudoktorid=Doktor.Doktorid " +
                "inner join Hasta on Randevu.Randevuhastaid=Hasta.Hastaid where Randevudoktorid='" + lbldrid.Text + "' and Randevu.Randevutarih < getdate()-1 " +
                "ORDER BY Randevutarih DESC, Randevusaat", bgl.baglanti());
            day.Fill(dty);
            dataGridGecmis.DataSource = dty;
            bgl.baglanti().Close();
            dataGridGecmis.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridAktif.Columns[4].DisplayIndex = 9;
        }
        public string TC;
        sqlbaglantısı bgl = new sqlbaglantısı();
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblizinbas.Text = null;
            lblizinbit.Text = null;
            btnrandevukaydet.Enabled = false;
            lbltc.Text = TC;
            lbltarih.Text = DateTime.Now.ToShortDateString(); // sadece tarih
            //doktorun tc sine bakarak personel idsini bulma
            SqlCommand komut = new SqlCommand("Select Personelid From Personel " +
                                              "where Personeltc=" + lbltc.Text, bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblperid.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
            //doktorun personelid sine bakarak doktor id sini bulma
            SqlCommand komut2 = new SqlCommand("Select Doktorid, Doktorad+' '+Doktorsoyad, Doktorizinbas, Doktorizinson From Doktor where Doktorpersonelid=" + lblperid.Text, bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lbldrid.Text = dr2[0].ToString();
                lbladsoyad.Text = dr2[1].ToString();
                lblizinbas.Text = dr2[2].ToString();
                lblizinbit.Text = dr2[3].ToString();
            }
            bgl.baglanti().Close();

            if (lblizinbas.Text != "")
            {
                DateTime timeizin = Convert.ToDateTime(lblizinbas.Text);
                DateTime timeson = Convert.ToDateTime(lblizinbit.Text);
                DateTime timenow = Convert.ToDateTime(lbltarih.Text);
                lblizinbas.Text = timeizin.ToShortDateString();
                lblizinbit.Text = timeson.ToShortDateString();

                if (timeizin <= timenow && timenow <= timeson)
                {
                    btnizinal.Enabled = false;
                    lblizindurum.Text = "İzinli";
                }
                else
                {
                    btnizinal.Enabled = true;
                    lblizindurum.Text = "İzinli Değil";
                }
            }
            else
            {
                lblizindurum.Text = "İzinli Değil";
            }
            Aktif_Randevu();
            Gecmis_Randevu();
        }
        private void btnbilgiduzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle frd = new FrmDoktorBilgiDuzenle();
            frd.doktorid = lbldrid.Text;
            frd.doktortc = lbltc.Text;
            frd.Show();
        }
        private void btnduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frd = new FrmDuyurular();
            frd.Show();
        }
        private void btncikis_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void btnanaekran_Click(object sender, EventArgs e)
        {
            FrmGirisler frm = new FrmGirisler();
            this.Close();
            frm.Show();
        }
        private void btnrandevukaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Randevu set Randevuozet=@p1 where Randevuid=" + txtid.Text, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", richtxtMuayene.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("muayene sonu bilgiler eklendi");
            richtxtMuayene.Clear();
            FrmDoktorDetay_Load(sender, e);
        }
        private void btnizin_Click(object sender, EventArgs e)
        {
            TimeSpan sonuc = dateTimePicker2.Value.Date - dateTimePicker1.Value.Date;
            int izinTop;
            int izin;

            SqlCommand komutt = new SqlCommand("Select Doktorizinbas, Doktorizinson From Doktor where Doktorid=" + lbldrid.Text, bgl.baglanti());
            SqlDataReader drr = komutt.ExecuteReader();
            drr.Read();
            string izin1 = drr[0].ToString();
            string izin2 = drr[1].ToString();
            bgl.baglanti().Close();

            if (izin1 == "" || izin2 == "")
            {
                if (dateTimePicker1.Value > DateTime.Now)
                {
                    if (dateTimePicker1.Value < dateTimePicker2.Value)
                    {
                        if (sonuc.Days <= 15)
                        {
                            SqlCommand komut2 = new SqlCommand("select Doktorizintop From Doktor where Doktorid=" + lbldrid.Text, bgl.baglanti());
                            izinTop = Convert.ToInt32(komut2.ExecuteScalar());
                            izin = izinTop + sonuc.Days;

                            if (izin < 22)
                            {
                                SqlCommand komut = new SqlCommand("Update Doktor set Doktorizinbas=@t1, Doktorizinson=@t2, Doktorizintop=@t3 where Doktorid=" + lbldrid.Text, bgl.baglanti());
                                komut.Parameters.AddWithValue("@t1", dateTimePicker1.Value);
                                komut.Parameters.AddWithValue("@t2", dateTimePicker2.Value);
                                komut.Parameters.AddWithValue("@t3", izin);
                                komut.ExecuteNonQuery();
                                bgl.baglanti().Close();
                                MessageBox.Show("İzin eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dateTimePicker1.ResetText();
                                dateTimePicker2.ResetText();
                                FrmDoktorDetay_Load(sender, e);
                            }
                            else
                                MessageBox.Show("Toplam izin" + izin + "gün oluyor.\nToplam 21 günü geçemez");
                        }
                        else
                            MessageBox.Show("15 Günden fazla izin alınamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("bitiş tarihi yanlış", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("izin yarından itibaren başlamalı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("İzin varken başka izin alınamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnizinson_Click(object sender, EventArgs e)
        {
            //int izin;
            //SqlCommand komut2 =new SqlCommand("select Doktorizinbas=@p1, Doktorizinson=@p2, Doktorizintop=@p3 where Doktorid="+)

            SqlCommand komut = new SqlCommand("Update Doktor set Doktorizinbas=NULL, Doktorizinson=NULL where Doktorid='" + lbldrid.Text + "'", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("İzin silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmDoktorDetay_Load(sender, e);
        }
        private void dataGridGecmis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnrandevukaydet.Enabled = true;
            int secilen = dataGridGecmis.SelectedCells[0].RowIndex;
            richTxtSikayet.Text = dataGridGecmis.Rows[secilen].Cells[8].Value.ToString();
            txtid.Text = dataGridGecmis.Rows[secilen].Cells[0].Value.ToString();
            richtxtMuayene.Text = dataGridGecmis.Rows[secilen].Cells[9].Value.ToString();
            txtidsil.Text = null;
        }
        private void dataGridAktif_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnrandevukaydet.Enabled = true;
            int secilen = dataGridAktif.SelectedCells[0].RowIndex;
            richTxtSikayet.Text = dataGridAktif.Rows[secilen].Cells[8].Value.ToString();
            txtid.Text = dataGridAktif.Rows[secilen].Cells[0].Value.ToString();
            richtxtMuayene.Text = dataGridAktif.Rows[secilen].Cells[9].Value.ToString();
            txtidsil.Text = null;
        }
        private void dataGridGecmis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridGecmis.SelectedCells[0].RowIndex;
            txtidsil.Text = dataGridGecmis.Rows[secilen].Cells[0].Value.ToString();
        }
        private void dataGridAktif_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridAktif.SelectedCells[0].RowIndex;
            txtidsil.Text = dataGridAktif.Rows[secilen].Cells[0].Value.ToString();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtidsil.Text != "")
            {
                if (MessageBox.Show(txtidsil.Text + " ID'li Randevuyu silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlCommand sil = new SqlCommand("delete from Randevu where Randevuid=" + txtidsil.Text, bgl.baglanti());
                    sil.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    FrmDoktorDetay_Load(sender, e);
                    txtidsil.Text = null;
                }
                else
                {
                    txtidsil.Text = null;
                }
            }
            else
            {
                MessageBox.Show("Silinecek Randevunun ID si bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cmbtarihlerA_SelectedIndexChanged(object sender, EventArgs e) //o tarihteki randevular
        {
            if (cmbtarihlerA.Text == "")
            {
                // date null old. için patlıyordu
            }
            else
            {
                // comboBOx daki tarihler yyyy-mm-dd oldğ. için hata veriyordu splitle tarihi ayrırıp geri birleştirdik
                string value = cmbtarihlerA.SelectedItem.ToString().Split(' ')[0];
                string yil = value.Split('.')[2];
                string ay = value.Split('.')[1];
                string gun = value.Split('.')[0];
                string date = yil + "-" + (ay.Length > 1 ? ay : "0" + ay) + "-" + (gun.Length > 1 ? gun : "0" + gun);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select Randevuid as 'ID', Randevutarih as 'Tarih', Randevusaat as 'Saat', Doktorad +' '+ Doktorsoyad as 'Doktor', " +
                    "Hastaid as 'H.ID', Hastaisim as 'Hasta', Hastatc as 'Hasta TC', Hastatelefon, Hastasikayet as 'Şikayet', Randevuozet as 'Muayene Sonrası' From Randevu " +
                    "inner join Doktor on Randevu.Randevudoktorid=Doktor.Doktorid " +
                    "inner join Hasta on Randevu.Randevuhastaid=Hasta.Hastaid where Randevudoktorid='" + lbldrid.Text + "' and " +
                    "Randevutarih= cast('" + date + "'as date) and Randevu.Randevutarih >= getdate()-1 " +
                    "ORDER BY Randevutarih, Randevusaat", bgl.baglanti());
                da.Fill(dt);
                dataGridAktif.DataSource = dt;
                bgl.baglanti().Close();
                dataGridAktif.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridAktif.Columns[4].DisplayIndex = 9;
            }
        }
        private void cmbtarihlerG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtarihlerG.Text == "")
            {
            }
            else
            {
                string value = cmbtarihlerG.SelectedItem.ToString().Split(' ')[0];
                string yil = value.Split('.')[2];
                string ay = value.Split('.')[1];
                string gun = value.Split('.')[0];
                string date = yil + "-" + (ay.Length > 1 ? ay : "0" + ay) + "-" + (gun.Length > 1 ? gun : "0" + gun);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select Randevuid as 'ID', Randevutarih as 'Tarih', Randevusaat as 'Saat', Doktorad +' '+ Doktorsoyad as 'Doktor', " +
                                "Hastaid as 'H.ID', Hastaisim as 'Hasta', Hastatc as 'Hasta TC', Hastatelefon, Hastasikayet as 'Şikayet', Randevuozet as 'Muayene Sonrası' From Randevu " +
                                "inner join Doktor on Randevu.Randevudoktorid=Doktor.Doktorid " +
                                "inner join Hasta on Randevu.Randevuhastaid=Hasta.Hastaid where Randevudoktorid='" + lbldrid.Text + "' and " +
                                "Randevutarih='" + date + "' and Randevu.Randevutarih < getdate()-1 " +
                                "ORDER BY Randevutarih DESC, Randevusaat", bgl.baglanti());
                da.Fill(dt);
                dataGridGecmis.DataSource = dt;
                bgl.baglanti().Close();
                dataGridGecmis.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridGecmis.Columns[4].DisplayIndex = 9;
            }
        }
        private void btnfiltretemizleA_Click(object sender, EventArgs e)
        {
            //AKTIF RANDEVULAR
            Aktif_Randevu();
            cmbtarihlerA.Text = null;
        }
        private void btnfiltretemizleG_Click(object sender, EventArgs e)
        {
            //GECMIS RANDEVULAR
            Gecmis_Randevu();
            cmbtarihlerG.Text = null;
        }
    }
}