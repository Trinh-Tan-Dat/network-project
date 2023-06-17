using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DoAn.Caro
{
    public class PlayInfor
    {
        private Point point;
        private int currentPlayer;

        public Point Point { get => point; set => point = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }

        public PlayInfor(Point point, int currentplayer)
        {
            this.Point = point;
            this.CurrentPlayer = currentplayer;
        }
    }
}
