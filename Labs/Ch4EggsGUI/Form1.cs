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
 * NAME: Aaron McArdle
 * 
 * Write a GUI program that adds up the number of eggs produced by some chickens:
 *  - Prompts the user for a number of eggs laid by four chickens.
 *  - Sums the eggs laid and display the total in dozens and eggs.
 *  
 */

namespace Ch4EggsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare Variables
        const int dozen = 12;
        int chicken1 = 0;
        int chicken2 = 0;
        int chicken3 = 0;
        int chicken4 = 0;
        int totalEggs = 0;
        int dozenEggs = 0;
        int remainderEggs = 0;
        string outputStr = "";


        private void button1_Click(object sender, EventArgs e)
        {
            // Assign Values to Variables 

            chicken1 = Convert.ToInt32(txtChicken1.Text);
            chicken2 = Convert.ToInt32(txtChicken2.Text);
            chicken3 = Convert.ToInt32(txtChicken3.Text);
            chicken4 = Convert.ToInt32(txtChicken4.Text);

            totalEggs = chicken1 + chicken2 + chicken3 + chicken4;
            dozenEggs = totalEggs / dozen;
            remainderEggs = totalEggs % dozenEggs;

            outputStr = totalEggs + " eggs total, or " + dozenEggs + " dozen and " + remainderEggs + " eggs";

            txtAnswer.Text = outputStr;

        }
    }
}
