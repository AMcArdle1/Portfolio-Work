
namespace Ch6CollegeAdmission
{
    partial class CollegeAdmissions
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
            this.lblGPA = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.lblAdmissionScore = new System.Windows.Forms.Label();
            this.txtAdmissionScore = new System.Windows.Forms.TextBox();
            this.btnAdmit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Location = new System.Drawing.Point(22, 23);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(37, 17);
            this.lblGPA.TabIndex = 0;
            this.lblGPA.Text = "GPA";
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(25, 43);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(100, 22);
            this.txtGPA.TabIndex = 1;
            // 
            // lblAdmissionScore
            // 
            this.lblAdmissionScore.AutoSize = true;
            this.lblAdmissionScore.Location = new System.Drawing.Point(234, 23);
            this.lblAdmissionScore.Name = "lblAdmissionScore";
            this.lblAdmissionScore.Size = new System.Drawing.Size(145, 17);
            this.lblAdmissionScore.TabIndex = 2;
            this.lblAdmissionScore.Text = "Admission Test Score";
            // 
            // txtAdmissionScore
            // 
            this.txtAdmissionScore.Location = new System.Drawing.Point(237, 43);
            this.txtAdmissionScore.Name = "txtAdmissionScore";
            this.txtAdmissionScore.Size = new System.Drawing.Size(142, 22);
            this.txtAdmissionScore.TabIndex = 3;
            // 
            // btnAdmit
            // 
            this.btnAdmit.Location = new System.Drawing.Point(25, 96);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(82, 27);
            this.btnAdmit.TabIndex = 4;
            this.btnAdmit.Text = "Admit";
            this.btnAdmit.UseVisualStyleBackColor = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblStatus.Location = new System.Drawing.Point(139, 96);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(94, 27);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CollegeAdmissions
            // 
            this.AcceptButton = this.btnAdmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 183);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnAdmit);
            this.Controls.Add(this.txtAdmissionScore);
            this.Controls.Add(this.lblAdmissionScore);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.lblGPA);
            this.Name = "CollegeAdmissions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "College Admission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.Label lblAdmissionScore;
        private System.Windows.Forms.TextBox txtAdmissionScore;
        private System.Windows.Forms.Button btnAdmit;
        private System.Windows.Forms.Label lblStatus;
    }
}

