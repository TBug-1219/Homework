//Victoria Buckner
//CS 313 01
//Chapter 06 Assignment 02
//This program will let the user chech which services were done
//along with the option to type in the price of parts and labor
//hours. When prompted it will then calculate the pricing for 
//everything and display them. It also allows the user to clear
//the form so they can reuse it again. There is also an exit
//button that will close the program. 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_06_Assignment_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double OilChangeCharges()
        {
            if (oilChangeCheck.Checked)
                return 50;
            else
                return 0;
        }

        private double LubeCharges()
        {
            if (lubeJobCheck.Checked)
                return 40;
            else
                return 0;
        }

        private double RadiatorFlushCharges()
        {
            if (radiatorFlushBox.Checked)
                return 100;
            else
                return 0;
        }

        private double TransmissionFlushCharges()
        {
            if (transmissionFlushCheck.Checked)
                return 120;
            else
                return 0;
        }

        private double InspectionCharges()
        {
            if (inspectionCheck.Checked)
                return 35;
            else
                return 0;
        }

        private double MufflerCharges()
        {
            if (replaceMufflerCheck.Checked)
                return 150;
            else
                return 0;
        }

        private double TireRotationCharges()
        {
            if (tireRotationCheck.Checked)
                return 25;
            else
                return 0;
        }

        private double PartsCharges()
        {
            double parts;
            if (double.TryParse(partsText.Text, out parts))
                return parts;
            else
                return 0;
        }

        private double LaborCharges()
        {
            double hours;
            if (double.TryParse(laborText.Text, out hours))
                return hours * 20;
            else
                return 0;
        }

        private double TaxCharges()
        {
            return PartsCharges() * 0.06;
        }

        private double TotalCharges()
        {
            double total;
            total = OilChangeCharges() +
                LubeCharges() +
                RadiatorFlushCharges() +
                TransmissionFlushCharges() +
                InspectionCharges() +
                MufflerCharges() +
                TireRotationCharges() +
                PartsCharges() +
                LaborCharges() +
                TaxCharges();
            return total;
        }



        private void clearButton_Click(object sender, EventArgs e)
        {
            oilChangeCheck.Checked = false;
            lubeJobCheck.Checked = false;
            radiatorFlushBox.Checked = false;
            transmissionFlushCheck.Checked = false;
            inspectionCheck.Checked = false;
            replaceMufflerCheck.Checked = false;
            tireRotationCheck.Checked = false;

            partsText.Text = "";
            laborText.Text = "";

            serviceLaborLabelBox.Text = "";
            partsLabelBox.Text = "";
            taxLabelBox.Text = "";
            totalFeesLabelBox.Text = "";

            partsText.Focus();
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            double services;
            double parts;
            double tax;
            double total;

            services = OilChangeCharges() +
                LubeCharges() +
                RadiatorFlushCharges() +
                TransmissionFlushCharges() +
                InspectionCharges() +
                MufflerCharges() +
                TireRotationCharges() +
                LaborCharges();

            parts = PartsCharges();
            tax = TaxCharges();
            total = TotalCharges();

            serviceLaborLabelBox.Text = services.ToString("c");
            partsLabelBox.Text = parts.ToString("c");
            taxLabelBox.Text = tax.ToString("c");
            totalFeesLabelBox.Text = total.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miscBox_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void partsLaborBox_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
