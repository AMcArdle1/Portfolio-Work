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
 * Create a GUI application to calculate a person's BMI.
 * 
 * 1. If the user does not enter a number for their weight then display "INVALID WEIGHT" in red.
 * 2. If the user enters a weight less than 70lbs or more than 300lbs then displays "INVALID WEIGHT" in red.
 * 3. If the user does not enter a number for their height then display "INVALID HEIGHT" in red.
 * 4. If the user enters a height less than 60 inches or more than 84 then display "INVALID HEIGHT" in red.
 * 5. If the weight and height are valid then display the calculate BMI and category.
 * 
 */
namespace Ch7BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare Global Constants

        const int MIN_WEIGHT = 70;
        const int MAX_WEIGHT = 300;
        const int MIN_HEIGHT = 60;
        const int MAX_HEIGHT = 84;
        const double MINOPTIMAL = 18.5;
        const double MAXOVER = 25.0;
        const double MINOBESE = 30.0;
        

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            // Declare Program Variables

            int userWeight = 0;
            int userHeight = 0;
            double userBMI = 0.0;

            try
            {
                validateWeight();
                userWeight = Convert.ToInt32(txtWeight.Text);
                validateHeight();
                userHeight = Convert.ToInt32(txtHeight.Text);
                userBMI = calculateBMI(userWeight, userHeight);
                lblBMI.Text = "BMI: " + userBMI.ToString("f1");
                bmiCategory(userBMI);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception Occurred!\n" + e.Message, "EXCEPTION!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validates that there is a value entered for Weight.
        // If value is entered, it validates that the value is within range.
        private void validateWeight()
        {
            bool flag = false;
            string weightStr = txtWeight.Text.ToString();
            int weightInt = 0;

            flag = validateIsNumeric(weightStr);

            if (!flag)
            {
                txtWeight.Text = "";
                txtWeight.Focus();
                throw new ArgumentException(
                    string.Format("Non-Numeric value for Weight was entered"));
            }
            else
            {
                weightInt = Convert.ToInt32(txtWeight.Text);

                if ((weightInt < MIN_WEIGHT) || (weightInt > MAX_WEIGHT))
                {
                    txtWeight.Text = "";
                    txtWeight.Focus();
                    throw new ArgumentException(
                        string.Format("Out-Of-Range Value (< 70 or > 300) was entered for Weight"));
                }
            }
        }

        // Validates that there is a value entered for Height.
        // If value is entered, it validates that the value is within range.
        private void validateHeight()
        {
            bool flag = false;
            string heightStr = txtHeight.Text.ToString();
            int heightInt = 0;

            flag = validateIsNumeric(heightStr);

            if (!flag)
            {
                txtHeight.Text = "";
                txtHeight.Focus();
                throw new ArgumentException(
                    string.Format("Non-Numeric value for Height was entered"));
            }
            else
            {
                heightInt = Convert.ToInt32(txtHeight.Text);

                if ((heightInt < MIN_HEIGHT) || (heightInt > MAX_HEIGHT))
                {
                    txtHeight.Text = "";
                    txtHeight.Focus();
                    throw new ArgumentException(
                        string.Format("Out-Of-Range Value (< 60 or > 84) was entered for Weight"));
                }
            }
        }

        private bool validateIsNumeric(string input)
        {
            int test = 0;

            return int.TryParse(input, out test);
        }

        // This method calculates the User's BMI from the values that were entered. 
        private double calculateBMI(int uW, int uH)
        {
            double BMI = ((uW / (Math.Pow(uH, 2))) * 703.0);

            return BMI;
        }

        // This method determines what the users BMI category is based on their BMI.
        private void bmiCategory(double bmi)
        {
            if (bmi < MINOPTIMAL)
            {
                lblCategory.Text = "Category: Underweight BMI";
            }
            else if (bmi < MAXOVER)
            {
                lblCategory.Text = "Category: Normal BMI";
            }
            else if (bmi < MINOBESE)
            {
                lblCategory.Text = "Category: Overweight BMI";
            }
            else
            {
                lblCategory.Text = "Category: Obese BMI";
            }
        }
    }
}
