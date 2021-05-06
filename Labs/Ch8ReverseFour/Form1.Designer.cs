
namespace Ch8ReverseFour
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
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber3 = new System.Windows.Forms.TextBox();
            this.txtNumber4 = new System.Windows.Forms.TextBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(12, 12);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(76, 22);
            this.txtNumber1.TabIndex = 0;
            this.txtNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(116, 12);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(76, 22);
            this.txtNumber2.TabIndex = 1;
            this.txtNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumber3
            // 
            this.txtNumber3.Location = new System.Drawing.Point(215, 12);
            this.txtNumber3.Name = "txtNumber3";
            this.txtNumber3.Size = new System.Drawing.Size(76, 22);
            this.txtNumber3.TabIndex = 2;
            this.txtNumber3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumber4
            // 
            this.txtNumber4.Location = new System.Drawing.Point(316, 12);
            this.txtNumber4.Name = "txtNumber4";
            this.txtNumber4.Size = new System.Drawing.Size(76, 22);
            this.txtNumber4.TabIndex = 3;
            this.txtNumber4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(166, 41);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 28);
            this.btnReverse.TabIndex = 4;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnReverse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 81);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.txtNumber4);
            this.Controls.Add(this.txtNumber3);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reverse4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber3;
        private System.Windows.Forms.TextBox txtNumber4;
        private System.Windows.Forms.Button btnReverse;
    }
}

