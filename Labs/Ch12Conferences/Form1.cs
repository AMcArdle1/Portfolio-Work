using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12Conferences
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Global Constants
        const int MAXNUM = 5;   // Max number of Conferences

        // Global Variables
        string groupName;
        DateTime date;
        int attendees;
        int roomNum;
        int currentNum = 0;
        int totalAttendees = 0;
        List<Conference> conferences = new List<Conference>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;
            int result;

            if (keepGoing)
            {
                keepGoing = ValidateGroupName();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = ValidateStartDate();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = ValidateAttendees(out result);
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = ValidateRoomNumber(out result);
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                // Check for Already full list
                if (currentNum >= MAXNUM)
                {
                    showMessageBox("Attempt To Enter Filled List!",
                                   "LIST ALREADY FILLED!!!");
                    return;
                }
                else
                {
                    FillList();
                }
            }
        }

        private bool ValidateGroupName()
        {
            if (txtGNEntry.Text.Trim() == "")
            {
                showMessageBox("Group Name Cannot Be Blank",
                               "INVALID GROUP NAME!!!");
                txtGNEntry.Focus();
                return false;
            }

            groupName = txtGNEntry.Text;
            return true;
        }

        private bool ValidateStartDate()
        {
            if (txtSDEntry.Text.Trim() == "")
            {
                showMessageBox("Start Date Cannot Be Blank",
                               "INVALID START DATE!!!");
                txtSDEntry.Focus();
                return false;  
            }

            date = Convert.ToDateTime(txtSDEntry.Text);
            return true;
        }

        private bool ValidateAttendees(out int result)
        {
            if(txtAEntry.Text.Trim() == "")
            {
                showMessageBox("Attendees Field Cannot Be Blank",
                               "INVALID INPUT!!!");
                result = -1;
                txtAEntry.Focus();
                return false;
            }

            bool res = Int32.TryParse(txtAEntry.Text, out result);

            if (!res)
            {
                showMessageBox("Attendees Field Must Be Numeric",
                               "NON-NUMERIC INPUT!!");
                result = -1;
                txtAEntry.Text = "";
                txtAEntry.Focus();
                return false;
            }

            if (result <= 0)
            {
                showMessageBox("Attendees Field Must Be Greater Than 0",
                               "NEGATIVE ATTENDEES FIELD!!!");
                result = -1;
                txtAEntry.Text = "";
                txtAEntry.Focus();
                return false;
            }

            attendees = Convert.ToInt32(txtAEntry.Text);
            totalAttendees += result;

            return true;
        }

        private bool ValidateRoomNumber(out int result)
        {
            if (txtREntry.Text.Trim() == "")
            {
                showMessageBox("Room Field Cannot Be Blank",
                               "INVALID INPUT!!!");
                result = -1;
                txtREntry.Focus();
                return false;
            }

            bool res = Int32.TryParse(txtREntry.Text, out result);

            if (!res)
            {
                showMessageBox("Room Field Must Be Numeric",
                               "NON-NUMERIC INPUT!!");
                result = -1;
                txtREntry.Text = "";
                txtREntry.Focus();
                return false;
            }

            if (result <= 0)
            {
                showMessageBox("Room Field Must Be Greater Than 0",
                               "NEGATIVE ROOM FIELD!!!");
                result = -1;
                txtREntry.Text = "";
                txtREntry.Focus();
                return false;
            }

            roomNum = result;

            return true;
        }

        private void FillList()
        {
            conferences.Add(new Conference(groupName, date ,attendees, roomNum));
            
            lblTAResults.Text = totalAttendees.ToString();
            rtxtSearchResults.Text = "Group Name: " + conferences[currentNum].GetGroupName() + "\n" +
                                     "Starting Date: " + conferences[currentNum].GetStartingDate() + "\n" + 
                                     "Attendees: " + conferences[currentNum].GetAttendees() + "\n" + 
                                     "Room #: " + conferences[currentNum].GetRoomNumber() + "\n";
            
            ++currentNum;
            lblCResults.Text = currentNum.ToString() + " / 20";
        }



        private void showMessageBox(string message, string title)
        {
            MessageBox.Show(message,
                            title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
