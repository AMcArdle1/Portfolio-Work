
namespace SQLQueries
{
    partial class Products
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
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label productDescShortLabel;
            System.Windows.Forms.Label productImageLabel;
            System.Windows.Forms.Label productPriceLabel;
            System.Windows.Forms.Label productQtyLabel;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label productDescLongLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnProductVendors = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesOrdersDataSet = new SQLQueries.SalesOrdersDataSet();
            this.productsTableAdapter = new SQLQueries.SalesOrdersDataSetTableAdapters.ProductsTableAdapter();
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new SQLQueries.SalesOrdersDataSetTableAdapters.TableAdapterManager();
            this.productIDLabel1 = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productDescShortTextBox = new System.Windows.Forms.TextBox();
            this.productImageTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.productQtyTextBox = new System.Windows.Forms.TextBox();
            this.categoryIDLabel1 = new System.Windows.Forms.Label();
            this.productDescLongTextBox = new System.Windows.Forms.TextBox();
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            productDescShortLabel = new System.Windows.Forms.Label();
            productImageLabel = new System.Windows.Forms.Label();
            productPriceLabel = new System.Windows.Forms.Label();
            productQtyLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            productDescLongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(21, 81);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(82, 18);
            productIDLabel.TabIndex = 30;
            productIDLabel.Text = "Product ID:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(21, 118);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(108, 18);
            productNameLabel.TabIndex = 31;
            productNameLabel.Text = "Product Name:";
            // 
            // productDescShortLabel
            // 
            productDescShortLabel.AutoSize = true;
            productDescShortLabel.Location = new System.Drawing.Point(21, 153);
            productDescShortLabel.Name = "productDescShortLabel";
            productDescShortLabel.Size = new System.Drawing.Size(143, 18);
            productDescShortLabel.TabIndex = 32;
            productDescShortLabel.Text = "Product Desc Short:";
            // 
            // productImageLabel
            // 
            productImageLabel.AutoSize = true;
            productImageLabel.Location = new System.Drawing.Point(500, 86);
            productImageLabel.Name = "productImageLabel";
            productImageLabel.Size = new System.Drawing.Size(108, 18);
            productImageLabel.TabIndex = 33;
            productImageLabel.Text = "Product Image:";
            // 
            // productPriceLabel
            // 
            productPriceLabel.AutoSize = true;
            productPriceLabel.Location = new System.Drawing.Point(21, 222);
            productPriceLabel.Name = "productPriceLabel";
            productPriceLabel.Size = new System.Drawing.Size(102, 18);
            productPriceLabel.TabIndex = 34;
            productPriceLabel.Text = "Product Price:";
            // 
            // productQtyLabel
            // 
            productQtyLabel.AutoSize = true;
            productQtyLabel.Location = new System.Drawing.Point(21, 254);
            productQtyLabel.Name = "productQtyLabel";
            productQtyLabel.Size = new System.Drawing.Size(91, 18);
            productQtyLabel.TabIndex = 35;
            productQtyLabel.Text = "Product Qty:";
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(21, 284);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(90, 18);
            categoryIDLabel.TabIndex = 36;
            categoryIDLabel.Text = "Category ID:";
            // 
            // productDescLongLabel
            // 
            productDescLongLabel.AutoSize = true;
            productDescLongLabel.Location = new System.Drawing.Point(21, 188);
            productDescLongLabel.Name = "productDescLongLabel";
            productDescLongLabel.Size = new System.Drawing.Size(140, 18);
            productDescLongLabel.TabIndex = 37;
            productDescLongLabel.Text = "Product Desc Long:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(415, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 56);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnVendors
            // 
            this.btnVendors.Location = new System.Drawing.Point(811, 326);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(107, 56);
            this.btnVendors.TabIndex = 27;
            this.btnVendors.Text = "Vendors";
            this.btnVendors.UseVisualStyleBackColor = true;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnProductVendors
            // 
            this.btnProductVendors.Location = new System.Drawing.Point(697, 326);
            this.btnProductVendors.Name = "btnProductVendors";
            this.btnProductVendors.Size = new System.Drawing.Size(107, 56);
            this.btnProductVendors.TabIndex = 26;
            this.btnProductVendors.Text = "Product Vendors";
            this.btnProductVendors.UseVisualStyleBackColor = true;
            this.btnProductVendors.Click += new System.EventHandler(this.btnProductVendors_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(129, 326);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(107, 56);
            this.btnCustomers.TabIndex = 25;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.Location = new System.Drawing.Point(470, 326);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(107, 56);
            this.btnOrderDetails.TabIndex = 24;
            this.btnOrderDetails.Text = "Order Details";
            this.btnOrderDetails.UseVisualStyleBackColor = true;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(243, 326);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(107, 56);
            this.btnOrders.TabIndex = 23;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(356, 326);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(107, 56);
            this.btnEmployees.TabIndex = 22;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(584, 326);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(107, 56);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Location = new System.Drawing.Point(16, 326);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(107, 56);
            this.btnCategories.TabIndex = 20;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.salesOrdersDataSet;
            // 
            // salesOrdersDataSet
            // 
            this.salesOrdersDataSet.DataSetName = "SalesOrdersDataSet";
            this.salesOrdersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.productsBindingSource;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(937, 27);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "Products Table";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.ProductVendorsTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SQLQueries.SalesOrdersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorsTableAdapter = null;
            // 
            // productIDLabel1
            // 
            this.productIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductID", true));
            this.productIDLabel1.Location = new System.Drawing.Point(169, 81);
            this.productIDLabel1.Name = "productIDLabel1";
            this.productIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.productIDLabel1.TabIndex = 31;
            this.productIDLabel1.Text = "label2";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(170, 115);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(300, 24);
            this.productNameTextBox.TabIndex = 32;
            // 
            // productDescShortTextBox
            // 
            this.productDescShortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductDescShort", true));
            this.productDescShortTextBox.Location = new System.Drawing.Point(170, 150);
            this.productDescShortTextBox.Name = "productDescShortTextBox";
            this.productDescShortTextBox.Size = new System.Drawing.Size(300, 24);
            this.productDescShortTextBox.TabIndex = 33;
            // 
            // productImageTextBox
            // 
            this.productImageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductImage", true));
            this.productImageTextBox.Location = new System.Drawing.Point(614, 83);
            this.productImageTextBox.Name = "productImageTextBox";
            this.productImageTextBox.Size = new System.Drawing.Size(304, 24);
            this.productImageTextBox.TabIndex = 34;
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.productPriceTextBox.Location = new System.Drawing.Point(170, 219);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(180, 24);
            this.productPriceTextBox.TabIndex = 35;
            this.productPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productQtyTextBox
            // 
            this.productQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductQty", true));
            this.productQtyTextBox.Location = new System.Drawing.Point(170, 251);
            this.productQtyTextBox.Name = "productQtyTextBox";
            this.productQtyTextBox.Size = new System.Drawing.Size(180, 24);
            this.productQtyTextBox.TabIndex = 36;
            this.productQtyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // categoryIDLabel1
            // 
            this.categoryIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "CategoryID", true));
            this.categoryIDLabel1.Location = new System.Drawing.Point(167, 284);
            this.categoryIDLabel1.Name = "categoryIDLabel1";
            this.categoryIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.categoryIDLabel1.TabIndex = 37;
            this.categoryIDLabel1.Text = "label2";
            // 
            // productDescLongTextBox
            // 
            this.productDescLongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductDescLong", true));
            this.productDescLongTextBox.Location = new System.Drawing.Point(170, 185);
            this.productDescLongTextBox.Name = "productDescLongTextBox";
            this.productDescLongTextBox.Size = new System.Drawing.Size(300, 24);
            this.productDescLongTextBox.TabIndex = 38;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 457);
            this.Controls.Add(productDescLongLabel);
            this.Controls.Add(this.productDescLongTextBox);
            this.Controls.Add(categoryIDLabel);
            this.Controls.Add(this.categoryIDLabel1);
            this.Controls.Add(productQtyLabel);
            this.Controls.Add(this.productQtyTextBox);
            this.Controls.Add(productPriceLabel);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(productImageLabel);
            this.Controls.Add(this.productImageTextBox);
            this.Controls.Add(productDescShortLabel);
            this.Controls.Add(this.productDescShortTextBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVendors);
            this.Controls.Add(this.btnProductVendors);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnOrderDetails);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCategories);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).EndInit();
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
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCategories;
        private SalesOrdersDataSet salesOrdersDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private SalesOrdersDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
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
        private System.Windows.Forms.Label label1;
        private SalesOrdersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label productIDLabel1;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productDescShortTextBox;
        private System.Windows.Forms.TextBox productImageTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.TextBox productQtyTextBox;
        private System.Windows.Forms.Label categoryIDLabel1;
        private System.Windows.Forms.TextBox productDescLongTextBox;
    }
}