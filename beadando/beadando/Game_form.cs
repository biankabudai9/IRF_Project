using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beadando
{
    public partial class Game_form : Form
    {
        


        public Game_form()
        {
            InitializeComponent();

            Start_uc start_uc = new Start_uc();
            panel.Controls.Add(start_uc);
            start_uc.Dock = DockStyle.Fill;

        }

        
    }
}
