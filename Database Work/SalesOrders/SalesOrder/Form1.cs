using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalesOrder
{
    public partial class FormSalesOrder : Form
    {
        // Create Database Variables
        SqlConnection conn;
        SqlCommand customersCommand;
        SqlDataAdapter customersAdapter;
        DataTable customersTable;
        CurrencyManager customersCurrencyManager;

        public FormSalesOrder()
        {
            InitializeComponent();
        }

        private void FormSalesOrder_Load(object sender, EventArgs e)
        {
            var connString = @"Server=VINTER2\SQLEXPRESS;Database=SalesOrders;Integrated Security=SSPI";

            // Create SQL connection based on connString
            conn = new SqlConnection(connString);

            // Open Database Connection
            conn.Open();

            // Instantiate customersComman SqlCommand object to set the string to read all customer records
            customersCommand = new SqlCommand("SELECT * FROM customers", conn);

            // Instantiate customerAdatper SqlDataAdapter object to "hold" the results of the customersCommand
            customersAdapter = new SqlDataAdapter(customersCommand);

            // Instantiate customersTable DataTable object
            customersTable = new DataTable();

            // "Fill" the customersTable using the customersAdapter
            customersAdapter.Fill(customersTable);

            // Bind the associated controls
            txtFirstName.DataBindings.Add("Text", customersTable, "customerFirstName");
            txtLastName.DataBindings.Add("Text", customersTable, "customerLastName");
            txtStreetAddress.DataBindings.Add("Text", customersTable, "customerStreetAddress");
            txtCity.DataBindings.Add("Text", customersTable, "customerCity");
            txtState.DataBindings.Add("Text", customersTable, "customerState");
            txtZipCode.DataBindings.Add("Text", customersTable, "customerZipCode");
            txtAreaCode.DataBindings.Add("Text", customersTable, "customerAreaCode".ToString());
            txtPhoneNumber.DataBindings.Add("Text", customersTable, "customerPhoneNumber");

            // Create currency manager
            customersCurrencyManager = (CurrencyManager)BindingContext[customersTable];

            customersAdapter.Dispose();
            customersTable.Dispose();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            customersCurrencyManager.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            customersCurrencyManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            customersCurrencyManager.Position++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            customersCurrencyManager.Position = customersCurrencyManager.Count - 1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", 
                                                  "EXIT NOW?", 
                                                  MessageBoxButtons.YesNo, 
                                                  MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
