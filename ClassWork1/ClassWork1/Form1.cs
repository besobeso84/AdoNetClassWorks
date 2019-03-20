using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String s = textBox1.Text;
            //label1.Text = "Hello " + s;
            //outText OutText = new outText();
            //OutText.outTextOnlabel(label1, textBox1);
            outMessage Outmessage = new outMessage();
            Outmessage.outTextOnlabel(textBox1, label1);
        }
    }
}
