using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace işlemdört
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, topla, cıkar, carp, bol;
            sayi1=Convert.ToInt32(txtSayi1.Text);
            sayi2=Convert.ToInt32(txtSayi2.Text);
            topla = sayi1 + sayi2;
            cıkar=sayi1- sayi2;
            carp=sayi1* sayi2;
            bol = sayi1 / sayi2;
            lblTopla.Text = "Topla: " + topla;
            lblCıkar.Text = "Fark: " + cıkar;
            lblCarp.Text = "Çarpım: " + carp;
            lblBol.Text = "Böl: " + bol;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Peru;
        }
    }
}
