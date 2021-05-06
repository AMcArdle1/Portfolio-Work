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
 * Write a GUI application that estimates the cost of a custom built desk based on a few factors.
 * 
 * The user can select from four kinds of wood: 
 * - Enter "m" for mahogany
 * - Enter "o" for oak
 * - Enter "p" for pine
 * - Enter anything else for other
 * 
 * Pine desks have a base cost of $100.
 * Oak desks have a base cost of $140.
 * All other woods have a base cost of $180.
 * There is a $30 surcharge added for each drawer.
 * 
 * Create the following methods:
 * - getWood()
 *   - Accepts no parameters, and returns the type of wood as a string ("mahogany", "oak", "pine", "other")
 * - getDrawers()
 *   - Accepts no parameters, and returns the number of drawers as an int.
 * - calculateWoodCost()
 *   - accepts type of wood as a string, and returns the cost of the wood as a double.
 * - calculateDrawerCost()
 *   - accepts the number of drawers as an int, and retuns the cost of the drawers as a double.
 * - calculateTotalCost()
 *   - accepts type of wood as a string and the number of drawers as an int, and retuns the total cost of the desk as a double. 
 */

namespace Ch6CustomDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare Global Variables 
        const double PINE_PRICE = 100.00;
        const double OAK_PRICE = 140.00;
        const double OTHER_PRICE = 180.00;
        const double DRAWER_PRICE = 30.00;

        char woodChoice = ' ';
        int numDrawers = 0;
        double woodCost = 0.0;
        double drawerCost = 0.0;
        double totalCost = 0.0;


        private void btnEstimate_Click(object sender, EventArgs e)
        {
            getWood();
            getDrawers();
            calculateWoodCost();
            calculateDrawerCost();
            calculateTotalCost();
        }

        private void getWood()
        {
            woodChoice = Convert.ToChar(txtWoodType.Text.Trim().ToLower());

        }

        private void getDrawers()
        {
            numDrawers = Convert.ToInt32(txtNumDrawers.Text);
        }

        private void calculateWoodCost()
        {
            if (woodChoice == 'm')
            {
                woodCost = OTHER_PRICE;
            }
            else if (woodChoice == 'o')
            {
                woodCost = OAK_PRICE;
            }
            else if (woodChoice == 'p')
            {
                woodCost = PINE_PRICE;
            }
            else
            {
                woodCost = OTHER_PRICE;
            }

            lblCostOfWood.Text = woodCost.ToString("c");
        }

        private void calculateDrawerCost()
        {
            drawerCost = numDrawers * DRAWER_PRICE;

            lblCostOfDrawers.Text = drawerCost.ToString("c");
        }

        private void calculateTotalCost()
        {
            totalCost = woodCost + drawerCost;

            lblTotalCost.Text = totalCost.ToString("c");
        }

    }
}
