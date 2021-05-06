
namespace Ch5TestScoresGUI
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
            this.txtScoreEntry = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblNumScores = new System.Windows.Forms.Label();
            this.lblSumScores = new System.Windows.Forms.Label();
            this.lblAvgScores = new System.Windows.Forms.Label();
            this.lblLowScore = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter a test score";
            // 
            // txtScoreEntry
            // 
            this.txtScoreEntry.Location = new System.Drawing.Point(15, 29);
            this.txtScoreEntry.Name = "txtScoreEntry";
            this.txtScoreEntry.Size = new System.Drawing.Size(163, 22);
            this.txtScoreEntry.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(15, 57);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 30);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblNumScores
            // 
            this.lblNumScores.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNumScores.Location = new System.Drawing.Point(12, 106);
            this.lblNumScores.Name = "lblNumScores";
            this.lblNumScores.Size = new System.Drawing.Size(246, 28);
            this.lblNumScores.TabIndex = 3;
            // 
            // lblSumScores
            // 
            this.lblSumScores.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSumScores.Location = new System.Drawing.Point(12, 146);
            this.lblSumScores.Name = "lblSumScores";
            this.lblSumScores.Size = new System.Drawing.Size(246, 28);
            this.lblSumScores.TabIndex = 4;
            // 
            // lblAvgScores
            // 
            this.lblAvgScores.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAvgScores.Location = new System.Drawing.Point(12, 186);
            this.lblAvgScores.Name = "lblAvgScores";
            this.lblAvgScores.Size = new System.Drawing.Size(246, 30);
            this.lblAvgScores.TabIndex = 5;
            // 
            // lblLowScore
            // 
            this.lblLowScore.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblLowScore.Location = new System.Drawing.Point(12, 229);
            this.lblLowScore.Name = "lblLowScore";
            this.lblLowScore.Size = new System.Drawing.Size(246, 31);
            this.lblLowScore.TabIndex = 6;
            // 
            // lblHighScore
            // 
            this.lblHighScore.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblHighScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHighScore.Location = new System.Drawing.Point(12, 272);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(246, 29);
            this.lblHighScore.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 310);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblLowScore);
            this.Controls.Add(this.lblAvgScores);
            this.Controls.Add(this.lblSumScores);
            this.Controls.Add(this.lblNumScores);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtScoreEntry);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScoreEntry;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblNumScores;
        private System.Windows.Forms.Label lblSumScores;
        private System.Windows.Forms.Label lblAvgScores;
        private System.Windows.Forms.Label lblLowScore;
        private System.Windows.Forms.Label lblHighScore;
    }
}

