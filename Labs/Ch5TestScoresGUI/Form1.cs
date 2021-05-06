using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

/*
 * NAME: Aaron McArdle
 * 
 * Implement Test Scores as a GUI Program
 * 
 */

namespace Ch5TestScoresGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare Variables

        int numScores = 0;
        double scoreInput = 0.0;
        double totalScores = 0.0;
        double avgScores = 0.0;
        double lowScore = 100.0;
        double highScore = 0.0;

        private void btnEnter_Click(object sender, EventArgs e)
        {

            // Assign values to variables

            scoreInput = Convert.ToDouble(txtScoreEntry.Text);
            if (scoreInput == 999)
            {
                DialogResult dialog = MessageBox.Show(
                    "Do you Want to Exit?", 
                    "EXIT NOW?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }
                
            }
            else if ((scoreInput < 0) || (scoreInput > 100))
            {
                MessageBox.Show("INPUT IS OUT OF RANGE", "ERROR");
                txtScoreEntry.Text = "";
            }

            else 
            {
                txtScoreEntry.Text = "";

                ++numScores;
                totalScores += scoreInput;
                avgScores = totalScores / numScores;

                if (scoreInput < lowScore)
                {
                    lowScore = scoreInput;
                }
                else if (scoreInput > highScore)
                {
                    highScore = scoreInput;
                }

                lblNumScores.Text = "Number of scores: " + numScores.ToString();
                lblSumScores.Text = "Sum of test scores: " + totalScores.ToString("f1");
                lblAvgScores.Text = "Average test score: " + avgScores.ToString("f1");
                lblLowScore.Text = "Lowest test score: " + lowScore.ToString("f1");
                lblHighScore.Text = "Highest test score: " + highScore.ToString("f1");
            }
        }
    }
}
