/** =========================================================

 Garrett Penfield

 Operating System Windows 10

 Microsoft Visual Studio community 2015

 CIS 169

 Name Of homework Assignment Unit 5 Random number guessing game

 Program Description: This program makes a user guess a random number

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace garrettPenfieldUnit5
{
    public partial class mainForm : Form
    {
        //Declaring a variable to hold a random number and the users number of guesses
        int randomNumber;
        int numberOfGuesses = 0;

        public mainForm()
        {
            InitializeComponent();
            //Creating a random object in memory and a variable that references it
            Random rand = new Random();
            //Setting the limits of the random number created to 1-100 and saving it into the randomNumber variable
            randomNumber = rand.Next(99) + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //The next 3 if statments: when the button is clicked compare the user input to the randomly generated number
                //If the two are equal
                if (int.Parse(userInput.Text) == randomNumber)
                {
                    //Increment number of guesses variable
                    numberOfGuesses++;
                    //Message to the user
                    MessageBox.Show("Conratulations! You are correct! It only took you " + numberOfGuesses + " guesses.");
                    //Clear the previous input
                    userInput.Text = String.Empty;
                    //Generate a new random number and reinitialize the number of guesses back to 0
                    Random rand = new Random();
                    randomNumber = rand.Next(100) + 1;
                    numberOfGuesses = 0;
                }

                //If the user input is greater
                else if (int.Parse(userInput.Text) > randomNumber)
                {
                    //Message to the user
                    MessageBox.Show("Too high! Please try again");
                    //Increment number of guesses variable
                    numberOfGuesses++;
                    //Clear the previous input
                    userInput.Text = String.Empty;
                }

                //If the user input is less than
                else if (int.Parse(userInput.Text) < randomNumber)
                {
                    //Message to the user 
                    MessageBox.Show("Too low! Please try again");
                    //Increment number of guesses variable
                    numberOfGuesses++;
                    //Clear the previous input
                    userInput.Text = String.Empty;
                }
            }

            //Catch exception in case user doesn't enter a number
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //If the exit button is clicked close the program
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
