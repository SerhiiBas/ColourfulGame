
namespace ColourfulGame
{
    partial class ColoreGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTextForUser = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbScoreInfo = new System.Windows.Forms.Label();
            this.lbWinScore = new System.Windows.Forms.Label();
            this.lbLoseScore = new System.Windows.Forms.Label();
            this.lbScoreInfo2 = new System.Windows.Forms.Label();
            this.lbSco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lbTextForUser
            // 
            this.lbTextForUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTextForUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTextForUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTextForUser.Location = new System.Drawing.Point(277, 159);
            this.lbTextForUser.Name = "lbTextForUser";
            this.lbTextForUser.Size = new System.Drawing.Size(249, 71);
            this.lbTextForUser.TabIndex = 0;
            this.lbTextForUser.Text = "Text";
            this.lbTextForUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbScore.Location = new System.Drawing.Point(12, 53);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(55, 20);
            this.lbScore.TabIndex = 1;
            this.lbScore.Text = "score : ";
            // 
            // lbScoreInfo
            // 
            this.lbScoreInfo.AutoSize = true;
            this.lbScoreInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbScoreInfo.Location = new System.Drawing.Point(24, 13);
            this.lbScoreInfo.Name = "lbScoreInfo";
            this.lbScoreInfo.Size = new System.Drawing.Size(43, 20);
            this.lbScoreInfo.TabIndex = 3;
            this.lbScoreInfo.Text = "win : ";
            // 
            // lbWinScore
            // 
            this.lbWinScore.AutoSize = true;
            this.lbWinScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbWinScore.Location = new System.Drawing.Point(61, 13);
            this.lbWinScore.Name = "lbWinScore";
            this.lbWinScore.Size = new System.Drawing.Size(25, 20);
            this.lbWinScore.TabIndex = 4;
            this.lbWinScore.Text = "10";
            // 
            // lbLoseScore
            // 
            this.lbLoseScore.AutoSize = true;
            this.lbLoseScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbLoseScore.Location = new System.Drawing.Point(55, 33);
            this.lbLoseScore.Name = "lbLoseScore";
            this.lbLoseScore.Size = new System.Drawing.Size(31, 20);
            this.lbLoseScore.TabIndex = 5;
            this.lbLoseScore.Text = "-10";
            // 
            // lbScoreInfo2
            // 
            this.lbScoreInfo2.AutoSize = true;
            this.lbScoreInfo2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbScoreInfo2.Location = new System.Drawing.Point(20, 33);
            this.lbScoreInfo2.Name = "lbScoreInfo2";
            this.lbScoreInfo2.Size = new System.Drawing.Size(47, 20);
            this.lbScoreInfo2.TabIndex = 6;
            this.lbScoreInfo2.Text = "lose : ";
            // 
            // lbSco
            // 
            this.lbSco.AutoSize = true;
            this.lbSco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSco.Location = new System.Drawing.Point(61, 53);
            this.lbSco.Name = "lbSco";
            this.lbSco.Size = new System.Drawing.Size(17, 20);
            this.lbSco.TabIndex = 7;
            this.lbSco.Text = "5";
            // 
            // ColoreGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSco);
            this.Controls.Add(this.lbScoreInfo2);
            this.Controls.Add(this.lbLoseScore);
            this.Controls.Add(this.lbWinScore);
            this.Controls.Add(this.lbScoreInfo);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbTextForUser);
            this.Name = "ColoreGame";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColoreGame";
            this.Click += new System.EventHandler(this.ColoreGame_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbTextForUser;
        public System.Windows.Forms.Label lbScore;
        public System.Windows.Forms.Label lbScoreInfo;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lbWinScore;
        public System.Windows.Forms.Label lbLoseScore;
        public System.Windows.Forms.Label lbScoreInfo2;
        public System.Windows.Forms.Label lbSco;
    }
}

