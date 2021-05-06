
namespace Ch12Conferences
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
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtGNEntry = new System.Windows.Forms.TextBox();
            this.txtSDEntry = new System.Windows.Forms.TextBox();
            this.lblStartingDate = new System.Windows.Forms.Label();
            this.txtAEntry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtREntry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblConferencesHeading = new System.Windows.Forms.Label();
            this.lblCResults = new System.Windows.Forms.Label();
            this.lblTAResults = new System.Windows.Forms.Label();
            this.lblTotalAttendeesHeader = new System.Windows.Forms.Label();
            this.txtBegin = new System.Windows.Forms.TextBox();
            this.lblBegin = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rtxtSearchResults = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(12, 9);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(93, 17);
            this.lblGroupName.TabIndex = 0;
            this.lblGroupName.Text = "Group Name:";
            // 
            // txtGNEntry
            // 
            this.txtGNEntry.Location = new System.Drawing.Point(15, 29);
            this.txtGNEntry.Name = "txtGNEntry";
            this.txtGNEntry.Size = new System.Drawing.Size(129, 22);
            this.txtGNEntry.TabIndex = 0;
            // 
            // txtSDEntry
            // 
            this.txtSDEntry.Location = new System.Drawing.Point(163, 29);
            this.txtSDEntry.Name = "txtSDEntry";
            this.txtSDEntry.Size = new System.Drawing.Size(129, 22);
            this.txtSDEntry.TabIndex = 1;
            // 
            // lblStartingDate
            // 
            this.lblStartingDate.AutoSize = true;
            this.lblStartingDate.Location = new System.Drawing.Point(160, 9);
            this.lblStartingDate.Name = "lblStartingDate";
            this.lblStartingDate.Size = new System.Drawing.Size(95, 17);
            this.lblStartingDate.TabIndex = 2;
            this.lblStartingDate.Text = "Starting Date:";
            // 
            // txtAEntry
            // 
            this.txtAEntry.Location = new System.Drawing.Point(301, 29);
            this.txtAEntry.Name = "txtAEntry";
            this.txtAEntry.Size = new System.Drawing.Size(129, 22);
            this.txtAEntry.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Attendees:";
            // 
            // txtREntry
            // 
            this.txtREntry.Location = new System.Drawing.Point(439, 29);
            this.txtREntry.Name = "txtREntry";
            this.txtREntry.Size = new System.Drawing.Size(129, 22);
            this.txtREntry.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Room:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(592, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblConferencesHeading
            // 
            this.lblConferencesHeading.AutoSize = true;
            this.lblConferencesHeading.Location = new System.Drawing.Point(13, 77);
            this.lblConferencesHeading.Name = "lblConferencesHeading";
            this.lblConferencesHeading.Size = new System.Drawing.Size(92, 17);
            this.lblConferencesHeading.TabIndex = 9;
            this.lblConferencesHeading.Text = "Conferences:";
            // 
            // lblCResults
            // 
            this.lblCResults.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCResults.Location = new System.Drawing.Point(131, 77);
            this.lblCResults.Name = "lblCResults";
            this.lblCResults.Size = new System.Drawing.Size(100, 23);
            this.lblCResults.TabIndex = 10;
            // 
            // lblTAResults
            // 
            this.lblTAResults.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTAResults.Location = new System.Drawing.Point(131, 114);
            this.lblTAResults.Name = "lblTAResults";
            this.lblTAResults.Size = new System.Drawing.Size(100, 23);
            this.lblTAResults.TabIndex = 12;
            // 
            // lblTotalAttendeesHeader
            // 
            this.lblTotalAttendeesHeader.AutoSize = true;
            this.lblTotalAttendeesHeader.Location = new System.Drawing.Point(13, 114);
            this.lblTotalAttendeesHeader.Name = "lblTotalAttendeesHeader";
            this.lblTotalAttendeesHeader.Size = new System.Drawing.Size(112, 17);
            this.lblTotalAttendeesHeader.TabIndex = 11;
            this.lblTotalAttendeesHeader.Text = "Total Attendees:";
            // 
            // txtBegin
            // 
            this.txtBegin.Location = new System.Drawing.Point(16, 185);
            this.txtBegin.Name = "txtBegin";
            this.txtBegin.Size = new System.Drawing.Size(129, 22);
            this.txtBegin.TabIndex = 5;
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.Location = new System.Drawing.Point(13, 165);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(48, 17);
            this.lblBegin.TabIndex = 13;
            this.lblBegin.Text = "Begin:";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(163, 185);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(129, 22);
            this.txtEnd.TabIndex = 6;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(160, 165);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(37, 17);
            this.lblEnd.TabIndex = 15;
            this.lblEnd.Text = "End:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(315, 185);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rtxtSearchResults
            // 
            this.rtxtSearchResults.Location = new System.Drawing.Point(16, 214);
            this.rtxtSearchResults.Name = "rtxtSearchResults";
            this.rtxtSearchResults.ReadOnly = true;
            this.rtxtSearchResults.Size = new System.Drawing.Size(552, 145);
            this.rtxtSearchResults.TabIndex = 18;
            this.rtxtSearchResults.TabStop = false;
            this.rtxtSearchResults.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 371);
            this.Controls.Add(this.rtxtSearchResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.txtBegin);
            this.Controls.Add(this.lblBegin);
            this.Controls.Add(this.lblTAResults);
            this.Controls.Add(this.lblTotalAttendeesHeader);
            this.Controls.Add(this.lblCResults);
            this.Controls.Add(this.lblConferencesHeading);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtREntry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSDEntry);
            this.Controls.Add(this.lblStartingDate);
            this.Controls.Add(this.txtGNEntry);
            this.Controls.Add(this.lblGroupName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGNEntry;
        private System.Windows.Forms.TextBox txtSDEntry;
        private System.Windows.Forms.Label lblStartingDate;
        private System.Windows.Forms.TextBox txtAEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtREntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblConferencesHeading;
        private System.Windows.Forms.Label lblCResults;
        private System.Windows.Forms.Label lblTAResults;
        private System.Windows.Forms.Label lblTotalAttendeesHeader;
        private System.Windows.Forms.TextBox txtBegin;
        private System.Windows.Forms.Label lblBegin;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox rtxtSearchResults;
    }
}

