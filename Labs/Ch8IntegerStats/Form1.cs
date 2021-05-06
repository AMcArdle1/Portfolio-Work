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
 * Name: Aaron McArdle
 * 
 * Write a GUI application that accepts up to 20 integers and calculates some 
 * statistics about those integers.
 * 
 */

namespace Ch8IntegerStats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare and initialize program constant
        const int MAXELEMENTS = 20;

        // Declare program array
        int [] numbers = new int [MAXELEMENTS];

        // Declare program variables 
        int min = 1000000;
        int max = -1;
        double sum = 0.0;
        double avg = 0.0;
        int count = 0;

        private void btnEnter_Click(object sender, EventArgs e)
        {
            calculateStats();
            count++;

            if (count == MAXELEMENTS)
            {
                txtNumEntry.Text = "";
                txtNumEntry.ReadOnly = true;
                printResults();
            }

        }

        private void calculateStats()
        {
            bool flag = false;
            string inputStr = txtNumEntry.Text.ToString();

            flag = validateIsNumeric(inputStr);

            if (!flag)
            {
                txtNumEntry.Text = "";
                txtNumEntry.Focus();
                MessageBox.Show("Non-Numeric Value was entered, Please try again.",
                               "ERROR!!!",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
            else
            {
                numbers[count] = Convert.ToInt32(txtNumEntry.Text.Trim());
                
                lblNumEnteredResult.Text = count + 1 + " / 20";

                if (numbers[count] < min)
                {
                    min = numbers[count];
                }
                else if (numbers[count] > max)
                {
                    max = numbers[count];
                }
                sum += numbers[count];

            }
        }

        private bool validateIsNumeric(string input)
        {
            int test = 0;

            return int.TryParse(input, out test);
        }

        private void printResults()
        {
            lblLowestResult.Text = min.ToString("f2");
            lblHighestResult.Text = max.ToString("f2");
            lblSumResult.Text = sum.ToString("f2");

            avg = sum / MAXELEMENTS;

            lblAverageResult.Text = avg.ToString("f2");
        }
    }
}
