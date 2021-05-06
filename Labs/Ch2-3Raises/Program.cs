using System;
using static System.Console;


/*
 * NAME: Aaron McArdle
 * 
 * Write a console program that calculates projected raises: 
 *  - Declares a named constant PERCENT_RAISE and assign it a value of 4% (or 0.04)
 *  - Prompts the user to the names and salaries of three employees.
 *  - Displays the projected salaries for these three employees over the next 2 years in a table, 
 *    assuming that they get a 4% raise every year
 * 
 */
namespace LB2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables

            const double PERCENT_RAISE = 0.04;
            string emp1 = "";
            string emp2 = "";
            string emp3 = "";
            double emp1Sal1 = 0.0;
            double emp2Sal1 = 0.0;
            double emp3Sal1 = 0.0;
            double emp1Sal2 = 0.0;
            double emp2Sal2 = 0.0;
            double emp3Sal2 = 0.0;
            double emp1Sal3 = 0.0;
            double emp2Sal3 = 0.0;
            double emp3Sal3 = 0.0;

            // Assign values to variables

            Write("Please enter Employee #1's name: ");
            emp1 = ReadLine();

            Write("Please enter Employee #1's salary: ");
            emp1Sal1 = Convert.ToDouble(ReadLine());

            Write("Please enter Employee #2's name: ");
            emp2 = ReadLine();

            Write("Please enter Employee #2's salary: ");
            emp2Sal1 = Convert.ToDouble(ReadLine());

            Write("Please enter Employee #3's name: ");
            emp3 = ReadLine();

            Write("Please enter Employee #3's salary: ");
            emp3Sal1 = Convert.ToDouble(ReadLine());

            // Calculate new salaries with raise

            emp1Sal2 = emp1Sal1 + (emp1Sal1 * PERCENT_RAISE);
            emp2Sal2 = emp2Sal1 + (emp2Sal1 * PERCENT_RAISE);
            emp3Sal2 = emp3Sal1 + (emp3Sal1 * PERCENT_RAISE);

            emp1Sal3 = emp1Sal2 + (emp1Sal2 * PERCENT_RAISE);
            emp2Sal3 = emp2Sal2 + (emp2Sal2 * PERCENT_RAISE);
            emp3Sal3 = emp3Sal2 + (emp3Sal2 * PERCENT_RAISE);


            // Print results to the console in a table

            /*
            WriteLine();
            WriteLine(emp1Sal2.ToString("c"));
            WriteLine(emp2Sal2.ToString("c"));
            WriteLine(emp3Sal2.ToString("c"));
            WriteLine();
            WriteLine(emp1Sal3.ToString("c"));
            WriteLine(emp2Sal3.ToString("c"));
            WriteLine(emp3Sal3.ToString("c"));
            */

            WriteLine();
            WriteLine("+-------------------------------+");
            WriteLine("|  Year  | " + emp1 + "  | " + emp2 + "  | " + emp3 + "  |");
            WriteLine("+-------------------------------+");
            WriteLine("| 2018   | " + emp1Sal1.ToString("c") + " | " + emp2Sal1.ToString("c") + " | " + emp3Sal1.ToString("c") + " |");
            WriteLine("| 2019   | " + emp1Sal2.ToString("c") + " | " + emp2Sal2.ToString("c") + " | " + emp3Sal2.ToString("c") + " |");
            WriteLine("| 2020   | " + emp1Sal3.ToString("c") + " | " + emp2Sal3.ToString("c") + " | " + emp3Sal3.ToString("c") + " |");
            WriteLine("+-------------------------------+");
        }
    }
}
