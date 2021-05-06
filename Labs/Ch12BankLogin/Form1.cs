using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12BankLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Constants
        const int NUMCUSTOMERS = 5;

        // Global Variables
        List<Account> accounts = new List<Account>();

        int validAccNumLoc = -1;
        int validPinNumLoc = -1;
        bool youreLogginIn = false;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            // Program continue variables
            bool missingInfo = true;
            bool badAccountNumber = true;
            bool badPinNumber = true;

            missingInfo = isAnyLoginInfoMissing();

            if (missingInfo)
            {
                return;
            }

            // If we reach this point, both the account number and the pin number textboxes were filled in.
            // Now validate each.
            badAccountNumber = validateAccountNumber(txtAccountNumberEntry.Text.Trim());
            badPinNumber = validatePinNumber(txtPinNumberEntry.Text.Trim());

            if ((badAccountNumber) || (badPinNumber))
            {
                displayBadMessage();
                return;
            }

            if (validAccNumLoc != validPinNumLoc)
            {
                displayBadMessage();
                return;
            }

            // Valid account number and valid pin number
            rewriteWelcomeScreen();
            makeScreenActive();
        }

        public void makeScreenActive()
        {
            // Log in current user
            youreLogginIn = true;
            btnLogin.Enabled = false;
            btnLogout.Enabled = true;
            btnDeposit.Enabled = true;
            btnWithdrawel.Enabled = true;
        }

        private bool isAnyLoginInfoMissing()
        {
            rtxtLoginInformation.Text = "";
            string missingLoginStr = "";
            missingLoginStr += "Account # and Pin # both mandatory for login";
            missingLoginStr += "\nAccount # entered as nnnnnnnnn where each n is a number";
            missingLoginStr += "\nThe Pin # entered as nnn where each n is a number";
            missingLoginStr += "\nPlease try again and enter both values";

            // Check for either/both acct #/ pin # fields left blank
            if ((txtAccountNumberEntry.Text == "") || (txtPinNumberEntry.Text == ""))
            {
                rtxtLoginInformation.Text = "";
                rtxtLoginInformation.Text = missingLoginStr;

                clearLoginFields();
                return true;
            }

            return false;
        }

        private bool validateAccountNumber(string an)
        {
            validAccNumLoc = -1;

            for (int lcv = 0; lcv < accounts.Count; ++lcv)
            {
                if (an == accounts[lcv].GetAccountNumber())
                {
                    validAccNumLoc = lcv;
                    return false;
                }
            }

            return true;
        }

        private bool validatePinNumber(string pn)
        {
            validPinNumLoc = -1;

            for (int lcv = 0; lcv < accounts.Count; ++lcv)
            {
                if (pn == accounts[lcv].GetPin())
                {
                    validPinNumLoc = lcv;
                    return false;
                }
            }

            return true;
        }

        private void displayBadMessage()
        {
            string wrongLoginStr = "";
            wrongLoginStr += "Bad Account # and/or Pin #!!";
            wrongLoginStr += "\nPlease re-enter your info now";

            rtxtLoginInformation.Text = "";
            rtxtLoginInformation.Text = wrongLoginStr;

            clearLoginFields();
        }

        private void clearLoginFields()
        {
            txtAccountNumberEntry.Text = "";
            txtPinNumberEntry.Text = "";
            txtAccountNumberEntry.Focus();
        }

        private void rewriteWelcomeScreen()
        {
            string welcomeStr = "Welcome ";
            welcomeStr += accounts[validPinNumLoc].GetTitle() + "";
            welcomeStr += accounts[validPinNumLoc].GetFirstName() + " ";
            welcomeStr += accounts[validPinNumLoc].GetLastName() + "\n";
            welcomeStr += "Your current account balance is: " + " ";
            welcomeStr += accounts[validPinNumLoc].GetBalance().ToString("c");

            rtxtLoginInformation.Text = welcomeStr;
            btnLogin.Enabled = false;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            bool keepGoing = loggedInOrNot();

            if (keepGoing)
            {
                attemptTheDeposit();
                return;
            }
        }

        public void attemptTheDeposit()
        {
            decimal deposit;

            try
            {
                deposit = Convert.ToDecimal(txtDeposit.Text);
                accounts[validPinNumLoc].MakeDeposit(deposit);
                rewriteWelcomeScreen();
            }
            catch (Exception e)
            {
                return;
            }
        }

        private void btnWithdrawel_Click(object sender, EventArgs e)
        {
            bool keepGoing = loggedInOrNot();

            if (keepGoing)
            {
                attemptTheWithdrawal();
                return;
            }
        }

        public void attemptTheWithdrawal()
        {
            decimal withdrawal;

            try
            {
                withdrawal = Convert.ToDecimal(txtWithdrawel.Text);
                accounts[validPinNumLoc].MakeWithdrawal(withdrawal);
                rewriteWelcomeScreen();
            }
            catch (Exception e)
            {
                return;
            }
        }

        private bool loggedInOrNot()
        {
            if (!youreLogginIn)
            {
                rtxtLoginInformation.Text = "You are not logged in so you cannot make a transaction.";
                return false;
            }

            return true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            if(MessageBox.Show("Do You Really Want To Logout?","LOGOUT NOW???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                blankOutScreen();

                youreLogginIn = false;
                btnLogin.Enabled = true;
                btnLogout.Enabled = false;
                btnDeposit.Enabled = false;
                btnWithdrawel.Enabled = false;
                txtAccountNumberEntry.Focus();
            }
        }

        public void blankOutScreen()
        {
            rtxtLoginInformation.Text = "";
            txtDeposit.Text = "";
            txtWithdrawel.Text = "";
            txtAccountNumberEntry.Text = "";
            txtPinNumberEntry.Text = "";
            txtAccountNumberEntry.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            accounts.Add(new Account("Ms.", "Sandy", "Scott", "123-456-789", "3456", 10000M));
            accounts.Add(new Account("Mr.", "Evan", "Gudmestad", "234-567-890", "8754", 2500.00M));
            accounts.Add(new Account("Mr.", "Paul", "Smith", "345-678-901", "6543", 13456.78M));
            accounts.Add(new Account("Ms.", "Shannon", "Brueggeman", "456-789-012", "2049", 5678.90M));
            accounts.Add(new Account("Mr.", "Charles", "Corrigan", "567-890-123", "4190", 100456.21M));
        }
    }
}
