
namespace ColourfulGame
{
    partial class Level
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
            this.buEasy = new System.Windows.Forms.Button();
            this.buHard = new System.Windows.Forms.Button();
            this.buMiddle = new System.Windows.Forms.Button();
            this.lbLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buEasy
            // 
            this.buEasy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buEasy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buEasy.Location = new System.Drawing.Point(359, 167);
            this.buEasy.Name = "buEasy";
            this.buEasy.Size = new System.Drawing.Size(94, 29);
            this.buEasy.TabIndex = 0;
            this.buEasy.Text = "Easy";
            this.buEasy.UseVisualStyleBackColor = false;
            this.buEasy.Click += new System.EventHandler(this.buEasy_Click);
            // 
            // buHard
            // 
            this.buHard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buHard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buHard.Location = new System.Drawing.Point(359, 276);
            this.buHard.Name = "buHard";
            this.buHard.Size = new System.Drawing.Size(94, 29);
            this.buHard.TabIndex = 2;
            this.buHard.Text = "Hard";
            this.buHard.UseVisualStyleBackColor = false;
            this.buHard.Click += new System.EventHandler(this.buHard_Click);
            // 
            // buMiddle
            // 
            this.buMiddle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buMiddle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buMiddle.Location = new System.Drawing.Point(359, 220);
            this.buMiddle.Name = "buMiddle";
            this.buMiddle.Size = new System.Drawing.Size(94, 29);
            this.buMiddle.TabIndex = 3;
            this.buMiddle.Text = "Middle";
            this.buMiddle.UseVisualStyleBackColor = false;
            this.buMiddle.Click += new System.EventHandler(this.buMiddle_Click);
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbLevel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbLevel.Location = new System.Drawing.Point(359, 73);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(104, 50);
            this.lbLevel.TabIndex = 4;
            this.lbLevel.Text = "Level";
            // 
            // Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.buMiddle);
            this.Controls.Add(this.buHard);
            this.Controls.Add(this.buEasy);
            this.Name = "Level";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buEasy;
        private System.Windows.Forms.Button buHard;
        private System.Windows.Forms.Button buMiddle;
        private System.Windows.Forms.Label lbLevel;
    }
}