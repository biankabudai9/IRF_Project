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
        databaseEntities context = new databaseEntities();
        List<SavedPlayer> savedPlayers = new List<SavedPlayer>();

        public Welcome_Form()
        {
            InitializeComponent();
            LoadSavedPlayers();

        }

        private void LoadSavedPlayers()
        {
            foreach (var item in context.Players)
            {
                SavedPlayer player = new SavedPlayer();
                player.age = item.age;
                player.name = item.name;
                player.score = item.score;
                player.password = item.password;
                savedPlayers.Add(player);
            }
        }

        private void newgame_Click(object sender, EventArgs e)
        {
            Form NewGame = new NewGame_Form();
            NewGame.Show();

        }

        private void results_Click(object sender, EventArgs e)
        {
            Form Resultsform = new Results_Form(savedPlayers);
            Resultsform.Show();

        }
    }
}
