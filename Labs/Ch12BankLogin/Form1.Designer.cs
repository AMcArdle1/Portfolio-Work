
namespace Ch12BankLogin
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
            this.lblAccountNumberHeader = new System.Windows.Forms.Label();
            this.txtAccountNumberEntry = new System.Windows.Forms.TextBox();
            this.txtPinNumberEntry = new System.Windows.Forms.TextBox();
            this.lblPinNumberHeader = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblDepositHeader = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtWithdrawel = new System.Windows.Forms.TextBox();
            this.lblWithdrawelHeader = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdrawel = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.rtxtLoginInformation = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblAccountNumberHeader
            // 
            this.lblAccountNumberHeader.AutoSize = true;
            this.lblAccountNumberHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumberHeader.Location = new System.Drawing.Point(14, 10);
            this.lblAccountNumberHeader.Name = "lblAccountNumberHeader";
            this.lblAccountNumberHeader.Size = new System.Drawing.Size(78, 18);
            this.lblAccountNumberHeader.TabIndex = 0;
            this.lblAccountNumberHeader.Text = "Account #:";
            // 
            // txtAccountNumberEntry
            // 
            this.txtAccountNumberEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumberEntry.Location = new System.Drawing.Point(120, 7);
            this.txtAccountNumberEntry.Name = "txtAccountNumberEntry";
            this.txtAccountNumberEntry.Size = new System.Drawing.Size(181, 24);
            this.txtAccountNumberEntry.TabIndex = 0;
            // 
            // txtPinNumberEntry
            // 
            this.txtPinNumberEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinNumberEntry.Location = new System.Drawing.Point(120, 48);
            this.txtPinNumberEntry.Name = "txtPinNumberEntry";
            this.txtPinNumberEntry.Size = new System.Drawing.Size(181, 24);
            this.txtPinNumberEntry.TabIndex = 1;
            // 
            // lblPinNumberHeader
            // 
            this.lblPinNumberHeader.AutoSize = true;
            this.lblPinNumberHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinNumberHeader.Location = new System.Drawing.Point(14, 52);
            this.lblPinNumberHeader.Name = "lblPinNumberHeader";
            this.lblPinNumberHeader.Size = new System.Drawing.Size(49, 18);
            this.lblPinNumberHeader.TabIndex = 2;
            this.lblPinNumberHeader.Text = "Pin #: ";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(345, 24);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 34);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblDepositHeader
            // 
            this.lblDepositHeader.AutoSize = true;
            this.lblDepositHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositHeader.Location = new System.Drawing.Point(15, 278);
            this.lblDepositHeader.Name = "lblDepositHeader";
            this.lblDepositHeader.Size = new System.Drawing.Size(235, 18);
            this.lblDepositHeader.TabIndex = 6;
            this.lblDepositHeader.Text = "Would you like to make a deposit?";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(18, 300);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(182, 24);
            this.txtDeposit.TabIndex = 3;
            // 
            // txtWithdrawel
            // 
            this.txtWithdrawel.Location = new System.Drawing.Point(18, 387);
            this.txtWithdrawel.Name = "txtWithdrawel";
            this.txtWithdrawel.Size = new System.Drawing.Size(182, 24);
            this.txtWithdrawel.TabIndex = 5;
            // 
            // lblWithdrawelHeader
            // 
            this.lblWithdrawelHeader.AutoSize = true;
            this.lblWithdrawelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawelHeader.Location = new System.Drawing.Point(15, 364);
            this.lblWithdrawelHeader.Name = "lblWithdrawelHeader";
            this.lblWithdrawelHeader.Size = new System.Drawing.Size(256, 18);
            this.lblWithdrawelHeader.TabIndex = 8;
            this.lblWithdrawelHeader.Text = "Would you like to make a withdrawel?";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Enabled = false;
            this.btnDeposit.Location = new System.Drawing.Point(345, 294);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(101, 38);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdrawel
            // 
            this.btnWithdrawel.Enabled = false;
            this.btnWithdrawel.Location = new System.Drawing.Point(345, 380);
            this.btnWithdrawel.Name = "btnWithdrawel";
            this.btnWithdrawel.Size = new System.Drawing.Size(101, 38);
            this.btnWithdrawel.TabIndex = 6;
            this.btnWithdrawel.Text = "Withdrawel";
            this.btnWithdrawel.UseVisualStyleBackColor = true;
            this.btnWithdrawel.Click += new System.EventHandler(this.btnWithdrawel_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Enabled = false;
            this.btnLogout.Location = new System.Drawing.Point(197, 445);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(91, 37);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // rtxtLoginInformation
            // 
            this.rtxtLoginInformation.Location = new System.Drawing.Point(17, 78);
            this.rtxtLoginInformation.Name = "rtxtLoginInformation";
            this.rtxtLoginInformation.Size = new System.Drawing.Size(454, 184);
            this.rtxtLoginInformation.TabIndex = 9;
            this.rtxtLoginInformation.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 506);
            this.Controls.Add(this.rtxtLoginInformation);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnWithdrawel);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtWithdrawel);
            this.Controls.Add(this.lblWithdrawelHeader);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.lblDepositHeader);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPinNumberEntry);
            this.Controls.Add(this.lblPinNumberHeader);
            this.Controls.Add(this.txtAccountNumberEntry);
            this.Controls.Add(this.lblAccountNumberHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weyland Bank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountNumberHeader;
        private System.Windows.Forms.TextBox txtAccountNumberEntry;
        private System.Windows.Forms.TextBox txtPinNumberEntry;
        private System.Windows.Forms.Label lblPinNumberHeader;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblDepositHeader;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox txtWithdrawel;
        private System.Windows.Forms.Label lblWithdrawelHeader;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdrawel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.RichTextBox rtxtLoginInformation;
    }
}

