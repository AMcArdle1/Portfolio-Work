
namespace Ch8IntegerStats
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
            this.txtNumEntry = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblNumEntered = new System.Windows.Forms.Label();
            this.lblLowest = new System.Windows.Forms.Label();
            this.lblHighest = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblNumEnteredResult = new System.Windows.Forms.Label();
            this.lblLowestResult = new System.Windows.Forms.Label();
            this.lblHighestResult = new System.Windows.Forms.Label();
            this.lblSumResult = new System.Windows.Forms.Label();
            this.lblAverageResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumEntry
            // 
            this.txtNumEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumEntry.Location = new System.Drawing.Point(12, 15);
            this.txtNumEntry.Name = "txtNumEntry";
            this.txtNumEntry.Size = new System.Drawing.Size(131, 27);
            this.txtNumEntry.TabIndex = 0;
            this.txtNumEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(185, 12);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 30);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblNumEntered
            // 
            this.lblNumEntered.AutoSize = true;
            this.lblNumEntered.Location = new System.Drawing.Point(12, 63);
            this.lblNumEntered.Name = "lblNumEntered";
            this.lblNumEntered.Size = new System.Drawing.Size(123, 17);
            this.lblNumEntered.TabIndex = 2;
            this.lblNumEntered.Text = "Numbers Entered:";
            // 
            // lblLowest
            // 
            this.lblLowest.AutoSize = true;
            this.lblLowest.Location = new System.Drawing.Point(12, 94);
            this.lblLowest.Name = "lblLowest";
            this.lblLowest.Size = new System.Drawing.Size(56, 17);
            this.lblLowest.TabIndex = 3;
            this.lblLowest.Text = "Lowest:";
            // 
            // lblHighest
            // 
            this.lblHighest.AutoSize = true;
            this.lblHighest.Location = new System.Drawing.Point(12, 127);
            this.lblHighest.Name = "lblHighest";
            this.lblHighest.Size = new System.Drawing.Size(60, 17);
            this.lblHighest.TabIndex = 4;
            this.lblHighest.Text = "Highest:";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(12, 159);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(40, 17);
            this.lblSum.TabIndex = 5;
            this.lblSum.Text = "Sum:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(12, 193);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(65, 17);
            this.lblAverage.TabIndex = 6;
            this.lblAverage.Text = "Average:";
            // 
            // lblNumEnteredResult
            // 
            this.lblNumEnteredResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNumEnteredResult.Location = new System.Drawing.Point(157, 63);
            this.lblNumEnteredResult.Name = "lblNumEnteredResult";
            this.lblNumEnteredResult.Size = new System.Drawing.Size(123, 17);
            this.lblNumEnteredResult.TabIndex = 7;
            this.lblNumEnteredResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowestResult
            // 
            this.lblLowestResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblLowestResult.Location = new System.Drawing.Point(157, 94);
            this.lblLowestResult.Name = "lblLowestResult";
            this.lblLowestResult.Size = new System.Drawing.Size(123, 17);
            this.lblLowestResult.TabIndex = 8;
            this.lblLowestResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHighestResult
            // 
            this.lblHighestResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblHighestResult.Location = new System.Drawing.Point(157, 127);
            this.lblHighestResult.Name = "lblHighestResult";
            this.lblHighestResult.Size = new System.Drawing.Size(123, 17);
            this.lblHighestResult.TabIndex = 9;
            this.lblHighestResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSumResult
            // 
            this.lblSumResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSumResult.Location = new System.Drawing.Point(157, 159);
            this.lblSumResult.Name = "lblSumResult";
            this.lblSumResult.Size = new System.Drawing.Size(123, 17);
            this.lblSumResult.TabIndex = 10;
            this.lblSumResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAverageResult
            // 
            this.lblAverageResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAverageResult.Location = new System.Drawing.Point(157, 193);
            this.lblAverageResult.Name = "lblAverageResult";
            this.lblAverageResult.Size = new System.Drawing.Size(123, 17);
            this.lblAverageResult.TabIndex = 11;
            this.lblAverageResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 234);
            this.Controls.Add(this.lblAverageResult);
            this.Controls.Add(this.lblSumResult);
            this.Controls.Add(this.lblHighestResult);
            this.Controls.Add(this.lblLowestResult);
            this.Controls.Add(this.lblNumEnteredResult);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblHighest);
            this.Controls.Add(this.lblLowest);
            this.Controls.Add(this.lblNumEntered);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtNumEntry);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integer Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumEntry;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblNumEntered;
        private System.Windows.Forms.Label lblLowest;
        private System.Windows.Forms.Label lblHighest;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblNumEnteredResult;
        private System.Windows.Forms.Label lblLowestResult;
        private System.Windows.Forms.Label lblHighestResult;
        private System.Windows.Forms.Label lblSumResult;
        private System.Windows.Forms.Label lblAverageResult;
    }
}

