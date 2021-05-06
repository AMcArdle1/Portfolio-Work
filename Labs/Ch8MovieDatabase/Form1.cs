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
 * Create a searchable database for a movie library.
 *  - The user can search by either the name of the movie or the director. 
 *  - If a movie is found, then the program will display information about the movie.
 *  - If a movie is not found, then it will display an error message.
 *  
 */
namespace Ch8MovieDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare and initialize program constant
        const string MNF = "Movie Not Found";

        // Declare 3 parallel arrays
        string[] name = { "Eternal Sunshine of the Spotless Mind", 
                          "Scott Pilgrim Vs. The World",
                          "Goldeneye",
                          "Dodgeball: A True Underdog Story"};
        string[] director = { "Marty Gondry",
                              "Edgar Wright",
                              "Martin Campbell", 
                              "Rawson Marshall Thurber" };
        string[] description = {"A film that explores the intricacy of relationships and the pain of loss. (One of my two favorite movies)",
                                "A bass guitarist for a garage-rock band faces an army of evil-exes who will stop at nothing to eliminate him for the love of a woman. (Another of my favorite movies)",
                                "A spy thriller that sees 007 trying to stop a former 00 Agent from using a satellite to destory the world.",
                                "A ragtag group bands together to join a dodgeball contest to save their gym from going out of business."};

        // Declare global variable 
        int index = -1;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = doesItemExist();

            if (keepGoing)
            {
                printResults();
            }
            else
            {
                lblNameResult.Text = MNF;
                lblDirectorResult.Text = MNF;
                lblDescriptionResult.Text = MNF;
            }
        }

        private bool doesItemExist()
        {
            index = -1;
            bool retVal = true;
            string item = txtMovieEntry.Text.ToLower().Trim();

            if (item == "")
            {
                MessageBox.Show("No Search Item Entered",
                                "ERROR!!!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtMovieEntry.Focus();
                retVal = false;
            }
            else
            {
                for (int lcv = 0; lcv < name.Length; ++lcv)
                {
                    if (name[lcv].ToLower().Contains(item))
                    {
                        retVal = true;
                        index = lcv;
                        break;
                    }
                    else if (director[lcv].ToLower().Contains(item))
                    {
                        retVal = true;
                        index = lcv;
                        break;
                    }
                    else
                    {
                        retVal = false;
                    }
                }
            }

            return retVal;
        }

        private void printResults()
        {
            lblNameResult.Text = name[index];
            lblDirectorResult.Text = director[index];
            lblDescriptionResult.Text = description[index];
        }
    }
}
