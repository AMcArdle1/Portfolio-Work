
namespace Ch12StoreInventory
{
    partial class Form1
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
            this.lblSBName = new System.Windows.Forms.Label();
            this.txtSBName = new System.Windows.Forms.TextBox();
            this.btnSBName = new System.Windows.Forms.Button();
            this.btnSBUPC = new System.Windows.Forms.Button();
            this.txtSBUPC = new System.Windows.Forms.TextBox();
            this.lblSBUPC = new System.Windows.Forms.Label();
            this.lblSBNHeader = new System.Windows.Forms.Label();
            this.lblSBNResult = new System.Windows.Forms.Label();
            this.lblSBNUPCResult = new System.Windows.Forms.Label();
            this.lblSBNUPCHeader = new System.Windows.Forms.Label();
            this.lblSBNStorePriceResult = new System.Windows.Forms.Label();
            this.lblSBNStorePriceHeader = new System.Windows.Forms.Label();
            this.lblSBUPCCostPerCaseResult = new System.Windows.Forms.Label();
            this.lblSBUPCCostPerCaseHeader = new System.Windows.Forms.Label();
            this.lblSBUPCUnitsPerCaseResult = new System.Windows.Forms.Label();
            this.lblSBUPCUnitsPerCaseHeader = new System.Windows.Forms.Label();
            this.lblSBUPCDistributorResult = new System.Windows.Forms.Label();
            this.lblSBUPCDistributorHeader = new System.Windows.Forms.Label();
            this.groupBoxChangeStorePrice = new System.Windows.Forms.GroupBox();
            this.lblCSPNewPriceHeader = new System.Windows.Forms.Label();
            this.txtCSPNewPriceEntry = new System.Windows.Forms.TextBox();
            this.txtCSPAccessKeyEntry = new System.Windows.Forms.TextBox();
            this.lblCSPAccessKeyHeader = new System.Windows.Forms.Label();
            this.btnUpdatePrice = new System.Windows.Forms.Button();
            this.lblCSPError = new System.Windows.Forms.Label();
            this.groupBoxDeleteItem = new System.Windows.Forms.GroupBox();
            this.lblDIError = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.txtAccessKeyEntry = new System.Windows.Forms.TextBox();
            this.lblDIAccessKeyHeader = new System.Windows.Forms.Label();
            this.txtDIVerifyUPCEntry = new System.Windows.Forms.TextBox();
            this.lblDIVerifyUPCHeader = new System.Windows.Forms.Label();
            this.groupBoxAddNewItem = new System.Windows.Forms.GroupBox();
            this.lblANINameHeader = new System.Windows.Forms.Label();
            this.txtANINameEntry = new System.Windows.Forms.TextBox();
            this.txtANIUPCEntry = new System.Windows.Forms.TextBox();
            this.lblANIUPCHeader = new System.Windows.Forms.Label();
            this.txtANIStorePriceEntry = new System.Windows.Forms.TextBox();
            this.lblANIStorePriceHeader = new System.Windows.Forms.Label();
            this.txtANIAccessKeyEntry = new System.Windows.Forms.TextBox();
            this.lblANIAccessKeyHeader = new System.Windows.Forms.Label();
            this.txtANICostPerCaseEntry = new System.Windows.Forms.TextBox();
            this.lblANICostPerCaseHeader = new System.Windows.Forms.Label();
            this.txtANIUnitsPerCaseEntry = new System.Windows.Forms.TextBox();
            this.lblANIUnitsPerCaseHeader = new System.Windows.Forms.Label();
            this.lblANIDistributorEntry = new System.Windows.Forms.TextBox();
            this.lblANIDistributorHeader = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblANIError = new System.Windows.Forms.Label();
            this.groupBoxChangeStorePrice.SuspendLayout();
            this.groupBoxDeleteItem.SuspendLayout();
            this.groupBoxAddNewItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSBName
            // 
            this.lblSBName.AutoSize = true;
            this.lblSBName.Location = new System.Drawing.Point(12, 9);
            this.lblSBName.Name = "lblSBName";
            this.lblSBName.Size = new System.Drawing.Size(113, 17);
            this.lblSBName.TabIndex = 0;
            this.lblSBName.Text = "Search by Name";
            // 
            // txtSBName
            // 
            this.txtSBName.Location = new System.Drawing.Point(15, 29);
            this.txtSBName.Name = "txtSBName";
            this.txtSBName.Size = new System.Drawing.Size(130, 22);
            this.txtSBName.TabIndex = 0;
            // 
            // btnSBName
            // 
            this.btnSBName.Location = new System.Drawing.Point(174, 29);
            this.btnSBName.Name = "btnSBName";
            this.btnSBName.Size = new System.Drawing.Size(75, 23);
            this.btnSBName.TabIndex = 1;
            this.btnSBName.Text = "Search";
            this.btnSBName.UseVisualStyleBackColor = true;
            // 
            // btnSBUPC
            // 
            this.btnSBUPC.Location = new System.Drawing.Point(471, 29);
            this.btnSBUPC.Name = "btnSBUPC";
            this.btnSBUPC.Size = new System.Drawing.Size(75, 23);
            this.btnSBUPC.TabIndex = 3;
            this.btnSBUPC.Text = "Search";
            this.btnSBUPC.UseVisualStyleBackColor = true;
            // 
            // txtSBUPC
            // 
            this.txtSBUPC.Location = new System.Drawing.Point(312, 29);
            this.txtSBUPC.Name = "txtSBUPC";
            this.txtSBUPC.Size = new System.Drawing.Size(130, 22);
            this.txtSBUPC.TabIndex = 2;
            // 
            // lblSBUPC
            // 
            this.lblSBUPC.AutoSize = true;
            this.lblSBUPC.Location = new System.Drawing.Point(309, 9);
            this.lblSBUPC.Name = "lblSBUPC";
            this.lblSBUPC.Size = new System.Drawing.Size(104, 17);
            this.lblSBUPC.TabIndex = 3;
            this.lblSBUPC.Text = "Search by UPC";
            // 
            // lblSBNHeader
            // 
            this.lblSBNHeader.AutoSize = true;
            this.lblSBNHeader.BackColor = System.Drawing.SystemColors.Control;
            this.lblSBNHeader.Location = new System.Drawing.Point(12, 71);
            this.lblSBNHeader.Name = "lblSBNHeader";
            this.lblSBNHeader.Size = new System.Drawing.Size(49, 17);
            this.lblSBNHeader.TabIndex = 6;
            this.lblSBNHeader.Text = "Name:";
            // 
            // lblSBNResult
            // 
            this.lblSBNResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSBNResult.Location = new System.Drawing.Point(103, 71);
            this.lblSBNResult.Name = "lblSBNResult";
            this.lblSBNResult.Size = new System.Drawing.Size(146, 21);
            this.lblSBNResult.TabIndex = 7;
            // 
            // lblSBNUPCResult
            // 
            this.lblSBNUPCResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSBNUPCResult.Location = new System.Drawing.Point(103, 108);
            this.lblSBNUPCResult.Name = "lblSBNUPCResult";
            this.lblSBNUPCResult.Size = new System.Drawing.Size(146, 21);
            this.lblSBNUPCResult.TabIndex = 9;
            // 
            // lblSBNUPCHeader
            // 
            this.lblSBNUPCHeader.AutoSize = true;
            this.lblSBNUPCHeader.BackColor = System.Drawing.SystemColors.Control;
            this.lblSBNUPCHeader.Location = new System.Drawing.Point(12, 108);
            this.lblSBNUPCHeader.Name = "lblSBNUPCHeader";
            this.lblSBNUPCHeader.Size = new System.Drawing.Size(40, 17);
            this.lblSBNUPCHeader.TabIndex = 8;
            this.lblSBNUPCHeader.Text = "UPC:";
            // 
            // lblSBNStorePriceResult
            // 
            this.lblSBNStorePriceResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSBNStorePriceResult.Location = new System.Drawing.Point(103, 144);
            this.lblSBNStorePriceResult.Name = "lblSBNStorePriceResult";
            this.lblSBNStorePriceResult.Size = new System.Drawing.Size(146, 21);
            this.lblSBNStorePriceResult.TabIndex = 11;
            // 
            // lblSBNStorePriceHeader
            // 
            this.lblSBNStorePriceHeader.AutoSize = true;
            this.lblSBNStorePriceHeader.BackColor = System.Drawing.SystemColors.Control;
            this.lblSBNStorePriceHeader.Location = new System.Drawing.Point(12, 144);
            this.lblSBNStorePriceHeader.Name = "lblSBNStorePriceHeader";
            this.lblSBNStorePriceHeader.Size = new System.Drawing.Size(82, 17);
            this.lblSBNStorePriceHeader.TabIndex = 10;
            this.lblSBNStorePriceHeader.Text = "Store Price:";
            // 
            // lblSBUPCCostPerCaseResult
            // 
            this.lblSBUPCCostPerCaseResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSBUPCCostPerCaseResult.Location = new System.Drawing.Point(417, 71);
            this.lblSBUPCCostPerCaseResult.Name = "lblSBUPCCostPerCaseResult";
            this.lblSBUPCCostPerCaseResult.Size = new System.Drawing.Size(129, 21);
            this.lblSBUPCCostPerCaseResult.TabIndex = 13;
            // 
            // lblSBUPCCostPerCaseHeader
            // 
            this.lblSBUPCCostPerCaseHeader.AutoSize = true;
            this.lblSBUPCCostPerCaseHeader.BackColor = System.Drawing.SystemColors.Control;
            this.lblSBUPCCostPerCaseHeader.Location = new System.Drawing.Point(309, 71);
            this.lblSBUPCCostPerCaseHeader.Name = "lblSBUPCCostPerCaseHeader";
            this.lblSBUPCCostPerCaseHeader.Size = new System.Drawing.Size(102, 17);
            this.lblSBUPCCostPerCaseHeader.TabIndex = 12;
            this.lblSBUPCCostPerCaseHeader.Text = "Cost Per Case:";
            // 
            // lblSBUPCUnitsPerCaseResult
            // 
            this.lblSBUPCUnitsPerCaseResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSBUPCUnitsPerCaseResult.Location = new System.Drawing.Point(420, 108);
            this.lblSBUPCUnitsPerCaseResult.Name = "lblSBUPCUnitsPerCaseResult";
            this.lblSBUPCUnitsPerCaseResult.Size = new System.Drawing.Size(126, 21);
            this.lblSBUPCUnitsPerCaseResult.TabIndex = 15;
            // 
            // lblSBUPCUnitsPerCaseHeader
            // 
            this.lblSBUPCUnitsPerCaseHeader.AutoSize = true;
            this.lblSBUPCUnitsPerCaseHeader.BackColor = System.Drawing.SystemColors.Control;
            this.lblSBUPCUnitsPerCaseHeader.Location = new System.Drawing.Point(309, 108);
            this.lblSBUPCUnitsPerCaseHeader.Name = "lblSBUPCUnitsPerCaseHeader";
            this.lblSBUPCUnitsPerCaseHeader.Size = new System.Drawing.Size(106, 17);
            this.lblSBUPCUnitsPerCaseHeader.TabIndex = 14;
            this.lblSBUPCUnitsPerCaseHeader.Text = "Units Per Case:";
            // 
            // lblSBUPCDistributorResult
            // 
            this.lblSBUPCDistributorResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSBUPCDistributorResult.Location = new System.Drawing.Point(420, 144);
            this.lblSBUPCDistributorResult.Name = "lblSBUPCDistributorResult";
            this.lblSBUPCDistributorResult.Size = new System.Drawing.Size(126, 21);
            this.lblSBUPCDistributorResult.TabIndex = 17;
            // 
            // lblSBUPCDistributorHeader
            // 
            this.lblSBUPCDistributorHeader.AutoSize = true;
            this.lblSBUPCDistributorHeader.BackColor = System.Drawing.SystemColors.Control;
            this.lblSBUPCDistributorHeader.Location = new System.Drawing.Point(309, 144);
            this.lblSBUPCDistributorHeader.Name = "lblSBUPCDistributorHeader";
            this.lblSBUPCDistributorHeader.Size = new System.Drawing.Size(81, 17);
            this.lblSBUPCDistributorHeader.TabIndex = 16;
            this.lblSBUPCDistributorHeader.Text = "Distributor: ";
            // 
            // groupBoxChangeStorePrice
            // 
            this.groupBoxChangeStorePrice.Controls.Add(this.lblCSPError);
            this.groupBoxChangeStorePrice.Controls.Add(this.btnUpdatePrice);
            this.groupBoxChangeStorePrice.Controls.Add(this.txtCSPAccessKeyEntry);
            this.groupBoxChangeStorePrice.Controls.Add(this.lblCSPAccessKeyHeader);
            this.groupBoxChangeStorePrice.Controls.Add(this.txtCSPNewPriceEntry);
            this.groupBoxChangeStorePrice.Controls.Add(this.lblCSPNewPriceHeader);
            this.groupBoxChangeStorePrice.Location = new System.Drawing.Point(15, 189);
            this.groupBoxChangeStorePrice.Name = "groupBoxChangeStorePrice";
            this.groupBoxChangeStorePrice.Size = new System.Drawing.Size(234, 181);
            this.groupBoxChangeStorePrice.TabIndex = 18;
            this.groupBoxChangeStorePrice.TabStop = false;
            this.groupBoxChangeStorePrice.Text = "Change Store Price";
            // 
            // lblCSPNewPriceHeader
            // 
            this.lblCSPNewPriceHeader.AutoSize = true;
            this.lblCSPNewPriceHeader.Location = new System.Drawing.Point(6, 33);
            this.lblCSPNewPriceHeader.Name = "lblCSPNewPriceHeader";
            this.lblCSPNewPriceHeader.Size = new System.Drawing.Size(71, 17);
            this.lblCSPNewPriceHeader.TabIndex = 0;
            this.lblCSPNewPriceHeader.Text = "New Price";
            // 
            // txtCSPNewPriceEntry
            // 
            this.txtCSPNewPriceEntry.Location = new System.Drawing.Point(104, 30);
            this.txtCSPNewPriceEntry.Name = "txtCSPNewPriceEntry";
            this.txtCSPNewPriceEntry.Size = new System.Drawing.Size(124, 22);
            this.txtCSPNewPriceEntry.TabIndex = 0;
            // 
            // txtCSPAccessKeyEntry
            // 
            this.txtCSPAccessKeyEntry.Location = new System.Drawing.Point(104, 70);
            this.txtCSPAccessKeyEntry.Name = "txtCSPAccessKeyEntry";
            this.txtCSPAccessKeyEntry.Size = new System.Drawing.Size(124, 22);
            this.txtCSPAccessKeyEntry.TabIndex = 1;
            // 
            // lblCSPAccessKeyHeader
            // 
            this.lblCSPAccessKeyHeader.AutoSize = true;
            this.lblCSPAccessKeyHeader.Location = new System.Drawing.Point(6, 73);
            this.lblCSPAccessKeyHeader.Name = "lblCSPAccessKeyHeader";
            this.lblCSPAccessKeyHeader.Size = new System.Drawing.Size(81, 17);
            this.lblCSPAccessKeyHeader.TabIndex = 2;
            this.lblCSPAccessKeyHeader.Text = "Access Key";
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.Location = new System.Drawing.Point(64, 110);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(104, 27);
            this.btnUpdatePrice.TabIndex = 2;
            this.btnUpdatePrice.Text = "Update Price";
            this.btnUpdatePrice.UseVisualStyleBackColor = true;
            // 
            // lblCSPError
            // 
            this.lblCSPError.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCSPError.Location = new System.Drawing.Point(9, 150);
            this.lblCSPError.Name = "lblCSPError";
            this.lblCSPError.Size = new System.Drawing.Size(219, 23);
            this.lblCSPError.TabIndex = 19;
            // 
            // groupBoxDeleteItem
            // 
            this.groupBoxDeleteItem.Controls.Add(this.lblDIError);
            this.groupBoxDeleteItem.Controls.Add(this.btnDeleteItem);
            this.groupBoxDeleteItem.Controls.Add(this.txtAccessKeyEntry);
            this.groupBoxDeleteItem.Controls.Add(this.lblDIAccessKeyHeader);
            this.groupBoxDeleteItem.Controls.Add(this.txtDIVerifyUPCEntry);
            this.groupBoxDeleteItem.Controls.Add(this.lblDIVerifyUPCHeader);
            this.groupBoxDeleteItem.Location = new System.Drawing.Point(312, 189);
            this.groupBoxDeleteItem.Name = "groupBoxDeleteItem";
            this.groupBoxDeleteItem.Size = new System.Drawing.Size(234, 181);
            this.groupBoxDeleteItem.TabIndex = 20;
            this.groupBoxDeleteItem.TabStop = false;
            this.groupBoxDeleteItem.Text = "Delete Item";
            // 
            // lblDIError
            // 
            this.lblDIError.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDIError.Location = new System.Drawing.Point(9, 150);
            this.lblDIError.Name = "lblDIError";
            this.lblDIError.Size = new System.Drawing.Size(219, 23);
            this.lblDIError.TabIndex = 19;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(64, 110);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(104, 27);
            this.btnDeleteItem.TabIndex = 2;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // txtAccessKeyEntry
            // 
            this.txtAccessKeyEntry.Location = new System.Drawing.Point(93, 70);
            this.txtAccessKeyEntry.Name = "txtAccessKeyEntry";
            this.txtAccessKeyEntry.Size = new System.Drawing.Size(135, 22);
            this.txtAccessKeyEntry.TabIndex = 1;
            // 
            // lblDIAccessKeyHeader
            // 
            this.lblDIAccessKeyHeader.AutoSize = true;
            this.lblDIAccessKeyHeader.Location = new System.Drawing.Point(6, 73);
            this.lblDIAccessKeyHeader.Name = "lblDIAccessKeyHeader";
            this.lblDIAccessKeyHeader.Size = new System.Drawing.Size(81, 17);
            this.lblDIAccessKeyHeader.TabIndex = 2;
            this.lblDIAccessKeyHeader.Text = "Access Key";
            // 
            // txtDIVerifyUPCEntry
            // 
            this.txtDIVerifyUPCEntry.Location = new System.Drawing.Point(93, 30);
            this.txtDIVerifyUPCEntry.Name = "txtDIVerifyUPCEntry";
            this.txtDIVerifyUPCEntry.Size = new System.Drawing.Size(135, 22);
            this.txtDIVerifyUPCEntry.TabIndex = 0;
            // 
            // lblDIVerifyUPCHeader
            // 
            this.lblDIVerifyUPCHeader.AutoSize = true;
            this.lblDIVerifyUPCHeader.Location = new System.Drawing.Point(6, 33);
            this.lblDIVerifyUPCHeader.Name = "lblDIVerifyUPCHeader";
            this.lblDIVerifyUPCHeader.Size = new System.Drawing.Size(76, 17);
            this.lblDIVerifyUPCHeader.TabIndex = 0;
            this.lblDIVerifyUPCHeader.Text = "Verify UPC";
            // 
            // groupBoxAddNewItem
            // 
            this.groupBoxAddNewItem.Controls.Add(this.lblANIError);
            this.groupBoxAddNewItem.Controls.Add(this.btnAddItem);
            this.groupBoxAddNewItem.Controls.Add(this.lblANIDistributorEntry);
            this.groupBoxAddNewItem.Controls.Add(this.lblANIDistributorHeader);
            this.groupBoxAddNewItem.Controls.Add(this.txtANIUnitsPerCaseEntry);
            this.groupBoxAddNewItem.Controls.Add(this.lblANIUnitsPerCaseHeader);
            this.groupBoxAddNewItem.Controls.Add(this.txtANICostPerCaseEntry);
            this.groupBoxAddNewItem.Controls.Add(this.lblANICostPerCaseHeader);
            this.groupBoxAddNewItem.Controls.Add(this.txtANIAccessKeyEntry);
            this.groupBoxAddNewItem.Controls.Add(this.lblANIAccessKeyHeader);
            this.groupBoxAddNewItem.Controls.Add(this.txtANIStorePriceEntry);
            this.groupBoxAddNewItem.Controls.Add(this.lblANIStorePriceHeader);
            this.groupBoxAddNewItem.Controls.Add(this.txtANIUPCEntry);
            this.groupBoxAddNewItem.Controls.Add(this.lblANIUPCHeader);
            this.groupBoxAddNewItem.Controls.Add(this.txtANINameEntry);
            this.groupBoxAddNewItem.Controls.Add(this.lblANINameHeader);
            this.groupBoxAddNewItem.Location = new System.Drawing.Point(15, 393);
            this.groupBoxAddNewItem.Name = "groupBoxAddNewItem";
            this.groupBoxAddNewItem.Size = new System.Drawing.Size(531, 226);
            this.groupBoxAddNewItem.TabIndex = 21;
            this.groupBoxAddNewItem.TabStop = false;
            this.groupBoxAddNewItem.Text = "Add New Item";
            // 
            // lblANINameHeader
            // 
            this.lblANINameHeader.AutoSize = true;
            this.lblANINameHeader.Location = new System.Drawing.Point(6, 31);
            this.lblANINameHeader.Name = "lblANINameHeader";
            this.lblANINameHeader.Size = new System.Drawing.Size(49, 17);
            this.lblANINameHeader.TabIndex = 22;
            this.lblANINameHeader.Text = "Name:";
            // 
            // txtANINameEntry
            // 
            this.txtANINameEntry.Location = new System.Drawing.Point(88, 28);
            this.txtANINameEntry.Name = "txtANINameEntry";
            this.txtANINameEntry.Size = new System.Drawing.Size(140, 22);
            this.txtANINameEntry.TabIndex = 0;
            // 
            // txtANIUPCEntry
            // 
            this.txtANIUPCEntry.Location = new System.Drawing.Point(88, 60);
            this.txtANIUPCEntry.Name = "txtANIUPCEntry";
            this.txtANIUPCEntry.Size = new System.Drawing.Size(140, 22);
            this.txtANIUPCEntry.TabIndex = 1;
            // 
            // lblANIUPCHeader
            // 
            this.lblANIUPCHeader.AutoSize = true;
            this.lblANIUPCHeader.Location = new System.Drawing.Point(6, 63);
            this.lblANIUPCHeader.Name = "lblANIUPCHeader";
            this.lblANIUPCHeader.Size = new System.Drawing.Size(40, 17);
            this.lblANIUPCHeader.TabIndex = 24;
            this.lblANIUPCHeader.Text = "UPC:";
            // 
            // txtANIStorePriceEntry
            // 
            this.txtANIStorePriceEntry.Location = new System.Drawing.Point(88, 92);
            this.txtANIStorePriceEntry.Name = "txtANIStorePriceEntry";
            this.txtANIStorePriceEntry.Size = new System.Drawing.Size(140, 22);
            this.txtANIStorePriceEntry.TabIndex = 2;
            // 
            // lblANIStorePriceHeader
            // 
            this.lblANIStorePriceHeader.AutoSize = true;
            this.lblANIStorePriceHeader.Location = new System.Drawing.Point(6, 95);
            this.lblANIStorePriceHeader.Name = "lblANIStorePriceHeader";
            this.lblANIStorePriceHeader.Size = new System.Drawing.Size(82, 17);
            this.lblANIStorePriceHeader.TabIndex = 26;
            this.lblANIStorePriceHeader.Text = "Store Price:";
            // 
            // txtANIAccessKeyEntry
            // 
            this.txtANIAccessKeyEntry.Location = new System.Drawing.Point(88, 125);
            this.txtANIAccessKeyEntry.Name = "txtANIAccessKeyEntry";
            this.txtANIAccessKeyEntry.Size = new System.Drawing.Size(140, 22);
            this.txtANIAccessKeyEntry.TabIndex = 3;
            // 
            // lblANIAccessKeyHeader
            // 
            this.lblANIAccessKeyHeader.AutoSize = true;
            this.lblANIAccessKeyHeader.Location = new System.Drawing.Point(6, 128);
            this.lblANIAccessKeyHeader.Name = "lblANIAccessKeyHeader";
            this.lblANIAccessKeyHeader.Size = new System.Drawing.Size(85, 17);
            this.lblANIAccessKeyHeader.TabIndex = 28;
            this.lblANIAccessKeyHeader.Text = "Access Key:";
            // 
            // txtANICostPerCaseEntry
            // 
            this.txtANICostPerCaseEntry.Location = new System.Drawing.Point(383, 28);
            this.txtANICostPerCaseEntry.Name = "txtANICostPerCaseEntry";
            this.txtANICostPerCaseEntry.Size = new System.Drawing.Size(114, 22);
            this.txtANICostPerCaseEntry.TabIndex = 4;
            // 
            // lblANICostPerCaseHeader
            // 
            this.lblANICostPerCaseHeader.AutoSize = true;
            this.lblANICostPerCaseHeader.Location = new System.Drawing.Point(275, 31);
            this.lblANICostPerCaseHeader.Name = "lblANICostPerCaseHeader";
            this.lblANICostPerCaseHeader.Size = new System.Drawing.Size(102, 17);
            this.lblANICostPerCaseHeader.TabIndex = 30;
            this.lblANICostPerCaseHeader.Text = "Cost Per Case:";
            // 
            // txtANIUnitsPerCaseEntry
            // 
            this.txtANIUnitsPerCaseEntry.Location = new System.Drawing.Point(383, 62);
            this.txtANIUnitsPerCaseEntry.Name = "txtANIUnitsPerCaseEntry";
            this.txtANIUnitsPerCaseEntry.Size = new System.Drawing.Size(114, 22);
            this.txtANIUnitsPerCaseEntry.TabIndex = 5;
            // 
            // lblANIUnitsPerCaseHeader
            // 
            this.lblANIUnitsPerCaseHeader.AutoSize = true;
            this.lblANIUnitsPerCaseHeader.Location = new System.Drawing.Point(275, 65);
            this.lblANIUnitsPerCaseHeader.Name = "lblANIUnitsPerCaseHeader";
            this.lblANIUnitsPerCaseHeader.Size = new System.Drawing.Size(99, 17);
            this.lblANIUnitsPerCaseHeader.TabIndex = 32;
            this.lblANIUnitsPerCaseHeader.Text = "Unit Per Case:";
            // 
            // lblANIDistributorEntry
            // 
            this.lblANIDistributorEntry.Location = new System.Drawing.Point(383, 94);
            this.lblANIDistributorEntry.Name = "lblANIDistributorEntry";
            this.lblANIDistributorEntry.Size = new System.Drawing.Size(114, 22);
            this.lblANIDistributorEntry.TabIndex = 6;
            // 
            // lblANIDistributorHeader
            // 
            this.lblANIDistributorHeader.AutoSize = true;
            this.lblANIDistributorHeader.Location = new System.Drawing.Point(275, 97);
            this.lblANIDistributorHeader.Name = "lblANIDistributorHeader";
            this.lblANIDistributorHeader.Size = new System.Drawing.Size(77, 17);
            this.lblANIDistributorHeader.TabIndex = 34;
            this.lblANIDistributorHeader.Text = "Distributor:";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(278, 125);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(97, 31);
            this.btnAddItem.TabIndex = 7;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // lblANIError
            // 
            this.lblANIError.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblANIError.Location = new System.Drawing.Point(6, 178);
            this.lblANIError.Name = "lblANIError";
            this.lblANIError.Size = new System.Drawing.Size(228, 23);
            this.lblANIError.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 631);
            this.Controls.Add(this.groupBoxAddNewItem);
            this.Controls.Add(this.groupBoxDeleteItem);
            this.Controls.Add(this.groupBoxChangeStorePrice);
            this.Controls.Add(this.lblSBUPCDistributorResult);
            this.Controls.Add(this.lblSBUPCDistributorHeader);
            this.Controls.Add(this.lblSBUPCUnitsPerCaseResult);
            this.Controls.Add(this.lblSBUPCUnitsPerCaseHeader);
            this.Controls.Add(this.lblSBUPCCostPerCaseResult);
            this.Controls.Add(this.lblSBUPCCostPerCaseHeader);
            this.Controls.Add(this.lblSBNStorePriceResult);
            this.Controls.Add(this.lblSBNStorePriceHeader);
            this.Controls.Add(this.lblSBNUPCResult);
            this.Controls.Add(this.lblSBNUPCHeader);
            this.Controls.Add(this.lblSBNResult);
            this.Controls.Add(this.lblSBNHeader);
            this.Controls.Add(this.btnSBUPC);
            this.Controls.Add(this.txtSBUPC);
            this.Controls.Add(this.lblSBUPC);
            this.Controls.Add(this.btnSBName);
            this.Controls.Add(this.txtSBName);
            this.Controls.Add(this.lblSBName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store inventory & Price Inquiry";
            this.groupBoxChangeStorePrice.ResumeLayout(false);
            this.groupBoxChangeStorePrice.PerformLayout();
            this.groupBoxDeleteItem.ResumeLayout(false);
            this.groupBoxDeleteItem.PerformLayout();
            this.groupBoxAddNewItem.ResumeLayout(false);
            this.groupBoxAddNewItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSBName;
        private System.Windows.Forms.TextBox txtSBName;
        private System.Windows.Forms.Button btnSBName;
        private System.Windows.Forms.Button btnSBUPC;
        private System.Windows.Forms.TextBox txtSBUPC;
        private System.Windows.Forms.Label lblSBUPC;
        private System.Windows.Forms.Label lblSBNHeader;
        private System.Windows.Forms.Label lblSBNResult;
        private System.Windows.Forms.Label lblSBNUPCResult;
        private System.Windows.Forms.Label lblSBNUPCHeader;
        private System.Windows.Forms.Label lblSBNStorePriceResult;
        private System.Windows.Forms.Label lblSBNStorePriceHeader;
        private System.Windows.Forms.Label lblSBUPCCostPerCaseResult;
        private System.Windows.Forms.Label lblSBUPCCostPerCaseHeader;
        private System.Windows.Forms.Label lblSBUPCUnitsPerCaseResult;
        private System.Windows.Forms.Label lblSBUPCUnitsPerCaseHeader;
        private System.Windows.Forms.Label lblSBUPCDistributorResult;
        private System.Windows.Forms.Label lblSBUPCDistributorHeader;
        private System.Windows.Forms.GroupBox groupBoxChangeStorePrice;
        private System.Windows.Forms.Label lblCSPError;
        private System.Windows.Forms.Button btnUpdatePrice;
        private System.Windows.Forms.TextBox txtCSPAccessKeyEntry;
        private System.Windows.Forms.Label lblCSPAccessKeyHeader;
        private System.Windows.Forms.TextBox txtCSPNewPriceEntry;
        private System.Windows.Forms.Label lblCSPNewPriceHeader;
        private System.Windows.Forms.GroupBox groupBoxDeleteItem;
        private System.Windows.Forms.Label lblDIError;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.TextBox txtAccessKeyEntry;
        private System.Windows.Forms.Label lblDIAccessKeyHeader;
        private System.Windows.Forms.TextBox txtDIVerifyUPCEntry;
        private System.Windows.Forms.Label lblDIVerifyUPCHeader;
        private System.Windows.Forms.GroupBox groupBoxAddNewItem;
        private System.Windows.Forms.Label lblANIError;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox lblANIDistributorEntry;
        private System.Windows.Forms.Label lblANIDistributorHeader;
        private System.Windows.Forms.TextBox txtANIUnitsPerCaseEntry;
        private System.Windows.Forms.Label lblANIUnitsPerCaseHeader;
        private System.Windows.Forms.TextBox txtANICostPerCaseEntry;
        private System.Windows.Forms.Label lblANICostPerCaseHeader;
        private System.Windows.Forms.TextBox txtANIAccessKeyEntry;
        private System.Windows.Forms.Label lblANIAccessKeyHeader;
        private System.Windows.Forms.TextBox txtANIStorePriceEntry;
        private System.Windows.Forms.Label lblANIStorePriceHeader;
        private System.Windows.Forms.TextBox txtANIUPCEntry;
        private System.Windows.Forms.Label lblANIUPCHeader;
        private System.Windows.Forms.TextBox txtANINameEntry;
        private System.Windows.Forms.Label lblANINameHeader;
    }
}

