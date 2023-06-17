using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.TabHome
{
    public partial class fTabDoAn : Form
    {
        public fTabDoAn()
        {
            InitializeComponent();
        }
        DoAn13.fMail f;
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DoAN5.fDoAn5 f = new DoAN5.fDoAn5();
            f.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DoAn2.Server s = new DoAn2.Server();
            s.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DoAn2.Client c = new DoAn2.Client();
            c.setAvar(((fHome)Application.OpenForms["fHome"]).butAvarta.Image);
            c.Show();
        }

        private void butMailApp_Click(object sender, EventArgs e)
        {
            DoAn13.fLoginEmail app = new DoAn13.fLoginEmail();
            app.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
