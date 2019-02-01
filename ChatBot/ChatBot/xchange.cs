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
    public partial class xchange : Form
    {
        public xchange()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string rt1 = richTextBox2.Text;
            richTextBox1.Text += richTextBox2.Text;
            richTextBox2.Text = null;
            switch (rt1)
            {
                case "ir":
                    richTextBox1.Text = "1 USD is 110,105 Iranian Rial";
                    break;

                case "ru":
                    richTextBox1.Text = "1 USD is 13,954.50 Indonesian Rupiah";
                    break;

                case "ca":
                    richTextBox1.Text = "1 USD is 1.31 Canadian Dollar";
                    break;

                case "eu":
                    richTextBox1.Text = "1 USD is 0.87 Euros";
                    break;

                case "help":
                    richTextBox1.Text = "The  inlisted are Iranian Rial, Indonesian Rupiah, Euro and Canadian Dollar \nEnter ir for rial \nEnter ru for Rupiah \nEnter ca for Candian Dollar \nEnter eu for Euro ";
                    break;

                case "back":
                    menu menu = new menu();
                    menu.Show();
                    this.Hide();
                    break;

                default:
                    richTextBox1.Text = "The entered command not recognized, Please enter the correct command or for more questions, contact our Customer Support \n";
                    break;
            }
        }

        private void xchange_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Welcome to the exchange rate bot \n to check the exchange rate of currencies for 1 USD \nThe currencies that are available \nThe  inlisted are Iranian Rial, Indonesian Rupiah, Euro and Canadian Dollar \nEnter ir for rial \nEnter ru for Rupiah \nEnter ca for Candian Dollar \nEnter eu for Euro \nToday, $1 is 42,105.00 Iranian Rial ";
        }
    }
}
