
namespace Ch8SortedPhrase
{
    partial class FormSortedPhrase
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
            this.txtPhraseEntry = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPhraseEntry
            // 
            this.txtPhraseEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhraseEntry.Location = new System.Drawing.Point(12, 12);
            this.txtPhraseEntry.Name = "txtPhraseEntry";
            this.txtPhraseEntry.Size = new System.Drawing.Size(397, 27);
            this.txtPhraseEntry.TabIndex = 0;
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(12, 59);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 27);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 104);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(397, 30);
            this.lblResult.TabIndex = 2;
            // 
            // FormSortedPhrase
            // 
            this.AcceptButton = this.btnSort;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 156);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtPhraseEntry);
            this.Name = "FormSortedPhrase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorted Phrase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhraseEntry;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblResult;
    }
}

