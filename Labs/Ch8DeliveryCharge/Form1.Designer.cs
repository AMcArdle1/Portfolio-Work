
namespace Ch8DeliveryCharge
{
    partial class FormDeliveryCharge
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
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblDeliveryCharge = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(12, 9);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(65, 17);
            this.lblZipCode.TabIndex = 0;
            this.lblZipCode.Text = "Zip Code";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(15, 29);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(100, 22);
            this.txtZipCode.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(121, 26);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 29);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblDeliveryCharge
            // 
            this.lblDeliveryCharge.AutoSize = true;
            this.lblDeliveryCharge.Location = new System.Drawing.Point(222, 9);
            this.lblDeliveryCharge.Name = "lblDeliveryCharge";
            this.lblDeliveryCharge.Size = new System.Drawing.Size(109, 17);
            this.lblDeliveryCharge.TabIndex = 3;
            this.lblDeliveryCharge.Text = "Delivery Charge";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblResult.Location = new System.Drawing.Point(222, 29);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(109, 22);
            this.lblResult.TabIndex = 4;
            // 
            // FormDeliveryCharge
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 69);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDeliveryCharge);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.lblZipCode);
            this.Name = "FormDeliveryCharge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Charge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblDeliveryCharge;
        private System.Windows.Forms.Label lblResult;
    }
}

