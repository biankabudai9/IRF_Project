using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beadando
{
    public class Hint_button : Button
    {
        public Hint_button()
        {
            Height = 35;
            Width = 35;
            Text = "?";
            BackColor = Color.FromArgb(255, 101, 155, 150);
            ForeColor = Color.White;
            FlatStyle = FlatStyle.Popup;
            Font = new Font("Century Gothic", 13, FontStyle.Bold);

        }
    }
}
