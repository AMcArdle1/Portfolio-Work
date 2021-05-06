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
 * Write a GUI application that calculates delivery charges to 10 different zip codes.
 * 
 * ZIP CODE              Delivery Charge ($)
 * --------              ---------------
 *  63101                     20
 *  63103                     12
 *  63105                     25
 *  63109                     15
 *  63113                     10
 *  63118                     23
 *  63130                     18
 *  63133                     20
 *  63136                     17
 *  63137                     12
 * 
 */

namespace Ch8DeliveryCharge
{
    public partial class FormDeliveryCharge : Form
    {
        public FormDeliveryCharge()
        {
            InitializeComponent();
        }

        // Declare and initialize program constant
        const int MAX = 10;         // Number of array elements

        // Declare and initialize program variables
        int[] ZipCode = new int[MAX] {63101, 63103, 63105, 63109, 63113, 63118, 63130, 63133, 63136, 63137};        // array for zip codes
        double[] DeliveryCharge = new double[MAX] {20, 12, 25, 15, 10, 23, 18, 20, 17, 12};                         // array for delivery charges

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            GetCharge();
        }

        // Finds delivery charge through user input
        private void GetCharge()
        {
            int userInput = Convert.ToInt32(txtZipCode.Text.Trim());
            int index = Array.IndexOf(ZipCode, userInput);     // Searches ZipCode array for value, returns index value
            

            if (index < 0)                                     // Checks if user inputted a valid zip-code
            {
                MessageBox.Show("The Zip-Code you entered does not exist, Please enter a valid Zip-Code",
                                "ERROR!!!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtZipCode.Text = "";
                lblResult.Text = "NOT VALID";
                txtZipCode.Focus();
            }
            else
            {
                double chargeAmount = DeliveryCharge[index];   // Grabs corresponding value from other array
                lblResult.Text = chargeAmount.ToString("c");    
            }
        }
    }
}
