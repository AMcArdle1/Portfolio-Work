using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12GameBreak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Global Constants
        const int MAXLEN = 5;
        const string GNF = "GAME NOT FOUND";

        // Global Variables 
        List<Game> games = new List<Game>()
        {
            new Game("Player Unknown's Battlegrounds (PUBG)",   "Bluehole",             35M),
            new Game("League of Legends",                       "Riot Games",           0M),
            new Game("Call of Duty: Black Ops III",             "Activision",           60M),
            new Game("Battlefield 4",                           "Electronic Arts (EA)", 20M),
            new Game("Super Mario Odyssey",                     "Nintendo",             60M)
        };
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int position = searchForGame();

            // If position returned was between 1 - 4,
            // show the associated game information.
            if ((position >= 0) && (position <= (MAXLEN - 1)))
            {
                showGameInfo(position);
            }
            // Position not found (-1 returned)
            // Show GNF in all 3 labels
            else
            {
                showGameNotFoundInfo();
            }
        }

        // If game exists (i.e. there is a match on what was inputted)
        // Return the Index. Otherwise return -1
        public int searchForGame()
        {
            string searchTerm = txtGameEntry.Text.Trim();

            // Traverse through game list. If a match is found 
            // return the position.
            // Otherwise return -1
            for (int lcv = 0; lcv < MAXLEN; ++lcv)
            {
                if (games[lcv].GetName().ToLower() == searchTerm.ToLower() || 
                    games[lcv].GetPublisher().ToLower() == searchTerm.ToLower())
                {
                    return lcv;
                }
            }

            return -1;
        }

        public void showGameInfo(int p)
        {
            // p represents the selected game
            lblNameResult.Text = games[p].GetName();
            lblPublisherResult.Text = games[p].GetPublisher();
            lblPriceResult.Text = games[p].GetPrice().ToString("c");
        }

        public void showGameNotFoundInfo()
        {
            lblNameResult.Text = GNF;
            lblPublisherResult.Text = GNF;
            lblPriceResult.Text = GNF;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllOutputFields();
        }

        public void clearAllOutputFields()
        {
            lblNameResult.Text = "";
            lblPublisherResult.Text = "";
            lblPriceResult.Text = "";
            txtGameEntry.Text = "";
            txtGameEntry.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clearAllOutputFields();
        }
    }
}
