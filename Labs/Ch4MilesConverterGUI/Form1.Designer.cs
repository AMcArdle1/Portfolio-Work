
namespace Ch4MilesConverterGUI
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
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.btnKilo = new System.Windows.Forms.Button();
            this.btnMiles = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distance in miles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distance in kilometers";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(12, 29);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(128, 22);
            this.txtMiles.TabIndex = 2;
            // 
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(219, 29);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(128, 22);
            this.txtKilos.TabIndex = 3;
            // 
            // btnKilo
            // 
            this.btnKilo.Location = new System.Drawing.Point(12, 66);
            this.btnKilo.Name = "btnKilo";
            this.btnKilo.Size = new System.Drawing.Size(128, 26);
            this.btnKilo.TabIndex = 4;
            this.btnKilo.Text = "Convert to km";
            this.btnKilo.UseVisualStyleBackColor = true;
            this.btnKilo.Click += new System.EventHandler(this.btnKilo_Click);
            // 
            // btnMiles
            // 
            this.btnMiles.Location = new System.Drawing.Point(219, 66);
            this.btnMiles.Name = "btnMiles";
            this.btnMiles.Size = new System.Drawing.Size(128, 26);
            this.btnMiles.TabIndex = 5;
            this.btnMiles.Text = "Convert to miles";
            this.btnMiles.UseVisualStyleBackColor = true;
            this.btnMiles.Click += new System.EventHandler(this.btnMiles_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAnswer.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAnswer.Location = new System.Drawing.Point(12, 111);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(208, 22);
            this.txtAnswer.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 148);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnMiles);
            this.Controls.Add(this.btnKilo);
            this.Controls.Add(this.txtKilos);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Distance Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.Button btnKilo;
        private System.Windows.Forms.Button btnMiles;
        private System.Windows.Forms.TextBox txtAnswer;
    }
}

