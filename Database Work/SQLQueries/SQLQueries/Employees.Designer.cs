
namespace SQLQueries
{
    partial class Employees
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
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label employeeFirstNameLabel;
            System.Windows.Forms.Label employeeStreetAddressLabel;
            System.Windows.Forms.Label employeeCityLabel;
            System.Windows.Forms.Label employeePhoneNumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnProductVendors = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesOrdersDataSet = new SQLQueries.SalesOrdersDataSet();
            this.employeesTableAdapter = new SQLQueries.SalesOrdersDataSetTableAdapters.EmployeesTableAdapter();
            this.lblEmployeesHeader = new System.Windows.Forms.Label();
            this.tableAdapterManager = new SQLQueries.SalesOrdersDataSetTableAdapters.TableAdapterManager();
            this.statesTableAdapter = new SQLQueries.SalesOrdersDataSetTableAdapters.StatesTableAdapter();
            this.employeeIDLabel1 = new System.Windows.Forms.Label();
            this.employeeFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeLastNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeStreetAddressTextBox = new System.Windows.Forms.TextBox();
            this.employeeCityTextBox = new System.Windows.Forms.TextBox();
            this.employeeStateComboBox = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.employeePhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.employeeAreaCodeTextBox = new System.Windows.Forms.TextBox();
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
            employeeIDLabel = new System.Windows.Forms.Label();
            employeeFirstNameLabel = new System.Windows.Forms.Label();
            employeeStreetAddressLabel = new System.Windows.Forms.Label();
            employeeCityLabel = new System.Windows.Forms.Label();
            employeePhoneNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(238, 74);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(96, 18);
            employeeIDLabel.TabIndex = 29;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // employeeFirstNameLabel
            // 
            employeeFirstNameLabel.AutoSize = true;
            employeeFirstNameLabel.Location = new System.Drawing.Point(238, 119);
            employeeFirstNameLabel.Name = "employeeFirstNameLabel";
            employeeFirstNameLabel.Size = new System.Drawing.Size(122, 18);
            employeeFirstNameLabel.TabIndex = 30;
            employeeFirstNameLabel.Text = "Employee Name:";
            // 
            // employeeStreetAddressLabel
            // 
            employeeStreetAddressLabel.AutoSize = true;
            employeeStreetAddressLabel.Location = new System.Drawing.Point(238, 162);
            employeeStreetAddressLabel.Name = "employeeStreetAddressLabel";
            employeeStreetAddressLabel.Size = new System.Drawing.Size(179, 18);
            employeeStreetAddressLabel.TabIndex = 32;
            employeeStreetAddressLabel.Text = "Employee Street Address:";
            // 
            // employeeCityLabel
            // 
            employeeCityLabel.AutoSize = true;
            employeeCityLabel.Location = new System.Drawing.Point(238, 204);
            employeeCityLabel.Name = "employeeCityLabel";
            employeeCityLabel.Size = new System.Drawing.Size(185, 18);
            employeeCityLabel.TabIndex = 33;
            employeeCityLabel.Text = "Employee City / State / Zip:";
            // 
            // employeePhoneNumberLabel
            // 
            employeePhoneNumberLabel.AutoSize = true;
            employeePhoneNumberLabel.Location = new System.Drawing.Point(238, 253);
            employeePhoneNumberLabel.Name = "employeePhoneNumberLabel";
            employeePhoneNumberLabel.Size = new System.Drawing.Size(182, 18);
            employeePhoneNumberLabel.TabIndex = 36;
            employeePhoneNumberLabel.Text = "Employee Phone Number:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(413, 372);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 56);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnVendors
            // 
            this.btnVendors.Location = new System.Drawing.Point(809, 309);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(107, 56);
            this.btnVendors.TabIndex = 27;
            this.btnVendors.Text = "Vendors";
            this.btnVendors.UseVisualStyleBackColor = true;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnProductVendors
            // 
            this.btnProductVendors.Location = new System.Drawing.Point(695, 309);
            this.btnProductVendors.Name = "btnProductVendors";
            this.btnProductVendors.Size = new System.Drawing.Size(107, 56);
            this.btnProductVendors.TabIndex = 26;
            this.btnProductVendors.Text = "Product Vendors";
            this.btnProductVendors.UseVisualStyleBackColor = true;
            this.btnProductVendors.Click += new System.EventHandler(this.btnProductVendors_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(582, 309);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(107, 56);
            this.btnProducts.TabIndex = 25;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.Location = new System.Drawing.Point(468, 309);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(107, 56);
            this.btnOrderDetails.TabIndex = 24;
            this.btnOrderDetails.Text = "Order Details";
            this.btnOrderDetails.UseVisualStyleBackColor = true;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(241, 309);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(107, 56);
            this.btnOrders.TabIndex = 23;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(127, 309);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(107, 56);
            this.btnCustomers.TabIndex = 22;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(354, 309);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(107, 56);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Location = new System.Drawing.Point(14, 309);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(107, 56);
            this.btnCategories.TabIndex = 20;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.salesOrdersDataSet;
            // 
            // salesOrdersDataSet
            // 
            this.salesOrdersDataSet.DataSetName = "SalesOrdersDataSet";
            this.salesOrdersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // lblEmployeesHeader
            // 
            this.lblEmployeesHeader.AutoSize = true;
            this.lblEmployeesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeesHeader.Location = new System.Drawing.Point(348, 27);
            this.lblEmployeesHeader.Name = "lblEmployeesHeader";
            this.lblEmployeesHeader.Size = new System.Drawing.Size(235, 32);
            this.lblEmployeesHeader.TabIndex = 29;
            this.lblEmployeesHeader.Text = "Employees Table";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ProductVendorsTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = this.statesTableAdapter;
            this.tableAdapterManager.UpdateOrder = SQLQueries.SalesOrdersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorsTableAdapter = null;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // employeeIDLabel1
            // 
            this.employeeIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeID", true));
            this.employeeIDLabel1.Location = new System.Drawing.Point(426, 74);
            this.employeeIDLabel1.Name = "employeeIDLabel1";
            this.employeeIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.employeeIDLabel1.TabIndex = 30;
            this.employeeIDLabel1.Text = "label2";
            // 
            // employeeFirstNameTextBox
            // 
            this.employeeFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeFirstName", true));
            this.employeeFirstNameTextBox.Location = new System.Drawing.Point(429, 116);
            this.employeeFirstNameTextBox.Name = "employeeFirstNameTextBox";
            this.employeeFirstNameTextBox.Size = new System.Drawing.Size(146, 24);
            this.employeeFirstNameTextBox.TabIndex = 31;
            // 
            // employeeLastNameTextBox
            // 
            this.employeeLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeLastName", true));
            this.employeeLastNameTextBox.Location = new System.Drawing.Point(582, 116);
            this.employeeLastNameTextBox.Name = "employeeLastNameTextBox";
            this.employeeLastNameTextBox.Size = new System.Drawing.Size(176, 24);
            this.employeeLastNameTextBox.TabIndex = 32;
            // 
            // employeeStreetAddressTextBox
            // 
            this.employeeStreetAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeStreetAddress", true));
            this.employeeStreetAddressTextBox.Location = new System.Drawing.Point(429, 159);
            this.employeeStreetAddressTextBox.Name = "employeeStreetAddressTextBox";
            this.employeeStreetAddressTextBox.Size = new System.Drawing.Size(329, 24);
            this.employeeStreetAddressTextBox.TabIndex = 33;
            // 
            // employeeCityTextBox
            // 
            this.employeeCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeCity", true));
            this.employeeCityTextBox.Location = new System.Drawing.Point(429, 201);
            this.employeeCityTextBox.Name = "employeeCityTextBox";
            this.employeeCityTextBox.Size = new System.Drawing.Size(100, 24);
            this.employeeCityTextBox.TabIndex = 34;
            // 
            // employeeStateComboBox
            // 
            this.employeeStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeState", true));
            this.employeeStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource1, "EmployeeState", true));
            this.employeeStateComboBox.DataSource = this.statesBindingSource;
            this.employeeStateComboBox.DisplayMember = "StateAbbrev";
            this.employeeStateComboBox.FormattingEnabled = true;
            this.employeeStateComboBox.Location = new System.Drawing.Point(535, 201);
            this.employeeStateComboBox.Name = "employeeStateComboBox";
            this.employeeStateComboBox.Size = new System.Drawing.Size(106, 26);
            this.employeeStateComboBox.TabIndex = 35;
            this.employeeStateComboBox.ValueMember = "StateAbbrev";
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            this.employeesBindingSource1.DataSource = this.salesOrdersDataSet;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.salesOrdersDataSet;
            // 
            // employeeZipCodeTextBox
            // 
            this.employeeZipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeZipCode", true));
            this.employeeZipCodeTextBox.Location = new System.Drawing.Point(647, 201);
            this.employeeZipCodeTextBox.Name = "employeeZipCodeTextBox";
            this.employeeZipCodeTextBox.Size = new System.Drawing.Size(111, 24);
            this.employeeZipCodeTextBox.TabIndex = 36;
            // 
            // employeePhoneNumberTextBox
            // 
            this.employeePhoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeePhoneNumber", true));
            this.employeePhoneNumberTextBox.Location = new System.Drawing.Point(538, 250);
            this.employeePhoneNumberTextBox.Name = "employeePhoneNumberTextBox";
            this.employeePhoneNumberTextBox.Size = new System.Drawing.Size(220, 24);
            this.employeePhoneNumberTextBox.TabIndex = 37;
            // 
            // employeeAreaCodeTextBox
            // 
            this.employeeAreaCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeAreaCode", true));
            this.employeeAreaCodeTextBox.Location = new System.Drawing.Point(429, 250);
            this.employeeAreaCodeTextBox.Name = "employeeAreaCodeTextBox";
            this.employeeAreaCodeTextBox.Size = new System.Drawing.Size(103, 24);
            this.employeeAreaCodeTextBox.TabIndex = 38;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.employeesBindingSource;
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
            this.bindingNavigator1.TabIndex = 39;
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
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 448);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.employeeAreaCodeTextBox);
            this.Controls.Add(employeePhoneNumberLabel);
            this.Controls.Add(this.employeePhoneNumberTextBox);
            this.Controls.Add(this.employeeZipCodeTextBox);
            this.Controls.Add(this.employeeStateComboBox);
            this.Controls.Add(employeeCityLabel);
            this.Controls.Add(this.employeeCityTextBox);
            this.Controls.Add(employeeStreetAddressLabel);
            this.Controls.Add(this.employeeStreetAddressTextBox);
            this.Controls.Add(this.employeeLastNameTextBox);
            this.Controls.Add(employeeFirstNameLabel);
            this.Controls.Add(this.employeeFirstNameTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDLabel1);
            this.Controls.Add(this.lblEmployeesHeader);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVendors);
            this.Controls.Add(this.btnProductVendors);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnOrderDetails);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCategories);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnProductVendors;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCategories;
        private SalesOrdersDataSet salesOrdersDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private SalesOrdersDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Label lblEmployeesHeader;
        private SalesOrdersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label employeeIDLabel1;
        private System.Windows.Forms.TextBox employeeFirstNameTextBox;
        private System.Windows.Forms.TextBox employeeLastNameTextBox;
        private System.Windows.Forms.TextBox employeeStreetAddressTextBox;
        private System.Windows.Forms.TextBox employeeCityTextBox;
        private System.Windows.Forms.ComboBox employeeStateComboBox;
        private System.Windows.Forms.TextBox employeeZipCodeTextBox;
        private SalesOrdersDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private System.Windows.Forms.TextBox employeePhoneNumberTextBox;
        private System.Windows.Forms.TextBox employeeAreaCodeTextBox;
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