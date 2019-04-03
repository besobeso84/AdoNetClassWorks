using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassWork2
{

    delegate string myDelegate(string text); 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeText _ChangeText = new changeText();
            //label1.Text = _ChangeText.changeSpace(textBox1.Text);
            //label2.Text = changeString.changeSpaceToEmpty(textBox1.Text);
            myDelegate _delegate = new myDelegate(_ChangeText.changeSpace);
            label1.Text = _delegate(textBox1.Text);
            _delegate = new myDelegate(changeString.changeSpaceToEmpty);
            label2.Text = _delegate(textBox1.Text);
        }
    }
}
