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
 * Write a GUi applicaton that masks all but the last 4 digits of a credit card number with
 * an X.
 *   - Leave the last 4 digits as is. 
 *   - Leave any spaces as is. 
 *   - Replace any number or letter with a #
 *         * HINT: Research Char.IsDigit() & Char.IsLetter()
 *   - The program should work for credit card numbers that are any length 
 *     (including numbers that are less than four digits long).
 *   - The program must support credit card numbers with spaces, dashes, or no separator.
 *   
 * Create a method named MaskNumber() that accepts an unmasked string, a replacement character,
 * the number of digits to preserve, then returns the masked string.
 * 
 */

namespace Ch6CreditCardMasker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMask_Click(object sender, EventArgs e)
        {
            maskNumber();
        }

        private void maskNumber()
        {
            //Declare Variables 
            string unmaskedString = txtEntry.Text;
            string maskedString = "";
            int len = txtEntry.Text.ToString().Length;

            for (int lcv = 0; lcv < len; ++lcv)
            {
                switch (unmaskedString)
            }
            
        }
    }
}
