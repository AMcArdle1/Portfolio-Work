using System;
using static System.Console;

/*
 * NAME: Aaron McArdle
 * Chapter 1 Lab Assignment
 *  Write, compile, and test a program named WineGlass that displays a pattern similar to the following on the screen.
 *  
 *  xxxxxxxxxxxxx
 *   x         x
 *    x       x
 *     xxxxxxx
 *        x
 *        x
 *      xxxxx
 */

namespace WineGlass
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("xxxxxxxxxxxxx");
            WriteLine(" x         x ");
            WriteLine("  x       x  ");
            WriteLine("   xxxxxxx   ");
            WriteLine("      x      ");
            WriteLine("      x      ");
            WriteLine("    xxxxx    ");
            ReadLine();
        }
    }
}
