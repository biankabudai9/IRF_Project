using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace beadando
{
    public partial class Register_uc : UserControl
    {
        databaseEntities context = new databaseEntities();
        public Register_uc()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Start_uc startuc = new Start_uc();
            Controls.Add(startuc);
            startuc.Dock = DockStyle.Fill;

        }

        private void newname_Validating(object sender, CancelEventArgs e)
        {
            var u = (from x in context.Players
                     where x.name == newname.Text
                     select x).FirstOrDefault();

            Regex r = new Regex(@"^(?!\s*$).{1}");
            if (r.IsMatch(newname.Text))
            {
               
                addplayer.Enabled = true;
            }
            else
            {
                newname.BackColor = Color.Salmon;
                e.Cancel = true;
                addplayer.Enabled = false;

            }

            if (u != null)
            {
                wrongname.Visible = true;
                newname.BackColor = Color.Salmon;
                e.Cancel = true;
                addplayer.Enabled = false;
            }
            else
            {
                addplayer.Enabled = true;
                wrongname.Visible = false;
            }
        }

        private void newname_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void newage_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"^[0-9]{2}$");
            if (r.IsMatch(newage.Text))
            {

                addplayer.Enabled = true;
                wrongage.Visible = false;
            }
            else
            {
                newage.BackColor = Color.Salmon;
                e.Cancel = true;
                addplayer.Enabled = false;
                wrongage.Visible = true;
            }
        }

        private void newage_TextChanged(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void pw_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"^(?!\s*$).{8}");
            if (r.IsMatch(pw.Text))
            {
                
                addplayer.Enabled = true;
                wrongpw.Visible = false;
            }
            else
            {
                pw.BackColor = Color.Salmon;
                e.Cancel = true;
                addplayer.Enabled = false;
                wrongpw.Visible = true;
            }
        }

        private void pw_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void pwagain_Validating(object sender, CancelEventArgs e)
        {
            string r = pw.Text;
            if (r == pwagain.Text)
            {
                
                addplayer.Enabled = true;
                wrongpw.Visible = false;
            }
            else
            {
                pwagain.BackColor = Color.Salmon;
                e.Cancel = true;
                addplayer.Enabled = false;
                wrongpw.Visible = true;
            }

        }

        private void pwagain_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }
    }

        
    }

