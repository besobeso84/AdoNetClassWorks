using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //eventExampleClass ev = new eventExampleClass();
            //ev.myEvent += new eventExampleDelegate(ev.methodN1);
            //ev.eventWorking(3);
            classImplementInterface obj = new classImplementInterface();
            int result = obj.methodN1();
            result += obj.methodN2(2);
            label1.Text = result.ToString();
            label2.Text = obj.methodN3(3.5, 6.9).ToString();
        }
    }
}
