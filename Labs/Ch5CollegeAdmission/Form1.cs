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
 * Name: Aaron McArdle
 * 
 * Write a GUI program that determines eligibility for college applicants:
 *  - Prompt the user for the high-school GPA and admission test score.
 *  - Display "Accept" if the student's GPA is 3.0 or higher and their admission test score is 60 or greater.
 *  - Display "Accept" if the student's GPA is less than 3.0 and their admission test score is 80 or greater.
 *  - Otherwise display "Reject"
 * 
 */

namespace Ch5CollegeAdmission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            string accept = "ACCEPT";
            string reject = "REJECT";
            double gpa = Convert.ToDouble(txtGPA.Text);
            double admitScore = Convert.ToDouble(txtTestScore.Text);

            if ((gpa >= 3.0) && (admitScore >= 60))
            {
                txtStatus.Text = accept;
            }
            else if ((gpa < 3.0) && (admitScore >= 80))
            {
                txtStatus.Text = accept;
            }
            else
            {
                txtStatus.Text = reject;
            }
        }
    }
}
