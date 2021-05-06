
namespace Ch10StudentList
{
    partial class FormStudentList
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
            this.labelAddStudentToCourse = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.listBoxStudentList = new System.Windows.Forms.ListBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.labelRemoveStudentByID = new System.Windows.Forms.Label();
            this.comboBoxStudentID = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddStudentToCourse
            // 
            this.labelAddStudentToCourse.AutoSize = true;
            this.labelAddStudentToCourse.Location = new System.Drawing.Point(72, 9);
            this.labelAddStudentToCourse.Name = "labelAddStudentToCourse";
            this.labelAddStudentToCourse.Size = new System.Drawing.Size(211, 17);
            this.labelAddStudentToCourse.TabIndex = 0;
            this.labelAddStudentToCourse.Text = "Add Student To Current Course:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(37, 52);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(78, 17);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(35, 85);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(35, 118);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(13, 151);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(102, 17);
            this.lblEmailAddress.TabIndex = 4;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(121, 49);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(162, 22);
            this.txtStudentID.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(121, 82);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(162, 22);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(121, 115);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(162, 22);
            this.txtLastName.TabIndex = 7;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(121, 148);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(162, 22);
            this.txtEmailAddress.TabIndex = 8;
            // 
            // listBoxStudentList
            // 
            this.listBoxStudentList.FormattingEnabled = true;
            this.listBoxStudentList.ItemHeight = 16;
            this.listBoxStudentList.Location = new System.Drawing.Point(289, 18);
            this.listBoxStudentList.Name = "listBoxStudentList";
            this.listBoxStudentList.Size = new System.Drawing.Size(499, 260);
            this.listBoxStudentList.TabIndex = 9;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(121, 176);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(162, 42);
            this.btnAddStudent.TabIndex = 10;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // labelRemoveStudentByID
            // 
            this.labelRemoveStudentByID.AutoSize = true;
            this.labelRemoveStudentByID.Location = new System.Drawing.Point(37, 331);
            this.labelRemoveStudentByID.Name = "labelRemoveStudentByID";
            this.labelRemoveStudentByID.Size = new System.Drawing.Size(154, 17);
            this.labelRemoveStudentByID.TabIndex = 11;
            this.labelRemoveStudentByID.Text = "Remove Student By ID:";
            // 
            // comboBoxStudentID
            // 
            this.comboBoxStudentID.FormattingEnabled = true;
            this.comboBoxStudentID.Location = new System.Drawing.Point(38, 351);
            this.comboBoxStudentID.Name = "comboBoxStudentID";
            this.comboBoxStudentID.Size = new System.Drawing.Size(161, 24);
            this.comboBoxStudentID.TabIndex = 12;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(37, 381);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(154, 38);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // FormStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.comboBoxStudentID);
            this.Controls.Add(this.labelRemoveStudentByID);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.listBoxStudentList);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.labelAddStudentToCourse);
            this.Name = "FormStudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddStudentToCourse;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.ListBox listBoxStudentList;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label labelRemoveStudentByID;
        private System.Windows.Forms.ComboBox comboBoxStudentID;
        private System.Windows.Forms.Button btnRemove;
    }
}

