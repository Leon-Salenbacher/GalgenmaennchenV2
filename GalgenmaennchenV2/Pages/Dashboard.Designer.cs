
namespace GalgenmaennchenV2.Pages
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.lblHallo = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelHeaderDashboard = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMenuSpiel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelHeaderDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHallo
            // 
            this.lblHallo.AutoSize = true;
            this.lblHallo.Font = new System.Drawing.Font("Calibri", 24F);
            this.lblHallo.Location = new System.Drawing.Point(90, 105);
            this.lblHallo.Name = "lblHallo";
            this.lblHallo.Size = new System.Drawing.Size(83, 39);
            this.lblHallo.TabIndex = 0;
            this.lblHallo.Text = "Hallo";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 24F);
            this.lblUsername.Location = new System.Drawing.Point(161, 105);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(157, 39);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Platzhalter";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(97, 308);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(187, 57);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Spielen";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(427, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 282);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // panelHeaderDashboard
            // 
            this.panelHeaderDashboard.BackColor = System.Drawing.Color.DimGray;
            this.panelHeaderDashboard.Controls.Add(this.button2);
            this.panelHeaderDashboard.Controls.Add(this.btnMenuSpiel);
            this.panelHeaderDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderDashboard.MaximumSize = new System.Drawing.Size(816, 97);
            this.panelHeaderDashboard.MinimumSize = new System.Drawing.Size(816, 45);
            this.panelHeaderDashboard.Name = "panelHeaderDashboard";
            this.panelHeaderDashboard.Size = new System.Drawing.Size(816, 45);
            this.panelHeaderDashboard.TabIndex = 8;
            this.panelHeaderDashboard.MouseEnter += new System.EventHandler(this.panelHeaderEnter);
            this.panelHeaderDashboard.MouseLeave += new System.EventHandler(this.panelHeaderClose);
            this.panelHeaderDashboard.MouseHover += new System.EventHandler(this.panelHeaderHover);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnMenuSpiel
            // 
            this.btnMenuSpiel.Location = new System.Drawing.Point(179, 54);
            this.btnMenuSpiel.Name = "btnMenuSpiel";
            this.btnMenuSpiel.Size = new System.Drawing.Size(119, 28);
            this.btnMenuSpiel.TabIndex = 0;
            this.btnMenuSpiel.Text = "button1";
            this.btnMenuSpiel.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timerHeader);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelHeaderDashboard);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblHallo);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panelHeaderDashboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHallo;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelHeaderDashboard;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMenuSpiel;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}