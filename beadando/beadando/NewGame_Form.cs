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
    public partial class NewGame_Form : Form
    {
        public NewGame_Form()
        {
            InitializeComponent();

            Start_uc start_uc = new Start_uc();
            panel1.Controls.Add(start_uc);
            start_uc.Dock = DockStyle.Fill;

        }


    }
}
