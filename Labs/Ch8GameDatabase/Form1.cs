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
 * Create a searchable database for a video game store.
 * 
 */

namespace Ch8GameDatabase
{
    public partial class FormGameBreak : Form
    {
        public FormGameBreak()
        {
            InitializeComponent();
        }
        // Declare and initialize program constant
        const string GNF = "Game Not Found";

        // Declare the 3 parallel arrays
        string[] name = {"Player Unknown's Battlegrounds (PUBG)", "League of Legends", "Call of Duty: Black Ops III", "Battlefield 4", "Super Mario Odyssey"};
        string[] publisher = {"Bluehole","Riot Games","Activision","Electronic Arts (EA)","Nintendo"};
        decimal[] price = {35.00m, 0.00m, 60.00m, 20.00m, 60.00m};

        // Declare global variable
        int index = -1;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = doesSearchItemExist();

            if (keepGoing)
            {
                printResults();
            }
            else
            {
                lblNameResult.Text = GNF;
                lblPublisherResult.Text = GNF;
                lblPriceResult.Text = GNF;
            }
        }

        private bool doesSearchItemExist()
        {
            index = -1;
            bool retVal = true;
            string item = txtSearchItem.Text.ToLower().Trim();

            if (item == "")                 // Text Box Entry is blank
            {
                MessageBox.Show("No Search Item Entered", 
                                "ERROR!!!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtSearchItem.Focus();
            }
            else                                                // Text Box Entry is filled
            { 
                for (int lcv = 0; lcv < name.Length; ++lcv)
                {
                    if (name[lcv].ToLower().Contains(item))
                    {   // item is in the name array
                        retVal = true;
                        index = lcv;
                        break;
                    }

                    else if(publisher[lcv].ToLower().Contains(item))
                    {   // item is in the publisher array
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
            lblNameResult.Text = name[index];
            lblPublisherResult.Text = publisher[index];
            lblPriceResult.Text = price[index].ToString("c");
        }

    }
}
