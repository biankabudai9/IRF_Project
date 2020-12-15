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


        public Results_Form()
        {
            InitializeComponent();

            chartfill();
        }

        private void chartfill()
        {
            var r = from y in context.Players
                    select new { y.name, y.score };


            var results = from x in r
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
            var details = from x in context.Players
                       select x;


            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "csv";
            if (save.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(save.FileName, false, Encoding.UTF8))
            {
                foreach (var d in details)
                {
                    sw.Write(d.name);
                    sw.Write(";");
                    sw.Write(d.score);
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
