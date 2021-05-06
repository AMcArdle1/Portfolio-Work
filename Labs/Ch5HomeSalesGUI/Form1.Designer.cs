
namespace Ch5HomeSalesGUI
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
            this.txtSaleAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEmpD = new System.Windows.Forms.Button();
            this.btnEmpE = new System.Windows.Forms.Button();
            this.btnEmpF = new System.Windows.Forms.Button();
            this.lblDSales = new System.Windows.Forms.Label();
            this.lblESales = new System.Windows.Forms.Label();
            this.lblFSales = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblMostSales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "How much was the sale?";
            // 
            // txtSaleAmount
            // 
            this.txtSaleAmount.Location = new System.Drawing.Point(15, 29);
            this.txtSaleAmount.Name = "txtSaleAmount";
            this.txtSaleAmount.Size = new System.Drawing.Size(160, 22);
            this.txtSaleAmount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Who made the sale?";
            // 
            // btnEmpD
            // 
            this.btnEmpD.Location = new System.Drawing.Point(15, 86);
            this.btnEmpD.Name = "btnEmpD";
            this.btnEmpD.Size = new System.Drawing.Size(75, 29);
            this.btnEmpD.TabIndex = 3;
            this.btnEmpD.Text = "Danielle";
            this.btnEmpD.UseVisualStyleBackColor = true;
            this.btnEmpD.Click += new System.EventHandler(this.btnEmpD_Click);
            // 
            // btnEmpE
            // 
            this.btnEmpE.Location = new System.Drawing.Point(157, 86);
            this.btnEmpE.Name = "btnEmpE";
            this.btnEmpE.Size = new System.Drawing.Size(75, 29);
            this.btnEmpE.TabIndex = 4;
            this.btnEmpE.Text = "Edward";
            this.btnEmpE.UseVisualStyleBackColor = true;
            this.btnEmpE.Click += new System.EventHandler(this.btnEmpE_Click);
            // 
            // btnEmpF
            // 
            this.btnEmpF.Location = new System.Drawing.Point(292, 86);
            this.btnEmpF.Name = "btnEmpF";
            this.btnEmpF.Size = new System.Drawing.Size(75, 29);
            this.btnEmpF.TabIndex = 5;
            this.btnEmpF.Text = "Francis";
            this.btnEmpF.UseVisualStyleBackColor = true;
            this.btnEmpF.Click += new System.EventHandler(this.btnEmpF_Click);
            // 
            // lblDSales
            // 
            this.lblDSales.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDSales.Location = new System.Drawing.Point(12, 147);
            this.lblDSales.Name = "lblDSales";
            this.lblDSales.Size = new System.Drawing.Size(240, 23);
            this.lblDSales.TabIndex = 6;
            // 
            // lblESales
            // 
            this.lblESales.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblESales.Location = new System.Drawing.Point(12, 182);
            this.lblESales.Name = "lblESales";
            this.lblESales.Size = new System.Drawing.Size(240, 23);
            this.lblESales.TabIndex = 7;
            // 
            // lblFSales
            // 
            this.lblFSales.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblFSales.Location = new System.Drawing.Point(12, 217);
            this.lblFSales.Name = "lblFSales";
            this.lblFSales.Size = new System.Drawing.Size(240, 23);
            this.lblFSales.TabIndex = 8;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalSales.Location = new System.Drawing.Point(12, 253);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(240, 23);
            this.lblTotalSales.TabIndex = 9;
            // 
            // lblMostSales
            // 
            this.lblMostSales.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMostSales.Location = new System.Drawing.Point(12, 305);
            this.lblMostSales.Name = "lblMostSales";
            this.lblMostSales.Size = new System.Drawing.Size(240, 23);
            this.lblMostSales.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 358);
            this.Controls.Add(this.lblMostSales);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.lblFSales);
            this.Controls.Add(this.lblESales);
            this.Controls.Add(this.lblDSales);
            this.Controls.Add(this.btnEmpF);
            this.Controls.Add(this.btnEmpE);
            this.Controls.Add(this.btnEmpD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSaleAmount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaleAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEmpD;
        private System.Windows.Forms.Button btnEmpE;
        private System.Windows.Forms.Button btnEmpF;
        private System.Windows.Forms.Label lblDSales;
        private System.Windows.Forms.Label lblESales;
        private System.Windows.Forms.Label lblFSales;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblMostSales;
    }
}

