
namespace Ch6Vowels
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
            this.lblPhrase = new System.Windows.Forms.Label();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPhrase
            // 
            this.lblPhrase.AutoSize = true;
            this.lblPhrase.Location = new System.Drawing.Point(12, 9);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(148, 17);
            this.lblPhrase.TabIndex = 0;
            this.lblPhrase.Text = "Please enter a phrase";
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(15, 29);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(145, 22);
            this.txtEntry.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblResult.Location = new System.Drawing.Point(12, 79);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(264, 23);
            this.lblResult.TabIndex = 2;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(201, 24);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 32);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 150);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.lblPhrase);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vowels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhrase;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnEnter;
    }
}

