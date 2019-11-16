using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Scores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// User ArrayList initialized for storing userinput ints
        /// </summary>
        List<int> userInputsScores = new List<int>();

        /// <summary>
        /// Method for AddNumBtn, includes displaying in disabled fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNumBtn_Click(object sender, EventArgs e)
        {
            //set a variable and convert to int from textbox
            int userNumber = Convert.ToInt32(userScoreTxt.Text);
            //variable min is set for minimum number validation
            int min = -1;
            //variable max is set for maximum number validation
            int max = 100;
            //initialize sum as 0
            int sum = 0;
            //int average = 0;
            int scoreCount = 0;

            //validates between number range
            if(userNumber > min && userNumber <= max)
            {
                //adds score to arraylist
                userInputsScores.Add(userNumber);

                for (int i = 0; i < userInputsScores.Count(); i++)
                {
                    //calculates sum, sends it to textbox
                    sum += userInputsScores[i];
                    scoreTotalTxt.Text = sum.ToString();
                }

                for (int i = 0; i < userInputsScores.Count(); i++)
                {
                    //increase how many scores are set, sends to textbox
                    scoreCount++;
                    scoreCountTxt.Text = scoreCount.ToString();
                }

                //calculates average as double, sends to textbox
                double average = (sum / scoreCount);
                averageTxt.Text = average.ToString();

            }
            else
            {
                MessageBox.Show("The score entered must be between 0 and 100");
            }

        }
        /// <summary>
        /// this creates another ArrayList of string, and populates it with
        /// each value from the previous array list to then be displayed in a messagebox
        /// the displayed string ArrayList is sorted before display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayScoresBtn_Click(object sender, EventArgs e)
        {
            List<String> userInputsString = new List<String>();

            foreach (int userNumber in userInputsScores)
            {
                userInputsString.Add(userNumber.ToString());
            }

            userInputsString.Sort();
            MessageBox.Show("Here are your scores" + $"\n{string.Join(", ", userInputsString)}");
            
        }

        /// <summary>
        /// This method exits the form when the exit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// clears all score data from the form when clear scores is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearScoresBtn_Click(object sender, EventArgs e)
        {
            userScoreTxt.Text = "";
            scoreCountTxt.Text = "";
            scoreTotalTxt.Text = "";
            averageTxt.Text = "";

            userInputsScores.Clear();

        }
    }
}
