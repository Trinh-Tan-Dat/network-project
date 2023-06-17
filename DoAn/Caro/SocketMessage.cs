using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DoAn.Caro
{
    [Serializable]
    public class SocketMessage
    {
        private int command;
        public int Command { get => command; set => command = value; }

        private Point point;
        public Point Point { get => point; set => point = value; }


        private string messege;
        public string Messege { get => messege; set => messege = value; }
        private byte[] dataSize;
        public byte[] DataSize { get => dataSize; set => dataSize = value; }
        private byte[] data;
        public byte[] Data { get => data; set => data = value; }
        public SocketMessage(int command, Point point, string messege)
        {
            this.Command = command;
            this.Point = point;
            this.Messege = messege;
        }
        public SocketMessage(int command, byte[] dataSize, byte[] data, string message)
        {
            this.command = command;
            this.DataSize = dataSize;
            this.Data = data;
            this.Messege = message;
        }
    }

    public enum SocketCommand
    {
        SEND_POINT,
        NEW_GAME,
        RQ_NEW_GAME,
        QUIT,
        START,
        CONNECT,
        ENDGAME,
        RUNTIME,
        RESET,
        REFUSE,
        SENDMESSAGE,
        SENDFILE
    }
}
