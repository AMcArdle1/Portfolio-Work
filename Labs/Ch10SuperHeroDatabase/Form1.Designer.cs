
namespace Ch10SuperHeroDatabase
{
    partial class FormSHDB
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
            this.lblSuperheroName = new System.Windows.Forms.Label();
            this.lblLikes = new System.Windows.Forms.Label();
            this.lblDislikes = new System.Windows.Forms.Label();
            this.lblSuperpower = new System.Windows.Forms.Label();
            this.lblLikesResult = new System.Windows.Forms.Label();
            this.lblDislikesResult = new System.Windows.Forms.Label();
            this.lblSuperpowerResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxSH = new System.Windows.Forms.PictureBox();
            this.comboBoxSHName = new System.Windows.Forms.ComboBox();
            this.lblBiographyResult = new System.Windows.Forms.Label();
            this.lblWikiLink = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSuperheroName
            // 
            this.lblSuperheroName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSuperheroName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperheroName.Location = new System.Drawing.Point(15, 97);
            this.lblSuperheroName.Name = "lblSuperheroName";
            this.lblSuperheroName.Size = new System.Drawing.Size(270, 35);
            this.lblSuperheroName.TabIndex = 0;
            this.lblSuperheroName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLikes.Location = new System.Drawing.Point(12, 157);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(53, 18);
            this.lblLikes.TabIndex = 1;
            this.lblLikes.Text = "Likes:";
            // 
            // lblDislikes
            // 
            this.lblDislikes.AutoSize = true;
            this.lblDislikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDislikes.Location = new System.Drawing.Point(12, 209);
            this.lblDislikes.Name = "lblDislikes";
            this.lblDislikes.Size = new System.Drawing.Size(73, 18);
            this.lblDislikes.TabIndex = 2;
            this.lblDislikes.Text = "Dislikes:";
            // 
            // lblSuperpower
            // 
            this.lblSuperpower.AutoSize = true;
            this.lblSuperpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperpower.Location = new System.Drawing.Point(12, 261);
            this.lblSuperpower.Name = "lblSuperpower";
            this.lblSuperpower.Size = new System.Drawing.Size(103, 18);
            this.lblSuperpower.TabIndex = 3;
            this.lblSuperpower.Text = "Superpower:";
            // 
            // lblLikesResult
            // 
            this.lblLikesResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblLikesResult.Location = new System.Drawing.Point(128, 159);
            this.lblLikesResult.Name = "lblLikesResult";
            this.lblLikesResult.Size = new System.Drawing.Size(157, 23);
            this.lblLikesResult.TabIndex = 4;
            // 
            // lblDislikesResult
            // 
            this.lblDislikesResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDislikesResult.Location = new System.Drawing.Point(128, 211);
            this.lblDislikesResult.Name = "lblDislikesResult";
            this.lblDislikesResult.Size = new System.Drawing.Size(157, 23);
            this.lblDislikesResult.TabIndex = 5;
            // 
            // lblSuperpowerResult
            // 
            this.lblSuperpowerResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSuperpowerResult.Location = new System.Drawing.Point(128, 263);
            this.lblSuperpowerResult.Name = "lblSuperpowerResult";
            this.lblSuperpowerResult.Size = new System.Drawing.Size(157, 23);
            this.lblSuperpowerResult.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Biography";
            // 
            // pictureBoxSH
            // 
            this.pictureBoxSH.Location = new System.Drawing.Point(315, 12);
            this.pictureBoxSH.Name = "pictureBoxSH";
            this.pictureBoxSH.Size = new System.Drawing.Size(353, 325);
            this.pictureBoxSH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSH.TabIndex = 8;
            this.pictureBoxSH.TabStop = false;
            // 
            // comboBoxSHName
            // 
            this.comboBoxSHName.FormattingEnabled = true;
            this.comboBoxSHName.Location = new System.Drawing.Point(15, 39);
            this.comboBoxSHName.Name = "comboBoxSHName";
            this.comboBoxSHName.Size = new System.Drawing.Size(270, 24);
            this.comboBoxSHName.TabIndex = 9;
            this.comboBoxSHName.SelectedIndexChanged += new System.EventHandler(this.comboBoxSHName_SelectedIndexChanged);
            // 
            // lblBiographyResult
            // 
            this.lblBiographyResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblBiographyResult.Location = new System.Drawing.Point(12, 378);
            this.lblBiographyResult.Name = "lblBiographyResult";
            this.lblBiographyResult.Size = new System.Drawing.Size(656, 118);
            this.lblBiographyResult.TabIndex = 10;
            // 
            // lblWikiLink
            // 
            this.lblWikiLink.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblWikiLink.Location = new System.Drawing.Point(315, 340);
            this.lblWikiLink.Name = "lblWikiLink";
            this.lblWikiLink.Size = new System.Drawing.Size(353, 23);
            this.lblWikiLink.TabIndex = 11;
            this.lblWikiLink.Text = "label2";
            // 
            // FormSHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 505);
            this.Controls.Add(this.lblWikiLink);
            this.Controls.Add(this.lblBiographyResult);
            this.Controls.Add(this.comboBoxSHName);
            this.Controls.Add(this.pictureBoxSH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSuperpowerResult);
            this.Controls.Add(this.lblDislikesResult);
            this.Controls.Add(this.lblLikesResult);
            this.Controls.Add(this.lblSuperpower);
            this.Controls.Add(this.lblDislikes);
            this.Controls.Add(this.lblLikes);
            this.Controls.Add(this.lblSuperheroName);
            this.Name = "FormSHDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Hero Database";
            this.Activated += new System.EventHandler(this.FormSHDB_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuperheroName;
        private System.Windows.Forms.Label lblLikes;
        private System.Windows.Forms.Label lblDislikes;
        private System.Windows.Forms.Label lblSuperpower;
        private System.Windows.Forms.Label lblLikesResult;
        private System.Windows.Forms.Label lblDislikesResult;
        private System.Windows.Forms.Label lblSuperpowerResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxSH;
        private System.Windows.Forms.ComboBox comboBoxSHName;
        private System.Windows.Forms.Label lblBiographyResult;
        private System.Windows.Forms.Label lblWikiLink;
    }
}

