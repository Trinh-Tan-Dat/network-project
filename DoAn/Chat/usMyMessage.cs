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
    public partial class usMyMessage : UserControl
    {
        public usMyMessage()
        {
            InitializeComponent();
        }
        private void usMyMessage_Resize(object sender, EventArgs e)
        {
            resize();
        }
        void resize()
        {
            this.Height = lbMessage.Height + 2 * lbMessage.Top + 10;
        }
        public void setLabelMessage(string s)
        {
            lbMessage.Text = s;
            resize();
        }
        public void setMyMessage(Image img, string s)
        {
            pictureAvar.Image = img;
            lbMessage.Text = s;
            resize();
        }
        public void setPicture(Image img)
        {
            pictureAvar.Image = img;
        }
    }
}
