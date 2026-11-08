//Victoria Buckner
//CS 313 01
//Chapter 07 Assignment 01
//This program will diaplay a page and let the user click
//the calculate button it will then read in the sales file
//display the file contents in a list box and also display
//the total of the sales along with the average of the sales
//the user can then click the exit button to stop the program.
//I DID DO THE EXTRA CREDIT SO THE PROGRAM WILL SHOW THE 
//HIGHEST SALE NUMBER IN A MESSAGE BOX!!

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_07_Assignment_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Total(double[] sales)
        {
            double total = 0;
            for (int index = 0; index < sales.Length; index++)
            {
                total += sales[index];
            }

            return total;
        }

        private double Average(double[] sales)
        {
            double total = Total(sales);
            double average;

            average = (double)total / sales.Length;

            return average;
        }

        private double Highest(double[] sales)
        {
            double highest = sales[0];
            for (int index = 0; index < sales.Length; index ++)
            {
                if (sales[index] > highest)
                {
                    highest = sales[index];
                }
            }

            return highest;
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                const int SIZE = 7;
                double[] num = new double[SIZE];
                int index = 0;
                double highest;
                double average;
                double total;
                StreamReader inputFile;

                inputFile = File.OpenText("Sales.txt");

                while (!inputFile.EndOfStream)
                {
                    num[index] = double.Parse(inputFile.ReadLine());
                    index++;
                }

                inputFile.Close();

                foreach(double value in num)
                {
                    salesListBox.Items.Add(value);
                }

                average = Average(num);
                total = Total(num);
                highest = Highest(num);

                totalLabelBox.Text = total.ToString("n1");
                averageLabelBox.Text = average.ToString("n1");
                MessageBox.Show("The Highest Sale: " + highest);
                

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
