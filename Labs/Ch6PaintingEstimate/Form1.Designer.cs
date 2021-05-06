
namespace Ch6PaintingEstimate
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblTotalArea = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 9);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(74, 17);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length (ft)";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(115, 9);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(66, 17);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width (ft)";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(12, 29);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 22);
            this.txtLength.TabIndex = 0;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(118, 30);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 22);
            this.txtWidth.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(224, 26);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(82, 28);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(312, 9);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(115, 17);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Total Area (sq ft)";
            // 
            // lblTotalArea
            // 
            this.lblTotalArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalArea.Location = new System.Drawing.Point(312, 28);
            this.lblTotalArea.Name = "lblTotalArea";
            this.lblTotalArea.Size = new System.Drawing.Size(115, 23);
            this.lblTotalArea.TabIndex = 6;
            this.lblTotalArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(433, 9);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(94, 17);
            this.lblCost.TabIndex = 7;
            this.lblCost.Text = "Total Cost ($)";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalCost.Location = new System.Drawing.Point(433, 29);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(94, 23);
            this.lblTotalCost.TabIndex = 8;
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 69);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblTotalArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painting Estimate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblTotalArea;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblTotalCost;
    }
}

