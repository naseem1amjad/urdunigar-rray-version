using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Urdu_Nigar_Unicode
{
    public partial class MyMessageBox : Form
    {
        public MyMessageBox()
        {
            InitializeComponent();
       
        }
        public void myText(string txt)
        { textBox1.Text = txt; }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void MyMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
