using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace beadando
{
    public partial class Start_uc : UserControl
    {

        databaseEntities context = new databaseEntities();

        public Start_uc()
        {
            InitializeComponent();

            combobox_colors();

            Go_IsEnabled();

        }


        // Regisztrációs Form betöltése
        private void Register_Click(object sender, EventArgs e)
        {


            Controls.Clear();
            Register_uc registeruc = new Register_uc();
            Controls.Add(registeruc);
            registeruc.Dock = DockStyle.Fill;


        }

        //ChosenColor táblából a színek betöltése comboboxokba
        void combobox_colors()
        {
            var co = from c in context.ChosenColors
                     select c;
            color1.DataSource = co.ToList();
            color1.DisplayMember = "color_name";
            color1.ValueMember = "color_id";

            color2.DataSource = co.ToList();
            color2.DisplayMember = "color_name";
            color2.ValueMember = "color_id";


        }

        // Engedélyezzük a Go Gombot, ha minden adat ki van töltve
        private void Go_IsEnabled()
        {
            if (name1.Text != "" && name2.Text != "" && pw1.Text != "" && pw2.Text != "" && color1.Text != "" && color2.Text != "" && color1.Text != color2.Text && incorrect_message.Visible == false)
            {

                Go.Enabled = true;

            }
            else
            {
                Go.Enabled = false;

            }
        }



        // Ha változtatunk a beírt adatokon, újra meghívja a Go_IsEnabled függvényt
        private void name1_TextChanged(object sender, EventArgs e)
        {
            Go_IsEnabled();
            
        }

        private void name2_TextChanged(object sender, EventArgs e)
        {
            Go_IsEnabled();
           
        }

        private void pw1_TextChanged(object sender, EventArgs e)
        {
            Go_IsEnabled();
            
        }

        private void pw2_TextChanged(object sender, EventArgs e)
        {
            Go_IsEnabled();

           
        }

        //A beírt adatok helyesek-e, szerepelnek-e az adatbázisban
        //Ha nem szerepel ilyen adat, akkor hibaüzenet jelenik meg
        private void IsItCorrect()
        {
            //Első felhasználónév és jelszó
            var u = (from a in context.Players
                     where a.name == name1.Text
                     select a).FirstOrDefault();

            if (u != null)
            {
                var p = (from c in context.Players
                         where u.name == c.name && c.password == pw1.Text
                         select c).FirstOrDefault();

                if (p != null)
                {
                    incorrect_message.Visible = false;
                }
                else
                {
                    incorrect_message.Visible = true;
                }

            }
            else
            {
                incorrect_message.Visible = true;
            }

            //Második felhasználónév és jelszó
            var u2 = (from b in context.Players
                      where b.name == name2.Text
                      select b).FirstOrDefault();

            if (u2 != null)
            {
                var p2 = (from d in context.Players
                          where u2.name == d.name && d.password == pw2.Text
                          select d).FirstOrDefault();

                if (p2 != null)
                {
                    incorrect_message.Visible = false;
                }
                else
                {
                    incorrect_message.Visible = true;
                }
            }
            else
            {
                incorrect_message.Visible = true;
            }

            //Egyforma színt nem választhatnak
            
           
        }

        // A Go gomb lenyomásakor megnézzük, kapunk-e hibaüzenetet az IsItCorrect függvényre
        // Ha nem, akkor betöltjük a játékosok adatait a játékhoz
        private void Go_Click(object sender, EventArgs e)
        {

            IsItCorrect();

            if (incorrect_message.Visible == false)           
            {
                var first = (from c in context.Players
                             where c.name == name1.Text
                             select c).FirstOrDefault();

                SavedPlayer firstplayer = new SavedPlayer();
                firstplayer.name = first.name;

                var second = (from c in context.Players
                              where c.name == name2.Text
                              select c).FirstOrDefault();

                SavedPlayer secondplayer = new SavedPlayer();
                secondplayer.name = second.name;


                // Szín tárolása az adatbázis R G B oszlopai alapján
                var colorf = (from c in context.ChosenColors
                              where c.color_name == color1.Text
                              select c).FirstOrDefault();

                Color colorFirst = Color.FromArgb(colorf.R, colorf.G, colorf.B);

                var colors = (from c in context.ChosenColors
                              where c.color_name == color2.Text
                              select c).FirstOrDefault();

                Color colorSecond = Color.FromArgb(colors.R, colors.G, colors.B);


                // Játék Form indítása
                Form Game_Form = new Game_Form(firstplayer, secondplayer, Color.FromArgb(255, 0, 0, 0), Color.FromArgb(140, 140, 20, 10));
                Game_Form.Show();
            }
            else
            {
               
                Go.Enabled = false; // Ha hibásak az adatok, nem lehet elindítani
            }


        }

        private void color1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Go_IsEnabled();
            if (color1.SelectedItem == color2.SelectedItem)
            {
                MessageBox.Show("Do not choose the same color");

            }
        }

        private void color2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Go_IsEnabled();
            if (color1.SelectedItem == color2.SelectedItem)
            {
                MessageBox.Show("Do not choose the same color");

            }
        }

        
    }
}
