
namespace Ch14_15Letters
{
    partial class FormLetterDelivery
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelAdditionalFee = new System.Windows.Forms.Label();
            this.textBoxSentDate = new System.Windows.Forms.TextBox();
            this.labelSentDate = new System.Windows.Forms.Label();
            this.textBoxTrackingNumber = new System.Windows.Forms.TextBox();
            this.labelTrackingNumber = new System.Windows.Forms.Label();
            this.textBoxRecipient = new System.Windows.Forms.TextBox();
            this.labelRecipient = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxLetterHistory = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.buttonSend);
            this.groupBox1.Controls.Add(this.labelAdditionalFee);
            this.groupBox1.Controls.Add(this.textBoxSentDate);
            this.groupBox1.Controls.Add(this.labelSentDate);
            this.groupBox1.Controls.Add(this.textBoxTrackingNumber);
            this.groupBox1.Controls.Add(this.labelTrackingNumber);
            this.groupBox1.Controls.Add(this.textBoxRecipient);
            this.groupBox1.Controls.Add(this.labelRecipient);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(225, 179);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 30);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(128, 179);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 30);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.Location = new System.Drawing.Point(20, 179);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 30);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelAdditionalFee
            // 
            this.labelAdditionalFee.AutoSize = true;
            this.labelAdditionalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdditionalFee.Location = new System.Drawing.Point(67, 142);
            this.labelAdditionalFee.Name = "labelAdditionalFee";
            this.labelAdditionalFee.Size = new System.Drawing.Size(236, 18);
            this.labelAdditionalFee.TabIndex = 6;
            this.labelAdditionalFee.Text = "(Additional Fee For Certified Letter)";
            this.labelAdditionalFee.Visible = false;
            // 
            // textBoxSentDate
            // 
            this.textBoxSentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSentDate.Location = new System.Drawing.Point(154, 57);
            this.textBoxSentDate.Name = "textBoxSentDate";
            this.textBoxSentDate.Size = new System.Drawing.Size(175, 24);
            this.textBoxSentDate.TabIndex = 1;
            // 
            // labelSentDate
            // 
            this.labelSentDate.AutoSize = true;
            this.labelSentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSentDate.Location = new System.Drawing.Point(6, 60);
            this.labelSentDate.Name = "labelSentDate";
            this.labelSentDate.Size = new System.Drawing.Size(77, 18);
            this.labelSentDate.TabIndex = 4;
            this.labelSentDate.Text = "Sent Date:";
            // 
            // textBoxTrackingNumber
            // 
            this.textBoxTrackingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrackingNumber.Location = new System.Drawing.Point(154, 98);
            this.textBoxTrackingNumber.Name = "textBoxTrackingNumber";
            this.textBoxTrackingNumber.Size = new System.Drawing.Size(175, 24);
            this.textBoxTrackingNumber.TabIndex = 2;
            // 
            // labelTrackingNumber
            // 
            this.labelTrackingNumber.AutoSize = true;
            this.labelTrackingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackingNumber.Location = new System.Drawing.Point(6, 101);
            this.labelTrackingNumber.Name = "labelTrackingNumber";
            this.labelTrackingNumber.Size = new System.Drawing.Size(126, 18);
            this.labelTrackingNumber.TabIndex = 2;
            this.labelTrackingNumber.Text = "Tracking Number:";
            // 
            // textBoxRecipient
            // 
            this.textBoxRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecipient.Location = new System.Drawing.Point(154, 15);
            this.textBoxRecipient.Name = "textBoxRecipient";
            this.textBoxRecipient.Size = new System.Drawing.Size(175, 24);
            this.textBoxRecipient.TabIndex = 0;
            // 
            // labelRecipient
            // 
            this.labelRecipient.AutoSize = true;
            this.labelRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecipient.Location = new System.Drawing.Point(6, 18);
            this.labelRecipient.Name = "labelRecipient";
            this.labelRecipient.Size = new System.Drawing.Size(73, 18);
            this.labelRecipient.TabIndex = 0;
            this.labelRecipient.Text = "Recipient:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.richTextBoxLetterHistory);
            this.groupBox2.Location = new System.Drawing.Point(366, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 276);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // richTextBoxLetterHistory
            // 
            this.richTextBoxLetterHistory.Location = new System.Drawing.Point(5, 15);
            this.richTextBoxLetterHistory.Name = "richTextBoxLetterHistory";
            this.richTextBoxLetterHistory.ReadOnly = true;
            this.richTextBoxLetterHistory.Size = new System.Drawing.Size(312, 256);
            this.richTextBoxLetterHistory.TabIndex = 10;
            this.richTextBoxLetterHistory.TabStop = false;
            this.richTextBoxLetterHistory.Text = "";
            // 
            // FormLetterDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 296);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormLetterDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letter Delivery";
            this.Load += new System.EventHandler(this.FormLetterDelivery_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelAdditionalFee;
        private System.Windows.Forms.TextBox textBoxSentDate;
        private System.Windows.Forms.Label labelSentDate;
        private System.Windows.Forms.TextBox textBoxTrackingNumber;
        private System.Windows.Forms.Label labelTrackingNumber;
        private System.Windows.Forms.TextBox textBoxRecipient;
        private System.Windows.Forms.Label labelRecipient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxLetterHistory;
    }
}

