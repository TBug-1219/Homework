//Victoria Buckner
//CS 313 01
//Chapter 03 Assignment 02
//This program will display some fruits with their prices and allow
//the user to click them to add the prices for their desired amount.
//It will also allow them to reset to try again.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_03_Assignment_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            double pearBox;
            pearBox = double.Parse(totalNum.Text) + 1.20;
            totalNum.Text = pearBox.ToString("F2");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalNum.Text = "0.00";
        }

        private void bananaBox_Click(object sender, EventArgs e)
        {
            double bananaBox;
            bananaBox = double.Parse(totalNum.Text) + 0.65;
            totalNum.Text = bananaBox.ToString("F2");
        }

        private void appleBox_Click(object sender, EventArgs e)
        {
            double appleBox;
            appleBox = double.Parse(totalNum.Text) + 1.35;
            totalNum.Text = appleBox.ToString("F2");
        }

        private void orangeBox_Click(object sender, EventArgs e)
        {
            double orangeBox;
            orangeBox = double.Parse(totalNum.Text) + 1.60;
            totalNum.Text = orangeBox.ToString("F2");
        }
    }
}
