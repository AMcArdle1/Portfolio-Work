
namespace Ch14_15Photos
{
    partial class FormPhotoShop
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
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.groupBoxFrame = new System.Windows.Forms.GroupBox();
            this.radioButtonFramed = new System.Windows.Forms.RadioButton();
            this.radioButtonMatted = new System.Windows.Forms.RadioButton();
            this.radioButtonUnframed = new System.Windows.Forms.RadioButton();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.radioButtonWhite = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.groupBoxMaterial = new System.Windows.Forms.GroupBox();
            this.radioButtonGold = new System.Windows.Forms.RadioButton();
            this.radioButtonSilver = new System.Windows.Forms.RadioButton();
            this.radioButtonSteel = new System.Windows.Forms.RadioButton();
            this.radioButtonOak = new System.Windows.Forms.RadioButton();
            this.radioButtonPine = new System.Windows.Forms.RadioButton();
            this.groupBoxStyle = new System.Windows.Forms.GroupBox();
            this.radioButtonEclectic = new System.Windows.Forms.RadioButton();
            this.radioButtonVintage = new System.Windows.Forms.RadioButton();
            this.radioButtonAntique = new System.Windows.Forms.RadioButton();
            this.radioButtonModern = new System.Windows.Forms.RadioButton();
            this.radioButtonSimple = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblCostResult = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxFrame.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.groupBoxMaterial.SuspendLayout();
            this.groupBoxStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(12, 9);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(73, 17);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Width (in):";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(91, 9);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(402, 22);
            this.txtWidth.TabIndex = 0;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(91, 50);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(402, 22);
            this.txtHeight.TabIndex = 1;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(12, 50);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(78, 17);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height (in):";
            // 
            // groupBoxFrame
            // 
            this.groupBoxFrame.Controls.Add(this.radioButtonFramed);
            this.groupBoxFrame.Controls.Add(this.radioButtonMatted);
            this.groupBoxFrame.Controls.Add(this.radioButtonUnframed);
            this.groupBoxFrame.Location = new System.Drawing.Point(15, 97);
            this.groupBoxFrame.Name = "groupBoxFrame";
            this.groupBoxFrame.Size = new System.Drawing.Size(478, 109);
            this.groupBoxFrame.TabIndex = 2;
            this.groupBoxFrame.TabStop = false;
            this.groupBoxFrame.Text = "Frame";
            // 
            // radioButtonFramed
            // 
            this.radioButtonFramed.AutoSize = true;
            this.radioButtonFramed.Location = new System.Drawing.Point(6, 75);
            this.radioButtonFramed.Name = "radioButtonFramed";
            this.radioButtonFramed.Size = new System.Drawing.Size(77, 21);
            this.radioButtonFramed.TabIndex = 2;
            this.radioButtonFramed.Text = "Framed";
            this.radioButtonFramed.UseVisualStyleBackColor = true;
            // 
            // radioButtonMatted
            // 
            this.radioButtonMatted.AutoSize = true;
            this.radioButtonMatted.Location = new System.Drawing.Point(6, 48);
            this.radioButtonMatted.Name = "radioButtonMatted";
            this.radioButtonMatted.Size = new System.Drawing.Size(72, 21);
            this.radioButtonMatted.TabIndex = 1;
            this.radioButtonMatted.Text = "Matted";
            this.radioButtonMatted.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnframed
            // 
            this.radioButtonUnframed.AutoSize = true;
            this.radioButtonUnframed.Location = new System.Drawing.Point(6, 21);
            this.radioButtonUnframed.Name = "radioButtonUnframed";
            this.radioButtonUnframed.Size = new System.Drawing.Size(91, 21);
            this.radioButtonUnframed.TabIndex = 0;
            this.radioButtonUnframed.Text = "Unframed";
            this.radioButtonUnframed.UseVisualStyleBackColor = true;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.radioButtonWhite);
            this.groupBoxColor.Controls.Add(this.radioButtonBlue);
            this.groupBoxColor.Controls.Add(this.radioButtonGreen);
            this.groupBoxColor.Controls.Add(this.radioButtonRed);
            this.groupBoxColor.Controls.Add(this.radioButtonBlack);
            this.groupBoxColor.Location = new System.Drawing.Point(15, 212);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(135, 160);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color";
            // 
            // radioButtonWhite
            // 
            this.radioButtonWhite.AutoSize = true;
            this.radioButtonWhite.Location = new System.Drawing.Point(19, 129);
            this.radioButtonWhite.Name = "radioButtonWhite";
            this.radioButtonWhite.Size = new System.Drawing.Size(65, 21);
            this.radioButtonWhite.TabIndex = 4;
            this.radioButtonWhite.Text = "White";
            this.radioButtonWhite.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(19, 102);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(57, 21);
            this.radioButtonBlue.TabIndex = 3;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(19, 75);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(69, 21);
            this.radioButtonGreen.TabIndex = 2;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(19, 48);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(55, 21);
            this.radioButtonRed.TabIndex = 1;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlack
            // 
            this.radioButtonBlack.AutoSize = true;
            this.radioButtonBlack.Location = new System.Drawing.Point(19, 21);
            this.radioButtonBlack.Name = "radioButtonBlack";
            this.radioButtonBlack.Size = new System.Drawing.Size(63, 21);
            this.radioButtonBlack.TabIndex = 0;
            this.radioButtonBlack.Text = "Black";
            this.radioButtonBlack.UseVisualStyleBackColor = true;
            // 
            // groupBoxMaterial
            // 
            this.groupBoxMaterial.Controls.Add(this.radioButtonGold);
            this.groupBoxMaterial.Controls.Add(this.radioButtonSilver);
            this.groupBoxMaterial.Controls.Add(this.radioButtonSteel);
            this.groupBoxMaterial.Controls.Add(this.radioButtonOak);
            this.groupBoxMaterial.Controls.Add(this.radioButtonPine);
            this.groupBoxMaterial.Location = new System.Drawing.Point(185, 212);
            this.groupBoxMaterial.Name = "groupBoxMaterial";
            this.groupBoxMaterial.Size = new System.Drawing.Size(135, 160);
            this.groupBoxMaterial.TabIndex = 4;
            this.groupBoxMaterial.TabStop = false;
            this.groupBoxMaterial.Text = "Material";
            // 
            // radioButtonGold
            // 
            this.radioButtonGold.AutoSize = true;
            this.radioButtonGold.Location = new System.Drawing.Point(17, 129);
            this.radioButtonGold.Name = "radioButtonGold";
            this.radioButtonGold.Size = new System.Drawing.Size(59, 21);
            this.radioButtonGold.TabIndex = 4;
            this.radioButtonGold.Text = "Gold";
            this.radioButtonGold.UseVisualStyleBackColor = true;
            // 
            // radioButtonSilver
            // 
            this.radioButtonSilver.AutoSize = true;
            this.radioButtonSilver.Location = new System.Drawing.Point(17, 102);
            this.radioButtonSilver.Name = "radioButtonSilver";
            this.radioButtonSilver.Size = new System.Drawing.Size(64, 21);
            this.radioButtonSilver.TabIndex = 3;
            this.radioButtonSilver.Text = "Silver";
            this.radioButtonSilver.UseVisualStyleBackColor = true;
            // 
            // radioButtonSteel
            // 
            this.radioButtonSteel.AutoSize = true;
            this.radioButtonSteel.Location = new System.Drawing.Point(17, 75);
            this.radioButtonSteel.Name = "radioButtonSteel";
            this.radioButtonSteel.Size = new System.Drawing.Size(61, 21);
            this.radioButtonSteel.TabIndex = 2;
            this.radioButtonSteel.Text = "Steel";
            this.radioButtonSteel.UseVisualStyleBackColor = true;
            // 
            // radioButtonOak
            // 
            this.radioButtonOak.AutoSize = true;
            this.radioButtonOak.Location = new System.Drawing.Point(17, 48);
            this.radioButtonOak.Name = "radioButtonOak";
            this.radioButtonOak.Size = new System.Drawing.Size(55, 21);
            this.radioButtonOak.TabIndex = 1;
            this.radioButtonOak.Text = "Oak";
            this.radioButtonOak.UseVisualStyleBackColor = true;
            // 
            // radioButtonPine
            // 
            this.radioButtonPine.AutoSize = true;
            this.radioButtonPine.Location = new System.Drawing.Point(17, 21);
            this.radioButtonPine.Name = "radioButtonPine";
            this.radioButtonPine.Size = new System.Drawing.Size(57, 21);
            this.radioButtonPine.TabIndex = 0;
            this.radioButtonPine.Text = "Pine";
            this.radioButtonPine.UseVisualStyleBackColor = true;
            // 
            // groupBoxStyle
            // 
            this.groupBoxStyle.Controls.Add(this.radioButtonEclectic);
            this.groupBoxStyle.Controls.Add(this.radioButtonVintage);
            this.groupBoxStyle.Controls.Add(this.radioButtonAntique);
            this.groupBoxStyle.Controls.Add(this.radioButtonModern);
            this.groupBoxStyle.Controls.Add(this.radioButtonSimple);
            this.groupBoxStyle.Location = new System.Drawing.Point(358, 212);
            this.groupBoxStyle.Name = "groupBoxStyle";
            this.groupBoxStyle.Size = new System.Drawing.Size(135, 160);
            this.groupBoxStyle.TabIndex = 5;
            this.groupBoxStyle.TabStop = false;
            this.groupBoxStyle.Text = "Style";
            // 
            // radioButtonEclectic
            // 
            this.radioButtonEclectic.AutoSize = true;
            this.radioButtonEclectic.Location = new System.Drawing.Point(11, 129);
            this.radioButtonEclectic.Name = "radioButtonEclectic";
            this.radioButtonEclectic.Size = new System.Drawing.Size(77, 21);
            this.radioButtonEclectic.TabIndex = 4;
            this.radioButtonEclectic.Text = "Eclectic";
            this.radioButtonEclectic.UseVisualStyleBackColor = true;
            // 
            // radioButtonVintage
            // 
            this.radioButtonVintage.AutoSize = true;
            this.radioButtonVintage.Location = new System.Drawing.Point(11, 102);
            this.radioButtonVintage.Name = "radioButtonVintage";
            this.radioButtonVintage.Size = new System.Drawing.Size(77, 21);
            this.radioButtonVintage.TabIndex = 3;
            this.radioButtonVintage.Text = "Vintage";
            this.radioButtonVintage.UseVisualStyleBackColor = true;
            // 
            // radioButtonAntique
            // 
            this.radioButtonAntique.AutoSize = true;
            this.radioButtonAntique.Location = new System.Drawing.Point(11, 75);
            this.radioButtonAntique.Name = "radioButtonAntique";
            this.radioButtonAntique.Size = new System.Drawing.Size(77, 21);
            this.radioButtonAntique.TabIndex = 2;
            this.radioButtonAntique.Text = "Antique";
            this.radioButtonAntique.UseVisualStyleBackColor = true;
            // 
            // radioButtonModern
            // 
            this.radioButtonModern.AutoSize = true;
            this.radioButtonModern.Location = new System.Drawing.Point(11, 48);
            this.radioButtonModern.Name = "radioButtonModern";
            this.radioButtonModern.Size = new System.Drawing.Size(77, 21);
            this.radioButtonModern.TabIndex = 1;
            this.radioButtonModern.Text = "Modern";
            this.radioButtonModern.UseVisualStyleBackColor = true;
            // 
            // radioButtonSimple
            // 
            this.radioButtonSimple.AutoSize = true;
            this.radioButtonSimple.Location = new System.Drawing.Point(11, 21);
            this.radioButtonSimple.Name = "radioButtonSimple";
            this.radioButtonSimple.Size = new System.Drawing.Size(71, 21);
            this.radioButtonSimple.TabIndex = 0;
            this.radioButtonSimple.Text = "Simple";
            this.radioButtonSimple.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(15, 391);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(97, 28);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(250, 390);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(64, 25);
            this.lblCost.TabIndex = 8;
            this.lblCost.Text = "Cost:";
            // 
            // lblCostResult
            // 
            this.lblCostResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCostResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostResult.Location = new System.Drawing.Point(320, 390);
            this.lblCostResult.Name = "lblCostResult";
            this.lblCostResult.Size = new System.Drawing.Size(173, 25);
            this.lblCostResult.TabIndex = 9;
            // 
            // lblResults
            // 
            this.lblResults.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(12, 431);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(481, 23);
            this.lblResults.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(134, 391);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 28);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormPhotoShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 467);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblCostResult);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBoxStyle);
            this.Controls.Add(this.groupBoxMaterial);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxFrame);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblWidth);
            this.Name = "FormPhotoShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photoshop";
            this.groupBoxFrame.ResumeLayout(false);
            this.groupBoxFrame.PerformLayout();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.groupBoxMaterial.ResumeLayout(false);
            this.groupBoxMaterial.PerformLayout();
            this.groupBoxStyle.ResumeLayout(false);
            this.groupBoxStyle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.GroupBox groupBoxFrame;
        private System.Windows.Forms.RadioButton radioButtonFramed;
        private System.Windows.Forms.RadioButton radioButtonMatted;
        private System.Windows.Forms.RadioButton radioButtonUnframed;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.RadioButton radioButtonWhite;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonBlack;
        private System.Windows.Forms.GroupBox groupBoxMaterial;
        private System.Windows.Forms.RadioButton radioButtonGold;
        private System.Windows.Forms.RadioButton radioButtonSilver;
        private System.Windows.Forms.RadioButton radioButtonSteel;
        private System.Windows.Forms.RadioButton radioButtonOak;
        private System.Windows.Forms.RadioButton radioButtonPine;
        private System.Windows.Forms.GroupBox groupBoxStyle;
        private System.Windows.Forms.RadioButton radioButtonEclectic;
        private System.Windows.Forms.RadioButton radioButtonVintage;
        private System.Windows.Forms.RadioButton radioButtonAntique;
        private System.Windows.Forms.RadioButton radioButtonModern;
        private System.Windows.Forms.RadioButton radioButtonSimple;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblCostResult;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnClear;
    }
}

