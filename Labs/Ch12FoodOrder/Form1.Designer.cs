
namespace Ch12FoodOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblSundaeHeading = new System.Windows.Forms.Label();
            this.lblSodaHeader = new System.Windows.Forms.Label();
            this.cbSundaeStatus = new System.Windows.Forms.CheckBox();
            this.cbSodaStatus = new System.Windows.Forms.CheckBox();
            this.lblSundaeHeader = new System.Windows.Forms.Label();
            this.lblDrinkHeader = new System.Windows.Forms.Label();
            this.cbSprinkles = new System.Windows.Forms.CheckBox();
            this.cbLime = new System.Windows.Forms.CheckBox();
            this.cbNuts = new System.Windows.Forms.CheckBox();
            this.cbPeach = new System.Windows.Forms.CheckBox();
            this.cbChoclateSyrup = new System.Windows.Forms.CheckBox();
            this.cbMango = new System.Windows.Forms.CheckBox();
            this.lblToppingError = new System.Windows.Forms.Label();
            this.lblDrinkError = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.rtbRecipt = new System.Windows.Forms.RichTextBox();
            this.lblOrderHeader = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "What name do you want on the order?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 22);
            this.textBox1.TabIndex = 0;
            // 
            // lblNameError
            // 
            this.lblNameError.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNameError.Location = new System.Drawing.Point(15, 54);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(247, 23);
            this.lblNameError.TabIndex = 2;
            // 
            // lblSundaeHeading
            // 
            this.lblSundaeHeading.AutoSize = true;
            this.lblSundaeHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSundaeHeading.Location = new System.Drawing.Point(12, 104);
            this.lblSundaeHeading.Name = "lblSundaeHeading";
            this.lblSundaeHeading.Size = new System.Drawing.Size(178, 17);
            this.lblSundaeHeading.TabIndex = 3;
            this.lblSundaeHeading.Text = "Do you want a sundae?";
            // 
            // lblSodaHeader
            // 
            this.lblSodaHeader.AutoSize = true;
            this.lblSodaHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSodaHeader.Location = new System.Drawing.Point(217, 104);
            this.lblSodaHeader.Name = "lblSodaHeader";
            this.lblSodaHeader.Size = new System.Drawing.Size(160, 17);
            this.lblSodaHeader.TabIndex = 4;
            this.lblSodaHeader.Text = "Do you want a soda?";
            // 
            // cbSundaeStatus
            // 
            this.cbSundaeStatus.AutoSize = true;
            this.cbSundaeStatus.Location = new System.Drawing.Point(15, 133);
            this.cbSundaeStatus.Name = "cbSundaeStatus";
            this.cbSundaeStatus.Size = new System.Drawing.Size(54, 21);
            this.cbSundaeStatus.TabIndex = 1;
            this.cbSundaeStatus.Text = "Yes";
            this.cbSundaeStatus.UseVisualStyleBackColor = true;
            // 
            // cbSodaStatus
            // 
            this.cbSodaStatus.AutoSize = true;
            this.cbSodaStatus.Location = new System.Drawing.Point(220, 133);
            this.cbSodaStatus.Name = "cbSodaStatus";
            this.cbSodaStatus.Size = new System.Drawing.Size(54, 21);
            this.cbSodaStatus.TabIndex = 2;
            this.cbSodaStatus.Text = "Yes";
            this.cbSodaStatus.UseVisualStyleBackColor = true;
            // 
            // lblSundaeHeader
            // 
            this.lblSundaeHeader.AutoSize = true;
            this.lblSundaeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSundaeHeader.Location = new System.Drawing.Point(15, 184);
            this.lblSundaeHeader.Name = "lblSundaeHeader";
            this.lblSundaeHeader.Size = new System.Drawing.Size(135, 17);
            this.lblSundaeHeader.TabIndex = 7;
            this.lblSundaeHeader.Text = "Sundae Toppings";
            // 
            // lblDrinkHeader
            // 
            this.lblDrinkHeader.AutoSize = true;
            this.lblDrinkHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinkHeader.Location = new System.Drawing.Point(217, 184);
            this.lblDrinkHeader.Name = "lblDrinkHeader";
            this.lblDrinkHeader.Size = new System.Drawing.Size(95, 17);
            this.lblDrinkHeader.TabIndex = 8;
            this.lblDrinkHeader.Text = "Drink Mixins";
            // 
            // cbSprinkles
            // 
            this.cbSprinkles.AutoSize = true;
            this.cbSprinkles.Location = new System.Drawing.Point(18, 213);
            this.cbSprinkles.Name = "cbSprinkles";
            this.cbSprinkles.Size = new System.Drawing.Size(88, 21);
            this.cbSprinkles.TabIndex = 3;
            this.cbSprinkles.Text = "Sprinkles";
            this.cbSprinkles.UseVisualStyleBackColor = true;
            // 
            // cbLime
            // 
            this.cbLime.AutoSize = true;
            this.cbLime.Location = new System.Drawing.Point(220, 213);
            this.cbLime.Name = "cbLime";
            this.cbLime.Size = new System.Drawing.Size(103, 21);
            this.cbLime.TabIndex = 6;
            this.cbLime.Text = "Lime Flavor";
            this.cbLime.UseVisualStyleBackColor = true;
            // 
            // cbNuts
            // 
            this.cbNuts.AutoSize = true;
            this.cbNuts.Location = new System.Drawing.Point(18, 240);
            this.cbNuts.Name = "cbNuts";
            this.cbNuts.Size = new System.Drawing.Size(59, 21);
            this.cbNuts.TabIndex = 4;
            this.cbNuts.Text = "Nuts";
            this.cbNuts.UseVisualStyleBackColor = true;
            // 
            // cbPeach
            // 
            this.cbPeach.AutoSize = true;
            this.cbPeach.Location = new System.Drawing.Point(220, 240);
            this.cbPeach.Name = "cbPeach";
            this.cbPeach.Size = new System.Drawing.Size(113, 21);
            this.cbPeach.TabIndex = 7;
            this.cbPeach.Text = "Peach Flavor";
            this.cbPeach.UseVisualStyleBackColor = true;
            // 
            // cbChoclateSyrup
            // 
            this.cbChoclateSyrup.AutoSize = true;
            this.cbChoclateSyrup.Location = new System.Drawing.Point(18, 267);
            this.cbChoclateSyrup.Name = "cbChoclateSyrup";
            this.cbChoclateSyrup.Size = new System.Drawing.Size(126, 21);
            this.cbChoclateSyrup.TabIndex = 5;
            this.cbChoclateSyrup.Text = "Choclate Syrup";
            this.cbChoclateSyrup.UseVisualStyleBackColor = true;
            // 
            // cbMango
            // 
            this.cbMango.AutoSize = true;
            this.cbMango.Location = new System.Drawing.Point(220, 267);
            this.cbMango.Name = "cbMango";
            this.cbMango.Size = new System.Drawing.Size(116, 21);
            this.cbMango.TabIndex = 8;
            this.cbMango.Text = "Mango Flavor";
            this.cbMango.UseVisualStyleBackColor = true;
            // 
            // lblToppingError
            // 
            this.lblToppingError.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblToppingError.Location = new System.Drawing.Point(15, 310);
            this.lblToppingError.Name = "lblToppingError";
            this.lblToppingError.Size = new System.Drawing.Size(129, 23);
            this.lblToppingError.TabIndex = 15;
            // 
            // lblDrinkError
            // 
            this.lblDrinkError.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDrinkError.Location = new System.Drawing.Point(217, 310);
            this.lblDrinkError.Name = "lblDrinkError";
            this.lblDrinkError.Size = new System.Drawing.Size(129, 23);
            this.lblDrinkError.TabIndex = 16;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(18, 365);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(158, 29);
            this.btnAddItem.TabIndex = 9;
            this.btnAddItem.Text = "Add Item to Order";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // rtbRecipt
            // 
            this.rtbRecipt.Location = new System.Drawing.Point(407, 54);
            this.rtbRecipt.Name = "rtbRecipt";
            this.rtbRecipt.Size = new System.Drawing.Size(395, 279);
            this.rtbRecipt.TabIndex = 18;
            this.rtbRecipt.TabStop = false;
            this.rtbRecipt.Text = "";
            // 
            // lblOrderHeader
            // 
            this.lblOrderHeader.AutoSize = true;
            this.lblOrderHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderHeader.Location = new System.Drawing.Point(735, 25);
            this.lblOrderHeader.Name = "lblOrderHeader";
            this.lblOrderHeader.Size = new System.Drawing.Size(67, 25);
            this.lblOrderHeader.TabIndex = 19;
            this.lblOrderHeader.Text = "Order";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(629, 336);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(173, 32);
            this.lblGrandTotal.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 427);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblOrderHeader);
            this.Controls.Add(this.rtbRecipt);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblDrinkError);
            this.Controls.Add(this.lblToppingError);
            this.Controls.Add(this.cbMango);
            this.Controls.Add(this.cbChoclateSyrup);
            this.Controls.Add(this.cbPeach);
            this.Controls.Add(this.cbNuts);
            this.Controls.Add(this.cbLime);
            this.Controls.Add(this.cbSprinkles);
            this.Controls.Add(this.lblDrinkHeader);
            this.Controls.Add(this.lblSundaeHeader);
            this.Controls.Add(this.cbSodaStatus);
            this.Controls.Add(this.cbSundaeStatus);
            this.Controls.Add(this.lblSodaHeader);
            this.Controls.Add(this.lblSundaeHeading);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblSundaeHeading;
        private System.Windows.Forms.Label lblSodaHeader;
        private System.Windows.Forms.CheckBox cbSundaeStatus;
        private System.Windows.Forms.CheckBox cbSodaStatus;
        private System.Windows.Forms.Label lblSundaeHeader;
        private System.Windows.Forms.Label lblDrinkHeader;
        private System.Windows.Forms.CheckBox cbSprinkles;
        private System.Windows.Forms.CheckBox cbLime;
        private System.Windows.Forms.CheckBox cbNuts;
        private System.Windows.Forms.CheckBox cbPeach;
        private System.Windows.Forms.CheckBox cbChoclateSyrup;
        private System.Windows.Forms.CheckBox cbMango;
        private System.Windows.Forms.Label lblToppingError;
        private System.Windows.Forms.Label lblDrinkError;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.RichTextBox rtbRecipt;
        private System.Windows.Forms.Label lblOrderHeader;
        private System.Windows.Forms.Label lblGrandTotal;
    }
}

