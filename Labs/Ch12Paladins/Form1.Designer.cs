
namespace Ch12Paladins
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
            this.txtChampionEntry = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rtxtResults = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtChampionEntry
            // 
            this.txtChampionEntry.Location = new System.Drawing.Point(12, 12);
            this.txtChampionEntry.Name = "txtChampionEntry";
            this.txtChampionEntry.Size = new System.Drawing.Size(260, 22);
            this.txtChampionEntry.TabIndex = 0;
            this.txtChampionEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(317, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtxtResults
            // 
            this.rtxtResults.Location = new System.Drawing.Point(12, 46);
            this.rtxtResults.Name = "rtxtResults";
            this.rtxtResults.ReadOnly = true;
            this.rtxtResults.Size = new System.Drawing.Size(422, 253);
            this.rtxtResults.TabIndex = 2;
            this.rtxtResults.TabStop = false;
            this.rtxtResults.Text = "";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 311);
            this.Controls.Add(this.rtxtResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtChampionEntry);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paladins Wiki";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChampionEntry;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox rtxtResults;
    }
}

