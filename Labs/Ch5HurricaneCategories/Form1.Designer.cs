
namespace Ch5HurricaneCategories
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtWindSpeed = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wind Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // txtWindSpeed
            // 
            this.txtWindSpeed.Location = new System.Drawing.Point(12, 29);
            this.txtWindSpeed.Name = "txtWindSpeed";
            this.txtWindSpeed.Size = new System.Drawing.Size(100, 22);
            this.txtWindSpeed.TabIndex = 2;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(206, 29);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(114, 22);
            this.txtCategory.TabIndex = 3;
            // 
            // btnEstimate
            // 
            this.btnEstimate.Location = new System.Drawing.Point(122, 25);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(75, 31);
            this.btnEstimate.TabIndex = 4;
            this.btnEstimate.Text = "Estimate";
            this.btnEstimate.UseVisualStyleBackColor = true;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEstimate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 82);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtWindSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hurricane Scale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWindSpeed;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnEstimate;
    }
}

