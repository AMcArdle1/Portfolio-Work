
namespace Ch5RockPaperScissors
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.lblComputerChoice = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.lblOverallResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(42, 24);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 29);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(147, 24);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 29);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(258, 24);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(75, 29);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // lblComputerChoice
            // 
            this.lblComputerChoice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblComputerChoice.Location = new System.Drawing.Point(39, 76);
            this.lblComputerChoice.Name = "lblComputerChoice";
            this.lblComputerChoice.Size = new System.Drawing.Size(294, 23);
            this.lblComputerChoice.TabIndex = 3;
            this.lblComputerChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPlayerScore.Location = new System.Drawing.Point(39, 118);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(140, 23);
            this.lblPlayerScore.TabIndex = 4;
            this.lblPlayerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblComputerScore.Location = new System.Drawing.Point(185, 118);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(148, 23);
            this.lblComputerScore.TabIndex = 5;
            this.lblComputerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOverallResult
            // 
            this.lblOverallResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblOverallResult.Location = new System.Drawing.Point(39, 160);
            this.lblOverallResult.Name = "lblOverallResult";
            this.lblOverallResult.Size = new System.Drawing.Size(294, 23);
            this.lblOverallResult.TabIndex = 6;
            this.lblOverallResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 221);
            this.Controls.Add(this.lblOverallResult);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblComputerChoice);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label lblComputerChoice;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Label lblOverallResult;
    }
}

