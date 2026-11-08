//Victoria Buckner
//CS 313 01
//Chapter 06 Assignment 01
//This program prompts the user to unput the wholesale cost
//of an item as well as the markup percentage of the item.
//The program will then calculate the retail price through
//a method that returns the price then the program will 
//display it in the label. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_06_Assignment_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double CalculateRetail(double wholesale, double markup)
        {
            double percentage;
            double costAdd;
            double retailPrice;

            percentage = markup / 100;
            costAdd = wholesale * percentage;
            retailPrice = wholesale + costAdd;
            return retailPrice;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double wholesale;
                double markup;
                double retail;

                wholesale = double.Parse(wholesaleText.Text);
                markup = double.Parse(markupText.Text);
                retail = CalculateRetail(wholesale, markup);

                priceNumLabel.Text = $"${retail:F2}";
            }

            catch
            {
                MessageBox.Show("Please enter valid numeric values.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
