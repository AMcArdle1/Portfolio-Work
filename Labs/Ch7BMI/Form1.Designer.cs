
namespace Ch7BMI
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
            this.lblWeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 9);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(58, 13);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Weight (lb)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Height (in)";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(76, 6);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(115, 20);
            this.txtWeight.TabIndex = 0;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(76, 41);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(115, 20);
            this.txtHeight.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(76, 82);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(115, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblBMI
            // 
            this.lblBMI.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblBMI.Location = new System.Drawing.Point(73, 125);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(118, 18);
            this.lblBMI.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCategory.Location = new System.Drawing.Point(73, 159);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(118, 18);
            this.lblCategory.TabIndex = 6;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 198);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWeight);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Body Mass Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblCategory;
    }
}

