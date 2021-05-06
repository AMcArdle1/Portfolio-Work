using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * NAME: Aaron McArdle
 * 
 * Write a GUI application that counts the number of vowels in a phrase that is entered by 
 * the user. For this exerice, count both uppercase and lowercase vowels, but do not
 * consider y to be a vowel.
 * 
 * Create a method named CountVowels() that accepts a phrase and returns the number of vowels in that phrase.
 * THIS METHOD SHOULD NOT HAVE ANY SIDE EFFECTS.
 * 
 */

namespace Ch6Vowels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            countVowels();
        }

        private void countVowels()
        {
            int numberOfVowels = 0;
            int len = txtEntry.Text.ToString().Length;
            string input = txtEntry.Text.ToString().ToUpper();

            for (int lcv = 0; lcv < len; ++lcv)
            {
                switch (input[lcv])
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        ++numberOfVowels;
                        break;

                    default:
                        break;
                }
            }

            lblResult.Text = "There are " + numberOfVowels.ToString() + " vowels in your phrase.";
        }
    }
}
