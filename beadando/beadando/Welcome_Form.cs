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
    public partial class Welcome_Form : Form
    {
        public Welcome_Form()
        {
            InitializeComponent();


        }

        private void newgame_Click(object sender, EventArgs e)
        {
            Form NewGame = new NewGame_Form();
            NewGame.Show();


        }

        private void results_Click(object sender, EventArgs e)
        {
            Form Resultsform = new Results_Form();
            Resultsform.Show();

        }
    }
}
