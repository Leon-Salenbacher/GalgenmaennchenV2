﻿
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
            this.SuspendLayout();
            // 
            // lblFinished
            // 
            this.lblFinished.AutoSize = true;
            this.lblFinished.Location = new System.Drawing.Point(206, 115);
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.Size = new System.Drawing.Size(35, 13);
            this.lblFinished.TabIndex = 0;
            this.lblFinished.Text = "label1";
            // 
            // FinishedOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 250);
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
    }
}