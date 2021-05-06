using System;
using static System.Console;

/*
 * NAME: Aaron McArdle
 * 
 * Write a console application that tracks the home sales of three salespeople 
 * (Danielle, Edward, Francis):
 *  
 *  - The program prompts the user for a salesperson initial (d, e, or f) 
 *    and the sales amount, then updates the total sales.
 *  
 *  - Any user can have multiple sales.
 *  
 *  - If the user enters "z" for the inital then the program should display the total
 *    sales for each salesperson, the grand total for all sales, and the name of the 
 *    salesperson with the highest total.
 *  
 *  - If the user enters an initial other than "d", "e", "f" or "z" then the program should
 *    display an error and prompt the user for a new initial.
 *  
 *  - All initals should be treated in case-insensitive manner.
 * 
 */

namespace Ch5HomeSales
{
    class Program
    {
        // Declare Variables 
        static char empInitial = ' ';
        static double saleAmount = 0.0;
        static double dSales = 0.0;
        static double eSales = 0.0;
        static double fSales = 0.0;
        static double totalSales = 0.0;

        static void Main(string[] args)
        {
          while (empInitial != 'z')
          {
                WriteLine("Who made the sale?");
                empInitial = Convert.ToChar(ReadLine().ToLower());
                saleAmount = 0.0;

                if (empInitial != 'd' && empInitial != 'e' && empInitial != 'f')
                {
                    WriteLine("Invalid Input");
                    continue;
                }
                
                if (empInitial == 'd')
                {
                    WriteLine("How much was the sale?");
                    saleAmount = Convert.ToDouble(ReadLine());
                    dSales += saleAmount;
                }

                else if (empInitial == 'e')
                { 
                    WriteLine("How much was the sale?");
                    saleAmount = Convert.ToDouble(ReadLine());
                    eSales += saleAmount;
                }

                else if (empInitial == 'f')
                {
                    WriteLine("How much was the sale?");
                    saleAmount = Convert.ToDouble(ReadLine());
                    fSales += saleAmount;
                }


          }

            WriteLine("Danielle Sales: " + dSales.ToString("c"));
            WriteLine("Edward Sales: " + eSales.ToString("c"));
            WriteLine("Francis Sales: " + fSales.ToString("c"));

            totalSales = dSales + eSales + fSales;
            WriteLine("\nGrand Total: " + totalSales.ToString("c"));

            if (dSales > eSales && dSales > fSales)
            {
                WriteLine("Danielle has the most sales");
            }
            else if (eSales > dSales && eSales > fSales)
            {
                WriteLine("Edward has the most sales");
            }
            else
            {
                WriteLine("Francis has the most sales");
            }

        }

    }
}
