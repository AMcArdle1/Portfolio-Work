
namespace Ch8GameDatabase
{
    partial class FormGameBreak
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblNameResult = new System.Windows.Forms.Label();
            this.lblPublisherResult = new System.Windows.Forms.Label();
            this.lblPriceResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(255, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItem.Location = new System.Drawing.Point(12, 12);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(237, 24);
            this.txtSearchItem.TabIndex = 0;
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
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 123);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(12, 91);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(71, 17);
            this.lblPublisher.TabIndex = 4;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblNameResult
            // 
            this.lblNameResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNameResult.Location = new System.Drawing.Point(149, 60);
            this.lblNameResult.Name = "lblNameResult";
            this.lblNameResult.Size = new System.Drawing.Size(181, 23);
            this.lblNameResult.TabIndex = 5;
            // 
            // lblPublisherResult
            // 
            this.lblPublisherResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPublisherResult.Location = new System.Drawing.Point(149, 91);
            this.lblPublisherResult.Name = "lblPublisherResult";
            this.lblPublisherResult.Size = new System.Drawing.Size(181, 23);
            this.lblPublisherResult.TabIndex = 6;
            // 
            // lblPriceResult
            // 
            this.lblPriceResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPriceResult.Location = new System.Drawing.Point(149, 123);
            this.lblPriceResult.Name = "lblPriceResult";
            this.lblPriceResult.Size = new System.Drawing.Size(181, 23);
            this.lblPriceResult.TabIndex = 7;
            // 
            // FormGameBreak
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 149);
            this.Controls.Add(this.lblPriceResult);
            this.Controls.Add(this.lblPublisherResult);
            this.Controls.Add(this.lblNameResult);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSearchItem);
            this.Controls.Add(this.btnSearch);
            this.Name = "FormGameBreak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameBreak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblNameResult;
        private System.Windows.Forms.Label lblPublisherResult;
        private System.Windows.Forms.Label lblPriceResult;
    }
}

