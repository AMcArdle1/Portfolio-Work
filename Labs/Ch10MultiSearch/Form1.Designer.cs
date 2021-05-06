
namespace Ch10MultiSearch
{
    partial class FormMS
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstNameEntry = new System.Windows.Forms.TextBox();
            this.txtLastNameEntry = new System.Windows.Forms.TextBox();
            this.btnSearchFirstName = new System.Windows.Forms.Button();
            this.btnSearchLastName = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblCourseGrade = new System.Windows.Forms.Label();
            this.lblGPA = new System.Windows.Forms.Label();
            this.lblCourseResult = new System.Windows.Forms.Label();
            this.lblCourseGradeResult = new System.Windows.Forms.Label();
            this.lblGPAResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(8, 9);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(92, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(264, 9);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(91, 20);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstNameEntry
            // 
            this.txtFirstNameEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNameEntry.Location = new System.Drawing.Point(12, 32);
            this.txtFirstNameEntry.Name = "txtFirstNameEntry";
            this.txtFirstNameEntry.Size = new System.Drawing.Size(208, 27);
            this.txtFirstNameEntry.TabIndex = 0;
            this.txtFirstNameEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirstNameEntry_Enter);
            // 
            // txtLastNameEntry
            // 
            this.txtLastNameEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNameEntry.Location = new System.Drawing.Point(268, 32);
            this.txtLastNameEntry.Name = "txtLastNameEntry";
            this.txtLastNameEntry.Size = new System.Drawing.Size(208, 27);
            this.txtLastNameEntry.TabIndex = 1;
            this.txtLastNameEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLastNameEntry_Enter);
            // 
            // btnSearchFirstName
            // 
            this.btnSearchFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFirstName.Location = new System.Drawing.Point(12, 65);
            this.btnSearchFirstName.Name = "btnSearchFirstName";
            this.btnSearchFirstName.Size = new System.Drawing.Size(208, 31);
            this.btnSearchFirstName.TabIndex = 2;
            this.btnSearchFirstName.Text = "Search by First Name";
            this.btnSearchFirstName.UseVisualStyleBackColor = true;
            this.btnSearchFirstName.Click += new System.EventHandler(this.btnSearchFirstName_Click);
            // 
            // btnSearchLastName
            // 
            this.btnSearchLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchLastName.Location = new System.Drawing.Point(268, 65);
            this.btnSearchLastName.Name = "btnSearchLastName";
            this.btnSearchLastName.Size = new System.Drawing.Size(208, 31);
            this.btnSearchLastName.TabIndex = 3;
            this.btnSearchLastName.Text = "Search by Last Name";
            this.btnSearchLastName.UseVisualStyleBackColor = true;
            this.btnSearchLastName.Click += new System.EventHandler(this.btnSearchLastName_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(12, 126);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(464, 38);
            this.lblStudentName.TabIndex = 6;
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(8, 181);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(73, 20);
            this.lblCourse.TabIndex = 7;
            this.lblCourse.Text = "Course: ";
            // 
            // lblCourseGrade
            // 
            this.lblCourseGrade.AutoSize = true;
            this.lblCourseGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseGrade.Location = new System.Drawing.Point(8, 222);
            this.lblCourseGrade.Name = "lblCourseGrade";
            this.lblCourseGrade.Size = new System.Drawing.Size(124, 20);
            this.lblCourseGrade.TabIndex = 8;
            this.lblCourseGrade.Text = "Course Grade: ";
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPA.Location = new System.Drawing.Point(8, 257);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(54, 20);
            this.lblGPA.TabIndex = 9;
            this.lblGPA.Text = "GPA: ";
            // 
            // lblCourseResult
            // 
            this.lblCourseResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCourseResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseResult.Location = new System.Drawing.Point(166, 181);
            this.lblCourseResult.Name = "lblCourseResult";
            this.lblCourseResult.Size = new System.Drawing.Size(164, 20);
            this.lblCourseResult.TabIndex = 10;
            this.lblCourseResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCourseGradeResult
            // 
            this.lblCourseGradeResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCourseGradeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseGradeResult.Location = new System.Drawing.Point(166, 222);
            this.lblCourseGradeResult.Name = "lblCourseGradeResult";
            this.lblCourseGradeResult.Size = new System.Drawing.Size(164, 20);
            this.lblCourseGradeResult.TabIndex = 11;
            this.lblCourseGradeResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGPAResult
            // 
            this.lblGPAResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblGPAResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPAResult.Location = new System.Drawing.Point(166, 257);
            this.lblGPAResult.Name = "lblGPAResult";
            this.lblGPAResult.Size = new System.Drawing.Size(164, 20);
            this.lblGPAResult.TabIndex = 12;
            this.lblGPAResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 307);
            this.Controls.Add(this.lblGPAResult);
            this.Controls.Add(this.lblCourseGradeResult);
            this.Controls.Add(this.lblCourseResult);
            this.Controls.Add(this.lblGPA);
            this.Controls.Add(this.lblCourseGrade);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.btnSearchLastName);
            this.Controls.Add(this.btnSearchFirstName);
            this.Controls.Add(this.txtLastNameEntry);
            this.Controls.Add(this.txtFirstNameEntry);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "FormMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstNameEntry;
        private System.Windows.Forms.TextBox txtLastNameEntry;
        private System.Windows.Forms.Button btnSearchFirstName;
        private System.Windows.Forms.Button btnSearchLastName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblCourseGrade;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Label lblCourseResult;
        private System.Windows.Forms.Label lblCourseGradeResult;
        private System.Windows.Forms.Label lblGPAResult;
    }
}

