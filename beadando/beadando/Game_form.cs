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
    }
}
