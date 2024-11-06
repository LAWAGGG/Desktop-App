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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void kalkulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 calculatorForm = new Form3();
            calculatorForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bangunDatarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRumus operasi = new FormRumus();
            operasi.Show();
            this.Hide();
        }

        private void keluarrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bangunRuangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangunRuang br = new BangunRuang();
            br.Show();
            this.Hide();
        }
    }
}
