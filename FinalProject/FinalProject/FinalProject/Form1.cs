//Victoria Buckner
//CS 313 01
//Final Project
//This program will let the user click the check button
//it will then display an input box for the user to 
//enter a name to check. Once they click OK it will 
//check the name against the array of popular names
//then it will display in the label box if the name
//IS or is NOT a popular name.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;



namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Make the array that the names will be read into
        string[] popularNames = new string[400];
        
        //This method will read the text file with the names
        //then it will add them to the array so the program
        //can check the names against the array.
        private void ReadNames()
        {
            StreamReader inputFile;
            inputFile = File.OpenText("popular_names.txt");

            int index = 0;

            while (!inputFile.EndOfStream)
            {
                popularNames[index] = inputFile.ReadLine();
                index++;
            }

            inputFile.Close();
        }

        //This method displays the input box for the user to 
        //input the name they want to check. Once the name
        //has been sent in the method will return the name.
        private string GetInput(string prompt, string title)
        {
            title = "Input Reqired";
            string name = Interaction.InputBox(prompt, title, "");

            return name;
        }

        //This method determines if the name is in the array 
        //once it decides it will display if the name IS or is
        //NOT one of the popular names into a label box. 
        private void Message(string name)
        {
            bool found = false;

            foreach (string i in popularNames)
            {
                if (i != null && i.ToLower() == name.ToLower())
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                displayLabel.Text = name + " IS one of the popular names.";
            }

            else
            {
                displayLabel.Text = name + " is NOT one of the popular names.";
            }
        }

        //This method runs when the Check button is clicked and it refrences
        //the other methods for the code to run all of the methods. If no name
        //is put into the input box this method will display into the label
        //that there was no name entered. 
        private void checkButton_Click(object sender, EventArgs e)
        {
            ReadNames();

            string inputName = GetInput("Enter a name:", "Name Lookup");

            if (string.IsNullOrEmpty(inputName))
            {
                displayLabel.Text = "No name entered.";
                return;
            }

            Message(inputName);
        }

        //This method is for the exit button. When it is clicked it will
        //close the program. 
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
