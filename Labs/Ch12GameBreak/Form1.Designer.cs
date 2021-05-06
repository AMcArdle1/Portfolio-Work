
namespace Ch12GameBreak
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
            this.txtGameEntry = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblNameHeader = new System.Windows.Forms.Label();
            this.lblNameResult = new System.Windows.Forms.Label();
            this.lblPublisherResult = new System.Windows.Forms.Label();
            this.lblPublisherHeader = new System.Windows.Forms.Label();
            this.lblPriceResult = new System.Windows.Forms.Label();
            this.lblPriceHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGameEntry
            // 
            this.txtGameEntry.Location = new System.Drawing.Point(12, 12);
            this.txtGameEntry.Name = "txtGameEntry";
            this.txtGameEntry.Size = new System.Drawing.Size(245, 24);
            this.txtGameEntry.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(279, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(387, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblNameHeader
            // 
            this.lblNameHeader.AutoSize = true;
            this.lblNameHeader.Location = new System.Drawing.Point(12, 66);
            this.lblNameHeader.Name = "lblNameHeader";
            this.lblNameHeader.Size = new System.Drawing.Size(52, 18);
            this.lblNameHeader.TabIndex = 3;
            this.lblNameHeader.Text = "Name:";
            // 
            // lblNameResult
            // 
            this.lblNameResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNameResult.Location = new System.Drawing.Point(94, 66);
            this.lblNameResult.Name = "lblNameResult";
            this.lblNameResult.Size = new System.Drawing.Size(368, 21);
            this.lblNameResult.TabIndex = 4;
            // 
            // lblPublisherResult
            // 
            this.lblPublisherResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPublisherResult.Location = new System.Drawing.Point(94, 114);
            this.lblPublisherResult.Name = "lblPublisherResult";
            this.lblPublisherResult.Size = new System.Drawing.Size(368, 21);
            this.lblPublisherResult.TabIndex = 6;
            // 
            // lblPublisherHeader
            // 
            this.lblPublisherHeader.AutoSize = true;
            this.lblPublisherHeader.Location = new System.Drawing.Point(12, 117);
            this.lblPublisherHeader.Name = "lblPublisherHeader";
            this.lblPublisherHeader.Size = new System.Drawing.Size(73, 18);
            this.lblPublisherHeader.TabIndex = 5;
            this.lblPublisherHeader.Text = "Publisher:";
            // 
            // lblPriceResult
            // 
            this.lblPriceResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPriceResult.Location = new System.Drawing.Point(94, 167);
            this.lblPriceResult.Name = "lblPriceResult";
            this.lblPriceResult.Size = new System.Drawing.Size(368, 21);
            this.lblPriceResult.TabIndex = 8;
            // 
            // lblPriceHeader
            // 
            this.lblPriceHeader.AutoSize = true;
            this.lblPriceHeader.Location = new System.Drawing.Point(12, 167);
            this.lblPriceHeader.Name = "lblPriceHeader";
            this.lblPriceHeader.Size = new System.Drawing.Size(46, 18);
            this.lblPriceHeader.TabIndex = 7;
            this.lblPriceHeader.Text = "Price:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 247);
            this.Controls.Add(this.lblPriceResult);
            this.Controls.Add(this.lblPriceHeader);
            this.Controls.Add(this.lblPublisherResult);
            this.Controls.Add(this.lblPublisherHeader);
            this.Controls.Add(this.lblNameResult);
            this.Controls.Add(this.lblNameHeader);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtGameEntry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameBreak";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGameEntry;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblNameHeader;
        private System.Windows.Forms.Label lblNameResult;
        private System.Windows.Forms.Label lblPublisherResult;
        private System.Windows.Forms.Label lblPublisherHeader;
        private System.Windows.Forms.Label lblPriceResult;
        private System.Windows.Forms.Label lblPriceHeader;
    }
}

