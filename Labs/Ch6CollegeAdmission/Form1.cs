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
 * Write a GUI program that determines eligibility for college applicants:
 *  - Prompt the user for the high-school GPA and admission test score.
 *  - Display “Accept” if the student’s GPA is 3.0 or higher and their admission test score is 60 or greater.
 *  - Display “Accept” if the student’s GPA is less than 3.0 and their admission test score is 80 or greater.
 *  - Otherwise display “Reject".
 *  
 *  Create a method named IsStudentAccepted() that accepts a GPA and an admission test score, and returns a boolean
 *  indicating whether or not the student was accepted. This method should not have any side effects.
 * 
 */

namespace Ch6CollegeAdmission
{
    public partial class CollegeAdmissions : Form
    {
        public CollegeAdmissions()
        {
            InitializeComponent();
        }

        // Declare Variables 
        private void btnAdmit_Click(object sender, EventArgs e)
        {
            isStudentAccepted();
        }

        private bool isStudentAccepted()
        {
            double gpa = Convert.ToDouble(txtGPA.Text);
            double admitScore = Convert.ToDouble(txtAdmissionScore.Text);

            if ((gpa >= 3.0) && (admitScore >= 60))
            {
                lblStatus.Text = "ACCEPT";
            }
            else if ((gpa < 3.0) && (admitScore >= 80))
            {
                lblStatus.Text = "ACCEPT";
            }
            else
            {
                lblStatus.Text = "REJECT";
                return false;
            }
            return true;
        }
    }
}
