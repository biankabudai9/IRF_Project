using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beadando
{
    public partial class Game_Form : Form
    {
        databaseEntities context = new databaseEntities();
        Random rnd;
        SavedPlayer player1;
        SavedPlayer player2;
        Color colorOfPlayer1;
        Color colorOfPlayer2;
        SavedPlayer currentPlayer;
        Graphics g;
        bool lost = false;
        bool firstLost = false;
        bool end = false;
        int x = -1;
        int y = -1;
        bool isDrawing = false;
        bool itCanDraw = false;
        bool isFirstGame = true;
        Pen pen;
        int counter;

        List<int> counterOfPlayer1;
        List<int> counterOfPlayer2;

        DirectBitmap dbmp;
        Bitmap firstMap;
        
        List<string> check;
        List<string> checkother;
        List<string> firstcheck;
        Color actualColor;

        
        

        public Game_Form(SavedPlayer playerFirst, SavedPlayer playerSecond, Color colorOfFirst, Color colorOfSecond)
        {
            InitializeComponent();

            player1 = playerFirst;
            player2 = playerSecond;
            colorOfPlayer1 = colorOfFirst;
            colorOfPlayer2 = colorOfSecond;

            getThePlayers();
            getFormElements();
            getPoints();
            getStarted();
            getFirstMap();

        }

        private void getFirstMap()
        {
            rnd = new Random();
            firstMap = new Bitmap("./startMaps/startmap" + rnd.Next(1, 4) + ".bmp");
            firstcheck = new List<string>();
            for (int i = 1; i <= 299; i++)
            {
                for (int j = 1; j <= 299; j++)
                {
                    if (firstMap.GetPixel(i, j) == Color.FromArgb(255, 0, 0, 0))
                    {
                        firstcheck.Add(i + ":" + j);
                        Console.WriteLine(firstcheck.Last());
                    }
                }
            }
        }

        private void getThePlayers()
        {

            counterOfPlayer1 = new List<int>();
            counterOfPlayer2 = new List<int>();
            counterOfPlayer1.Add(0);
            counterOfPlayer2.Add(0);
            label1.Text = player1.name;
            label2.Text = player2.name;
            name1.Text = player1.name;
            name2.Text = player2.name;


        }
        private void getFormElements()
        {
            panel1 = new Panel();
            panel1.Width = 300;
            panel1.Height = 300;
            panel1.Top = 30;
            panel1.Left = (this.ClientSize.Width / 2) - 150;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.BackColor = Color.White;

            panel1.MouseEnter += Panel1_MouseEnter;
            panel1.MouseLeave += Panel1_MouseLeave;
            panel1.MouseDown += Panel1_MouseDown;
            panel1.MouseUp += Panel1_MouseUp;
            panel1.MouseMove += Panel1_MouseMove;

            dbmp = new DirectBitmap(panel1.Width, panel1.Height);
            g = panel1.CreateGraphics();
            pen = new Pen(actualColor, 5);
            this.Controls.Add(panel1);
        }

        private void getStarted()
        {
            check = new List<string>();
            checkother = new List<string>();
            currentPlayer = player1;
            actualColor = colorOfPlayer1;
        }

        private void getPoints()
        {
            score1.Text = counterOfPlayer1.Sum().ToString();
            score2.Text = counterOfPlayer2.Sum().ToString();
            latest1.Text = counterOfPlayer1.Last().ToString();
            latest2.Text = counterOfPlayer2.Last().ToString();
        }

        private bool checkPosition(int x, int y)
        {

            if (x > 299 || x < 0 || y > 299 || y < 0)
            {
                return false;
            }
            return true;

        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (itCanDraw && isDrawing && x != -1 && y != -1)
            {

                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;

                checkPosition(x, y);

                if (checkPosition(x, y))
                {
                    try
                    {
                        dbmp.SetPixel(x - 1, y - 1, actualColor);
                    }
                    catch (Exception)
                    { }
                    try
                    {
                        dbmp.SetPixel(x - 1, y, actualColor);
                    }
                    catch (Exception)
                    { }
                    try
                    {
                        dbmp.SetPixel(x - 1, y + 1, actualColor);
                    }
                    catch (Exception)
                    { }
                    try
                    {
                        dbmp.SetPixel(x, y - 1, actualColor);
                    }
                    catch (Exception)
                    { }
                    try
                    {
                        dbmp.SetPixel(x, y, actualColor);
                    }
                    catch (Exception)
                    { }
                    try
                    {
                        dbmp.SetPixel(x, y + 1, actualColor);
                    }
                    catch (Exception)
                    { }
                    try
                    {
                        dbmp.SetPixel(x + 1, y - 1, actualColor);
                    }
                    catch (Exception)
                    { }
                    try
                    {
                        dbmp.SetPixel(x + 1, y, actualColor);
                    }
                    catch (Exception)
                    { }
                    try
                    {
                        dbmp.SetPixel(x + 1, y + 1, actualColor);
                    }
                    catch (Exception)
                    { }
                }
                else
                {
                    endOfRound();
                }

            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            endOfRound();
        }

        private void endOfRound()
        {
            if (itCanDraw)
            {
                counter = 0;
                isDrawing = false;

                x = -1;
                y = -1;

                
                
                for (int i = 1; i <= panel1.Width-1; i++)
                {
                    for (int j = 1; j <= panel1.Height-1; j++)
                    {
                        if (dbmp.GetPixel(i, j) == colorOfPlayer1)
                        {
                            if (isFirstGame && firstcheck.Contains(i + ":" + j))
                            {
                                firstLost = true;
                            }
                            if (checkother.Contains(i + ":" + j))
                            {
                                
                                end = true;
                            }
                            if (check.Contains(i + ":" + j))
                            {
                                lost = true;
                            }
                            else
                            {
                                check.Add(i + ":" + j);
                            }

                            counter++;
                        }
                        if (dbmp.GetPixel(i, j) == colorOfPlayer2)
                        {

                            if (isFirstGame && firstcheck.Contains(i + ":" + j))
                            {
                                firstLost = true;
                            }
                            if (check.Contains(i + ":" + j))
                            {
                                end = true;
                            }
                            if (checkother.Contains(i + ":" + j))
                            {
                                lost = true;
                            }
                            else
                            {
                                checkother.Add(i + ":" + j);
                            }

                            counter++;
                        }
                    }
                }

                if (lost || end || firstLost)
                {
                    if (firstLost && currentPlayer == player1)
                    {
                        MessageBox.Show(player2.name + " won! Because " + player1.name + " crossed the first line.");
                        pointToPlayer2();
                        this.Close();
                    }
                    if (firstLost && currentPlayer == player2)
                    {
                        MessageBox.Show(player1.name + " won! Because " + player2.name + " crossed the first line.");
                        pointToPlayer1();
                        this.Close();
                    }
                    if (lost && currentPlayer == player1)
                    {
                        MessageBox.Show(player2.name + " won! Because " + player1.name + " crossed his/her own line.");
                        pointToPlayer2();
                        this.Close();
                    }

                    if (lost && currentPlayer == player2)
                    {
                        MessageBox.Show(player1.name + " won! Because " + player2.name + " crossed his/her own line.");
                        pointToPlayer1();
                        this.Close();
                    }

                    else if (end)
                    {
                        itIsTheFinalCount();
                        this.Close();
                    }
                }
                else
                {
                    if (currentPlayer == player1)
                    {
                        counterOfPlayer1.Add(counter);
                    }
                    else
                    {
                        counterOfPlayer2.Add(counter);
                    }
                    panel1.BackColor = Color.Black;
                    panel1.BackColor = Color.White;
                    getPoints();
                    changeplayer();
                }


            }
        }


        private void itIsTheFinalCount()
        {
            if (counterOfPlayer1.Sum() == counterOfPlayer2.Sum())
            {
                MessageBox.Show("Tie");
            }
            else if (counterOfPlayer1.Sum() > counterOfPlayer2.Sum())
            {
                MessageBox.Show(player1.name + " won! Points: " + counterOfPlayer1.Sum());
                pointToPlayer1();
            }
            else
            {
                MessageBox.Show(player2.name + " won! Points: " + counterOfPlayer2.Sum());
                pointToPlayer2();
            }
        }

        private void pointToPlayer1()
        {

            Player p = (from c in context.Players
                        where c.name == player1.name
                        select c).FirstOrDefault();

            p.score++;
            context.SaveChanges();
        }

        private void pointToPlayer2()
        {

            Player p = (from c in context.Players
                        where c.name == player2.name
                        select c).FirstOrDefault();

            p.score++;
            context.SaveChanges();
        }



        private void changeplayer()
        {

            if (currentPlayer == player1)
            {
                currentPlayer = player2;
                actualColor = colorOfPlayer2;
                MessageBox.Show(player1.name + " got " + counterOfPlayer1.Last() + " points! Now it is " + player2.name + "'s round!");

            }

            else
            {
                currentPlayer = player1;
                actualColor = colorOfPlayer1;
                isFirstGame = false;
                MessageBox.Show(player2.name + " got " + counterOfPlayer2.Last() + " points! Now it is " + player1.name + "'s round!");

            }

            pen = new Pen(actualColor, 5);

           

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            x = e.X;
            y = e.Y;
            dbmp = new DirectBitmap(panel1.Width, panel1.Height);
        }

        private void Panel1_MouseLeave(object sender, EventArgs e)
        {
            itCanDraw = false;
        }

        private void Panel1_MouseEnter(object sender, EventArgs e)
        {
            itCanDraw = true;
        }

        
    }
}
