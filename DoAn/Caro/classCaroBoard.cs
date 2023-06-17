using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace DoAn.Caro
{
    public class classCaroBoard
    {
        public static int chessWidth = 35;
        public static int chessHeight = 35;

        public static int boardWidth = 29;
        public static int boardHeight = 17;


        #region Properties 
        private Panel caroBoard; 
        public Panel CaroBoard { get => caroBoard; set => caroBoard = value; }

        private List<Player> player;
        public List<Player> Player { get => player; set => player = value; }

        public int currentPlayer;
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }

        private Label playerName;
        public Label PlayerName { get => playerName; set => playerName = value; }

        private PictureBox playerMark;
        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }

        private List<List<Button>> matrix;
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

        private event EventHandler<ButtonClickEvent> playerMarked;
        public event EventHandler<ButtonClickEvent> Playermarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }
        #endregion

        #region Initialize        
        public classCaroBoard(Panel caroBoard, Label playerName, PictureBox playerMark)
        {
            this.CaroBoard = caroBoard; //vẽ bàn cờ truyền vào
            this.PlayerName = playerName;
            this.PlayerMark = playerMark;

            this.Player = new List<Player>()
            {
                new Player("Player 1", new Bitmap(DoAn.Properties.Resources.quanX)),
                new Player("Player 2", new Bitmap(DoAn.Properties.Resources.quanY_removebg_preview))
            };


        }
        #endregion

        #region Methods 
        public void drawBoard()
        {
            CaroBoard.Enabled = true;
            CaroBoard.Controls.Clear();
            CurrentPlayer = 0;
            ChangePlayer();

            Matrix = new List<List<Button>>();
            Button oldButton = new Button()
            {
                Width = 0,
                Location = new Point(0, 0),
            };
            for (int i = 0; i < boardHeight; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j <= boardWidth; j++)
                {
                    Button btn = new Button()
                    {
                        Width = chessWidth,
                        Height = chessHeight,
                        Location = new Point(oldButton.Width + oldButton.Location.X, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString(),
                        Cursor = Cursors.Hand
                    };
                    btn.Click += btn_Click;
                    CaroBoard.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + chessHeight); 
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }
        Point crtPoint;
        public void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null) //ko điền vào ô đã có hình
                return;
            Mark(btn);
            CurrentPlayer = (CurrentPlayer == 0) ? 1 : 0; //đổi lượt người chơi khác
            ChangePlayer();
            if (playerMarked != null)
                playerMarked(this, new ButtonClickEvent(getPoint(btn)));

            Color x = btn.BackColor;
            Matrix[crtPoint.Y][crtPoint.X].BackColor = x;
            btn.BackColor = Color.Silver;
            crtPoint = getPoint(btn);

            if (isEndGame(btn))
            {
                EndGame();
            }
        }
        public void OtherPlayerMark(Point point)
        {
            Button btn = Matrix[point.Y][point.X];
            if (btn.BackgroundImage != null)
                return;
            Mark(btn);
            CurrentPlayer = (CurrentPlayer == 0) ? 1 : 0;
            ChangePlayer();


            Color x = btn.BackColor;
            Matrix[crtPoint.Y][crtPoint.X].BackColor = x;
            btn.BackColor = Color.Silver;
            crtPoint = getPoint(btn);



            if (isEndGame(btn))
            {
                EndGame();
            }
        }
        private Point getPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);
            Point point = new Point(horizontal, vertical);
            return point;
        }

        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark; //thêm quân cờ vào ô
        }

        public void ChangePlayer()
        {
            PlayerName.Text = Player[CurrentPlayer].Name;
            PlayerMark.Image = Player[CurrentPlayer].Mark;
        }

        public void EndGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());
        }

        public bool isEndGame(Button btn)
        {
            return isEndHor(btn) || isEndVer(btn) || isEndDia(btn) || isEndDiaSub(btn);
        }


        private bool isEndHor(Button btn) //endgame theo chiều ngang (horizontal)
        {
            Point point = getPoint(btn);
            int countLeft = 0;
            int countRight = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                    countLeft++;
                else
                    break;
            }

            for (int i = point.X + 1; i < boardWidth; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                    countRight++;
                else
                    break;
            }
            return countLeft + countRight == 5;
        }

        private bool isEndVer(Button btn) //endgame theo chiều dọc (vertical)
        {
            Point point = getPoint(btn);
            int countUp = 0;
            int countDown = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                    countUp++;
                else
                    break;
            }

            for (int i = point.Y + 1; i < boardHeight; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                    countDown++;
                else
                    break;
            }
            return countUp + countDown == 5;
        }

        private bool isEndDia(Button btn) //endgame theo đường chéo phải (diagonal) 
        {
            Point point = getPoint(btn);
            int countUp = 0;
            int countDown = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0) break;
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                    countUp++;
                else
                    break;
            }

            for (int i = 1; i < boardWidth - point.X; i++)
            {
                if (point.X + i >= boardWidth || point.Y + i >= boardHeight) break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                    countDown++;
                else
                    break;
            }
            return countUp + countDown == 5;
        }

        private bool isEndDiaSub(Button btn) //endgame theo đường chéo trái 
        {
            Point point = getPoint(btn);
            int countUp = 0;
            int countDown = 0;
            for (int i = 0; i <= point.Y; i++)
            {
                if (point.Y - i < 0 || point.X + i >= boardWidth) break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                    countUp++;
                else
                    break;
            }

            for (int i = 1; i < boardHeight - point.Y && i <= point.X; i++)
            {
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                    countDown++;
                else
                    break;
            }
            return countUp + countDown == 5;
        }

        #endregion
    }

    public class ButtonClickEvent : EventArgs
    {
        private Point clickedPoint;
        public Point ClickedPoint { get => clickedPoint; set => clickedPoint = value; }
        public ButtonClickEvent(Point point)
        {
            this.ClickedPoint = point;
        }
    }
}