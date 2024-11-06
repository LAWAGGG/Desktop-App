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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = TBUsername.Text;
            string password = TBPassword.Text;
            string role = Role.Text;

            if (username == "Mangtoy" && password == "1" && role == "admin")
            {
                Form2 Menu = new Form2();
                Menu.Show();
                this.Hide();
                
            }
            else if (username == "user" && password == "12" && role == "user")
            {
                Form3 kalku = new Form3();
                kalku.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah", "login gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void TBUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
