using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneKayit
{
    public partial class sifre_deneme : Form
    {
        public sifre_deneme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            var strarray = str.Split(' ');
            label1.Text = null;

            int i = 0;
            int j = 1;
            for (i=0; i<str.Length; i++)
            {
                if (str[i] < str[i + 1] || str[i] > str[i + 1])
                {
                    MessageBox.Show("ardışık sayı girme");
                }                
            }
            MessageBox.Show(Convert.ToString(str[i]));

        }
    }
}
