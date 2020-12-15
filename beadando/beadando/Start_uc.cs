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

            colors();
            Go_IsEnabled();

        }

        void colors()
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

        private void Go_IsEnabled()
        {
            if (name1.Text != "" && name2.Text != "" && pw1.Text != "" && pw2.Text != "" && color1.Text != "" && color2.Text != "" && incorrect_message.Visible == false)
            {

                Go.Enabled = true;

            }
            else
            {
                Go.Enabled = false;

            }
        }

        private void Register_Click(object sender, EventArgs e)
        {


            Controls.Clear();
            Register_uc registeruc = new Register_uc();
            Controls.Add(registeruc);
            registeruc.Dock = DockStyle.Fill;

            
        }

        private void name1_TextChanged(object sender, EventArgs e)
        {
            Go_IsEnabled();
            IsItCorrect();
        }

        private void name2_TextChanged(object sender, EventArgs e)
        {
            Go_IsEnabled();
            IsItCorrect();
        }

        private void pw1_TextChanged(object sender, EventArgs e)
        {
            Go_IsEnabled();
            IsItCorrect();
        }

        private void pw2_TextChanged(object sender, EventArgs e)
        {
            Go_IsEnabled();
            IsItCorrect();
        }

        private void IsItCorrect()
        {
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

        }
        private void Go_Click(object sender, EventArgs e)
        {
            

            if (incorrect_message.Visible == false)           
            {
                

                Form NewGame_Form = new NewGame_Form();
                NewGame_Form.Show();

            }


        }
    }
}
