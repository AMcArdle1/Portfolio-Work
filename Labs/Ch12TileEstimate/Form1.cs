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
 *  Name: Aaron McArdle 
 */

namespace Ch12TileEstimate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Global Constant
        const int MAXLEN = 5;

        // Global Variables 
        string[] names = new string[MAXLEN];
        int[] widths = new int[MAXLEN];
        int[] lengths = new int[MAXLEN];
        int[] areas = new int[MAXLEN];
        int[] boxNeeded = new int[MAXLEN];
        int currentNum = 0;
        int width = 0;
        int length = 0;
        int b = 0;
        int totalBoxes = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;
            int result;

            if (keepGoing)
            {
                keepGoing = validateName();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = validateWidth(out result);
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = validateLength(out result);
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                // Check for Already full list
                if (currentNum >= MAXLEN)
                {
                    showMessageBox("Attempt To Enter Filled List!",
                                   "LIST ALREADY FILLED!!!");
                    return;
                }
                else
                {
                    calculateCurrentRoom();
                    fillUpOutput();
                }
            }
        }

        private bool validateName()
        {
            if (txtName.Text.Trim() == "")
            {
                showMessageBox("Name Field Cannot Be Empty", 
                                "EMPTY NAME FIELD!!!");
                txtName.Focus();
                return false;
            }

            Name = txtName.Text;
            return true;
        }

        private bool validateWidth(out int result)
        {
            if (txtWidth.Text.Trim() == "")
            {
                showMessageBox("Width Field Cannot Be Empty",
                               "EMPTY WIDTH FIELD!!!");
                result = -1;
                txtWidth.Focus();
                return false;
            }

            bool res = Int32.TryParse(txtWidth.Text, out result);

            if (!res)
            {
                showMessageBox("Width Field Must Be Numeric",
                               "NON-NUMERIC WIDTH FIELD!!!");
                result = -1;
                txtWidth.Text = "";
                txtWidth.Focus();
                return false;
            }

            if (result <= 0)
            {
                showMessageBox("Width Field Must Be Greater Than 0",
                               "NEGATIVE WIDTH FIELD!!!");
                result = -1;
                txtWidth.Text = "";
                txtWidth.Focus();
                return false;
            }

            width = result;
            showMessageBox("Current width: " + width.ToString(),
                           "SET IN FUNCTION validateWidth()");
            return true;
        }

        private bool validateLength(out int result)
        {
            if (txtLength.Text.Trim() == "")
            {
                showMessageBox("Length Field Cannot Be Empty",
                               "EMPTY LENGTH FIELD!!!");
                result = -1;
                txtLength.Focus();
                return false;
            }

            bool res = Int32.TryParse(txtLength.Text, out result);

            if (!res)
            {
                showMessageBox("Length Field Must Be Numeric",
                               "NON-NUMERIC LENGTH FIELD!!!");
                result = -1;
                txtLength.Text = "";
                txtLength.Focus();
                return false;
            }

            if (result <= 0)
            {
                showMessageBox("Length Field Must Be Greater Than 0",
                               "NEGATIVE LENGTH FIELD!!!");
                result = -1;
                txtLength.Text = "";
                txtLength.Focus();
                return false;
            }

            length = result;
            showMessageBox("Current length: " + length.ToString(),
                           "SET IN FUNCTION validateLength()");
            return true;
        }

        private void calculateCurrentRoom()
        {
            widths[currentNum] = width;
            lengths[currentNum] = length;
            areas[currentNum] = length * width;

            b = areas[currentNum] / 12;
            if (areas[currentNum] % 12 > 0)
            {
                ++b;
            }

            totalBoxes += b;
            boxNeeded[currentNum] = b;
            ++currentNum;
        }

        private void fillUpOutput()
        {
            string tot = "";

            lblRoomsResult.Text = "";
            lblRoomsResult.Text = currentNum.ToString() + " / 5";
            lblTBNResult.Text = totalBoxes.ToString();

            tot = Name + " (";
            tot += width + "x";
            tot += length + ") ";
            tot += "needs ";
            tot += b.ToString();
            tot += " boxes";
            rtxtTotals.Text += tot + "\n";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            txtName.Text = "";
            txtWidth.Text = "";
            txtLength.Text = "";
            b = 0;
            length = 0;
            width = 0;
            txtName.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clearFields();
        }

        private void showMessageBox(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
