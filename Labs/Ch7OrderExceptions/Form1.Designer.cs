
namespace Ch7OrderExceptions
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
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblEstimatedDD = new System.Windows.Forms.Label();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtEstimatedDD = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.AutoSize = true;
            this.lblItemNumber.Location = new System.Drawing.Point(12, 9);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(121, 13);
            this.lblItemNumber.TabIndex = 0;
            this.lblItemNumber.Text = "Item Number [ 100, 999]";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 42);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(82, 13);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity [ 1, 12]";
            // 
            // lblEstimatedDD
            // 
            this.lblEstimatedDD.AutoSize = true;
            this.lblEstimatedDD.Location = new System.Drawing.Point(12, 77);
            this.lblEstimatedDD.Name = "lblEstimatedDD";
            this.lblEstimatedDD.Size = new System.Drawing.Size(157, 13);
            this.lblEstimatedDD.TabIndex = 2;
            this.lblEstimatedDD.Text = "Estimated Delivery Days [ 1, 30]";
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.Location = new System.Drawing.Point(188, 6);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(100, 20);
            this.txtItemNumber.TabIndex = 0;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(188, 39);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 1;
            // 
            // txtEstimatedDD
            // 
            this.txtEstimatedDD.Location = new System.Drawing.Point(188, 74);
            this.txtEstimatedDD.Name = "txtEstimatedDD";
            this.txtEstimatedDD.Size = new System.Drawing.Size(100, 20);
            this.txtEstimatedDD.TabIndex = 2;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(188, 109);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(100, 23);
            this.btnValidate.TabIndex = 3;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblOrderStatus.Location = new System.Drawing.Point(67, 151);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(168, 23);
            this.lblOrderStatus.TabIndex = 7;
            this.lblOrderStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnValidate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 195);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtEstimatedDD);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtItemNumber);
            this.Controls.Add(this.lblEstimatedDD);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblItemNumber);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblEstimatedDD;
        private System.Windows.Forms.TextBox txtItemNumber;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtEstimatedDD;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblOrderStatus;
    }
}

