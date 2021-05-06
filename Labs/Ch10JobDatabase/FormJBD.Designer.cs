
namespace Ch10JobDatabase
{
    partial class FormJDB
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
            this.lblWIAYII = new System.Windows.Forms.Label();
            this.listBoxIndustries = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWIAYII
            // 
            this.lblWIAYII.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWIAYII.Location = new System.Drawing.Point(12, 9);
            this.lblWIAYII.Name = "lblWIAYII";
            this.lblWIAYII.Size = new System.Drawing.Size(341, 48);
            this.lblWIAYII.TabIndex = 0;
            this.lblWIAYII.Text = "What industries are you interested in? (Select all that apply)";
            // 
            // listBoxIndustries
            // 
            this.listBoxIndustries.FormattingEnabled = true;
            this.listBoxIndustries.ItemHeight = 16;
            this.listBoxIndustries.Location = new System.Drawing.Point(16, 60);
            this.listBoxIndustries.Name = "listBoxIndustries";
            this.listBoxIndustries.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxIndustries.Size = new System.Drawing.Size(319, 132);
            this.listBoxIndustries.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(16, 212);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormJDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 259);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.listBoxIndustries);
            this.Controls.Add(this.lblWIAYII);
            this.Name = "FormJDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Database";
            this.Activated += new System.EventHandler(this.FormJDB_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWIAYII;
        private System.Windows.Forms.ListBox listBoxIndustries;
        private System.Windows.Forms.Button btnSearch;
    }
}

