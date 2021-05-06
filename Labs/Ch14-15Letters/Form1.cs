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
 * 
 */

namespace Ch14_15Letters
{
    public partial class FormLetterDelivery : Form
    {
        public FormLetterDelivery()
        {
            InitializeComponent();
        }

        // Create Global Constant
        const int TOTALELEMENTS = 10;

        // Create Global Variables
        List<Letter> letter = new List<Letter>(TOTALELEMENTS);
        List<CertifiedLetter> certifiedLetter = new List<CertifiedLetter>(TOTALELEMENTS);
        string[] sentLetters = new string[TOTALELEMENTS];
        int numElements = 0;

        private void buttonSend_Click(object sender, EventArgs e)
        {
            bool keepGoing = ValidateRecipient();

            if (keepGoing)
            {
                keepGoing = ValidateSentDate();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = IsThereATrackingNumber();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                InstantiateACertifiedLetter();
            }
            else
            {
                InstantiateANonCertifiedLetter();
            }
        }

        private bool ValidateRecipient()
        {
            if (textBoxRecipient.Text.Trim() == "")
            {
                ShowMessage("Recipient Name Cannot Be Empty", "RECIPIENT FIELD EMPTY!!!");
                
                textBoxRecipient.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateSentDate()
        {
            try
            {
                DateTime.Parse(textBoxSentDate.Text.Trim());
            }
            catch (Exception e)
            {
                ShowMessage("Invalid Date Format!!!", "INVALID DATE!!!");

                textBoxSentDate.Text = "";
                textBoxSentDate.Focus();
                return false;
            }

            return true;
        }

        private bool IsThereATrackingNumber()
        {
            if (textBoxTrackingNumber.Text.ToString() == "")
            {
                return false;
            }

            return true;
        }

        private void InstantiateACertifiedLetter()
        {
            
            if (numElements < TOTALELEMENTS)
            {
                CertifiedLetter cl = new CertifiedLetter(textBoxRecipient.Text,
                                                     Convert.ToDateTime(textBoxSentDate.Text),
                                                     textBoxTrackingNumber.Text);

                certifiedLetter.Add(cl);
                richTextBoxLetterHistory.Text += cl.ToString() + "\n";
                sentLetters = richTextBoxLetterHistory.Text.Split('\n');
                labelAdditionalFee.Visible = true;
                ++numElements;
            }
            else
            {
                ShowMessage("Can't Add Anymore Elements To List", "LIST IS ALREADY FULL!!!");
                labelAdditionalFee.Visible = false;
            }

            //DisplayArrayContents();
        }

        private void InstantiateANonCertifiedLetter()
        {
            if (numElements < TOTALELEMENTS)
            {
                Letter l = new Letter(textBoxRecipient.Text,
                                      Convert.ToDateTime(textBoxSentDate.Text));
                
                letter.Add(l);
                
                labelAdditionalFee.Visible = false;

                richTextBoxLetterHistory.Text += l.ToString() + "\n";
                sentLetters = richTextBoxLetterHistory.Text.Split('\n');
                ++numElements;
            }
            else
            {
                ShowMessage("Can't Add Anymore Elements To List", "LIST IS ALREADY FULL!!!");
            }

            //DisplayArrayContents();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            textBoxRecipient.Text = "";
            textBoxSentDate.Text = "";
            textBoxTrackingNumber.Text = "";
            labelAdditionalFee.Visible = false;
            textBoxRecipient.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormLetterDelivery_Load(object sender, EventArgs e)
        {
            Letter l1 = new Letter("Mom", Convert.ToDateTime("3/23/2021"));
            richTextBoxLetterHistory.Text += l1 + "\n";
            sentLetters[0] = richTextBoxLetterHistory.Text;
            ++numElements;

            Letter l2 = new Letter("Dad", Convert.ToDateTime("3/23/2021"));
            richTextBoxLetterHistory.Text += l2 + "\n";
            sentLetters[1] = richTextBoxLetterHistory.Text;
            ++numElements;

            CertifiedLetter cl1 = new CertifiedLetter("Specturm", Convert.ToDateTime("3/23/2021"), "456");
            richTextBoxLetterHistory.Text += cl1 + "\n";
            sentLetters[2] = richTextBoxLetterHistory.Text;
            ++numElements;

            CertifiedLetter cl2 = new CertifiedLetter("Spider", Convert.ToDateTime("3/24/2021"), "789");
            richTextBoxLetterHistory.Text += cl2 + "\n";
            sentLetters[3] = richTextBoxLetterHistory.Text;
            ++numElements;
        }

        private void DisplayArrayContents()
        {
            string str = "";
            int len = sentLetters.Length - 1;

            for (int lcv = 0; lcv < len; ++lcv)
            {
                str += "sentLetters[" + lcv.ToString() + "]: " + sentLetters[lcv] + "\n";
            }

            MessageBox.Show("Contents of Array sentLetters:\n" + str, 
                            "ARRAY CONTENTS", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
        }
    }
}
