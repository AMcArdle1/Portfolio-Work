
namespace SalesOrdersDB2
{
    partial class FormSalesOrdersAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalesOrdersAuto));
            System.Windows.Forms.Label customerFirstNameLabel;
            System.Windows.Forms.Label customerStreetAddressLabel;
            System.Windows.Forms.Label customerCityLabel;
            System.Windows.Forms.Label customerPhoneNumberLabel;
            this.salesOrdersDataSet = new SalesOrdersDB2.SalesOrdersDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new SalesOrdersDB2.SalesOrdersDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new SalesOrdersDB2.SalesOrdersDataSetTableAdapters.TableAdapterManager();
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.customersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customerFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.customerLastNameTextBox = new System.Windows.Forms.TextBox();
            this.customerStreetAddressTextBox = new System.Windows.Forms.TextBox();
            this.customerCityTextBox = new System.Windows.Forms.TextBox();
            this.customerStateTextBox = new System.Windows.Forms.TextBox();
            this.customerZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.customerAreaCodeTextBox = new System.Windows.Forms.TextBox();
            this.customerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            customerFirstNameLabel = new System.Windows.Forms.Label();
            customerStreetAddressLabel = new System.Windows.Forms.Label();
            customerCityLabel = new System.Windows.Forms.Label();
            customerPhoneNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // salesOrdersDataSet
            // 
            this.salesOrdersDataSet.DataSetName = "SalesOrdersDataSet";
            this.salesOrdersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.salesOrdersDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.UpdateOrder = SalesOrdersDB2.SalesOrdersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.customersBindingNavigatorSaveItem});
            this.customersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customersBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.customersBindingNavigator.TabIndex = 0;
            this.customersBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // customersBindingNavigatorSaveItem
            // 
            this.customersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customersBindingNavigatorSaveItem.Image")));
            this.customersBindingNavigatorSaveItem.Name = "customersBindingNavigatorSaveItem";
            this.customersBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.customersBindingNavigatorSaveItem.Text = "Save Data";
            this.customersBindingNavigatorSaveItem.Click += new System.EventHandler(this.customersBindingNavigatorSaveItem_Click);
            // 
            // customerFirstNameLabel
            // 
            customerFirstNameLabel.AutoSize = true;
            customerFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerFirstNameLabel.Location = new System.Drawing.Point(112, 109);
            customerFirstNameLabel.Name = "customerFirstNameLabel";
            customerFirstNameLabel.Size = new System.Drawing.Size(194, 29);
            customerFirstNameLabel.TabIndex = 1;
            customerFirstNameLabel.Text = "Customer Name:";
            // 
            // customerFirstNameTextBox
            // 
            this.customerFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerFirstName", true));
            this.customerFirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerFirstNameTextBox.Location = new System.Drawing.Point(360, 106);
            this.customerFirstNameTextBox.Name = "customerFirstNameTextBox";
            this.customerFirstNameTextBox.Size = new System.Drawing.Size(154, 34);
            this.customerFirstNameTextBox.TabIndex = 2;
            // 
            // customerLastNameTextBox
            // 
            this.customerLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerLastName", true));
            this.customerLastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLastNameTextBox.Location = new System.Drawing.Point(530, 106);
            this.customerLastNameTextBox.Name = "customerLastNameTextBox";
            this.customerLastNameTextBox.Size = new System.Drawing.Size(154, 34);
            this.customerLastNameTextBox.TabIndex = 4;
            // 
            // customerStreetAddressLabel
            // 
            customerStreetAddressLabel.AutoSize = true;
            customerStreetAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerStreetAddressLabel.Location = new System.Drawing.Point(53, 154);
            customerStreetAddressLabel.Name = "customerStreetAddressLabel";
            customerStreetAddressLabel.Size = new System.Drawing.Size(288, 29);
            customerStreetAddressLabel.TabIndex = 5;
            customerStreetAddressLabel.Text = "Customer Street Address:";
            // 
            // customerStreetAddressTextBox
            // 
            this.customerStreetAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerStreetAddress", true));
            this.customerStreetAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerStreetAddressTextBox.Location = new System.Drawing.Point(358, 154);
            this.customerStreetAddressTextBox.Name = "customerStreetAddressTextBox";
            this.customerStreetAddressTextBox.Size = new System.Drawing.Size(324, 34);
            this.customerStreetAddressTextBox.TabIndex = 6;
            // 
            // customerCityLabel
            // 
            customerCityLabel.AutoSize = true;
            customerCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerCityLabel.Location = new System.Drawing.Point(112, 201);
            customerCityLabel.Name = "customerCityLabel";
            customerCityLabel.Size = new System.Drawing.Size(180, 29);
            customerCityLabel.TabIndex = 7;
            customerCityLabel.Text = "City / State / Zip";
            // 
            // customerCityTextBox
            // 
            this.customerCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerCity", true));
            this.customerCityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCityTextBox.Location = new System.Drawing.Point(360, 201);
            this.customerCityTextBox.Name = "customerCityTextBox";
            this.customerCityTextBox.Size = new System.Drawing.Size(100, 34);
            this.customerCityTextBox.TabIndex = 8;
            // 
            // customerStateTextBox
            // 
            this.customerStateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerState", true));
            this.customerStateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerStateTextBox.Location = new System.Drawing.Point(482, 201);
            this.customerStateTextBox.Name = "customerStateTextBox";
            this.customerStateTextBox.Size = new System.Drawing.Size(84, 34);
            this.customerStateTextBox.TabIndex = 10;
            // 
            // customerZipCodeTextBox
            // 
            this.customerZipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerZipCode", true));
            this.customerZipCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerZipCodeTextBox.Location = new System.Drawing.Point(584, 201);
            this.customerZipCodeTextBox.Name = "customerZipCodeTextBox";
            this.customerZipCodeTextBox.Size = new System.Drawing.Size(100, 34);
            this.customerZipCodeTextBox.TabIndex = 12;
            // 
            // customerAreaCodeTextBox
            // 
            this.customerAreaCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerAreaCode", true));
            this.customerAreaCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAreaCodeTextBox.Location = new System.Drawing.Point(360, 256);
            this.customerAreaCodeTextBox.Name = "customerAreaCodeTextBox";
            this.customerAreaCodeTextBox.Size = new System.Drawing.Size(100, 34);
            this.customerAreaCodeTextBox.TabIndex = 14;
            // 
            // customerPhoneNumberLabel
            // 
            customerPhoneNumberLabel.AutoSize = true;
            customerPhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerPhoneNumberLabel.Location = new System.Drawing.Point(49, 256);
            customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
            customerPhoneNumberLabel.Size = new System.Drawing.Size(292, 29);
            customerPhoneNumberLabel.TabIndex = 15;
            customerPhoneNumberLabel.Text = "Customer Phone Number:";
            // 
            // customerPhoneNumberTextBox
            // 
            this.customerPhoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerPhoneNumber", true));
            this.customerPhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPhoneNumberTextBox.Location = new System.Drawing.Point(466, 256);
            this.customerPhoneNumberTextBox.Name = "customerPhoneNumberTextBox";
            this.customerPhoneNumberTextBox.Size = new System.Drawing.Size(218, 34);
            this.customerPhoneNumberTextBox.TabIndex = 16;
            // 
            // FormSalesOrdersAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(customerPhoneNumberLabel);
            this.Controls.Add(this.customerPhoneNumberTextBox);
            this.Controls.Add(this.customerAreaCodeTextBox);
            this.Controls.Add(this.customerZipCodeTextBox);
            this.Controls.Add(this.customerStateTextBox);
            this.Controls.Add(customerCityLabel);
            this.Controls.Add(this.customerCityTextBox);
            this.Controls.Add(customerStreetAddressLabel);
            this.Controls.Add(this.customerStreetAddressTextBox);
            this.Controls.Add(this.customerLastNameTextBox);
            this.Controls.Add(customerFirstNameLabel);
            this.Controls.Add(this.customerFirstNameTextBox);
            this.Controls.Add(this.customersBindingNavigator);
            this.Name = "FormSalesOrdersAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormSalesOrdersAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SalesOrdersDataSet salesOrdersDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private SalesOrdersDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private SalesOrdersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton customersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox customerFirstNameTextBox;
        private System.Windows.Forms.TextBox customerLastNameTextBox;
        private System.Windows.Forms.TextBox customerStreetAddressTextBox;
        private System.Windows.Forms.TextBox customerCityTextBox;
        private System.Windows.Forms.TextBox customerStateTextBox;
        private System.Windows.Forms.TextBox customerZipCodeTextBox;
        private System.Windows.Forms.TextBox customerAreaCodeTextBox;
        private System.Windows.Forms.TextBox customerPhoneNumberTextBox;
    }
}

