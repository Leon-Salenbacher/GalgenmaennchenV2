
namespace GalgenmaennchenV2.Pages
{
    partial class MainPage
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
            this.btnAnmelden = new System.Windows.Forms.Button();
            this.txtNachname = new System.Windows.Forms.TextBox();
            this.lblNachname = new System.Windows.Forms.Label();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.lblVorname = new System.Windows.Forms.Label();
            this.txtboxPasswort = new System.Windows.Forms.TextBox();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAnmelden
            // 
            this.btnAnmelden.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnmelden.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnmelden.Location = new System.Drawing.Point(269, 344);
            this.btnAnmelden.Name = "btnAnmelden";
            this.btnAnmelden.Size = new System.Drawing.Size(277, 60);
            this.btnAnmelden.TabIndex = 4;
            this.btnAnmelden.Text = "Anmelden";
            this.btnAnmelden.UseVisualStyleBackColor = false;
            // 
            // txtNachname
            // 
            this.txtNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNachname.Location = new System.Drawing.Point(269, 192);
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(277, 38);
            this.txtNachname.TabIndex = 7;
            // 
            // lblNachname
            // 
            this.lblNachname.AutoSize = true;
            this.lblNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNachname.Location = new System.Drawing.Point(267, 158);
            this.lblNachname.Name = "lblNachname";
            this.lblNachname.Size = new System.Drawing.Size(145, 31);
            this.lblNachname.TabIndex = 11;
            this.lblNachname.Text = "Nachname";
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswort.Location = new System.Drawing.Point(263, 242);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(127, 31);
            this.lblPasswort.TabIndex = 10;
            this.lblPasswort.Text = "Passwort";
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVorname.Location = new System.Drawing.Point(263, 73);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(123, 31);
            this.lblVorname.TabIndex = 9;
            this.lblVorname.Text = "Vorname";
            // 
            // txtboxPasswort
            // 
            this.txtboxPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPasswort.Location = new System.Drawing.Point(269, 276);
            this.txtboxPasswort.Name = "txtboxPasswort";
            this.txtboxPasswort.Size = new System.Drawing.Size(277, 38);
            this.txtboxPasswort.TabIndex = 8;
            // 
            // txtVorname
            // 
            this.txtVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVorname.Location = new System.Drawing.Point(269, 107);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(277, 38);
            this.txtVorname.TabIndex = 6;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNachname);
            this.Controls.Add(this.lblNachname);
            this.Controls.Add(this.lblPasswort);
            this.Controls.Add(this.lblVorname);
            this.Controls.Add(this.txtboxPasswort);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.btnAnmelden);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnmelden;
        private System.Windows.Forms.TextBox txtNachname;
        private System.Windows.Forms.Label lblNachname;
        private System.Windows.Forms.Label lblPasswort;
        private System.Windows.Forms.Label lblVorname;
        private System.Windows.Forms.TextBox txtboxPasswort;
        private System.Windows.Forms.TextBox txtVorname;
    }
}