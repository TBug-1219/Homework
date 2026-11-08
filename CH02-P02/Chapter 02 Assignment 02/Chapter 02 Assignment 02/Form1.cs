//Victoria Buckner
//CS 313 01
//Chapter 02 Assignment 02
//This program will display the setup and punch line
//for the joke when the appropriate buttons are pressed.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_02_Assignment_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Which way did the programmer go?";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "He went DATA way!";
        }
    }
}
