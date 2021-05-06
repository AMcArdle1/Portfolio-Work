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
 * Build a GUI program that allows the user to play three rounds of Rock Paper Scissors.
 * Once all three rounds are over, display the winner.
 * 
 */

namespace Ch5RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare Variables
        const int rock = 1;
        const int paper = 2;
        const int scissors = 3;

        static int roundNumber = 0;
        static int computerChoice = 0;
        static int playerChoice = 0;
        static int playerScore = 0;
        static int computerScore = 0;

        private void btnRock_Click(object sender, EventArgs e)
        {
            playerChoice = rock;
            nextRound();
            
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            playerChoice = paper;
            nextRound();
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            playerChoice = scissors;
            nextRound();
        }

        private void nextRound()
        {
            ++roundNumber;

            if (roundNumber <= 3)
            {
                generateComputerChoice();
                roundWinner();
                roundResults();
            }
            else
            {
                displayResults();
            }
        }

        private void generateComputerChoice()
        {
            Random rand = new Random();
            computerChoice = rand.Next(1, 4);

            if (computerChoice == rock)
            {
                lblComputerChoice.Text = "Computer picked Rock";
            }
            else if (computerChoice == paper)
            {
                lblComputerChoice.Text = "Computer picked Paper";
            }
            else
            {
                lblComputerChoice.Text = "Computer picked Scissors";
            }
        }

        private void roundWinner()
        {
            if (playerChoice == paper && computerChoice == rock)
            {
                ++playerScore;
            }
            else if (playerChoice == rock && computerChoice == paper)
            {
                ++computerScore;
            }
            else if (playerChoice == rock && computerChoice == scissors)
            {
                ++playerScore;
            }
            else if (playerChoice == scissors && computerChoice == rock)
            {
                ++computerScore;
            }
            else if (playerChoice ==  scissors && computerChoice == paper)
            {
                ++playerScore;
            }
            else if (playerChoice == paper && computerChoice == scissors)
            {
                ++computerScore;
            }
        }

        private void roundResults()
        {
            lblPlayerScore.Text = "Player Score: " + playerScore.ToString();
            lblComputerScore.Text = "Computer Score: " + computerScore.ToString();
        }

        private void displayResults()
        {
            if (playerScore > computerScore)
            {
                lblOverallResult.Text = "PLAYER WINS!!!";
            }
            else
            {
                lblOverallResult.Text = "COMPUTER WINS!!!";
            }
        }
    }
}
