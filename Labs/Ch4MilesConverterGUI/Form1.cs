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

/*
 * NAME: Aaron McArdle
 * 
 * Write a GUI program that converts distances between miles and kilometers:
 *  - Declares a named constant name KM_PER_MILE which holds the number of 
 *    kilometers in a mile (1.6 km per mile).
 *  - Prompts the user for a distance in miles or kilometers.
 *  - The user can convert miles to kilometers.
 *  - The user can convert kilometers to miles.
 *  - The programs displays the distance in both kilmeters and miles.
 *  
 */
namespace Ch4MilesConverterGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare Variables

        const double KM_PER_MILE = 1.6;
        double miles = 0.0;
        double kilos = 0.0;
        string outputStr = "";

        private void btnKilo_Click(object sender, EventArgs e)
        {
            miles = Convert.ToDouble(txtMiles.Text);
            kilos = miles * KM_PER_MILE;

            outputStr = miles.ToString("f1") + " miles is " + kilos.ToString("f1") + " kilometers";

            txtAnswer.Text = outputStr;
        }

        private void btnMiles_Click(object sender, EventArgs e)
        {
            kilos = Convert.ToDouble(txtKilos.Text);
            miles = kilos / KM_PER_MILE;

            outputStr = kilos.ToString("f1") + " kilometers is " + miles.ToString("f1") + " miles";

            txtAnswer.Text = outputStr;
        }
    }
}
