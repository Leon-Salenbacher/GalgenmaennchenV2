
namespace GalgenmaennchenV2.Pages
{
    partial class FinishedOverlay
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
            this.lblFinished = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFinished
            // 
            this.lblFinished.AutoSize = true;
            this.lblFinished.Location = new System.Drawing.Point(206, 79);
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.Size = new System.Drawing.Size(35, 13);
            this.lblFinished.TabIndex = 0;
            this.lblFinished.Text = "label1";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(189, 162);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(206, 111);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(35, 13);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "label1";
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.Location = new System.Drawing.Point(206, 135);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(35, 13);
            this.lblLose.TabIndex = 3;
            this.lblLose.Text = "label1";
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.Location = new System.Drawing.Point(279, 111);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(35, 13);
            this.lblHighscore.TabIndex = 4;
            this.lblHighscore.Text = "label1";
            // 
            // FinishedOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 250);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblFinished);
            this.Name = "FinishedOverlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinishedOverlay";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FinishedOverlay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFinished;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label lblHighscore;
    }
}