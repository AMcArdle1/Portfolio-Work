
namespace SQLQueries
{
    partial class Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label customerFirstNameLabel;
            System.Windows.Forms.Label customerStreetAddressLabel;
            System.Windows.Forms.Label customerCityLabel;
            System.Windows.Forms.Label customerPhoneNumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnProductVendors = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.salesOrdersDataSet = new SQLQueries.SalesOrdersDataSet();
            this.salesOrdersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new SQLQueries.SalesOrdersDataSetTableAdapters.CustomersTableAdapter();
            this.btnExit = new System.Windows.Forms.Button();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new SQLQueries.SalesOrdersDataSetTableAdapters.TableAdapterManager();
            this.employeesTableAdapter = new SQLQueries.SalesOrdersDataSetTableAdapters.EmployeesTableAdapter();
            this.statesTableAdapter = new SQLQueries.SalesOrdersDataSetTableAdapters.StatesTableAdapter();
            this.customerIDLabel1 = new System.Windows.Forms.Label();
            this.lblCustomersHeader = new System.Windows.Forms.Label();
            this.customerFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerLastNameTextBox = new System.Windows.Forms.TextBox();
            this.customerStreetAddressTextBox = new System.Windows.Forms.TextBox();
            this.customerCityTextBox = new System.Windows.Forms.TextBox();
            this.customerStateComboBox = new System.Windows.Forms.ComboBox();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.customerAreaCodeTextBox = new System.Windows.Forms.TextBox();
            this.customerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            customerIDLabel = new System.Windows.Forms.Label();
            customerFirstNameLabel = new System.Windows.Forms.Label();
            customerStreetAddressLabel = new System.Windows.Forms.Label();
            customerCityLabel = new System.Windows.Forms.Label();
            customerPhoneNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(238, 86);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(96, 18);
            customerIDLabel.TabIndex = 19;
            customerIDLabel.Text = "Customer ID:";
            // 
            // customerFirstNameLabel
            // 
            customerFirstNameLabel.AutoSize = true;
            customerFirstNameLabel.Location = new System.Drawing.Point(238, 123);
            customerFirstNameLabel.Name = "customerFirstNameLabel";
            customerFirstNameLabel.Size = new System.Drawing.Size(122, 18);
            customerFirstNameLabel.TabIndex = 21;
            customerFirstNameLabel.Text = "Customer Name:";
            // 
            // customerStreetAddressLabel
            // 
            customerStreetAddressLabel.AutoSize = true;
            customerStreetAddressLabel.Location = new System.Drawing.Point(238, 168);
            customerStreetAddressLabel.Name = "customerStreetAddressLabel";
            customerStreetAddressLabel.Size = new System.Drawing.Size(179, 18);
            customerStreetAddressLabel.TabIndex = 23;
            customerStreetAddressLabel.Text = "Customer Street Address:";
            // 
            // customerCityLabel
            // 
            customerCityLabel.AutoSize = true;
            customerCityLabel.Location = new System.Drawing.Point(238, 213);
            customerCityLabel.Name = "customerCityLabel";
            customerCityLabel.Size = new System.Drawing.Size(185, 18);
            customerCityLabel.TabIndex = 24;
            customerCityLabel.Text = "Customer City / State / Zip:";
            // 
            // customerPhoneNumberLabel
            // 
            customerPhoneNumberLabel.AutoSize = true;
            customerPhoneNumberLabel.Location = new System.Drawing.Point(238, 262);
            customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
            customerPhoneNumberLabel.Size = new System.Drawing.Size(182, 18);
            customerPhoneNumberLabel.TabIndex = 28;
            customerPhoneNumberLabel.Text = "Customer Phone Number:";
            // 
            // btnVendors
            // 
            this.btnVendors.Location = new System.Drawing.Point(809, 343);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(107, 56);
            this.btnVendors.TabIndex = 17;
            this.btnVendors.Text = "Vendors";
            this.btnVendors.UseVisualStyleBackColor = true;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnProductVendors
            // 
            this.btnProductVendors.Location = new System.Drawing.Point(695, 343);
            this.btnProductVendors.Name = "btnProductVendors";
            this.btnProductVendors.Size = new System.Drawing.Size(107, 56);
            this.btnProductVendors.TabIndex = 16;
            this.btnProductVendors.Text = "Product Vendors";
            this.btnProductVendors.UseVisualStyleBackColor = true;
            this.btnProductVendors.Click += new System.EventHandler(this.btnProductVendors_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(582, 343);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(107, 56);
            this.btnProducts.TabIndex = 15;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.Location = new System.Drawing.Point(468, 343);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(107, 56);
            this.btnOrderDetails.TabIndex = 14;
            this.btnOrderDetails.Text = "Order Details";
            this.btnOrderDetails.UseVisualStyleBackColor = true;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(241, 343);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(107, 56);
            this.btnOrders.TabIndex = 13;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(354, 343);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(107, 56);
            this.btnEmployees.TabIndex = 12;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(127, 343);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(107, 56);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Location = new System.Drawing.Point(14, 343);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(107, 56);
            this.btnCategories.TabIndex = 10;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // salesOrdersDataSet
            // 
            this.salesOrdersDataSet.DataSetName = "SalesOrdersDataSet";
            this.salesOrdersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesOrdersDataSetBindingSource
            // 
            this.salesOrdersDataSetBindingSource.DataSource = this.salesOrdersDataSet;
            this.salesOrdersDataSetBindingSource.Position = 0;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.salesOrdersDataSetBindingSource;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(413, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 56);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.salesOrdersDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ProductVendorsTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = this.statesTableAdapter;
            this.tableAdapterManager.UpdateOrder = SQLQueries.SalesOrdersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorsTableAdapter = null;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // customerIDLabel1
            // 
            this.customerIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "CustomerID", true));
            this.customerIDLabel1.Location = new System.Drawing.Point(420, 86);
            this.customerIDLabel1.Name = "customerIDLabel1";
            this.customerIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.customerIDLabel1.TabIndex = 20;
            this.customerIDLabel1.Text = "label1";
            // 
            // lblCustomersHeader
            // 
            this.lblCustomersHeader.AutoSize = true;
            this.lblCustomersHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomersHeader.Location = new System.Drawing.Point(348, 27);
            this.lblCustomersHeader.Name = "lblCustomersHeader";
            this.lblCustomersHeader.Size = new System.Drawing.Size(230, 32);
            this.lblCustomersHeader.TabIndex = 21;
            this.lblCustomersHeader.Text = "Customers Table";
            // 
            // customerFirstNameTextBox
            // 
            this.customerFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "CustomerFirstName", true));
            this.customerFirstNameTextBox.Location = new System.Drawing.Point(423, 123);
            this.customerFirstNameTextBox.Name = "customerFirstNameTextBox";
            this.customerFirstNameTextBox.Size = new System.Drawing.Size(153, 24);
            this.customerFirstNameTextBox.TabIndex = 22;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.salesOrdersDataSet;
            // 
            // customerLastNameTextBox
            // 
            this.customerLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "CustomerLastName", true));
            this.customerLastNameTextBox.Location = new System.Drawing.Point(582, 123);
            this.customerLastNameTextBox.Name = "customerLastNameTextBox";
            this.customerLastNameTextBox.Size = new System.Drawing.Size(158, 24);
            this.customerLastNameTextBox.TabIndex = 23;
            // 
            // customerStreetAddressTextBox
            // 
            this.customerStreetAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "CustomerStreetAddress", true));
            this.customerStreetAddressTextBox.Location = new System.Drawing.Point(423, 165);
            this.customerStreetAddressTextBox.Name = "customerStreetAddressTextBox";
            this.customerStreetAddressTextBox.Size = new System.Drawing.Size(317, 24);
            this.customerStreetAddressTextBox.TabIndex = 24;
            // 
            // customerCityTextBox
            // 
            this.customerCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "CustomerCity", true));
            this.customerCityTextBox.Location = new System.Drawing.Point(423, 210);
            this.customerCityTextBox.Name = "customerCityTextBox";
            this.customerCityTextBox.Size = new System.Drawing.Size(100, 24);
            this.customerCityTextBox.TabIndex = 25;
            // 
            // customerStateComboBox
            // 
            this.customerStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "CustomerState", true));
            this.customerStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customersBindingSource, "CustomerState", true));
            this.customerStateComboBox.DataSource = this.statesBindingSource;
            this.customerStateComboBox.DisplayMember = "StateAbbrev";
            this.customerStateComboBox.FormattingEnabled = true;
            this.customerStateComboBox.Location = new System.Drawing.Point(529, 210);
            this.customerStateComboBox.Name = "customerStateComboBox";
            this.customerStateComboBox.Size = new System.Drawing.Size(105, 26);
            this.customerStateComboBox.TabIndex = 26;
            this.customerStateComboBox.ValueMember = "StateAbbrev";
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.salesOrdersDataSet;
            // 
            // customerZipCodeTextBox
            // 
            this.customerZipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "CustomerZipCode", true));
            this.customerZipCodeTextBox.Location = new System.Drawing.Point(640, 210);
            this.customerZipCodeTextBox.Name = "customerZipCodeTextBox";
            this.customerZipCodeTextBox.Size = new System.Drawing.Size(100, 24);
            this.customerZipCodeTextBox.TabIndex = 27;
            // 
            // customerAreaCodeTextBox
            // 
            this.customerAreaCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "CustomerAreaCode", true));
            this.customerAreaCodeTextBox.Location = new System.Drawing.Point(423, 262);
            this.customerAreaCodeTextBox.Name = "customerAreaCodeTextBox";
            this.customerAreaCodeTextBox.Size = new System.Drawing.Size(100, 24);
            this.customerAreaCodeTextBox.TabIndex = 28;
            // 
            // customerPhoneNumberTextBox
            // 
            this.customerPhoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "CustomerPhoneNumber", true));
            this.customerPhoneNumberTextBox.Location = new System.Drawing.Point(529, 262);
            this.customerPhoneNumberTextBox.Name = "customerPhoneNumberTextBox";
            this.customerPhoneNumberTextBox.Size = new System.Drawing.Size(211, 24);
            this.customerPhoneNumberTextBox.TabIndex = 29;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.customersBindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(936, 27);
            this.bindingNavigator1.TabIndex = 30;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 482);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(customerPhoneNumberLabel);
            this.Controls.Add(this.customerPhoneNumberTextBox);
            this.Controls.Add(this.customerAreaCodeTextBox);
            this.Controls.Add(this.customerZipCodeTextBox);
            this.Controls.Add(this.customerStateComboBox);
            this.Controls.Add(customerCityLabel);
            this.Controls.Add(this.customerCityTextBox);
            this.Controls.Add(customerStreetAddressLabel);
            this.Controls.Add(this.customerStreetAddressTextBox);
            this.Controls.Add(this.customerLastNameTextBox);
            this.Controls.Add(customerFirstNameLabel);
            this.Controls.Add(this.customerFirstNameTextBox);
            this.Controls.Add(this.lblCustomersHeader);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDLabel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVendors);
            this.Controls.Add(this.btnProductVendors);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnOrderDetails);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCategories);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnProductVendors;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCategories;
        private SalesOrdersDataSet salesOrdersDataSet;
        private System.Windows.Forms.BindingSource salesOrdersDataSetBindingSource;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private SalesOrdersDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private SalesOrdersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label customerIDLabel1;
        private System.Windows.Forms.Label lblCustomersHeader;
        private System.Windows.Forms.TextBox customerFirstNameTextBox;
        private SalesOrdersDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private SalesOrdersDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private System.Windows.Forms.TextBox customerLastNameTextBox;
        private System.Windows.Forms.TextBox customerStreetAddressTextBox;
        private System.Windows.Forms.TextBox customerCityTextBox;
        private System.Windows.Forms.ComboBox customerStateComboBox;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private System.Windows.Forms.TextBox customerZipCodeTextBox;
        private System.Windows.Forms.TextBox customerAreaCodeTextBox;
        private System.Windows.Forms.TextBox customerPhoneNumberTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}