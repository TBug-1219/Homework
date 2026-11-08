//Victoria Buckner
//CS 313 01
//Chapter 05 Assignment 01
//This program will display two empty picture boxes and two buttons.
//One of the buttons will make the picture boxes display random dice.
//The other button will close the program with the code Close().

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_05_Assignment_02
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            int die1 = rand.Next(1, 7);
            int die2 = rand.Next(1, 7);

            diceBox1.Image = Image.FromFile($"Die{die1}.bmp");
            diceBox2.Image = Image.FromFile($"Die{die2}.bmp");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
