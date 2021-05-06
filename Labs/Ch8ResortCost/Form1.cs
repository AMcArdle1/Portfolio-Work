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
 * Write a GUI application that calculates the cost of resort stay based on the number of nights stayed.
 * 
 * Nights Stayed         Nightly Rate 
 * -------------         ------------
 * 1-2 Nights            $200 per night
 * 3-4 Nights            $180 per night
 * 5-7 Nights            $160 per night
 * 8 or more Nights      $145 per night
 * 
 */

namespace Ch8ResortCost
{
    public partial class FormResort : Form
    {
        public FormResort()
        {
            InitializeComponent();
        }

        // Declare and initialize program constant
        const int MAX = 8;     // Number of array elements 

        // Declare and initialize program arrays
        int[] NightsStayed = new int[MAX] { 1, 2, 3, 4, 5, 6, 7, 8 };
        double[] PricePerNight = new double[MAX] { 200.00, 200.00, 180.00, 180.00, 160.00, 160.00, 160.00, 145.00 };

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            int userInput = Convert.ToInt32(txtNightsStayed.Text.Trim());
            int index = Array.IndexOf(NightsStayed, userInput);

            if (index < 0 || index > MAX)
            {
                MessageBox.Show("The number of nights entered is out-of-range, please enter a number within range (1-8).",
                                "ERROR!!!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtNightsStayed.Text = "";
                txtNightsStayed.Focus();
            }
            else
            {
                int numNights = NightsStayed[index];
                double nightlyRate = PricePerNight[index];

                double totalCost = numNights * nightlyRate;

            lblNightlyCostResult.Text = nightlyRate.ToString("c");
            lblTotalCostResult.Text = totalCost.ToString("c");
            }
        }
    }
}
