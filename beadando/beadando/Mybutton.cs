using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beadando
{
    public class Mybutton : Button
    {
        public Mybutton()
        {
            Height = 80;
            Width = 250;

            BackColor = Color.FromArgb(255, 0, 78, 82);
            ForeColor = Color.White;
            FlatStyle = FlatStyle.Popup;
            Font = new Font("Century Gothic", 16, FontStyle.Bold);


        }

    }
}
