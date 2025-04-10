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

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The Average method accepts an int array argument
        // and returns the Average of the values in the array.
        private   int Average(int[] scores)
        {
            int total = 0; // Accumulator
            // Loop through the array and add the values to total.
            for (int index = 0; index < scores.Length; index++)
            {
                total += scores[index];
            }
            // Return the average.
            return total / scores.Length;
        }
        

        // The Highest method accepts an int array argument
        // and returns the highest value in that array.
        private  int Highest(int[]scores  )
        {
           int highest = scores[0]; // Assume the first score is the highest
            for (int index = 1; index < scores.Length; index++)
            {
                if (scores[index] > highest)
                    highest = scores[index];
            }
            return highest;
        }

        // The Lowest method accepts an int array argument
        // and returns the lowest value in that array.
        private  int Lowest(int[] scores)
        {
            int lowest = scores[0]; // Assume the first score is the lowest
            for (int index = 1; index < scores.Length; index++)
            {
                if (scores[index] < lowest)
                    lowest = scores[index];
            }
            return lowest;
        }
        

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 48; // Size of the array
            int[] testScores = new int[SIZE]; // Array to hold the test scores
            int index = 0; // Number of test scores read
            int highestScore=0; // Highest test score
            int lowestScore = 0; // Lowest test score
            double averageScore = 0.0; // Average test score
            StreamReader inputFile; // Input file stream
            try
            {
             if(OpenFile.ShowDialog() == DialogResult.OK)
                {
                    // Open the file.
                    inputFile = File.OpenText(OpenFile.FileName);
                    // Read the test scores from the file.
                    while (index < SIZE && !inputFile.EndOfStream)
                    {
                        testScores[index] = Convert.ToInt32(inputFile.ReadLine());
                        index++;
                    }
                    // Close the file.
                    inputFile.Close();
                    // Calculate the average, highest, and lowest scores.
                    averageScore = Average(testScores);
                    highestScore = Highest(testScores);
                    lowestScore = Lowest(testScores);
                    // Display the results.
                    averageScoreLabel.Text = averageScore.ToString("n1");
                    highScoreLabel.Text = highestScore.ToString();
                    lowScoreLabel.Text = lowestScore.ToString();
                }
            }
            catch (Exception ex)
            {
                // Display the error message.
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
