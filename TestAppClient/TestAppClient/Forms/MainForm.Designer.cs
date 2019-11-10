namespace TestAppClient.Forms
{
    partial class MainForm
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
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.SignUpButton = new TestAppClient.CustomControls.CustomButton();
            this.LogInButton = new TestAppClient.CustomControls.CustomButton();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(12, 73);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(92, 29);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = "Login: ";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 113);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(142, 29);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password: ";
            // 
            // LoginInput
            // 
            this.LoginInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginInput.Location = new System.Drawing.Point(316, 70);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(304, 34);
            this.LoginInput.TabIndex = 1;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordInput.Location = new System.Drawing.Point(316, 110);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(304, 34);
            this.PasswordInput.TabIndex = 2;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpButton.BackColor = System.Drawing.SystemColors.Control;
            this.SignUpButton.BorderColor = System.Drawing.SystemColors.Highlight;
            this.SignUpButton.BorderWidth = 4F;
            this.SignUpButton.CornerBackColor = System.Drawing.SystemColors.Control;
            this.SignUpButton.CornerRadius = 20;
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.DefBackColor = System.Drawing.SystemColors.Control;
            this.SignUpButton.EnteredBackColor = System.Drawing.Color.LightSkyBlue;
            this.SignUpButton.EnteredBorderWidth = 7F;
            this.SignUpButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SignUpButton.FlatAppearance.BorderSize = 50;
            this.SignUpButton.Location = new System.Drawing.Point(12, 214);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(286, 127);
            this.SignUpButton.Smooth = 20;
            this.SignUpButton.TabIndex = 3;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LogInButton.BackColor = System.Drawing.SystemColors.Control;
            this.LogInButton.BorderColor = System.Drawing.SystemColors.Highlight;
            this.LogInButton.BorderWidth = 4F;
            this.LogInButton.CornerBackColor = System.Drawing.SystemColors.Control;
            this.LogInButton.CornerRadius = 20;
            this.LogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInButton.DefBackColor = System.Drawing.SystemColors.Control;
            this.LogInButton.EnteredBackColor = System.Drawing.Color.LightSkyBlue;
            this.LogInButton.EnteredBorderWidth = 7F;
            this.LogInButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LogInButton.FlatAppearance.BorderSize = 50;
            this.LogInButton.Location = new System.Drawing.Point(316, 214);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(304, 127);
            this.LogInButton.Smooth = 20;
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(632, 353);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.LoginInput);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LogInButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomButton LogInButton;
        private System.Windows.Forms.Timer timer1;
        private CustomControls.CustomButton SignUpButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.TextBox PasswordInput;
    }
}

