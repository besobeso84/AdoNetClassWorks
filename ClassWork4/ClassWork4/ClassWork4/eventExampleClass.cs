using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ClassWork4
{
    delegate void eventExampleDelegate(int p);
    class eventExampleClass
    {
        public event eventExampleDelegate myEvent;

        public void eventWorking(int p)
        {
            myEvent(p);
        }

        public void methodN1(int p)
        {
            MessageBox.Show(p.ToString());
        }
    }
}
