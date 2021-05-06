
namespace SQLQueryTester
{
    partial class FrmSQLQueryTester
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
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblRecordsReturned = new System.Windows.Forms.Label();
            this.lblNumRecords = new System.Windows.Forms.Label();
            this.dgvQueryTester = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryTester)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(12, 340);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(560, 55);
            this.txtQuery.TabIndex = 0;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(578, 340);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(669, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(759, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblRecordsReturned
            // 
            this.lblRecordsReturned.AutoSize = true;
            this.lblRecordsReturned.Location = new System.Drawing.Point(578, 372);
            this.lblRecordsReturned.Name = "lblRecordsReturned";
            this.lblRecordsReturned.Size = new System.Drawing.Size(128, 17);
            this.lblRecordsReturned.TabIndex = 4;
            this.lblRecordsReturned.Text = "Records Returned:";
            // 
            // lblNumRecords
            // 
            this.lblNumRecords.BackColor = System.Drawing.SystemColors.Control;
            this.lblNumRecords.Location = new System.Drawing.Point(712, 372);
            this.lblNumRecords.Name = "lblNumRecords";
            this.lblNumRecords.Size = new System.Drawing.Size(100, 23);
            this.lblNumRecords.TabIndex = 5;
            // 
            // dgvQueryTester
            // 
            this.dgvQueryTester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueryTester.Location = new System.Drawing.Point(12, 12);
            this.dgvQueryTester.Name = "dgvQueryTester";
            this.dgvQueryTester.RowHeadersWidth = 51;
            this.dgvQueryTester.RowTemplate.Height = 24;
            this.dgvQueryTester.Size = new System.Drawing.Size(822, 322);
            this.dgvQueryTester.TabIndex = 6;
            // 
            // FrmSQLQueryTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(846, 405);
            this.Controls.Add(this.dgvQueryTester);
            this.Controls.Add(this.lblNumRecords);
            this.Controls.Add(this.lblRecordsReturned);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtQuery);
            this.Name = "FrmSQLQueryTester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Query Tester";
            this.Load += new System.EventHandler(this.FrmSQLQueryTester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryTester)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblRecordsReturned;
        private System.Windows.Forms.Label lblNumRecords;
        private System.Windows.Forms.DataGridView dgvQueryTester;
    }
}

