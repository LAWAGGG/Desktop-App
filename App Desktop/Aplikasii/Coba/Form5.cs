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
    public partial class BangunRuang : Form
    {
        public BangunRuang()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sisi = double.Parse(SBol.Text);

            double lp = 6 * sisi * sisi;
            double kel = 12 * sisi;
            double vol = sisi * sisi * sisi;

            LPBol.Text = lp.ToString();
            KelBol.Text = kel.ToString();
            VolBol.Text = vol.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double r = double.Parse(JariBola.Text);

            double lp = 4 * 3.14 * r * r ;
            double vol = 4.0 / 3.0 * 3.14 * r * r * r;

            LPBola.Text = lp.ToString();
            VolumeBola.Text = vol.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double r = double.Parse(JariLS.Text);
            double t = double.Parse(TInggiLS.Text);
            double s = double.Parse(SisiLS.Text);

            double v = 1.0 / 3.0 * 3.14 * r * r * t;
            double lp = (3.14 * r * r) + (3.14 * r * s);

            VolLS.Text = lp.ToString();
            LuasPLS.Text = lp.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            menu.Show();
            this.Close();
        }
    }
}
