using System;
using static System.Console;

/*
 * NAME: Aaron McArdle
 * 
 * Write a console program that converts distances from miles to kilmeters:
 *  - Declares a named constant named KM_PER_MILE which holds the number 
 *    of kilmeters in a mile (1.6 km per mile).
 *  - Prompts the user for a distance in miles
 *  - Displays the distance in both kilmeters and miles. 
 */

namespace LB1
{
    class Program
    {
        const double KM_PER_MILE = 1.6;

        static void Main(string[] args)
        {
            // Declare Variables

            double miles = 0.0;
            double kilo = 0.0;
            string outputStr = "";

            Write("Please enter number of mile(s): ");
            miles = Convert.ToDouble(ReadLine());
            kilo = miles * KM_PER_MILE;

            outputStr = "\n" + miles.ToString("f2") + " miles is " + kilo.ToString("f2") + " kilometers\n";

            Write(outputStr);
        }
    }
}
