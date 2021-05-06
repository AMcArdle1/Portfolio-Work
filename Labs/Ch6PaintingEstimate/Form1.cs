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
 * Write a GUI application that esitmates the cost of painting a room. The price of the job
 * is $6 per square foot. Assume that the room has four full walls and 9-foot ceilings.
 * 
 * Create the following methods: 
 *  - Create a method named CalculateTotalArea() that accepts the length and width of the room
 *  in feet and returns the total area of the room in square feet.
 *  
 *  - Create a method named CalculatePaintEstimate() that accepts the total area the room in 
 *  square feet and returns the total cost of the job in dollars.
 *   
 */

namespace Ch6PaintingEstimate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare Variables 
        const decimal PRICE_PER_SQ_FOOT = 6.00m;

        double length = 0.0;
        double width = 0.0;
        decimal totalArea = 0.0m;
        decimal totalCost = 0.0m;

        private void button1_Click(object sender, EventArgs e)
        {
            calculateTotalArea();
            calculatePaintEstimate();
        }

        private void calculateTotalArea()
        {
            length = Convert.ToDouble(txtLength.Text);
            width = Convert.ToDouble(txtWidth.Text);

            totalArea = (decimal)(length * width);

            lblTotalArea.Text = totalArea.ToString("f2");
        }

        private void calculatePaintEstimate()
        {
            totalCost = totalArea * PRICE_PER_SQ_FOOT;

            lblTotalCost.Text = totalCost.ToString("c");
        }
    }
}
