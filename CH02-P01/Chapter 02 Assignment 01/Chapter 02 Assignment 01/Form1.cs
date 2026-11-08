//Victoria Buckner
//CS 313 01
//Chapter 02, Assignment 01
//This program will allow the user to click on one of the cards
//then it will display the name of the card. The user can then 
//click another card or click the exit button that will close
//the application.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_02_Assignment_01
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Ace of Clubs";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Ace of Diamonds";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Four of Spades";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Ace of Hearts";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Ace of Spades";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
