using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class classUser
    {
        public int stt { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public byte[] img { get; set; }
        public bool online { get; set; }
        public string username { get; set; }
        public void setSTT(int a)
        {
            this.stt = a;
        }
    }
    
}
