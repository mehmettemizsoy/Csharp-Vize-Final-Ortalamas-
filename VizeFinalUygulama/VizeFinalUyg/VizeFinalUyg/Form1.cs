using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeFinalUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float vize;
        float final;
        float ortalama;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            vize = float.Parse(txtVize.Text);
            final = float.Parse(txtFinal.Text);
            float vizeYuzdeOtuz = (vize * 30) / 100;
            float finalYuzdeYetmis = (final * 70) / 100;
            ortalama = vizeYuzdeOtuz + finalYuzdeYetmis;
            lblOrtalama.Text = ortalama.ToString();
            if (ortalama < 20)
            {
                lblHarf.Text = "FF";
            }
            if (ortalama >= 20 && ortalama < 40)
            {
                lblHarf.Text = "DD";
            }
            if(ortalama>=40 && ortalama < 60)
            {
                lblHarf.Text = "CC";
            }
            if(ortalama>=60 && ortalama < 80)
            {
                lblHarf.Text = "BB";
            }
            if(ortalama>=80 && ortalama <= 100)
            {
                lblHarf.Text = "AA";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
