//Victoria Buckner
//CS 313 01
//Chapter 04 Assignment 01
//This program will ask the user to input the number of books purchased this month.
//Once the user clicks calculate the program will calculate the amount of points the
//customer has earned this month and display it in a label box. The program also 
//allows the user to select if they are older than 55 and it will double their
//points earned for that month.
//I DID DO THE EXTRA CREDIT!!!

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_04_Assignment_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pointsLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int purchaseNum, pointNum;
            purchaseNum = int.Parse(numBox.Text);
            if (purchaseNum == 0)
            {
                pointNum = 0;
                pointsLabel.Text = pointNum.ToString();
            }
            else if (purchaseNum == 1)
            {
                pointNum = 10;
                pointsLabel.Text = pointNum.ToString();
            }
            else if (purchaseNum == 2)
            {
                pointNum = 20;
                pointsLabel.Text = pointNum.ToString();
            }
            else if (purchaseNum == 3)
            {
                pointNum = 30;
                pointsLabel.Text = pointNum.ToString();
            }
            else
            {
                pointNum = 40;
                pointsLabel.Text = pointNum.ToString();
            }
            if (ageCheck.Checked)
            {
                pointNum *= 2;
                pointsLabel.Text = pointNum.ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
