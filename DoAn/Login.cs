using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAn
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        public string strConnection = @"Data Source=server-asia.database.windows.net;Initial Catalog=DoAn;User ID=dangnguyen03;Password=Danghaha123vn";
        public SqlConnection sql = null;
        public void DisconnectSQL()
        {
            if (sql != null && sql.State ==ConnectionState.Open)
            {
                sql.Close();
            }    
        }    
        private void fLogin_Load(object sender, EventArgs e)
        {
            try
            {
                if (sql == null)
                {
                    sql = new SqlConnection(strConnection);
                }  
                if (sql.State == ConnectionState.Closed)
                {
                    sql.Open();
                }    
            }
            catch
            {
                failConnect1.BringToFront();
            }
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

        private void usLogin1_Load(object sender, EventArgs e)
        {

        }

        private void fLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisconnectSQL();
        }
    }
}
