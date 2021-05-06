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
 * Write a GUI application that allows the user to look up information about a chamption in Paladins by name. 
 */
namespace Ch12Paladins
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Global Constants 
        const int MAXLEN = 6;       // Max Number of Champions
        const string CNF = "CHAMPION NOT FOUND";

        // Global Variables 
        List<Champion> champions = new List<Champion>()
        {
            new Champion("Ruckus", "Front Line", "Miniguns", "Missile Launcher", "Emitter", "Advance", "Hexa Fire"),
            new Champion("Makoa", "Front Line", "Cannon", "Dredge Anchor", "Shell Shield", "Shell Spin", "Ancient Rage"),
            new Champion("Drogoz", "Damage", "Rocket Launcher", "Fire Spit", "Salvo", "Thrust", "Dragon Punch"),
            new Champion("Tyra", "Damage", "Auto Rifle", "Nade Launcher", "Fire Bomb", "Hunter's Mark", "Crossfire"),
            new Champion("Grover", "Support", "Throwing Axe", "Crippling Throw", "Blossom", "Vine", "Whirlwind"),
            new Champion("Evie", "Flank", "Ice Staff", "Ice Block", "Blink", "Soar", "Ice Storm")
        };
        private void button1_Click(object sender, EventArgs e)
        {
            int position = searchForChampion();

            if ((position >= 0) && (position < MAXLEN))
            {
                showChampionInfo(position);
            }
            else
            {
                showChampionNotFoundInfo();
            }
        }

        public int searchForChampion()
        {
            string searchTerm = txtChampionEntry.Text.Trim();

            // Looks through champion list, if match is found position is returned, otherwise returns -1;
            for (int lcv = 0; lcv < MAXLEN; ++lcv)
            {
                if (champions[lcv].GetName().ToLower() == searchTerm.ToLower())
                {
                    return lcv;
                }
            }

            return -1;
        }

        // A Match is Found, Displays the Champion Information
        public void showChampionInfo(int p)
        {
            rtxtResults.Text = "\n" + champions[p].GetName() +
                               "\n" + champions[p].GetChampionType() +
                               "\n\nLeftMouse: " + champions[p].GetLeftMouse() +
                               "\nRightMouse: " + champions[p].GetRightMouse() +
                               "\n\nQ: " + champions[p].GetQ() +
                               "\nF: " + champions[p].GetF()+
                               "\nE: " + champions[p].GetE();
        }

        // A Match is NOT Found, Displays CNF Error
        public void showChampionNotFoundInfo()
        {
            rtxtResults.Text = CNF;
        }

        public void clearFields()
        {
            rtxtResults.Text = "";
            txtChampionEntry.Text = "";
            txtChampionEntry.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
