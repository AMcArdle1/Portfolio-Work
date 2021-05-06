
namespace SQLQueries
{
    partial class OrderDetails
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
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label orderDetailQuotedPriceLabel;
            System.Windows.Forms.Label orderDetailQuantityOrderedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetails));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnProductVendors = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesOrdersDataSet = new SQLQueries.SalesOrdersDataSet();
            this.orderDetailsTableAdapter = new SQLQueries.SalesOrdersDataSetTableAdapters.OrderDetailsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tableAdapterManager = new SQLQueries.SalesOrdersDataSetTableAdapters.TableAdapterManager();
            this.orderIDLabel1 = new System.Windows.Forms.Label();
            this.productIDLabel1 = new System.Windows.Forms.Label();
            this.orderDetailQuotedPriceTextBox = new System.Windows.Forms.TextBox();
            this.orderDetailQuantityOrderedTextBox = new System.Windows.Forms.TextBox();
            orderIDLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            orderDetailQuotedPriceLabel = new System.Windows.Forms.Label();
            orderDetailQuantityOrderedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(238, 98);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(68, 18);
            orderIDLabel.TabIndex = 30;
            orderIDLabel.Text = "Order ID:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(238, 138);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(82, 18);
            productIDLabel.TabIndex = 31;
            productIDLabel.Text = "Product ID:";
            // 
            // orderDetailQuotedPriceLabel
            // 
            orderDetailQuotedPriceLabel.AutoSize = true;
            orderDetailQuotedPriceLabel.Location = new System.Drawing.Point(238, 183);
            orderDetailQuotedPriceLabel.Name = "orderDetailQuotedPriceLabel";
            orderDetailQuotedPriceLabel.Size = new System.Drawing.Size(182, 18);
            orderDetailQuotedPriceLabel.TabIndex = 32;
            orderDetailQuotedPriceLabel.Text = "Order Detail Quoted Price:";
            // 
            // orderDetailQuantityOrderedLabel
            // 
            orderDetailQuantityOrderedLabel.AutoSize = true;
            orderDetailQuantityOrderedLabel.Location = new System.Drawing.Point(238, 224);
            orderDetailQuantityOrderedLabel.Name = "orderDetailQuantityOrderedLabel";
            orderDetailQuantityOrderedLabel.Size = new System.Drawing.Size(207, 18);
            orderDetailQuantityOrderedLabel.TabIndex = 33;
            orderDetailQuantityOrderedLabel.Text = "Order Detail Quantity Ordered:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(413, 376);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 56);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnVendors
            // 
            this.btnVendors.Location = new System.Drawing.Point(809, 313);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(107, 56);
            this.btnVendors.TabIndex = 27;
            this.btnVendors.Text = "Vendors";
            this.btnVendors.UseVisualStyleBackColor = true;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnProductVendors
            // 
            this.btnProductVendors.Location = new System.Drawing.Point(695, 313);
            this.btnProductVendors.Name = "btnProductVendors";
            this.btnProductVendors.Size = new System.Drawing.Size(107, 56);
            this.btnProductVendors.TabIndex = 26;
            this.btnProductVendors.Text = "Product Vendors";
            this.btnProductVendors.UseVisualStyleBackColor = true;
            this.btnProductVendors.Click += new System.EventHandler(this.btnProductVendors_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(582, 313);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(107, 56);
            this.btnProducts.TabIndex = 25;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(127, 313);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(107, 56);
            this.btnCustomers.TabIndex = 24;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(241, 313);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(107, 56);
            this.btnOrders.TabIndex = 23;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(354, 313);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(107, 56);
            this.btnEmployees.TabIndex = 22;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(468, 313);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(107, 56);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Location = new System.Drawing.Point(14, 313);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(107, 56);
            this.btnCategories.TabIndex = 20;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.salesOrdersDataSet;
            // 
            // salesOrdersDataSet
            // 
            this.salesOrdersDataSet.DataSetName = "SalesOrdersDataSet";
            this.salesOrdersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetailsTableAdapter
            // 
            this.orderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "Order Details Table";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.orderDetailsBindingSource;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(938, 27);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.OrderDetailsTableAdapter = this.orderDetailsTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ProductVendorsTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SQLQueries.SalesOrdersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorsTableAdapter = null;
            // 
            // orderIDLabel1
            // 
            this.orderIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "OrderID", true));
            this.orderIDLabel1.Location = new System.Drawing.Point(448, 98);
            this.orderIDLabel1.Name = "orderIDLabel1";
            this.orderIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.orderIDLabel1.TabIndex = 31;
            this.orderIDLabel1.Text = "label2";
            // 
            // productIDLabel1
            // 
            this.productIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "ProductID", true));
            this.productIDLabel1.Location = new System.Drawing.Point(448, 138);
            this.productIDLabel1.Name = "productIDLabel1";
            this.productIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.productIDLabel1.TabIndex = 32;
            this.productIDLabel1.Text = "label2";
            // 
            // orderDetailQuotedPriceTextBox
            // 
            this.orderDetailQuotedPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "OrderDetailQuotedPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.orderDetailQuotedPriceTextBox.Location = new System.Drawing.Point(451, 180);
            this.orderDetailQuotedPriceTextBox.Name = "orderDetailQuotedPriceTextBox";
            this.orderDetailQuotedPriceTextBox.Size = new System.Drawing.Size(124, 24);
            this.orderDetailQuotedPriceTextBox.TabIndex = 33;
            this.orderDetailQuotedPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderDetailQuantityOrderedTextBox
            // 
            this.orderDetailQuantityOrderedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "OrderDetailQuantityOrdered", true));
            this.orderDetailQuantityOrderedTextBox.Location = new System.Drawing.Point(451, 221);
            this.orderDetailQuantityOrderedTextBox.Name = "orderDetailQuantityOrderedTextBox";
            this.orderDetailQuantityOrderedTextBox.Size = new System.Drawing.Size(124, 24);
            this.orderDetailQuantityOrderedTextBox.TabIndex = 34;
            this.orderDetailQuantityOrderedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 452);
            this.Controls.Add(orderDetailQuantityOrderedLabel);
            this.Controls.Add(this.orderDetailQuantityOrderedTextBox);
            this.Controls.Add(orderDetailQuotedPriceLabel);
            this.Controls.Add(this.orderDetailQuotedPriceTextBox);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDLabel1);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDLabel1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVendors);
            this.Controls.Add(this.btnProductVendors);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCategories);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderDetails";
            this.Load += new System.EventHandler(this.OrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCategories;
        private SalesOrdersDataSet salesOrdersDataSet;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private SalesOrdersDataSetTableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter;
        private System.Windows.Forms.Label label1;
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
        private SalesOrdersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label orderIDLabel1;
        private System.Windows.Forms.Label productIDLabel1;
        private System.Windows.Forms.TextBox orderDetailQuotedPriceTextBox;
        private System.Windows.Forms.TextBox orderDetailQuantityOrderedTextBox;
    }
}