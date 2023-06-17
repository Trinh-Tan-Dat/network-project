using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DoAn.Caro
{
    public class Player
    {
        private string name;
        public string Name { get => name; set => name = value; }

        private Bitmap mark;
        public Bitmap Mark { get => mark; set => mark = value; }

        public Player(string name, Bitmap mark)
        {
            this.Name = name;
            this.Mark = mark;
        }
    }

}
