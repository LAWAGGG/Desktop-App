using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coba
{
    public partial class FormRumus : Form
    {
        public FormRumus()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Menu = new Form2();
            Menu.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TBHasil_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            double panjang = double.Parse(TB1.Text);
            double lebar = double.Parse(TB2.Text);

            double luas = panjang * lebar;
            double keliling = 2 * (panjang + lebar);

            TBHasil.Text = luas.ToString();
            TBHasil1.Text = keliling.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double sisi = double.Parse(TBSisi.Text);

            double keliling = sisi * sisi;

            TBH1.Text = keliling.ToString();
        }

        private void FormRumus_Load(object sender, EventArgs e)
        {

        }

        private void HasilLingkaran_Click(object sender, EventArgs e)
        {
            double Jaring = double.Parse(InputR.Text);

            double keliling = 2 * 3.14 * Jaring;
            double Luas = 3.14 * Jaring*Jaring;

            LuasLingkaran.Text = Luas.ToString();
            KelilingLingkaran.Text = keliling.ToString();
            

        }

        private void TBSisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBH1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(SisiA.Text);
            double b = double.Parse(SisiB.Text);
            double c = double.Parse(SisiC.Text);
            double d = double.Parse(SisiD.Text);
            double tinggi = double.Parse(Tinggi.Text);

            double Keliling = a+b+c+d;
            double luas = 0.5 * (a + b) * tinggi;

            KelilingTrapesium.Text = Keliling.ToString();
            LuasTrapesium.Text = luas.ToString();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            double a = double.Parse(TBa.Text);
            double b = double.Parse(TBb.Text);
            double tinggi = double.Parse(TBt.Text);
            double alas = double.Parse(TBalas.Text);

            double keliling = 2 * (a + b);
            double Luas = alas * tinggi;

            KelilingJajarGenjang.Text= keliling.ToString();
            LuasJajarGenjang.Text = Luas.ToString();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double D1 = double.Parse(Diagonal1.Text);
            double D2 = double.Parse(Diagonal2.Text);
            double sisi = double.Parse(SisiBK.Text);

            double luas = 0.5 * D1 * D2;
            double keliling = 4 * sisi;

            KelilingBelahKetupat.Text= keliling.ToString();
            LuasBelahKetupat.Text= luas.ToString();
        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double D1 = double.Parse(Diagonal1LL.Text);
            double D2 = double.Parse (Diagonal2LL.Text);
            double a = double.Parse(SisiALL.Text);
            double b = double.Parse(SisiBLL.Text);

            double luas = 0.5 * D1 * D2;
            double keliling = 2 * (a + b);

            KelilingLayang.Text= keliling.ToString();   
            LuasLayang.Text= luas.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double al = double.Parse(AlasSegi.Text);
            double ti = double.Parse(TinggiSegi.Text);
            double sis = double.Parse(SisiSegi.Text);

            double Luas = 1.0/2.0 * al * ti;
            double keliling = 3 * sis;

            KelilingSegi.Text= keliling.ToString();
            LuasSegi.Text= Luas.ToString();
        }
    }
}
