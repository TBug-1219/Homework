//Victoria Buckner
//CS 313 01
//Chapter 05 Assignment 01
//This program will display a list box and once the user clicks calculate
//it will display the tuition costs for the next 5 years with the increasing
//rate. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_05_Assignment_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            priceListBox.Items.Clear();

            double tuition = 6000;
            double rate = 0.02;
            int year;

            for (year = 1; year <= 5; year++)
            {
                tuition += tuition * rate;
                priceListBox.Items.Add("Year " + year + ": " + tuition.ToString("C"));
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
