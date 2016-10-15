/** =========================================================

 Garrett Penfield

 Operating System Windows 10

 Microsoft Visual Studio 2015 Community

 CIS 169

 Unit 3 Meal Calculator

 Program Description: Take a meal price (input by the user) then corectly calculate the tax, tip, and the meal total.

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace garrettPenfieldUnit3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Declaring Variables
        double mealTotal;
        double tipAmount;
        double taxAmount;
        double total;

        //Calculations performed when calculate button is clicked
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Stores user input from text box into variable
            mealTotal = double.Parse(foodChargeInput.Text);

            //Calculates tip amount and saves it in variable
            tipAmount = mealTotal * .15;

            //Calculates tax amount and saves it in variable
            taxAmount = mealTotal * .07;

            //Calculates total and saves it in variable
            total = mealTotal + tipAmount + taxAmount;

            //Converts variable to string for output
            tipDisplay.Text = tipAmount.ToString("C");

            //Converts variable to string for output
            salesTaxDisplay.Text = taxAmount.ToString("C");

            //Converts variable to string for output
            totalDisplay.Text = total.ToString("C"); 
        }

        //Closes form when exit button is clicked
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
