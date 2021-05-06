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
 */

namespace Ch12FlashCards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Global Constant
        const int MAXLEN = 10;      // Max number of flashcard objects

        // Global Variables
        int lcv = 0;                // Loop Control Variable
        // Creating a list of flashCard objects
        List<Flashcard> flashCards = new List<Flashcard>()
        {
            new Flashcard("internet", "The Internet is the wiring that allows computers all over the world to communicate."),
            new Flashcard("world wide web", "The World Wide Web is a system that operates via the wiring that is the Internet."),
            new Flashcard("web browser", "A program you use to look at, and navigate between, pages on the World Wide Web."),
            new Flashcard("cookie", "A small text file sent to your computer by a web site you have visited. "),
            new Flashcard("capcta", "Strings of letters and numbers typed in before something can be accessed.")
        };

        private void btnDefine_Click(object sender, EventArgs e)
        {
            // Check for no input 
            if (txtTermEntry.Text.Trim() == string.Empty)      // Same as txtTermEntry.Text == ""
            {
                showMessageBox("No term entered into the associated textBox!",
                               "TERM TEXTBOX EMPTY");
                txtTermEntry.Focus();
                return;
            }

            // There is something in the Term TextBox. 
            // See if there is a definiton for the entered term.
            for (lcv = 0; lcv < flashCards.Count; ++lcv)
            {
                // If term found in list. Get definition
                if (txtTermEntry.Text.ToLower() == flashCards[lcv].GetTerm())
                {
                    lblDefinition.Text = flashCards[lcv].GetDefinition();
                    clearBottom();
                    lblDefinition.Visible = true;

                    return;
                }
            }

            //  Term was NOT found in list, "possibly" create a new term.
            if (flashCards.Count < MAXLEN)
            {
                //  Add new term to list
                lblDontKnowYet.Visible = true;
                txtDefinitionInput.Visible = true;
                btnAdd.Visible = true;
                lblDefinition.Visible = false;
                txtDefinitionInput.Focus();
            }

            // This list is already full 
            else
            {
                showMessageBox("Failed Attempt To Add New Term. List Already Full",
                               "FLASH CARD LIST ALREADY FULL");
                txtDefinitionInput.Text = "";
                txtDefinitionInput.Visible = false;
                btnAdd.Visible = false;
                lblDontKnowYet.Visible = false;
                txtTermEntry.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Instantiate a new flashcard object
            flashCards.Add(new Flashcard(txtTermEntry.Text, txtDefinitionInput.Text));
            lblDefinition.Text = txtDefinitionInput.Text;
            showMessageBox("The Term " + txtTermEntry.Text + " has been successfully added to the list.",
                           "TERM ADDED TO LIST!!");
            clearBottom();
            clearTop();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearBottom();
            clearTop();
        }

        // Clear Top-half of screen
        private void clearTop()
        {
            txtTermEntry.Text = "";
            lblDefinition.Text = "";
            lblDefinition.Visible = false;
            txtTermEntry.Focus();
        }

        // Clear Bottom-half of screen
        private void clearBottom()
        {
            lblDontKnowYet.Visible = false;
            txtDefinitionInput.Text = "";
            txtDefinitionInput.Visible = false;
            btnAdd.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clearBottom();
            lblDefinition.Visible = false;
        }

        //  Programmer-Written method to handle all MessageBox entries
        private void showMessageBox(string title, string text)
        {
            MessageBox.Show(title,
                            text,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
