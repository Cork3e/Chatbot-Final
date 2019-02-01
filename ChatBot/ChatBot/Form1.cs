using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBot
{
    public partial class Form1 : Form
    {
        string nonamemessage = "Please Enter your username and password";  
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show(nonamemessage);
            }

            else
            {
                menu menu = new menu();
                menu.Show();
                this.Hide();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if ((textBox1.Text == "") || (textBox2.Text == ""))
                {
                    MessageBox.Show(nonamemessage);
                }

                else
                {
                    menu menu = new menu();
                    menu.Show();
                    this.Hide();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
