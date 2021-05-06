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
 * Create a GUI application to check that orders are valid.
 * 
 */
namespace Ch7OrderExceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare Global Constants
        const int MIN_ITEM_NUM = 100;
        const int MAX_ITEM_NUM = 999;
        const int MIN_QUANTITY = 1;
        const int MAX_QUANTITY = 12;
        const int MIN_DAYS = 1;
        const int MAX_DAYS = 30;

        private void btnValidate_Click(object sender, EventArgs e)
        {
            validate();
        }

        private void validate()
        {
            // Declare program variables
            int itemNumber = 0;
            int itemQuantity = 0;
            int estimatedDays = 0;

            try
            {
                validateItemNumber();
                validateItemQuantity();
                validateEstimatedDays();
                lblOrderStatus.Text = "ORDER IS VALID";
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception Occurred!\n" + e.Message, "EXCEPTION!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validateItemNumber()
        {
            bool flag = false;
            string itemStr = txtItemNumber.Text.ToString();
            int itemInt = 0;

            flag = validateIsNumeric(itemStr);

            if (!flag)
            {
                txtItemNumber.Text = "";
                txtItemNumber.Focus();
                lblOrderStatus.Text = "ORDER IS INVALID";
                throw new ArgumentException(
                    string.Format("Non-Numeric Input was entered, please try again."));
            }
            else
            {
                itemInt = Convert.ToInt32(txtItemNumber.Text);
                if ((itemInt < MIN_ITEM_NUM) || (itemInt > MAX_ITEM_NUM))
                {
                    txtItemNumber.Text = "";
                    txtItemNumber.Focus();
                    lblOrderStatus.Text = "ORDER IS INVALID";
                    throw new ArgumentException(
                        string.Format("Out of Range Value (<100 or >999) has been entered, please try again"));
                }
            }
        }

        private void validateItemQuantity()
        {
            bool flag = false;
            string quantityStr = txtQuantity.Text.ToString();
            int quantityInt = 0;

            flag = validateIsNumeric(quantityStr);

            if (!flag)
            {
                txtQuantity.Text = "";
                txtQuantity.Focus();
                lblOrderStatus.Text = "ORDER IS INVALID";
                throw new ArgumentException(
                    string.Format("Non-Numeric Value has been inputted, please try again"));
            }
            else
            {
                quantityInt = Convert.ToInt32(txtQuantity.Text);
                if ((quantityInt < MIN_QUANTITY) || (quantityInt > MAX_QUANTITY))
                {
                    txtQuantity.Text = "";
                    txtQuantity.Focus();
                    lblOrderStatus.Text = "ORDER IS INVALID";
                    throw new ArgumentException(
                        string.Format("Out of Range Value (<1 or >12) has been inputted, please try again"));
                }
            }
        }

        private void validateEstimatedDays()
        {
            bool flag = false;
            string daysStr = txtEstimatedDD.Text.ToString();
            int daysInt = 0;

            flag = validateIsNumeric(daysStr);

            if (!flag)
            {
                txtEstimatedDD.Text = "";
                txtEstimatedDD.Focus();
                lblOrderStatus.Text = "ORDER IS INVALID";
                throw new ArgumentException(
                    string.Format("Non-Numeric Value has been inputted, please try again"));
            }
            else
            {
                daysInt = Convert.ToInt32(txtEstimatedDD.Text);
                if ((daysInt < MIN_DAYS) || (daysInt > MAX_DAYS))
                {
                    txtEstimatedDD.Text = "";
                    txtEstimatedDD.Focus();
                    lblOrderStatus.Text = "ORDER IS INVALID";
                    throw new ArgumentException(
                        string.Format("Out of Range Value (<1 or >30) has been inputted, please try again"));
                }
            }
        }

        private bool validateIsNumeric(string input)
        {
            int test = 0;
            return int.TryParse(input, out test);
        }
    }
}
