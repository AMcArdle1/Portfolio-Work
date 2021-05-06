using System;
using System.Windows.Forms;



/*
 * Name: Aaron McArdle
 * 
 * Create a GUI application to search for job openings.
 * - Program must contain at least 5 industries.
 * - Program must conatin information about at least 5 jobs.
 * - ListBox must be populated programmatically.
 * - ListBox must allow multiple industires to be selected.
 * - Clicking the search button will show the search results in a new window.
 * - Search results must be populated programmatically.
 * 
 */
namespace Ch10JobDatabase
{
    public partial class FormJDB : Form
    {
        public FormJDB()
        {
            InitializeComponent();
        }

        // Declare and initialize program constant
        const int MAXELEMENTS = 5;

        // Declare and initialize program arrays
        string[] industries = {"Information Technology",
                               "Mechanical Technology",
                               "Chemical Engineering",
                               "HVAC",
                               "Automotive" };

        private void FormJDB_Activated(object sender, EventArgs e)
        {
            listBoxIndustries.Items.Clear();

            for (int lcv = 0; lcv < MAXELEMENTS; ++lcv)
            {
                listBoxIndustries.Items.Add(industries[lcv]);
                listBoxIndustries.SelectedIndex = -1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
             int index = listBoxIndustries.SelectedIndex;
            
            if (index == -1)
            {
                MessageBox.Show("Please select an option",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                Form FormSR = new FormSR(index);
                FormSR.Show();
            }
        }
    }
}
