
namespace SQLQueries
{
    partial class Vendors
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
            System.Windows.Forms.Label vendorIDLabel;
            System.Windows.Forms.Label vendorNameLabel;
            System.Windows.Forms.Label vendorStreetAddressLabel;
            System.Windows.Forms.Label vendorCityLabel;
            System.Windows.Forms.Label vendorPhoneNumberLabel;
            System.Windows.Forms.Label vendorFaxNumberLabel;
            System.Windows.Forms.Label vendorWebPageLabel;
            System.Windows.Forms.Label vendorEMailAddressLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendors));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProductVendors = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesOrdersDataSet = new SQLQueries.SalesOrdersDataSet();
            this.vendorsTableAdapter = new SQLQueries.SalesOrdersDataSetTableAdapters.VendorsTableAdapter();
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
            this.lblVendorsHeader = new System.Windows.Forms.Label();
            this.tableAdapterManager = new SQLQueries.SalesOrdersDataSetTableAdapters.TableAdapterManager();
            this.statesTableAdapter = new SQLQueries.SalesOrdersDataSetTableAdapters.StatesTableAdapter();
            this.vendorIDLabel1 = new System.Windows.Forms.Label();
            this.vendorNameTextBox = new System.Windows.Forms.TextBox();
            this.vendorStreetAddressTextBox = new System.Windows.Forms.TextBox();
            this.vendorCityTextBox = new System.Windows.Forms.TextBox();
            this.vendorStateComboBox = new System.Windows.Forms.ComboBox();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.vendorPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.vendorFaxNumberTextBox = new System.Windows.Forms.TextBox();
            this.vendorWebPageTextBox = new System.Windows.Forms.TextBox();
            this.vendorEMailAddressTextBox = new System.Windows.Forms.TextBox();
            vendorIDLabel = new System.Windows.Forms.Label();
            vendorNameLabel = new System.Windows.Forms.Label();
            vendorStreetAddressLabel = new System.Windows.Forms.Label();
            vendorCityLabel = new System.Windows.Forms.Label();
            vendorPhoneNumberLabel = new System.Windows.Forms.Label();
            vendorFaxNumberLabel = new System.Windows.Forms.Label();
            vendorWebPageLabel = new System.Windows.Forms.Label();
            vendorEMailAddressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorIDLabel
            // 
            vendorIDLabel.AutoSize = true;
            vendorIDLabel.Location = new System.Drawing.Point(12, 70);
            vendorIDLabel.Name = "vendorIDLabel";
            vendorIDLabel.Size = new System.Drawing.Size(77, 18);
            vendorIDLabel.TabIndex = 30;
            vendorIDLabel.Text = "Vendor ID:";
            // 
            // vendorNameLabel
            // 
            vendorNameLabel.AutoSize = true;
            vendorNameLabel.Location = new System.Drawing.Point(12, 104);
            vendorNameLabel.Name = "vendorNameLabel";
            vendorNameLabel.Size = new System.Drawing.Size(103, 18);
            vendorNameLabel.TabIndex = 31;
            vendorNameLabel.Text = "Vendor Name:";
            // 
            // vendorStreetAddressLabel
            // 
            vendorStreetAddressLabel.AutoSize = true;
            vendorStreetAddressLabel.Location = new System.Drawing.Point(12, 138);
            vendorStreetAddressLabel.Name = "vendorStreetAddressLabel";
            vendorStreetAddressLabel.Size = new System.Drawing.Size(160, 18);
            vendorStreetAddressLabel.TabIndex = 32;
            vendorStreetAddressLabel.Text = "Vendor Street Address:";
            // 
            // vendorCityLabel
            // 
            vendorCityLabel.AutoSize = true;
            vendorCityLabel.Location = new System.Drawing.Point(12, 175);
            vendorCityLabel.Name = "vendorCityLabel";
            vendorCityLabel.Size = new System.Drawing.Size(166, 18);
            vendorCityLabel.TabIndex = 33;
            vendorCityLabel.Text = "Vendor City / State / Zip:";
            // 
            // vendorPhoneNumberLabel
            // 
            vendorPhoneNumberLabel.AutoSize = true;
            vendorPhoneNumberLabel.Location = new System.Drawing.Point(475, 75);
            vendorPhoneNumberLabel.Name = "vendorPhoneNumberLabel";
            vendorPhoneNumberLabel.Size = new System.Drawing.Size(163, 18);
            vendorPhoneNumberLabel.TabIndex = 36;
            vendorPhoneNumberLabel.Text = "Vendor Phone Number:";
            // 
            // vendorFaxNumberLabel
            // 
            vendorFaxNumberLabel.AutoSize = true;
            vendorFaxNumberLabel.Location = new System.Drawing.Point(475, 111);
            vendorFaxNumberLabel.Name = "vendorFaxNumberLabel";
            vendorFaxNumberLabel.Size = new System.Drawing.Size(144, 18);
            vendorFaxNumberLabel.TabIndex = 37;
            vendorFaxNumberLabel.Text = "Vendor Fax Number:";
            // 
            // vendorWebPageLabel
            // 
            vendorWebPageLabel.AutoSize = true;
            vendorWebPageLabel.Location = new System.Drawing.Point(475, 145);
            vendorWebPageLabel.Name = "vendorWebPageLabel";
            vendorWebPageLabel.Size = new System.Drawing.Size(132, 18);
            vendorWebPageLabel.TabIndex = 38;
            vendorWebPageLabel.Text = "Vendor Web Page:";
            // 
            // vendorEMailAddressLabel
            // 
            vendorEMailAddressLabel.AutoSize = true;
            vendorEMailAddressLabel.Location = new System.Drawing.Point(475, 177);
            vendorEMailAddressLabel.Name = "vendorEMailAddressLabel";
            vendorEMailAddressLabel.Size = new System.Drawing.Size(158, 18);
            vendorEMailAddressLabel.TabIndex = 39;
            vendorEMailAddressLabel.Text = "Vendor EMail Address:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(409, 341);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 56);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(123, 278);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(107, 56);
            this.btnCustomers.TabIndex = 27;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnProductVendors
            // 
            this.btnProductVendors.Location = new System.Drawing.Point(691, 278);
            this.btnProductVendors.Name = "btnProductVendors";
            this.btnProductVendors.Size = new System.Drawing.Size(107, 56);
            this.btnProductVendors.TabIndex = 26;
            this.btnProductVendors.Text = "Product Vendors";
            this.btnProductVendors.UseVisualStyleBackColor = true;
            this.btnProductVendors.Click += new System.EventHandler(this.btnProductVendors_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(578, 278);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(107, 56);
            this.btnProducts.TabIndex = 25;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.Location = new System.Drawing.Point(464, 278);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(107, 56);
            this.btnOrderDetails.TabIndex = 24;
            this.btnOrderDetails.Text = "Order Details";
            this.btnOrderDetails.UseVisualStyleBackColor = true;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(237, 278);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(107, 56);
            this.btnOrders.TabIndex = 23;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(350, 278);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(107, 56);
            this.btnEmployees.TabIndex = 22;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(805, 278);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(107, 56);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Location = new System.Drawing.Point(10, 278);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(107, 56);
            this.btnCategories.TabIndex = 20;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.salesOrdersDataSet;
            // 
            // salesOrdersDataSet
            // 
            this.salesOrdersDataSet.DataSetName = "SalesOrdersDataSet";
            this.salesOrdersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.vendorsBindingSource;
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
            this.bindingNavigator1.TabIndex = 29;
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
            // lblVendorsHeader
            // 
            this.lblVendorsHeader.AutoSize = true;
            this.lblVendorsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorsHeader.Location = new System.Drawing.Point(351, 27);
            this.lblVendorsHeader.Name = "lblVendorsHeader";
            this.lblVendorsHeader.Size = new System.Drawing.Size(200, 32);
            this.lblVendorsHeader.TabIndex = 30;
            this.lblVendorsHeader.Text = "Vendors Table";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ProductVendorsTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = this.statesTableAdapter;
            this.tableAdapterManager.UpdateOrder = SQLQueries.SalesOrdersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorsTableAdapter = this.vendorsTableAdapter;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // vendorIDLabel1
            // 
            this.vendorIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorID", true));
            this.vendorIDLabel1.Location = new System.Drawing.Point(175, 70);
            this.vendorIDLabel1.Name = "vendorIDLabel1";
            this.vendorIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.vendorIDLabel1.TabIndex = 31;
            this.vendorIDLabel1.Text = "label1";
            // 
            // vendorNameTextBox
            // 
            this.vendorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorName", true));
            this.vendorNameTextBox.Location = new System.Drawing.Point(178, 101);
            this.vendorNameTextBox.Name = "vendorNameTextBox";
            this.vendorNameTextBox.Size = new System.Drawing.Size(255, 24);
            this.vendorNameTextBox.TabIndex = 32;
            // 
            // vendorStreetAddressTextBox
            // 
            this.vendorStreetAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorStreetAddress", true));
            this.vendorStreetAddressTextBox.Location = new System.Drawing.Point(178, 135);
            this.vendorStreetAddressTextBox.Name = "vendorStreetAddressTextBox";
            this.vendorStreetAddressTextBox.Size = new System.Drawing.Size(255, 24);
            this.vendorStreetAddressTextBox.TabIndex = 33;
            // 
            // vendorCityTextBox
            // 
            this.vendorCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorCity", true));
            this.vendorCityTextBox.Location = new System.Drawing.Point(178, 172);
            this.vendorCityTextBox.Name = "vendorCityTextBox";
            this.vendorCityTextBox.Size = new System.Drawing.Size(97, 24);
            this.vendorCityTextBox.TabIndex = 34;
            // 
            // vendorStateComboBox
            // 
            this.vendorStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorState", true));
            this.vendorStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendorsBindingSource, "VendorState", true));
            this.vendorStateComboBox.DataSource = this.statesBindingSource;
            this.vendorStateComboBox.DisplayMember = "StateAbbrev";
            this.vendorStateComboBox.FormattingEnabled = true;
            this.vendorStateComboBox.Location = new System.Drawing.Point(282, 172);
            this.vendorStateComboBox.Name = "vendorStateComboBox";
            this.vendorStateComboBox.Size = new System.Drawing.Size(90, 26);
            this.vendorStateComboBox.TabIndex = 35;
            this.vendorStateComboBox.ValueMember = "StateAbbrev";
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.salesOrdersDataSet;
            // 
            // vendorZipCodeTextBox
            // 
            this.vendorZipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorZipCode", true));
            this.vendorZipCodeTextBox.Location = new System.Drawing.Point(378, 172);
            this.vendorZipCodeTextBox.Name = "vendorZipCodeTextBox";
            this.vendorZipCodeTextBox.Size = new System.Drawing.Size(55, 24);
            this.vendorZipCodeTextBox.TabIndex = 36;
            // 
            // vendorPhoneNumberTextBox
            // 
            this.vendorPhoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorPhoneNumber", true));
            this.vendorPhoneNumberTextBox.Location = new System.Drawing.Point(641, 72);
            this.vendorPhoneNumberTextBox.Name = "vendorPhoneNumberTextBox";
            this.vendorPhoneNumberTextBox.Size = new System.Drawing.Size(271, 24);
            this.vendorPhoneNumberTextBox.TabIndex = 37;
            // 
            // vendorFaxNumberTextBox
            // 
            this.vendorFaxNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorFaxNumber", true));
            this.vendorFaxNumberTextBox.Location = new System.Drawing.Point(641, 108);
            this.vendorFaxNumberTextBox.Name = "vendorFaxNumberTextBox";
            this.vendorFaxNumberTextBox.Size = new System.Drawing.Size(271, 24);
            this.vendorFaxNumberTextBox.TabIndex = 38;
            // 
            // vendorWebPageTextBox
            // 
            this.vendorWebPageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorWebPage", true));
            this.vendorWebPageTextBox.Location = new System.Drawing.Point(641, 142);
            this.vendorWebPageTextBox.Name = "vendorWebPageTextBox";
            this.vendorWebPageTextBox.Size = new System.Drawing.Size(271, 24);
            this.vendorWebPageTextBox.TabIndex = 39;
            // 
            // vendorEMailAddressTextBox
            // 
            this.vendorEMailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorEMailAddress", true));
            this.vendorEMailAddressTextBox.Location = new System.Drawing.Point(641, 174);
            this.vendorEMailAddressTextBox.Name = "vendorEMailAddressTextBox";
            this.vendorEMailAddressTextBox.Size = new System.Drawing.Size(271, 24);
            this.vendorEMailAddressTextBox.TabIndex = 40;
            // 
            // Vendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 412);
            this.Controls.Add(vendorEMailAddressLabel);
            this.Controls.Add(this.vendorEMailAddressTextBox);
            this.Controls.Add(vendorWebPageLabel);
            this.Controls.Add(this.vendorWebPageTextBox);
            this.Controls.Add(vendorFaxNumberLabel);
            this.Controls.Add(this.vendorFaxNumberTextBox);
            this.Controls.Add(vendorPhoneNumberLabel);
            this.Controls.Add(this.vendorPhoneNumberTextBox);
            this.Controls.Add(this.vendorZipCodeTextBox);
            this.Controls.Add(this.vendorStateComboBox);
            this.Controls.Add(vendorCityLabel);
            this.Controls.Add(this.vendorCityTextBox);
            this.Controls.Add(vendorStreetAddressLabel);
            this.Controls.Add(this.vendorStreetAddressTextBox);
            this.Controls.Add(vendorNameLabel);
            this.Controls.Add(this.vendorNameTextBox);
            this.Controls.Add(vendorIDLabel);
            this.Controls.Add(this.vendorIDLabel1);
            this.Controls.Add(this.lblVendorsHeader);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnProductVendors);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnOrderDetails);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCategories);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Vendors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendors";
            this.Load += new System.EventHandler(this.Vendors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProductVendors;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCategories;
        private SalesOrdersDataSet salesOrdersDataSet;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private SalesOrdersDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
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
        private System.Windows.Forms.Label lblVendorsHeader;
        private SalesOrdersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SalesOrdersDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private System.Windows.Forms.Label vendorIDLabel1;
        private System.Windows.Forms.TextBox vendorNameTextBox;
        private System.Windows.Forms.TextBox vendorStreetAddressTextBox;
        private System.Windows.Forms.TextBox vendorCityTextBox;
        private System.Windows.Forms.ComboBox vendorStateComboBox;
        private System.Windows.Forms.TextBox vendorZipCodeTextBox;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private System.Windows.Forms.TextBox vendorPhoneNumberTextBox;
        private System.Windows.Forms.TextBox vendorFaxNumberTextBox;
        private System.Windows.Forms.TextBox vendorWebPageTextBox;
        private System.Windows.Forms.TextBox vendorEMailAddressTextBox;
    }
}