using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Coba
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(TBIsi.Text);
            TBIsi.Clear();
            TBIsi.Focus();
            count = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TBIsi.Text = TBIsi.Text + 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TBIsi.Text = TBIsi.Text + 3;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           Close();
        }

        private void satu_Click(object sender, EventArgs e)
        {
            TBIsi.Text = TBIsi.Text + 1;
        }

        private void empat_Click(object sender, EventArgs e)
        {
            TBIsi.Text = TBIsi.Text + 4;
        }

        private void lima_Click(object sender, EventArgs e)
        {
            TBIsi.Text = TBIsi.Text + 5;
        }

        private void enam_Click(object sender, EventArgs e)
        {
            TBIsi.Text = TBIsi.Text + 6;
        }

        private void tujuh_Click(object sender, EventArgs e)
        {
            TBIsi.Text = TBIsi.Text + 7;
        }

        private void delapan_Click(object sender, EventArgs e)
        {
            TBIsi.Text = TBIsi.Text + 8;
        }

        private void sembilan_Click(object sender, EventArgs e)
        {
            TBIsi.Text = TBIsi.Text + 9;
        }

        private void nol_Click(object sender, EventArgs e)
        {
            TBIsi.Text = TBIsi.Text + 0;
        }

        private void koma_Click(object sender, EventArgs e)
        {
            TBIsi.Clear();
        }

        private void kurang_Click(object sender, EventArgs e)
        {
            if (TBIsi.Text != "") 
            {
                num1 = float.Parse(TBIsi.Text);
                TBIsi.Clear();
                TBIsi.Focus();
                count = 1;
            }
           
        }

        private void kali_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(TBIsi.Text);
            TBIsi.Clear();
            TBIsi.Focus();
            count = 3;
        }

        private void bagi_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(TBIsi.Text);
            TBIsi.Clear();
            TBIsi.Focus();
            count = 4;
        }

        private void TBIsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void samadengan_Click(object sender, EventArgs e)
        {
            compute(count);
        }
        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(TBIsi.Text);
                    TBIsi.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(TBIsi.Text);
                    TBIsi.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(TBIsi.Text);
                    TBIsi.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(TBIsi.Text);
                    TBIsi.Text = ans.ToString();
                    break;

                  
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int c = TBIsi.TextLength;
            int flag = 0;
            string text = TBIsi.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ",")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                TBIsi.Text = TBIsi.Text + ",";
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
         
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

