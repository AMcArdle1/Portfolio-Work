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
 * Write a GUI application that can reverse the order of four numbers
 * entered by the user.
 * 
 * Create a method named Reverse4() that accepts four integers by reference and has no return value.
 * This method should reverse the order of all 4 integers that were passed in.
 * 
 */

namespace Ch8ReverseFour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare and initialize program constant 
        const int MAX = 4;      // Number of array elements

        // Declare and initialize program variables 
        static int[] numbers = new int[MAX];


        private void btnReverse_Click(object sender, EventArgs e)
        {
            inputNumbers();
            Reverse4();
        }

        private void inputNumbers()
        {
            numbers[0] = Convert.ToInt32(txtNumber1.Text);
            numbers[1] = Convert.ToInt32(txtNumber2.Text);
            numbers[2] = Convert.ToInt32(txtNumber3.Text);
            numbers[3] = Convert.ToInt32(txtNumber4.Text);
        }

        private void Reverse4()
        {
            Array.Reverse(numbers);

            txtNumber1.Text = Convert.ToString(numbers[0]);
            txtNumber2.Text = Convert.ToString(numbers[1]);
            txtNumber3.Text = Convert.ToString(numbers[2]);
            txtNumber4.Text = Convert.ToString(numbers[3]);
        }
    }
}
