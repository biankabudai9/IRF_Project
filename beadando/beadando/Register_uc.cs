using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beadando
{
    public partial class Register_uc : UserControl
    {
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

        }

        
    }
}
