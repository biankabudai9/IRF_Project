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

        private void Register_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Register_uc registeruc = new Register_uc();
            Controls.Add(registeruc);
            registeruc.Dock = DockStyle.Fill;

            
        }

      
    }
}
