using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesOrdersDB2
{
    public partial class FormSalesOrdersAuto : Form
    {
        public FormSalesOrdersAuto()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salesOrdersDataSet);

        }

        private void FormSalesOrdersAuto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesOrdersDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.salesOrdersDataSet.Customers);

        }
    }
}
