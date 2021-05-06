
namespace Ch6CreditCardMasker
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
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.lblMaskedNumber = new System.Windows.Forms.Label();
            this.btnMask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(12, 12);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(218, 22);
            this.txtEntry.TabIndex = 0;
            // 
            // lblMaskedNumber
            // 
            this.lblMaskedNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMaskedNumber.Location = new System.Drawing.Point(9, 48);
            this.lblMaskedNumber.Name = "lblMaskedNumber";
            this.lblMaskedNumber.Size = new System.Drawing.Size(221, 23);
            this.lblMaskedNumber.TabIndex = 1;
            // 
            // btnMask
            // 
            this.btnMask.Location = new System.Drawing.Point(258, 12);
            this.btnMask.Name = "btnMask";
            this.btnMask.Size = new System.Drawing.Size(75, 23);
            this.btnMask.TabIndex = 1;
            this.btnMask.Text = "Mask";
            this.btnMask.UseVisualStyleBackColor = true;
            this.btnMask.Click += new System.EventHandler(this.btnMask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 84);
            this.Controls.Add(this.btnMask);
            this.Controls.Add(this.lblMaskedNumber);
            this.Controls.Add(this.txtEntry);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Card Masker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Label lblMaskedNumber;
        private System.Windows.Forms.Button btnMask;
    }
}

