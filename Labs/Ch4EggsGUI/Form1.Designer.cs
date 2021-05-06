
namespace Ch4EggsGUI
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
            this.txtChicken1 = new System.Windows.Forms.TextBox();
            this.txtChicken2 = new System.Windows.Forms.TextBox();
            this.txtChicken3 = new System.Windows.Forms.TextBox();
            this.txtChicken4 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter number of eggs laid by each chicken:";
            // 
            // txtChicken1
            // 
            this.txtChicken1.Location = new System.Drawing.Point(36, 38);
            this.txtChicken1.Name = "txtChicken1";
            this.txtChicken1.Size = new System.Drawing.Size(100, 22);
            this.txtChicken1.TabIndex = 1;
            // 
            // txtChicken2
            // 
            this.txtChicken2.Location = new System.Drawing.Point(142, 38);
            this.txtChicken2.Name = "txtChicken2";
            this.txtChicken2.Size = new System.Drawing.Size(100, 22);
            this.txtChicken2.TabIndex = 2;
            // 
            // txtChicken3
            // 
            this.txtChicken3.Location = new System.Drawing.Point(248, 38);
            this.txtChicken3.Name = "txtChicken3";
            this.txtChicken3.Size = new System.Drawing.Size(100, 22);
            this.txtChicken3.TabIndex = 3;
            // 
            // txtChicken4
            // 
            this.txtChicken4.Location = new System.Drawing.Point(354, 38);
            this.txtChicken4.Name = "txtChicken4";
            this.txtChicken4.Size = new System.Drawing.Size(100, 22);
            this.txtChicken4.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(200, 75);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(87, 28);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(105, 118);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(278, 22);
            this.txtAnswer.TabIndex = 6;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 162);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtChicken4);
            this.Controls.Add(this.txtChicken3);
            this.Controls.Add(this.txtChicken2);
            this.Controls.Add(this.txtChicken1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chicken Farmer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChicken1;
        private System.Windows.Forms.TextBox txtChicken2;
        private System.Windows.Forms.TextBox txtChicken3;
        private System.Windows.Forms.TextBox txtChicken4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtAnswer;
    }
}

