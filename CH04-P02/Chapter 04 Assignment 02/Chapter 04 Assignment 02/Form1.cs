//Victoria Buckner
//CS 313 01
//Chapter 04 Assignment 02
//This program will have the user input the type of training and location
//then it will calculate and give the user the registration cost along
//with the lodging cost and the total cost of the training. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_04_Assignment_02
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

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int days = 0;
            int registrationFee = 0;
            int lodgeFee = 0;

            switch(trainingListBox.SelectedItem.ToString())
            {
                case "Handling Stress":
                    days = 3; registrationFee = 1000;
                    break;
                case "Time Management":
                    days = 3; registrationFee = 800;
                    break;
                case "Supervision Skills":
                    days = 3; registrationFee = 1500;
                    break;
                case "Negotiation":
                    days = 3; registrationFee = 1300;
                    break;
                case "How to Interview":
                    days = 1; registrationFee = 500;
                    break;
            }

            switch (locationListBox.SelectedItem.ToString())
            {
                case "Austin":
                    lodgeFee = 150;
                    break;
                case "Chicago":
                    lodgeFee = 225;
                    break;
                case "Dallas":
                    lodgeFee = 175;
                    break;
                case "Orlando":
                    lodgeFee = 300;
                    break;
                case "Pheonix":
                    lodgeFee = 175;
                    break;
                case "Raleigh":
                    lodgeFee = 150;
                    break;
            }

            int lodgingTotal = lodgeFee * days;
            int totalFee = registrationFee + lodgingTotal;

            registrationCost.Text = "$" + registrationFee;
            lodgingCost.Text = "$" + lodgingTotal;
            totalCost.Text = "$" + totalFee;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
