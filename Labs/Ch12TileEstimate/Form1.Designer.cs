
namespace Ch12TileEstimate
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblRooms = new System.Windows.Forms.Label();
            this.lblRoomsResult = new System.Windows.Forms.Label();
            this.lblTBNResult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.rtxtTotals = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 24);
            this.txtName.TabIndex = 0;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(166, 30);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 24);
            this.txtWidth.TabIndex = 1;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(166, 9);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(50, 18);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(325, 30);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 24);
            this.txtLength.TabIndex = 2;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(325, 9);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(56, 18);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Length:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(464, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Location = new System.Drawing.Point(12, 86);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(62, 18);
            this.lblRooms.TabIndex = 7;
            this.lblRooms.Text = "Rooms:";
            // 
            // lblRoomsResult
            // 
            this.lblRoomsResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblRoomsResult.Location = new System.Drawing.Point(166, 86);
            this.lblRoomsResult.Name = "lblRoomsResult";
            this.lblRoomsResult.Size = new System.Drawing.Size(115, 24);
            this.lblRoomsResult.TabIndex = 8;
            // 
            // lblTBNResult
            // 
            this.lblTBNResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTBNResult.Location = new System.Drawing.Point(166, 138);
            this.lblTBNResult.Name = "lblTBNResult";
            this.lblTBNResult.Size = new System.Drawing.Size(115, 24);
            this.lblTBNResult.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Boxes Needed:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(464, 69);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rtxtTotals
            // 
            this.rtxtTotals.Location = new System.Drawing.Point(15, 176);
            this.rtxtTotals.Name = "rtxtTotals";
            this.rtxtTotals.ReadOnly = true;
            this.rtxtTotals.Size = new System.Drawing.Size(524, 189);
            this.rtxtTotals.TabIndex = 13;
            this.rtxtTotals.TabStop = false;
            this.rtxtTotals.Text = "";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 377);
            this.Controls.Add(this.rtxtTotals);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTBNResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblRoomsResult);
            this.Controls.Add(this.lblRooms);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiling Estimator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.Label lblRoomsResult;
        private System.Windows.Forms.Label lblTBNResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtxtTotals;
    }
}

