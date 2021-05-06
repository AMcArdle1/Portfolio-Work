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
 * Implement Ch5HomeSales as a GUI program
 * 
 */

namespace Ch5HomeSalesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare Variables
        double saleAmount = 0.0;
        double dSales = 0.0;
        double eSales = 0.0;
        double fSales = 0.0;
        double totalSales = 0.0;

        private void btnEmpD_Click(object sender, EventArgs e)
        {
            saleAmount = Convert.ToDouble(txtSaleAmount.Text);
            dSales += saleAmount;
            txtSaleAmount.Text = "";
            txtSaleAmount.Focus();

            lblDSales.Text = "Danielle Sales: " + dSales.ToString("c");
            lblESales.Text = "Edward Sales: " + eSales.ToString("c");
            lblFSales.Text = "Francis Sales: " + fSales.ToString("c");

            totalSales = dSales + eSales + fSales;
            lblTotalSales.Text = "Grand Total: " + totalSales.ToString("c"); 

            if (dSales > eSales && dSales > fSales)
            {
                lblMostSales.Text = "Danielle has the most sales";
            }
            
        }

        private void btnEmpE_Click(object sender, EventArgs e)
        {
            saleAmount = Convert.ToDouble(txtSaleAmount.Text);
            eSales += saleAmount;
            txtSaleAmount.Text = "";
            txtSaleAmount.Focus();

            lblDSales.Text = "Danielle Sales: " + dSales.ToString("c");
            lblESales.Text = "Edward Sales: " + eSales.ToString("c");
            lblFSales.Text = "Francis Sales: " + fSales.ToString("c");

            totalSales = dSales + eSales + fSales;
            lblTotalSales.Text = "Grand Total: " + totalSales.ToString("c");

            if (eSales > dSales && eSales > fSales)
            {
                lblMostSales.Text = "Edward has the most sales";
            }
        }

        private void btnEmpF_Click(object sender, EventArgs e)
        {
            saleAmount = Convert.ToDouble(txtSaleAmount.Text);
            fSales += saleAmount;
            txtSaleAmount.Text = "";
            txtSaleAmount.Focus();

            lblDSales.Text = "Danielle Sales: " + dSales.ToString("c");
            lblESales.Text = "Edward Sales: " + eSales.ToString("c");
            lblFSales.Text = "Francis Sales: " + fSales.ToString("c");
            
            totalSales = dSales + eSales + fSales;
            lblTotalSales.Text = "Grand Total: " + totalSales.ToString("c");

            if (fSales > dSales && fSales > eSales)
            {
                lblMostSales.Text = "Francis has the most sales";
            }
        }

    }
}
