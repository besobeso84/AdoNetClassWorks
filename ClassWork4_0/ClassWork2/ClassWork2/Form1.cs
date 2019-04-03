using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            withNumber wN;
            withNumber wN1 = new withNumber(workingWithNumber.workN1);
            withNumber wN2 = new withNumber(workingWithNumber.workN2);
            withNumber wN3 = new withNumber(workingWithNumber.workN3);

            wN = wN1;
            wN += wN2;
            wN += wN3;
            wN(2);

            label1.Text = workingWithNumber.returnN().ToString();

            wN -= wN2;
            wN -= wN3;
            wN(2);
            label2.Text = workingWithNumber.returnN().ToString();
        }
    }
}
