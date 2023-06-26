
namespace ColourfulGame
{
    partial class Front
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
            this.buPlay = new System.Windows.Forms.Button();
            this.gbLeng = new System.Windows.Forms.GroupBox();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbUkranian = new System.Windows.Forms.RadioButton();
            this.gbLeng.SuspendLayout();
            this.SuspendLayout();
            // 
            // buPlay
            // 
            this.buPlay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buPlay.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buPlay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buPlay.Location = new System.Drawing.Point(333, 173);
            this.buPlay.Name = "buPlay";
            this.buPlay.Size = new System.Drawing.Size(138, 70);
            this.buPlay.TabIndex = 0;
            this.buPlay.Text = "Play";
            this.buPlay.UseVisualStyleBackColor = false;
            this.buPlay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buPlay_MouseClick);
            // 
            // gbLeng
            // 
            this.gbLeng.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbLeng.Controls.Add(this.rbEnglish);
            this.gbLeng.Controls.Add(this.rbUkranian);
            this.gbLeng.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbLeng.Location = new System.Drawing.Point(12, 12);
            this.gbLeng.Name = "gbLeng";
            this.gbLeng.Size = new System.Drawing.Size(162, 102);
            this.gbLeng.TabIndex = 2;
            this.gbLeng.TabStop = false;
            this.gbLeng.Text = "language :";
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Checked = true;
            this.rbEnglish.Location = new System.Drawing.Point(6, 26);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(77, 24);
            this.rbEnglish.TabIndex = 1;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "English";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // rbUkranian
            // 
            this.rbUkranian.AutoSize = true;
            this.rbUkranian.Location = new System.Drawing.Point(6, 56);
            this.rbUkranian.Name = "rbUkranian";
            this.rbUkranian.Size = new System.Drawing.Size(92, 24);
            this.rbUkranian.TabIndex = 0;
            this.rbUkranian.Text = "Ukrainian";
            this.rbUkranian.UseVisualStyleBackColor = true;
            // 
            // Front
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbLeng);
            this.Controls.Add(this.buPlay);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Front";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColoreGames";
            this.gbLeng.ResumeLayout(false);
            this.gbLeng.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buPlay;
        private System.Windows.Forms.GroupBox gbLeng;
        private System.Windows.Forms.RadioButton rbEnglish;
        public System.Windows.Forms.RadioButton rbUkranian;
    }
}