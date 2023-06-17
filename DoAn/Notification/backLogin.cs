using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.Notification
{
    public partial class backLogin : Form
    {
        public backLogin()
        {
            InitializeComponent();
        }
        bool drag = false;
        Point po = new Point(0, 0);
        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            po = new Point(e.X, e.Y);
        }

        private void guna2Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point pt = PointToScreen(e.Location);
                this.Location = new Point(pt.X - po.X, pt.Y - po.Y);
            }
        }


        private void butOK_Click(object sender, EventArgs e)
        {
            ((fLogin)Application.OpenForms["fLogin"]).usLogin1.BringToFront();
            this.Close();
        }

    }
}
