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

namespace Ch5Vowels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int numberOfVowels = calculateNumberOfVowels();

            lblNumberVowels.Text = "There are " + numberOfVowels + " vowels in your phrase";
        }

        private int calculateNumberOfVowels()
        {
            int number = 0;
            int len = txtPhrase.Text.ToString().Length;
            string input = txtPhrase.Text.ToString().ToUpper();

            for (int lcv = 0; lcv < len; ++lcv)
            {
                switch (input[lcv])
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        ++number;
                        break;

                    default:
                        break;
                }
            }

            return number;
        }
    }
}
