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
 * Write a GUI program that estimates the category of a hurricane based on the wind speed 
 * (based on the Saffir-Simpson Hurricane Scale):
 *  - Category 5 hurricanes have sustained winds of at least 157 miles per hour.
 *  - Category 4 hurricanes have sustained winds of at least 130 miles per hour.
 *  - Category 3 hurricanes have sustained winds of at least 111 miles per hour.
 *  - Category 2 hurricanes have sustained winds of at least 96 miles per hour.
 *  - Category 1 hurricanes have sustained winds of at least 74 miles per hour.
 *  - Any storm with winds of less than 74 miles per hour is not classified as a hurricane.
 * 
 */

namespace Ch5HurricaneCategories
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            double windSpeed = Convert.ToDouble(txtWindSpeed.Text);

            if (windSpeed >= 157)
            {
                txtCategory.Text = "Category 5";
            }
            else if (windSpeed >= 130)
            {
                txtCategory.Text = "Category 4";
            }
            else if (windSpeed >= 111)
            {
                txtCategory.Text = "Category 3";
            }
            else if (windSpeed >= 96)
            {
                txtCategory.Text = "Category 2";
            }
            else if (windSpeed >= 74)
            {
                txtCategory.Text = "Category 1";
            }
            else
            {
                txtCategory.Text = "Not a Hurricane";
            }
        }
    }
}
