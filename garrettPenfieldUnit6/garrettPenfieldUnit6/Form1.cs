/** =========================================================

 Garrett Penfield

 Operating System Windows 10

 Microsoft Visual Studio community 2015

 CIS 169

 Name Of homework Assignment Unit 6 Hospital Charges

 Program Description: This program calculates the total for a stay in the hospital

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

namespace garrettPenfieldUnit6
{
    public partial class hospitalChargesForm : Form
    {
        public hospitalChargesForm()
        {
            InitializeComponent();
        }

        //Declaring Variables
        decimal stayCharges, miscCharges, totalCharges;

        //Actions to be performed when calculate button is clicked
        private void calculateTotal_Click(object sender, EventArgs e)
        {
            try
            {
                //Execute methods and store them in variables
                stayCharges = CalcStayCharges(int.Parse(daysInHospitalInput.Text));
                miscCharges = CalcMiscCharges();
                totalCharges = CalcTotalCharges();
                //Show message box with total charges for the hospital stay
                MessageBox.Show("Total for your hospital stay is $" + totalCharges);
                //Clear all the fields
                daysInHospitalInput.Text = "";
                totalMedicationInput.Text = "";
                totalSurgicalChargesInput.Text = "";
                totalLabFeesInput.Text = "";
                totalRehabFeesInput.Text = "";

            }

            //Show message box warning of invalid input format
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Method to calculate per day charges
        private decimal CalcStayCharges(int days)
        {
            return days * 350;
        }

        //Method to calculate all other charges
        private decimal CalcMiscCharges()
        {
            return decimal.Parse(totalMedicationInput.Text) + decimal.Parse(totalSurgicalChargesInput.Text) +
                decimal.Parse(totalLabFeesInput.Text) + decimal.Parse(totalRehabFeesInput.Text);
        }

        //Method to sum per day charges and all other charges
        private decimal CalcTotalCharges()
        {
            return stayCharges + miscCharges;
        }

        //Close the program when exit button is clicked
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
