//Victoria Buckner
//CS 313 01
//Chapter 07 Assignment 02
//This program will let the user click the check button
//it will then show the number of correct and incorrect
//answers to the driving exam as well as the questions
//that were answered incorrectly. A message box will 
//pop up displaying if the exam was passed or failed. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chapter_07_Assignment_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[] studentAnswers = new char[20];

        private char[] getCorrectAnswers()
        {
            char[] correctAnswers =
            {
                'B', 'D', 'A', 'A', 'C',
                'A', 'B', 'A', 'C', 'D',
                'B', 'C', 'D', 'A', 'D',
                'C', 'C', 'B', 'D', 'A'
            };
            return correctAnswers;
        }
        private void readStudentAnswers()
        {
            StreamReader inputFile;
            inputFile = File.OpenText("testAnswers.txt");

            int index = 0;

            while (!inputFile.EndOfStream)
            {
                studentAnswers[index] = char.Parse(inputFile.ReadLine());
                index++;
            }

            inputFile.Close();
        }

        private int countCorrect(char[] correct, char[] studentAnswers)
        {
            int correctCount = 0;

            for (int i = 0; i < 20; i++)
            {
                if(correct[i] == studentAnswers[i])
                {
                    correctCount++;
                }
            }

            return correctCount;
        }

        private int countIncorrect(int correctCount)
        {
            int incorrectCount;

            incorrectCount = 20 - correctCount;

            return incorrectCount;
        }

        private int[] getMissedQuestions(char[] correctAnswers, char[] studentAnswers)
        {
            int count = 0;

            for (int i = 0; i < 20; i++)
            {
                if (correctAnswers[i] != studentAnswers[i])
                {
                    count++;
                }
            }

            int[] missedQuestions = new int[count];

            int index = 0;
            for (int i = 0; i < 20; i++)
            {
                if (correctAnswers[i] != studentAnswers[i])
                {
                    missedQuestions[index] = i + 1;
                    index++;
                }
            }

            return missedQuestions;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            incorrectAnswerNumbers.Items.Clear();

            readStudentAnswers();
            char[] correct = getCorrectAnswers();

            int correctCount = countCorrect(correct, studentAnswers);
            int incorrectCount = countIncorrect(correctCount);
            int[] missedQuestions = getMissedQuestions(correct, studentAnswers);

            correctAnswers.Text = correctCount.ToString();
            incorrectAnswers.Text = incorrectCount.ToString();

            incorrectAnswerNumbers.Items.Add("Missed Questions: ");
            foreach (int i in missedQuestions)
                incorrectAnswerNumbers.Items.Add("Question: " + i);

            if (correctCount >= 15)
            {
                MessageBox.Show("Passed Exam");
            }
            else
            {
                MessageBox.Show("Failed Exam");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
