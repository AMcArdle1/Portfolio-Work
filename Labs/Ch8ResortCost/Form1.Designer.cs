
namespace Ch8ResortCost
{
    partial class FormResort
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
            this.lblNightsStayed = new System.Windows.Forms.Label();
            this.txtNightsStayed = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblNightlyCost = new System.Windows.Forms.Label();
            this.lblTotalCostOfStay = new System.Windows.Forms.Label();
            this.lblNightlyCostResult = new System.Windows.Forms.Label();
            this.lblTotalCostResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNightsStayed
            // 
            this.lblNightsStayed.AutoSize = true;
            this.lblNightsStayed.Location = new System.Drawing.Point(12, 9);
            this.lblNightsStayed.Name = "lblNightsStayed";
            this.lblNightsStayed.Size = new System.Drawing.Size(96, 17);
            this.lblNightsStayed.TabIndex = 0;
            this.lblNightsStayed.Text = "Nights Stayed";
            // 
            // txtNightsStayed
            // 
            this.txtNightsStayed.Location = new System.Drawing.Point(15, 29);
            this.txtNightsStayed.Name = "txtNightsStayed";
            this.txtNightsStayed.Size = new System.Drawing.Size(100, 22);
            this.txtNightsStayed.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(139, 27);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(81, 27);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblNightlyCost
            // 
            this.lblNightlyCost.AutoSize = true;
            this.lblNightlyCost.Location = new System.Drawing.Point(237, 9);
            this.lblNightlyCost.Name = "lblNightlyCost";
            this.lblNightlyCost.Size = new System.Drawing.Size(83, 17);
            this.lblNightlyCost.TabIndex = 3;
            this.lblNightlyCost.Text = "Nightly Cost";
            // 
            // lblTotalCostOfStay
            // 
            this.lblTotalCostOfStay.AutoSize = true;
            this.lblTotalCostOfStay.Location = new System.Drawing.Point(348, 9);
            this.lblTotalCostOfStay.Name = "lblTotalCostOfStay";
            this.lblTotalCostOfStay.Size = new System.Drawing.Size(118, 17);
            this.lblTotalCostOfStay.TabIndex = 4;
            this.lblTotalCostOfStay.Text = "Total Cost of stay";
            // 
            // lblNightlyCostResult
            // 
            this.lblNightlyCostResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNightlyCostResult.Location = new System.Drawing.Point(237, 32);
            this.lblNightlyCostResult.Name = "lblNightlyCostResult";
            this.lblNightlyCostResult.Size = new System.Drawing.Size(83, 23);
            this.lblNightlyCostResult.TabIndex = 5;
            // 
            // lblTotalCostResult
            // 
            this.lblTotalCostResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalCostResult.Location = new System.Drawing.Point(348, 32);
            this.lblTotalCostResult.Name = "lblTotalCostResult";
            this.lblTotalCostResult.Size = new System.Drawing.Size(118, 23);
            this.lblTotalCostResult.TabIndex = 6;
            // 
            // FormResort
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(503, 79);
            this.Controls.Add(this.lblTotalCostResult);
            this.Controls.Add(this.lblNightlyCostResult);
            this.Controls.Add(this.lblTotalCostOfStay);
            this.Controls.Add(this.lblNightlyCost);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNightsStayed);
            this.Controls.Add(this.lblNightsStayed);
            this.Name = "FormResort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Carefree Resort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNightsStayed;
        private System.Windows.Forms.TextBox txtNightsStayed;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblNightlyCost;
        private System.Windows.Forms.Label lblTotalCostOfStay;
        private System.Windows.Forms.Label lblNightlyCostResult;
        private System.Windows.Forms.Label lblTotalCostResult;
    }
}

