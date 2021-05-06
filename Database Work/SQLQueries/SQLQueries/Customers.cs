using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLQueries
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesOrdersDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.salesOrdersDataSet.States);
            // TODO: This line of code loads data into the 'salesOrdersDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.salesOrdersDataSet.Employees);
            // TODO: This line of code loads data into the 'salesOrdersDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.salesOrdersDataSet.Customers);

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            this.Hide();
            Categories frmCategories = new Categories();
            frmCategories.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home frmHome = new Home();
            frmHome.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders frmOrders = new Orders();
            frmOrders.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees frmEmployees = new Employees();
            frmEmployees.ShowDialog();
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderDetails frmOrderDetails = new OrderDetails();
            frmOrderDetails.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products frmProducts = new Products();
            frmProducts.ShowDialog();
        }

        private void btnProductVendors_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductVendors frmProductVendors = new ProductVendors();
            frmProductVendors.ShowDialog();
        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendors frmVendors = new Vendors();
            frmVendors.ShowDialog();
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
