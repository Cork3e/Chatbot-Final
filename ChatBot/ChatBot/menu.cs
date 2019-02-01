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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            weather weather = new weather();
            weather.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            weather weather = new weather();
            weather.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            xchange xchange = new xchange();
            xchange.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Projects "ConsoleAPplication1" and "ConsoleApplication2" did not run due to sum problems. ////// Please run them separately to view the online chat part.
        }
    }
}
