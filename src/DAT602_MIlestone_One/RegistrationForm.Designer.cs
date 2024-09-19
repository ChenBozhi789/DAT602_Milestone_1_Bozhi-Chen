﻿namespace DAT602_MIlestone_One
{
    partial class RegistrationForm
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
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRepwd = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblReenterpwd = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lbGamename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(100, 238);
            this.txtPwd.Multiline = true;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(206, 30);
            this.txtPwd.TabIndex = 19;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(100, 106);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(206, 30);
            this.txtUsername.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 172);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 30);
            this.txtEmail.TabIndex = 17;
            // 
            // txtRepwd
            // 
            this.txtRepwd.Location = new System.Drawing.Point(100, 304);
            this.txtRepwd.Multiline = true;
            this.txtRepwd.Name = "txtRepwd";
            this.txtRepwd.PasswordChar = '*';
            this.txtRepwd.Size = new System.Drawing.Size(206, 30);
            this.txtRepwd.TabIndex = 16;
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = true;
            this.btnRegister.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegister.Location = new System.Drawing.Point(150, 353);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(112, 38);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(96, 142);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 29);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // lblReenterpwd
            // 
            this.lblReenterpwd.AutoSize = true;
            this.lblReenterpwd.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblReenterpwd.Location = new System.Drawing.Point(96, 274);
            this.lblReenterpwd.Name = "lblReenterpwd";
            this.lblReenterpwd.Size = new System.Drawing.Size(203, 29);
            this.lblReenterpwd.TabIndex = 13;
            this.lblReenterpwd.Text = "Re-enter Password";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(96, 208);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(111, 29);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(96, 76);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(117, 29);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Username";
            // 
            // lbGamename
            // 
            this.lbGamename.AutoSize = true;
            this.lbGamename.Font = new System.Drawing.Font("Calibri", 20F);
            this.lbGamename.Location = new System.Drawing.Point(24, 32);
            this.lbGamename.Name = "lbGamename";
            this.lbGamename.Size = new System.Drawing.Size(368, 41);
            this.lbGamename.TabIndex = 10;
            this.lbGamename.Text = "Treasure Hunt Adventure";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 410);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRepwd);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblReenterpwd);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lbGamename);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRepwd;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblReenterpwd;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lbGamename;
    }
}