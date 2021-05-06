
namespace Ch6CustomDesk
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
            this.lblWoodType = new System.Windows.Forms.Label();
            this.txtWoodType = new System.Windows.Forms.TextBox();
            this.lblNumDrawers = new System.Windows.Forms.Label();
            this.txtNumDrawers = new System.Windows.Forms.TextBox();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.lblCOW = new System.Windows.Forms.Label();
            this.lblCostOfWood = new System.Windows.Forms.Label();
            this.lblCostOfDrawers = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblCOD = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWoodType
            // 
            this.lblWoodType.AutoSize = true;
            this.lblWoodType.Location = new System.Drawing.Point(12, 9);
            this.lblWoodType.Name = "lblWoodType";
            this.lblWoodType.Size = new System.Drawing.Size(97, 17);
            this.lblWoodType.TabIndex = 0;
            this.lblWoodType.Text = "Type of Wood";
            // 
            // txtWoodType
            // 
            this.txtWoodType.Location = new System.Drawing.Point(15, 29);
            this.txtWoodType.Name = "txtWoodType";
            this.txtWoodType.Size = new System.Drawing.Size(100, 22);
            this.txtWoodType.TabIndex = 0;
            // 
            // lblNumDrawers
            // 
            this.lblNumDrawers.AutoSize = true;
            this.lblNumDrawers.Location = new System.Drawing.Point(166, 9);
            this.lblNumDrawers.Name = "lblNumDrawers";
            this.lblNumDrawers.Size = new System.Drawing.Size(130, 17);
            this.lblNumDrawers.TabIndex = 2;
            this.lblNumDrawers.Text = "Number of Drawers";
            // 
            // txtNumDrawers
            // 
            this.txtNumDrawers.Location = new System.Drawing.Point(169, 29);
            this.txtNumDrawers.Name = "txtNumDrawers";
            this.txtNumDrawers.Size = new System.Drawing.Size(127, 22);
            this.txtNumDrawers.TabIndex = 1;
            // 
            // btnEstimate
            // 
            this.btnEstimate.Location = new System.Drawing.Point(15, 75);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(75, 28);
            this.btnEstimate.TabIndex = 2;
            this.btnEstimate.Text = "Estimate";
            this.btnEstimate.UseVisualStyleBackColor = true;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // lblCOW
            // 
            this.lblCOW.AutoSize = true;
            this.lblCOW.Location = new System.Drawing.Point(12, 136);
            this.lblCOW.Name = "lblCOW";
            this.lblCOW.Size = new System.Drawing.Size(93, 17);
            this.lblCOW.TabIndex = 5;
            this.lblCOW.Text = "Cost of Wood";
            // 
            // lblCostOfWood
            // 
            this.lblCostOfWood.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCostOfWood.Location = new System.Drawing.Point(12, 153);
            this.lblCostOfWood.Name = "lblCostOfWood";
            this.lblCostOfWood.Size = new System.Drawing.Size(103, 23);
            this.lblCostOfWood.TabIndex = 6;
            // 
            // lblCostOfDrawers
            // 
            this.lblCostOfDrawers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCostOfDrawers.Location = new System.Drawing.Point(155, 153);
            this.lblCostOfDrawers.Name = "lblCostOfDrawers";
            this.lblCostOfDrawers.Size = new System.Drawing.Size(103, 23);
            this.lblCostOfDrawers.TabIndex = 7;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalCost.Location = new System.Drawing.Point(294, 153);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(103, 23);
            this.lblTotalCost.TabIndex = 8;
            // 
            // lblCOD
            // 
            this.lblCOD.AutoSize = true;
            this.lblCOD.Location = new System.Drawing.Point(155, 136);
            this.lblCOD.Name = "lblCOD";
            this.lblCOD.Size = new System.Drawing.Size(108, 17);
            this.lblCOD.TabIndex = 9;
            this.lblCOD.Text = "Cost of Drawers";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(294, 136);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(72, 17);
            this.lblTC.TabIndex = 10;
            this.lblTC.Text = "Total Cost";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEstimate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 191);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblCOD);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblCostOfDrawers);
            this.Controls.Add(this.lblCostOfWood);
            this.Controls.Add(this.lblCOW);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.txtNumDrawers);
            this.Controls.Add(this.lblNumDrawers);
            this.Controls.Add(this.txtWoodType);
            this.Controls.Add(this.lblWoodType);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Custom Desk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWoodType;
        private System.Windows.Forms.TextBox txtWoodType;
        private System.Windows.Forms.Label lblNumDrawers;
        private System.Windows.Forms.TextBox txtNumDrawers;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.Label lblCOW;
        private System.Windows.Forms.Label lblCostOfWood;
        private System.Windows.Forms.Label lblCostOfDrawers;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblCOD;
        private System.Windows.Forms.Label lblTC;
    }
}

