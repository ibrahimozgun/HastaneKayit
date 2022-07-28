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
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            //datagridview e randevu listeleme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From Tbl_Randevular", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tarih";
            dataGridView1.Columns[2].HeaderText = "Saat";
            dataGridView1.Columns[3].HeaderText = "Branş";
            dataGridView1.Columns[4].HeaderText = "Doktor";
            dataGridView1.Columns[5].HeaderText = "Durum";
            dataGridView1.Columns[6].HeaderText = "Hasta TC";
            dataGridView1.Columns[0].Width=39; //id genişliği
        }

        //public int secilen;
        // https://www.udemy.com/course/sifirdan-ileri-seviye-csharp-programlama/learn/lecture/8388878#overview
        // tablodan bir randevuya çıft tıklayınca veriler sekreter detaya gidecek 
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //yap
        }
    }
}
