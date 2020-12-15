using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beadando
{
    

    public partial class Results_Form : Form
    {

        databaseEntities context = new databaseEntities();
        List<SavedPlayer> _savedPlayers = new List<SavedPlayer>();

        public Results_Form(List<SavedPlayer> savedPlayers)
        {
            InitializeComponent();
            _savedPlayers = savedPlayers;
            chartfill(savedPlayers);
        }

        private void chartfill(List<SavedPlayer> savedPlayers)
        {
            var r = from y in savedPlayers
                    select new { y.name, y.score };
            var r2 = (from z in r
                      orderby z.score descending
                      select z).Take(5);

            var results = from x in r2
                          select new diagram
                          {
                              name = x.name,
                              score = x.score
                          };

            diagramBindingSource.DataSource = results.ToList();

            piechart.DataBind();



        }

        private void download_Click(object sender, EventArgs e)
        {
            var details = from x in _savedPlayers
                          select x;


            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "csv";
            if (save.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(save.FileName, false, Encoding.UTF8))
            {
                sw.Write("name");
                sw.Write(";");
                sw.Write("score");
                sw.Write(";");
                sw.Write("age");
                sw.Write(";");
                sw.WriteLine();
                foreach (var d in details)
                {
                    sw.Write(d.name);
                    sw.Write(";");
                    sw.Write(d.score.ToString());
                    sw.Write(";");
                    sw.Write(d.AgeGroup);
                    sw.Write(";");
                    sw.WriteLine();
                }
            }
        }
    }

    public class diagram
    {
        public string name { get; set; }
        public int score { get; set; }

    }

}
