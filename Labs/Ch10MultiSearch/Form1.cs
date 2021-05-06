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
 * Create a GUI application that can search for students by both first & last name.
 * - Create 10 of your own "records", each with a first name, a last name, a course, a course grade, and the GPA.
 * - The user can search for students by first name.
 * - The user can search for students by last name.
 * - When a student is found the search results display the student's full name, course, course grade, and overall GPA.
 * - When a student is not found display an error message.
 * - The user must be able to initiate a search by pressing Enter on the keyboard, in the corresponding Textbox (HINT: PerformClick).
 */

namespace Ch10MultiSearch
{
    public partial class FormMS : Form
    {
        public FormMS()
        {
            InitializeComponent();
        }

        // Declare and initialize program constant

        const string ERROR = "STUDENT NOT FOUND";

        // Declare and initialize program arrays

        string[] firstNames = {"Jon",
                               "Barry",
                               "Ben",
                               "Jamie",
                               "Ron",
                               "Harry",
                               "Bill",
                               "Jill",
                               "Mollie",
                               "Aaron"};

        string[] lastNames = {"Smith",
                               "Sanders",
                               "Peters",
                               "Valentine",
                               "Edwards",
                               "Peterson",
                               "Lee",
                               "Scott",
                               "Trevor",
                               "Wayne"};

        string[] courseName = {"GD 101",
                               "GD 111",
                               "AWD 1000",
                               "AWD 1100",
                               "ENG 100",
                               "ENG 111",
                               "ENG 200",
                               "CMP 100",
                               "CMP 200",
                               "PE 100"};

        string[] courseGrade = {"A",
                               "F",
                               "D",
                               "B",
                               "A",
                               "C",
                               "A",
                               "F",
                               "A",
                               "D"};

        string[] GPA =        {"4.0",
                               "2.5",
                               "3.2",
                               "3.4",
                               "3.0",
                               "3.1",
                               "2.9",
                               "1.5",
                               "4.2",
                               "3.0"};

        // Declare global variable
        int index = -1;

        private void btnSearchFirstName_Click(object sender, EventArgs e)
        {
            bool keepGoing = doesFirstNameExist();

            if (keepGoing)
            {
                printResults();
            }
            else
            {
                lblStudentName.Text = ERROR;
                lblCourseResult.Text = "";
                lblCourseGradeResult.Text = "";
                lblGPAResult.Text = "";
            }
        }

        private void btnSearchLastName_Click(object sender, EventArgs e)
        {
            bool keepGoing = doesLastNameExist();

            if (keepGoing)
            {
                printResults();
            }
            else
            {
                lblStudentName.Text = ERROR;
                lblCourseResult.Text = "";
                lblCourseGradeResult.Text = "";
                lblGPAResult.Text = "";
            }
        }

        // When user presses enter in first name text box it excutes the search by first name
        private void txtFirstNameEntry_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchFirstName_Click(this, new EventArgs()); 
            }
        }

        // When user presses enter in last name text box it excute the search by last name.
        private void txtLastNameEntry_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchLastName_Click(this, new EventArgs());
            }
        }

        private bool doesFirstNameExist()
        {
            index = -1;
            bool retVal = false;
            string item = txtFirstNameEntry.Text.Trim().ToLower();

            if (item == "")                 // Text Box Entry is blank
            {
                MessageBox.Show("No Search Item Entered",
                                "ERROR!!!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtFirstNameEntry.Focus();
            }
            else
            {
                for (int lcv = 0; lcv < firstNames.Length; ++lcv)
                {
                    if (firstNames[lcv].ToLower().Contains(item))
                    {   // item is in the name array
                        retVal = true;
                        index = lcv;
                        break;
                    }
                }
            }

            return retVal;
        }

        private bool doesLastNameExist()
        {
            index = -1;
            bool retVal = false;
            string item = txtLastNameEntry.Text.Trim().ToLower();

            if (item == "")                 // Text Box Entry is blank
            {
                MessageBox.Show("No Search Item Entered",
                                "ERROR!!!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtLastNameEntry.Focus();
            }
            else
            {
                for (int lcv = 0; lcv < lastNames.Length; ++lcv)
                {
                    if (lastNames[lcv].ToLower().Contains(item))
                    {   // item is in the name array
                        retVal = true;
                        index = lcv;
                        break;
                    }
                }
            }

            return retVal;
        }

        private void printResults()
        {
            lblStudentName.Text = firstNames[index] + " " + lastNames[index];
            lblCourseResult.Text = courseName[index];
            lblCourseGradeResult.Text = courseGrade[index];
            lblGPAResult.Text = GPA[index];
        }
    }
}
