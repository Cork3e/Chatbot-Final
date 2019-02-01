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
    
    public partial class weather : Form
    {
        public weather()
        {
            InitializeComponent();
        }

        Random weatherrand = new Random();

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                richTextBox1.Text += richTextBox2.Text;
                richTextBox2.Text = null;

                int a = weatherrand.Next(-20, 40);
                string rt1 = richTextBox2.Text;
                richTextBox1.Text += richTextBox2.Text;
                richTextBox2.Text = null;
                switch (rt1)
                {
                    case "saturday":
                        richTextBox1.Text = "The weather for Saturday is " + a + "C \n";
                        break;

                    case "sunday":
                        richTextBox1.Text = "The weather for Sunday is " + a + "C \n";
                        break;

                    case "monday":
                        richTextBox1.Text = "The weather for Monday is " + a + "C \n";
                        break;

                    case "tuesday":
                        richTextBox1.Text = "The weather for Tuesday is " + a + "C \n";
                        break;

                    case "wednesday":
                        richTextBox1.Text = "The weather for Wednesday is " + a + "C \n";
                        break;

                    case "thursday":
                        richTextBox1.Text = "The weather for Thursday is " + a + "C ";
                        break;

                    case "friday":
                        richTextBox1.Text = "The weather for Friday is " + a + "C \n";
                        break;

                    case "back":
                        menu menu = new menu();
                        menu.Show();
                        this.Hide();
                        break;

                    default:
                        richTextBox1.Text = "Enter a day of the week all in lowr case to see the weather of that day \n To go back to the main manu, enter Back";
                        break;
                }

            }
        }
        private void weather_Load(object sender, EventArgs e)
        {

            int a = weatherrand.Next(-20, 40);
            richTextBox1.Text = "Wlcme to the weather bot \nTo get the weather information of a specific day of this week, \nEnter a day of the week all in lowr case to see the weather of that day \n To go back to the main manu, enter Back \nThe weather today is " + a +"c";
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            int a = weatherrand.Next(-20, 40);
            string rt1 = richTextBox2.Text;
            richTextBox1.Text += richTextBox2.Text;
            richTextBox2.Text = null;
            switch (rt1)
            {
                case "saturday":
                    richTextBox1.Text="The weather for Saturday is " + a + "C \n";
                    break;

                case "sunday":
                    richTextBox1.Text = "The weather for Sunday is " + a + "C \n";
                    break;

                case "monday":
                    richTextBox1.Text = "The weather for Monday is " + a + "C \n";
                    break;

                case "tuesday":
                    richTextBox1.Text = "The weather for Tuesday is " + a + "C \n";
                    break;

                case "wednesday":
                    richTextBox1.Text = "The weather for Wednesday is " + a + "C \n";
                    break;

                case "thursday":
                    richTextBox1.Text = "The weather for Thursday is " + a + "C ";
                    break;

                case "friday":
                    richTextBox1.Text = "The weather for Friday is " + a + "C \n";
                    break;

                case "help":
                    richTextBox1.Text = "Enter a day of the week all in lowr case to see the weather of that day \n To go back to the main manu, enter Back";
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
    }
}
