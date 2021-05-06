using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12BankLogin
{
    class Account
    {
        // Create Constant
        public decimal MINBALANCE = 25.00m;

        // Instance Variables 
        private readonly string _title;
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _accountNumber;
        private readonly string _pin;
        private decimal _balance;

        // Constructor
        public Account (string title, string firstName, string lastName, string accountNumber, string pin, decimal balance)
        {
            _title = title;
            _firstName = firstName;
            _lastName = lastName;
            _accountNumber = accountNumber;
            _pin = pin;
            _balance = balance;
        }

        // Getters
        public string GetTitle()
        {
            return _title;
        }

        public string GetFirstName()
        {
            return _firstName;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public string GetAccountNumber()
        {
            return _accountNumber;
        }

        public string GetPin()
        {
            return _pin;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        // Attempted Deposit
        public void MakeDeposit(decimal deposit)
        {
            decimal theDeposit = -1m;

            try
            {
                // Attempt to make deposit
                theDeposit = deposit;

                // Check for 0 or a negative deposit
                if (theDeposit <= 0)
                {
                    MessageBox.Show("Illegal Deposit (0 or Negative Amount) Attempted!", "ILLEGAL DEPOSIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    return;
                }

                // Valid deposit
                _balance += deposit;
            }
            catch (Exception e)
            {
                return;
            }
        }

        // Attempted Withdrawal
        public void MakeWithdrawal(decimal amount)
        {
            decimal theAmount = amount;
            decimal temp = -1;

            try
            {
                // Check for 0 or negative withdrawal attempt
                if (theAmount <= 0)
                {
                    MessageBox.Show("Illegal Withdrawal (0 or Negative Amount) Attempted!", "ILLEGAL WITHDRAWAL", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                // Positive Amount for Withdrawal inputted.
                // Attempt to make withdrawal.
                temp = _balance - theAmount;

                if (temp >= MINBALANCE)
                {
                    _balance -= amount;
                }
                else
                {
                    MessageBox.Show("Illegal Withdrawl. The attempted withdrawal would leave the account with < the minimum balance of:" + MINBALANCE.ToString("c"), "ILLEGAL WITHDRAWAL", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }
            catch (Exception e)
            {
                return;
            }
            
        }
    }
}
