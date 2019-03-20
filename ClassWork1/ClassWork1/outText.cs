using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork1
{
    class outText
    {
        public void outTextOnlabel(TextBox textbox, Label label)
        {
            label.Text = "Hello " + textbox.Text;
        }

        private void outTextOnlabel(Label label, TextBox textbox)
        {
            label.Text = "Hello " + textbox.Text;
        }
    }
}
