
namespace Ch12FlashCards
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
            this.txtTermEntry = new System.Windows.Forms.TextBox();
            this.btnDefine = new System.Windows.Forms.Button();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.txtDefinitionInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDontKnowYet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "What term do you want me to define?";
            // 
            // txtTermEntry
            // 
            this.txtTermEntry.Location = new System.Drawing.Point(15, 29);
            this.txtTermEntry.Name = "txtTermEntry";
            this.txtTermEntry.Size = new System.Drawing.Size(240, 22);
            this.txtTermEntry.TabIndex = 1;
            // 
            // btnDefine
            // 
            this.btnDefine.Location = new System.Drawing.Point(288, 29);
            this.btnDefine.Name = "btnDefine";
            this.btnDefine.Size = new System.Drawing.Size(75, 23);
            this.btnDefine.TabIndex = 2;
            this.btnDefine.Text = "Define";
            this.btnDefine.UseVisualStyleBackColor = true;
            this.btnDefine.Click += new System.EventHandler(this.btnDefine_Click);
            // 
            // lblDefinition
            // 
            this.lblDefinition.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefinition.Location = new System.Drawing.Point(12, 66);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(468, 99);
            this.lblDefinition.TabIndex = 3;
            // 
            // txtDefinitionInput
            // 
            this.txtDefinitionInput.Location = new System.Drawing.Point(16, 223);
            this.txtDefinitionInput.Name = "txtDefinitionInput";
            this.txtDefinitionInput.Size = new System.Drawing.Size(239, 22);
            this.txtDefinitionInput.TabIndex = 4;
            this.txtDefinitionInput.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(288, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(405, 29);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDontKnowYet
            // 
            this.lblDontKnowYet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDontKnowYet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDontKnowYet.Location = new System.Drawing.Point(12, 177);
            this.lblDontKnowYet.Name = "lblDontKnowYet";
            this.lblDontKnowYet.Size = new System.Drawing.Size(468, 23);
            this.lblDontKnowYet.TabIndex = 7;
            this.lblDontKnowYet.Text = "I Don\'t Know This Term, Please Enter the Defintion";
            this.lblDontKnowYet.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 278);
            this.Controls.Add(this.lblDontKnowYet);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDefinitionInput);
            this.Controls.Add(this.lblDefinition);
            this.Controls.Add(this.btnDefine);
            this.Controls.Add(this.txtTermEntry);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Flash Cards";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTermEntry;
        private System.Windows.Forms.Button btnDefine;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.TextBox txtDefinitionInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDontKnowYet;
    }
}

