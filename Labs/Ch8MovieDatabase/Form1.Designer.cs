
namespace Ch8MovieDatabase
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
            this.txtMovieEntry = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNameResult = new System.Windows.Forms.Label();
            this.lblDirectorResult = new System.Windows.Forms.Label();
            this.lblDescriptionResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMovieEntry
            // 
            this.txtMovieEntry.Location = new System.Drawing.Point(12, 12);
            this.txtMovieEntry.Name = "txtMovieEntry";
            this.txtMovieEntry.Size = new System.Drawing.Size(253, 22);
            this.txtMovieEntry.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(282, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Director:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            // 
            // lblNameResult
            // 
            this.lblNameResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNameResult.Location = new System.Drawing.Point(112, 60);
            this.lblNameResult.Name = "lblNameResult";
            this.lblNameResult.Size = new System.Drawing.Size(278, 23);
            this.lblNameResult.TabIndex = 5;
            // 
            // lblDirectorResult
            // 
            this.lblDirectorResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDirectorResult.Location = new System.Drawing.Point(112, 99);
            this.lblDirectorResult.Name = "lblDirectorResult";
            this.lblDirectorResult.Size = new System.Drawing.Size(278, 23);
            this.lblDirectorResult.TabIndex = 6;
            // 
            // lblDescriptionResult
            // 
            this.lblDescriptionResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDescriptionResult.Location = new System.Drawing.Point(112, 137);
            this.lblDescriptionResult.Name = "lblDescriptionResult";
            this.lblDescriptionResult.Size = new System.Drawing.Size(278, 102);
            this.lblDescriptionResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 248);
            this.Controls.Add(this.lblDescriptionResult);
            this.Controls.Add(this.lblDirectorResult);
            this.Controls.Add(this.lblNameResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMovieEntry);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMovieEntry;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNameResult;
        private System.Windows.Forms.Label lblDirectorResult;
        private System.Windows.Forms.Label lblDescriptionResult;
    }
}

