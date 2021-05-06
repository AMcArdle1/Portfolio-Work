using System;
using static System.Console;

/*
 * NAME: Aaron McArdle
 * 
 * Write a console program that calculates the average grade for a student: 
 *  - Prompts the user for four test scores
 *  - Displays the average of the entered test scores
 * 
 */

namespace LB3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables 

            int test1 = 0;
            int test2 = 0;
            int test3 = 0;
            int test4 = 0;
            double avg = 0.0;
            string outputStr = "";

            Write("Please enter test score #1: ");
            test1 = Convert.ToInt32(ReadLine());

            Write("Please enter test score #2: ");
            test2 = Convert.ToInt32(ReadLine());

            Write("Please enter test score #3: ");
            test3 = Convert.ToInt32(ReadLine());

            Write("Please enter test score #4: ");
            test4 = Convert.ToInt32(ReadLine());

            avg = ((double)test1 + test2 + test3 + test4) / 4;

            outputStr = "\nThe test scores entered are: " + test1.ToString() + "," + test2.ToString() + "," + test3.ToString() + "," + test4.ToString() + "\n" + "The average grade for these scores are: " + avg.ToString("f2") + "\n";

            Write(outputStr);
        }
    }
}
