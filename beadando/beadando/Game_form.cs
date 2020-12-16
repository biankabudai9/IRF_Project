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
        SavedPlayer player1;
        SavedPlayer player2;
        Color colorOfPlayer1;
        Color colorOfPlayer2;
        SavedPlayer currentPlayer;
        Graphics g;
        bool lost = false;
        bool end = false;
        int x = -1;
        int y = -1;
        bool isDrawing = false;
        bool itCanDraw = false;
        Pen pen;
        Panel panel2;
        int counter;

        List<int> counterOfPlayer1;
        List<int> counterOfPlayer2;

        DirectBitmap teszt;

        List<string> check;
        List<string> checkother;
        Color actualColor = Color.FromArgb(255, 0, 0, 0);


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
            panel1.BackColor = Color.Red;

            panel1.MouseEnter += Panel1_MouseEnter;
            panel1.MouseLeave += Panel1_MouseLeave;
            panel1.MouseDown += Panel1_MouseDown;
            panel1.MouseUp += Panel1_MouseUp;
            panel1.MouseMove += Panel1_MouseMove;

            teszt = new DirectBitmap(panel1.Width, panel1.Height);
            g = panel1.CreateGraphics();
            pen = new Pen(actualColor, 5);
            this.Controls.Add(panel1);
        }

        private void getStarted()
        {
            check = new List<string>();
            checkother = new List<string>();
            currentPlayer = player1;
        }

        private void getPoints()
        {
            score1.Text = counterOfPlayer1.Sum().ToString();
            score2.Text = counterOfPlayer2.Sum().ToString();
            latest1.Text = counterOfPlayer1.Last().ToString();
            latest2.Text = counterOfPlayer2.Last().ToString();
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (itCanDraw && isDrawing && x != -1 && y != -1)
            {

                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;

                try
                {
                    teszt.SetPixel(x - 1, y - 1, actualColor);
                }
                catch (Exception)
                {

                }
                try
                {
                    teszt.SetPixel(x - 1, y, actualColor);
                }
                catch (Exception)
                {

                }
                try
                {
                    teszt.SetPixel(x - 1, y + 1, actualColor);
                }
                catch (Exception)
                {

                }
                try
                {
                    teszt.SetPixel(x, y - 1, actualColor);
                }
                catch (Exception)
                {

                }
                try
                {
                    teszt.SetPixel(x, y, actualColor);
                }
                catch (Exception)
                {
                    endOfRound();
                }
                try
                {
                    teszt.SetPixel(x, y + 1, actualColor);
                }
                catch (Exception)
                {

                }
                try
                {
                    teszt.SetPixel(x + 1, y - 1, actualColor);
                }
                catch (Exception)
                {

                }
                try
                {
                    teszt.SetPixel(x + 1, y, actualColor);
                }
                catch (Exception)
                {

                }
                try
                {
                    teszt.SetPixel(x + 1, y + 1, actualColor);
                }
                catch (Exception)
                {

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

                //MessageBox.Show("másik");
                panel2.BackgroundImage = teszt.Bitmap;
                for (int i = 1; i <= 299; i++)
                {
                    for (int j = 1; j <= 299; j++)
                    {
                        if (teszt.GetPixel(i, j) == colorOfPlayer1)
                        {
                            if (checkother.Contains(i + ":" + j))
                            {
                                MessageBox.Show("Belementél a másikba");
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
                        if (teszt.GetPixel(i, j) == colorOfPlayer2)
                        {
                            if (check.Contains(i + ":" + j))
                            {
                                MessageBox.Show("Belementél a másikba");
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

                if (lost && currentPlayer == player1)
                {
                    MessageBox.Show(player2.name + " győzött");
                }

                if (lost && currentPlayer == player2)
                {
                    MessageBox.Show(player1.name + " győzött");
                }

                if (end && currentPlayer == player1)
                {
                    MessageBox.Show("Számolunk");
                }

                if (end && currentPlayer == player1)
                {
                    MessageBox.Show("Számolunk");
                }

                MessageBox.Show(counter.ToString());
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

        private void changeplayer()
        {

            if (currentPlayer == player1)
            {
                currentPlayer = player2;
            }

            else
            {
                currentPlayer = player1;
            }

            if (actualColor == colorOfPlayer1)
            {
                actualColor = colorOfPlayer2;
            }
            else
            {
                actualColor = colorOfPlayer1;
            }

            pen = new Pen(actualColor, 5);

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            x = e.X;
            y = e.Y;
            teszt = new DirectBitmap(panel1.Width, panel1.Height);
        }

        private void Panel1_MouseLeave(object sender, EventArgs e)
        {
            itCanDraw = false;
        }

        private void Panel1_MouseEnter(object sender, EventArgs e)
        {
            itCanDraw = true;
        }

        private void isItTheEnd()
        {

            if (true)
            {

            }
            else
            {

            }



        }
    }
}
