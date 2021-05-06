using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQLQueryTester
{
    public partial class FrmSQLQueryTester : Form
    {
        // Create database variables
        SqlConnection conn;
        SqlCommand queryCommand;
        SqlDataAdapter queryAdapter;
        DataTable table;

        public FrmSQLQueryTester()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            queryCommand = null;
            queryAdapter = new SqlDataAdapter();
            table = new DataTable();

            try
            {
                queryCommand = new SqlCommand(txtQuery.Text, conn);
                queryAdapter.SelectCommand = queryCommand;
                queryAdapter.Fill(table);

                dgvQueryTester.DataSource = table;
                lblNumRecords.Text = table.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Error! " + ex.Message,
                                "ERROR IN SQL!!!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            this.dgvQueryTester.DataSource = null;
            this.dgvQueryTester.Rows.Clear();
            txtQuery.Text = "";
            lblNumRecords.Text = "0";
            txtQuery.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?",
                                                  "EXIT NOW?",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                conn.Close();
                Application.Exit();
            }
        }

        private void FrmSQLQueryTester_Load(object sender, EventArgs e)
        {
            var connString = @"Server=VINTER2\SQLEXPRESS;Database=SalesOrders;Integrated Security=SSPI";

            // Create SqlConnection based on connString
            conn = new SqlConnection(connString);

            // Open Connection
            conn.Open();
        }
    }
}
