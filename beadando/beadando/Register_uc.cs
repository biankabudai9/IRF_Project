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
                newname.BackColor = Color.FromArgb(255, 216, 242, 246);

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
                newname.BackColor = Color.FromArgb(255, 216, 242, 246);
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
            if (newage.Text == "") return;
            if (Convert.ToInt32(newage.Text) >= 6 && Convert.ToInt32(newage.Text) < 100)
            {
                newage.BackColor = Color.FromArgb(255, 216, 242, 246);
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
                pw.BackColor = Color.FromArgb(255, 216, 242, 246);
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
                pwagain.BackColor = Color.FromArgb(255, 216, 242, 246);
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

        private void hint_button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Choose a unique username that is not used by anyone yet.");
        }

        private void hint_button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please provide your age to help improve our statistics.");
        }

        private void hint_button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add a password that contains both letters and numbers and is at least 8 characters. Confirm it in the next field.");
        }
    }

        
    }

