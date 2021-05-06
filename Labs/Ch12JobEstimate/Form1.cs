using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12JobEstimate
{
    public partial class FormJE : Form
    {
        public FormJE()
        {
            InitializeComponent();
        }

        // Global Constant
        const decimal TRIPFEE = 35.00m;

        // Global Variables 
        List<Job> jobs = new List<Job>();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            jobs.Clear();

            string description = txtDescription.Text.Trim();
            string htcStr = txtHTC.Text.Trim();
            string hrStr = txtHourlyRate.Text.Trim();
            decimal hoursToComplete = 0.0m;
            decimal hourlyRate = 0.0m;
            decimal totalFee = 0.0m;
            
            try
            {
                if (description == "")
                {
                    showMessageBox("Description cannot be blank",
                                   "DESCRIPTION FIELD EMPTY!!!!");
                    return;
                }

                if (htcStr == "")
                {
                    showMessageBox("Hours To Complete cannot be blank",
                                   "HOURS TO COMPLETE FIELD EMPTY!!!");
                    return;
                }

                hoursToComplete = Convert.ToDecimal(htcStr);

                if (hoursToComplete <= 0)
                {
                    showMessageBox("You cannot work less than 0 hours",
                                   "INVALID HOURS TO COMPLETE!!!");
                    return;
                }

                if (hrStr == "")
                {
                    showMessageBox("Hourly Rate cannot be blank",
                                   "HOURLY RATE FIELD EMPTY!!!");
                    return;
                }

                hourlyRate = Convert.ToDecimal(hrStr);

                if (hourlyRate <= 0)
                {
                    showMessageBox("Invalid Hourly Rate, Please enter a number >0",
                                   "INVALID HOURLY RATE!!!");
                }

                totalFee = (hourlyRate * hoursToComplete) + TRIPFEE;

                jobs.Add(new Job(description, hoursToComplete, hourlyRate, totalFee));
                displayCurrentValue();
            }
            catch (FormatException fe)
            {
                showMessageBox("Non-Numeric Input",
                               "NON-NUMERIC INPUT!!!");
                return;
            }
        }

        private void showMessageBox(string message, string title)
        {
            MessageBox.Show(message,
                            title, 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
        }

        private void displayCurrentValue()
        {
            lblDescriptionCurrent.Text = jobs[0].GetDescription();
            lblHTCCurrent.Text = jobs[0].GetHTC().ToString() + " hours";
            lblHourlyRateCurrent.Text = jobs[0].GetHourlyFee().ToString("c");
            lblTotalFeeCurrent.Text = jobs[0].GetTotalFee().ToString("c");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearCurrentValue();
        }

        private void clearCurrentValue()
        {
            jobs.Clear();
            txtDescription.Text = "";
            txtHTC.Text = "";
            txtHourlyRate.Text = "";
            lblDescriptionCurrent.Text = "";
            lblHTCCurrent.Text = "";
            lblHourlyRateCurrent.Text = "";
            lblTotalFeeCurrent.Text = "";
        }

        private void FormJE_Load(object sender, EventArgs e)
        {
            clearCurrentValue();
        }

        
    }
}
