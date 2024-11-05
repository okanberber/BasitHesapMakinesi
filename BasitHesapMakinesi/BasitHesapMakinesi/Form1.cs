using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasitHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            if (tb_sayi1.Text == "")
            {
                tb_sayi1.Text = "0";
            }
            if (tb_sayi2.Text == "")
            {
                tb_sayi2.Text = "0";
            }
            double sayi1=Convert.ToDouble(tb_sayi1.Text);
            double sayi2=Convert.ToDouble(tb_sayi2.Text);
            double sonuc = sayi1 + sayi2;
            tb_sonuc.Text=Convert.ToString(sonuc);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tb_sayi1.Text = "";
            tb_sayi2.Text = "";
            tb_sonuc.Text = "";
        }

        private void btn_cikar_Click(object sender, EventArgs e)
        {
            if (tb_sayi1.Text == "")
            {
                tb_sayi1.Text = "0";
            }
            if(tb_sayi2.Text == "")
            {
                tb_sayi2.Text="0";
            }
            double sayi1=Convert.ToDouble(tb_sayi1.Text);
            double sayi2 = Convert.ToDouble(tb_sayi2.Text);
            double sonuc =sayi1 - sayi2;
            tb_sonuc.Text = Convert.ToString(sonuc);
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            if (tb_sayi1.Text == "")
            {
                tb_sayi1.Text = "0";
            }
            if (tb_sayi2.Text == "")
            {
                tb_sayi2.Text = "0";
            }
            double sayi1 = Convert.ToDouble(tb_sayi1.Text);
            double sayi2 = Convert.ToDouble(tb_sayi2.Text);
            double sonuc = sayi1 * sayi2;
            tb_sonuc.Text = Convert.ToString(sonuc);
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            if (tb_sayi1.Text == "")
            {
                tb_sayi1.Text = "0";
            }
            if (tb_sayi2.Text == "")
            {
                tb_sayi2.Text = "0";
            }
            double sayi1 = Convert.ToDouble(tb_sayi1.Text);
            double sayi2 = Convert.ToDouble(tb_sayi2.Text);
            double sonuc = sayi1 / sayi2;
            tb_sonuc.Text = Convert.ToString(sonuc);
        }
    }
}
