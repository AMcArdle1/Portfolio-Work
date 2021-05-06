using System;
using static System.Console;

namespace Ch2_3PigLatin
{
    class Program
    {
        const string pigLatin = "ay";
        static void Main(string[] args)
        {
            string word = "";
            char firstChar = ' ';

            Write("Enter any English word: ");
            word = ReadLine();

            firstChar = Convert.ToChar(word.Substring(0, 1));
            word = word.Remove(0, 1);
            WriteLine("The first letter is: " + firstChar);
            WriteLine("The remaining string is: " + word);
            word = word + firstChar.ToString() + pigLatin;
            WriteLine("The Pig Latin string is: " + word);
        }
    }
}
