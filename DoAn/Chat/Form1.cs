using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1.PerformClick();
            }    
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            usMyMessage1.setLabelMessage(textBox1.Text);
            usYourMessage1.setLabelMessage(textBox1.Text);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DoAn2.Client c = new DoAn2.Client();
            c.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DoAn2.Server s = new DoAn2.Server();
            s.Show();
        }
    }
}
