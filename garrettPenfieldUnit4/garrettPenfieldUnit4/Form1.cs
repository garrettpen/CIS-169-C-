/** =========================================================

 Garrett Penfield

 Operating System Windows 10

 Microsoft Visual Studio community 2015

 CIS 169

 Unit 4 Time Calculator

 Program Description: This program takes a user input (number of seconds) and converts it into
 other measurements of time.

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

namespace garrettPenfieldUnit4
{
    public partial class timeCalculator : Form
    {
        public timeCalculator()
        {
            InitializeComponent();
        }

        //Declaring variables
        int seconds, minutes, hours, days;

        //Closes form when exit button is clicked
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Resets values to defaults when reset button is clicked
        private void resetButton_Click(object sender, EventArgs e)
        {
            secondsInput.Text = "";
            secondsResult.Text = "0";
            minutesResult.Text = "0";
            hoursResult.Text = "0";
            daysResult.Text = "0";
        }

        //Converts seconds into other measurements of time when calculate button is clicked
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Sets seconds value
            seconds = int.Parse(secondsInput.Text);

            //If user inputs 60 seconds or more this calculates the minute equivalent
            secondsResult.Text = secondsInput.Text;
            if (seconds == 60 || seconds > 60)
            {
                minutes = seconds / 60;
                minutesResult.Text = minutes.ToString();
            }

            //If user inputs 3600 seconds or more this calculates the hour equivalent
            if (seconds == 3600 || seconds > 60)
            {
                hours = seconds / 3600;
                hoursResult.Text = hours.ToString();
            }

            //If user inputs 86400 seconds or more this calculates the days equivalent
            if (seconds == 86400 || seconds > 86400)
            {
                days = seconds / 86400;
                daysResult.Text = days.ToString();
            }
        }
    }
}
