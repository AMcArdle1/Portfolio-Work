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
 * Write a GUI application that sorts all of the words in a phrase entered by the user.
 * 
 * Create a method named SortWords() that accepts a parameter array for the unsorted
 * words and returns an array with the sorted words.
 * 
 */
namespace Ch8SortedPhrase
{
    public partial class FormSortedPhrase : Form
    {
        public FormSortedPhrase()
        {
            InitializeComponent();
        }

        // Declare program array 
        string[] unsortedPhrase = { };

        private void btnSort_Click(object sender, EventArgs e)
        {
            inputPhrase();
            sortWords();
        }

        private void inputPhrase()
        {
            string input = txtPhraseEntry.Text;
            unsortedPhrase = input.Split();
        }

        private void sortWords()
        {
            lblResult.Text = "";

            Array.Sort(unsortedPhrase);
            for (int lcv = 0; lcv < unsortedPhrase.Length; ++lcv)
            {
                lblResult.Text += unsortedPhrase[lcv] + " ";
            }
        }
    }
}
