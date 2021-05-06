
namespace Ch5CollegeAdmission
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.txtTestScore = new System.Windows.Forms.TextBox();
            this.btnAdmit = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "GPA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admission Test Score";
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(29, 40);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(100, 22);
            this.txtGPA.TabIndex = 2;
            // 
            // txtTestScore
            // 
            this.txtTestScore.Location = new System.Drawing.Point(189, 40);
            this.txtTestScore.Name = "txtTestScore";
            this.txtTestScore.Size = new System.Drawing.Size(142, 22);
            this.txtTestScore.TabIndex = 3;
            // 
            // btnAdmit
            // 
            this.btnAdmit.Location = new System.Drawing.Point(29, 86);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(75, 31);
            this.btnAdmit.TabIndex = 4;
            this.btnAdmit.Text = "Admit";
            this.btnAdmit.UseVisualStyleBackColor = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(189, 90);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(100, 22);
            this.txtStatus.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 145);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnAdmit);
            this.Controls.Add(this.txtTestScore);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "College Admission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.TextBox txtTestScore;
        private System.Windows.Forms.Button btnAdmit;
        private System.Windows.Forms.TextBox txtStatus;
    }
}

