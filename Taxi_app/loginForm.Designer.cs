namespace Taxi_app
{
    partial class Login
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
            this.exitButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Label();
            this.userTextbox = new System.Windows.Forms.TextBox();
            this.Passw = new System.Windows.Forms.Label();
            this.passwTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exitButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.Location = new System.Drawing.Point(82, 505);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(315, 50);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.loginButton.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.loginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginButton.Location = new System.Drawing.Point(82, 437);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(315, 47);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.User.Font = new System.Drawing.Font("Cambria Math", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.Yellow;
            this.User.Location = new System.Drawing.Point(79, 185);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(86, 106);
            this.User.TabIndex = 2;
            this.User.Text = "User";
            this.User.Click += new System.EventHandler(this.label1_Click);
            // 
            // userTextbox
            // 
            this.userTextbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.userTextbox.Font = new System.Drawing.Font("Cambria Math", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextbox.Location = new System.Drawing.Point(185, 225);
            this.userTextbox.Name = "userTextbox";
            this.userTextbox.Size = new System.Drawing.Size(212, 30);
            this.userTextbox.TabIndex = 4;
            // 
            // Passw
            // 
            this.Passw.AutoSize = true;
            this.Passw.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Passw.Font = new System.Drawing.Font("Cambria Math", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passw.ForeColor = System.Drawing.Color.Yellow;
            this.Passw.Location = new System.Drawing.Point(79, 270);
            this.Passw.Name = "Passw";
            this.Passw.Size = new System.Drawing.Size(101, 106);
            this.Passw.TabIndex = 5;
            this.Passw.Text = "Passw";
            // 
            // passwTextbox
            // 
            this.passwTextbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.passwTextbox.Font = new System.Drawing.Font("Cambria Math", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwTextbox.Location = new System.Drawing.Point(185, 304);
            this.passwTextbox.Name = "passwTextbox";
            this.passwTextbox.Size = new System.Drawing.Size(212, 30);
            this.passwTextbox.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(471, 664);
            this.Controls.Add(this.passwTextbox);
            this.Controls.Add(this.Passw);
            this.Controls.Add(this.userTextbox);
            this.Controls.Add(this.User);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Login";
            this.Text = "TAXI";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.TextBox userTextbox;
        private System.Windows.Forms.Label Passw;
        private System.Windows.Forms.TextBox passwTextbox;
    }
}

