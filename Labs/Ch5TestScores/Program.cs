using System;
using static System.Console;

/*
 * NAME: Aaron McArdle
 * 
 * Write a console application that accepts an indefinite number of test scores for a student,
 * and then computes some statistics about those scores:
 *  - Prompt the user for test scores until they enter 999
 *  - If the user enters a score inside the range of 0 through 100
 *      - Accept the score
 *      - Prompt the user for another score
 *  - If the user enters 999
 *      - Ignore the test score
 *      - DO NOT display an error message
 *      - Display the number of scores, sum, average, min, and max
 *      - stop the program
 *  - If they enter a score outside the range of 0 through 100
 *      - Ignore the test score
 *      - Display an error message
 *      - Prompt the user for another score
 *      
 */

namespace Ch5TestScores
{
    class Program
    {
        // Declare Variables 
        static int numScores = 0;
        static double scoreInput = 0.0;
        static double totalScores = 0.0;
        static double avgScore = 0.0;
        static double lowScore = 100.0;
        static double highScore;
        
        

        static void Main(string[] args)
        {
            InputScore();
        }

        static void InputScore()
        {
            while (scoreInput != 999)       // Loops while input is not 999
            {
                Write("Please enter a test score: ");
                scoreInput = Convert.ToDouble(ReadLine());

                if (scoreInput < 0 || scoreInput > 100)    // checks if input is in range
                {
                    WriteLine("Invalid Score");
                    continue;
                }

                if (scoreInput < lowScore)
                {
                    lowScore = scoreInput;
                }

                else if (scoreInput > highScore)
                {
                    highScore = scoreInput;
                }

                ++numScores;
                totalScores += scoreInput;
                avgScore = totalScores / numScores;

                if (scoreInput == 999)
                {
                    break;
                }
             
            }

            DisplayResults();
        }

        static void DisplayResults()
        {
            Write("\nNumber of scores: " + numScores.ToString());
            Write("\nSum of test scores: " + totalScores.ToString("f1"));
            Write("\nAverage test score: " + avgScore.ToString("f1"));
            Write("\nLowest test score: " + lowScore.ToString("f1"));
            Write("\nHighest test score: " + highScore.ToString("f1"));
            
        }
    }
}
