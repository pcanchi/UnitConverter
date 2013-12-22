using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MLib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible)
                listBox1.Visible = false;
            else
                listBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.Visible)
                listBox2.Visible = false;
            else
                listBox2.Visible = true;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            if (listBox1.Visible)
            {
                listBox2.Visible = true;
                listBox1.Visible = false;
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (listBox2.Visible)
            {
                listBox1.Visible = true;
                listBox2.Visible = false;
            }
        }  
    }
}
