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
 * Write a GUI program that calculates projected raises:
 *  - Declares a named constant PERCENT_RAISE and assign it a value of 4% (or 1.04)
 *  - Prompts the user for the names and salaries of three employees.
 *  - Displays the projected salaries for these three employee over the 
 *    next 2 years in a table, assuming that they get a 4% raise every year.
 *    
 */

namespace Ch4RaisesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare Variables

        const double PERCENT_RAISE = 0.04;
        
        string emp1 = "";
        string emp2 = "";
        string emp3 = "";

        double emp1Sal1 = 0.0;
        double emp2Sal1 = 0.0;
        double emp3Sal1 = 0.0;
        double emp1Sal2 = 0.0;
        double emp2Sal2 = 0.0;
        double emp3Sal2 = 0.0;
        double emp1Sal3 = 0.0;
        double emp2Sal3 = 0.0;
        double emp3Sal3 = 0.0;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Assign Values to Variables

            emp1 = txtEmp1Entry.Text;
            emp2 = txtEmp2Entry.Text;
            emp3 = txtEmp3Entry.Text;

            emp1Sal1 = Convert.ToDouble(txtSal1Entry.Text);
            emp2Sal1 = Convert.ToDouble(txtSal2Entry.Text);
            emp3Sal1 = Convert.ToDouble(txtSal3Entry.Text);


            // Calculate Projected Salary Values

            emp1Sal2 = emp1Sal1 + (emp1Sal1 * PERCENT_RAISE);
            emp2Sal2 = emp2Sal1 + (emp2Sal1 * PERCENT_RAISE);
            emp3Sal2 = emp3Sal1 + (emp3Sal1 * PERCENT_RAISE);

            emp1Sal3 = emp1Sal2 + (emp1Sal2 * PERCENT_RAISE);
            emp2Sal3 = emp2Sal2 + (emp2Sal2 * PERCENT_RAISE);
            emp3Sal3 = emp3Sal2 + (emp3Sal2 * PERCENT_RAISE);

            // Display Values to Table

            txtEmp1Name.Text = emp1;
            txtEmp2Name.Text = emp2;
            txtEmp3Name.Text = emp3;

            txtEmpSal1.Text = emp1Sal1.ToString("c");
            txtEmp2Sal1.Text = emp2Sal1.ToString("c");
            txtEmp3Sal1.Text = emp3Sal1.ToString("c");

            txtEmpSal2.Text = emp1Sal2.ToString("c");
            txtEmp2Sal2.Text = emp2Sal2.ToString("c");
            txtEmp3Sal2.Text = emp3Sal2.ToString("c");

            txtEmpSal3.Text = emp1Sal3.ToString("c");
            txtEmp2Sal3.Text = emp2Sal3.ToString("c");
            txtEmp3Sal3.Text = emp3Sal3.ToString("c");

        }

    }
}
