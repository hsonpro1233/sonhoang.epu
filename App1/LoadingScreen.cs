using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class LoadingScreen : Form
    {
        Random rnd = new Random();
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2CircleProgressBar1.Value = 0;
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2CircleProgressBar1.Increment(rnd.Next(10,30));
            label1.Text = (label1.Text == "Loading...") ? "Loading" : (label1.Text + ".");
            if (guna2CircleProgressBar1.Value >= 300)
            {
                Form x = new LoginForm();
                x.Show();
                timer1.Stop();
                this.Hide();
            };
        }
    }
}
