//Victoria Buckner
//CS 313 01
//Chapter 03 Program 01
//This program will ask the user to unput the number of tigers and lions in 
//the big cat exhibit then it'll ask the total number of big cats. From there
//it will calculate the percantages or each cat type in the exhibit and display.
//It an also clear the information for easy use again and an exit button to quit.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_03_Assignment_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double tigersNum, lionsNum;

            tigersNum = double.Parse(tigersText.Text) / double.Parse(totalText.Text) * 100;
            tigersPerText.Text = tigersNum.ToString("F2") + "%";
            lionsNum = double.Parse(lionsText.Text) / double.Parse(totalText.Text) * 100;
            lionsPerText.Text = lionsNum.ToString("F2") + "%";

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            tigersText.Text = "";
            lionsText.Text = "";
            totalText.Text = "";

            tigersPerText.Text = "";
            lionsPerText.Text = "";

            tigersText.Focus();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
