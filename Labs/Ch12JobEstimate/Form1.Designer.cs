
namespace Ch12JobEstimate
{
    partial class FormJE
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
            this.lblNewValueHeader = new System.Windows.Forms.Label();
            this.lblCurrentValueHeader = new System.Windows.Forms.Label();
            this.lblDescriptionHeader = new System.Windows.Forms.Label();
            this.lblDescriptionCurrent = new System.Windows.Forms.Label();
            this.lblHTCHeader = new System.Windows.Forms.Label();
            this.lblHourlyRateHeader = new System.Windows.Forms.Label();
            this.lblTotalFeeHeader = new System.Windows.Forms.Label();
            this.lblTotalFeeCurrent = new System.Windows.Forms.Label();
            this.lblHTCCurrent = new System.Windows.Forms.Label();
            this.lblHourlyRateCurrent = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtHTC = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTripFee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNewValueHeader
            // 
            this.lblNewValueHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNewValueHeader.Location = new System.Drawing.Point(199, 9);
            this.lblNewValueHeader.Name = "lblNewValueHeader";
            this.lblNewValueHeader.Size = new System.Drawing.Size(157, 19);
            this.lblNewValueHeader.TabIndex = 0;
            this.lblNewValueHeader.Text = "New Value";
            this.lblNewValueHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentValueHeader
            // 
            this.lblCurrentValueHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCurrentValueHeader.Location = new System.Drawing.Point(381, 9);
            this.lblCurrentValueHeader.Name = "lblCurrentValueHeader";
            this.lblCurrentValueHeader.Size = new System.Drawing.Size(157, 19);
            this.lblCurrentValueHeader.TabIndex = 1;
            this.lblCurrentValueHeader.Text = "Current Value";
            this.lblCurrentValueHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescriptionHeader
            // 
            this.lblDescriptionHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDescriptionHeader.Location = new System.Drawing.Point(12, 47);
            this.lblDescriptionHeader.Name = "lblDescriptionHeader";
            this.lblDescriptionHeader.Size = new System.Drawing.Size(157, 19);
            this.lblDescriptionHeader.TabIndex = 2;
            this.lblDescriptionHeader.Text = "Description:";
            this.lblDescriptionHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescriptionCurrent
            // 
            this.lblDescriptionCurrent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDescriptionCurrent.Location = new System.Drawing.Point(381, 47);
            this.lblDescriptionCurrent.Name = "lblDescriptionCurrent";
            this.lblDescriptionCurrent.Size = new System.Drawing.Size(157, 19);
            this.lblDescriptionCurrent.TabIndex = 3;
            this.lblDescriptionCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHTCHeader
            // 
            this.lblHTCHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblHTCHeader.Location = new System.Drawing.Point(12, 85);
            this.lblHTCHeader.Name = "lblHTCHeader";
            this.lblHTCHeader.Size = new System.Drawing.Size(157, 19);
            this.lblHTCHeader.TabIndex = 4;
            this.lblHTCHeader.Text = "Hours to Complete:";
            this.lblHTCHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHourlyRateHeader
            // 
            this.lblHourlyRateHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblHourlyRateHeader.Location = new System.Drawing.Point(12, 125);
            this.lblHourlyRateHeader.Name = "lblHourlyRateHeader";
            this.lblHourlyRateHeader.Size = new System.Drawing.Size(157, 19);
            this.lblHourlyRateHeader.TabIndex = 5;
            this.lblHourlyRateHeader.Text = "Hourly Rate:";
            this.lblHourlyRateHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalFeeHeader
            // 
            this.lblTotalFeeHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalFeeHeader.Location = new System.Drawing.Point(12, 166);
            this.lblTotalFeeHeader.Name = "lblTotalFeeHeader";
            this.lblTotalFeeHeader.Size = new System.Drawing.Size(157, 19);
            this.lblTotalFeeHeader.TabIndex = 6;
            this.lblTotalFeeHeader.Text = "Total Fee:";
            this.lblTotalFeeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalFeeCurrent
            // 
            this.lblTotalFeeCurrent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalFeeCurrent.Location = new System.Drawing.Point(381, 166);
            this.lblTotalFeeCurrent.Name = "lblTotalFeeCurrent";
            this.lblTotalFeeCurrent.Size = new System.Drawing.Size(157, 19);
            this.lblTotalFeeCurrent.TabIndex = 7;
            this.lblTotalFeeCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHTCCurrent
            // 
            this.lblHTCCurrent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblHTCCurrent.Location = new System.Drawing.Point(381, 85);
            this.lblHTCCurrent.Name = "lblHTCCurrent";
            this.lblHTCCurrent.Size = new System.Drawing.Size(157, 19);
            this.lblHTCCurrent.TabIndex = 7;
            this.lblHTCCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHourlyRateCurrent
            // 
            this.lblHourlyRateCurrent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblHourlyRateCurrent.Location = new System.Drawing.Point(381, 125);
            this.lblHourlyRateCurrent.Name = "lblHourlyRateCurrent";
            this.lblHourlyRateCurrent.Size = new System.Drawing.Size(157, 19);
            this.lblHourlyRateCurrent.TabIndex = 8;
            this.lblHourlyRateCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(202, 44);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(154, 24);
            this.txtDescription.TabIndex = 0;
            // 
            // txtHTC
            // 
            this.txtHTC.Location = new System.Drawing.Point(202, 82);
            this.txtHTC.Name = "txtHTC";
            this.txtHTC.Size = new System.Drawing.Size(154, 24);
            this.txtHTC.TabIndex = 1;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(202, 122);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(154, 24);
            this.txtHourlyRate.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(202, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(384, 214);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTripFee
            // 
            this.lblTripFee.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTripFee.Location = new System.Drawing.Point(199, 166);
            this.lblTripFee.Name = "lblTripFee";
            this.lblTripFee.Size = new System.Drawing.Size(157, 19);
            this.lblTripFee.TabIndex = 15;
            this.lblTripFee.Text = "Plus Trip Fee ($35)";
            this.lblTripFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormJE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 280);
            this.Controls.Add(this.lblTripFee);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.txtHTC);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblHourlyRateCurrent);
            this.Controls.Add(this.lblHTCCurrent);
            this.Controls.Add(this.lblTotalFeeCurrent);
            this.Controls.Add(this.lblTotalFeeHeader);
            this.Controls.Add(this.lblHourlyRateHeader);
            this.Controls.Add(this.lblHTCHeader);
            this.Controls.Add(this.lblDescriptionCurrent);
            this.Controls.Add(this.lblDescriptionHeader);
            this.Controls.Add(this.lblCurrentValueHeader);
            this.Controls.Add(this.lblNewValueHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormJE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harold\'s Home Services";
            this.Load += new System.EventHandler(this.FormJE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewValueHeader;
        private System.Windows.Forms.Label lblCurrentValueHeader;
        private System.Windows.Forms.Label lblDescriptionHeader;
        private System.Windows.Forms.Label lblDescriptionCurrent;
        private System.Windows.Forms.Label lblHTCHeader;
        private System.Windows.Forms.Label lblHourlyRateHeader;
        private System.Windows.Forms.Label lblTotalFeeHeader;
        private System.Windows.Forms.Label lblTotalFeeCurrent;
        private System.Windows.Forms.Label lblHTCCurrent;
        private System.Windows.Forms.Label lblHourlyRateCurrent;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtHTC;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTripFee;
    }
}

