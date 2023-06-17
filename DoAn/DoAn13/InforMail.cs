using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DoAn13
{
    public class InforMail
    {
        public string subject { get; set; }
        public string date { get; set; }
        public string from { get; set; }
        public string num { get; set; }
        public string body { get; set; }
        public string bodytext { get; set; }

        public void set(string num, string from, string subject, string date, string body, string bodytext)
        {
            this.subject = subject;
            this.date = date;
            this.from = from;
            this.num = num;
            this.body = body;
            this.bodytext = bodytext;
        }    
    }
}
