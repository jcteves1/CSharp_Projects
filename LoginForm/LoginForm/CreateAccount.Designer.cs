namespace WindowsFormsApp1
{
    partial class formCreateAccount
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.llbLogin = new System.Windows.Forms.LinkLabel();
            this.lbConfirmWarning = new System.Windows.Forms.Label();
            this.lbUsernameWarning = new System.Windows.Forms.Label();
            this.lbPasswordWarning = new System.Windows.Forms.Label();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(177, 103);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(304, 22);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(177, 56);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(304, 22);
            this.tbUsername.TabIndex = 6;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(56, 106);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(67, 16);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(56, 59);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(70, 16);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "Username";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(177, 151);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(304, 22);
            this.tbConfirmPassword.TabIndex = 9;
            this.tbConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Location = new System.Drawing.Point(56, 151);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(115, 16);
            this.lbConfirmPassword.TabIndex = 8;
            this.lbConfirmPassword.Text = "Confirm Password";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(231, 208);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(344, 208);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // llbLogin
            // 
            this.llbLogin.AutoSize = true;
            this.llbLogin.Location = new System.Drawing.Point(93, 215);
            this.llbLogin.Name = "llbLogin";
            this.llbLogin.Size = new System.Drawing.Size(88, 16);
            this.llbLogin.TabIndex = 12;
            this.llbLogin.TabStop = true;
            this.llbLogin.Text = "Back to Login";
            this.llbLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLogin_LinkClicked);
            // 
            // lbConfirmWarning
            // 
            this.lbConfirmWarning.AutoSize = true;
            this.lbConfirmWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmWarning.ForeColor = System.Drawing.Color.Red;
            this.lbConfirmWarning.Location = new System.Drawing.Point(175, 179);
            this.lbConfirmWarning.Name = "lbConfirmWarning";
            this.lbConfirmWarning.Size = new System.Drawing.Size(168, 16);
            this.lbConfirmWarning.TabIndex = 13;
            this.lbConfirmWarning.Text = "Confirm Password Warning";
            // 
            // lbUsernameWarning
            // 
            this.lbUsernameWarning.AutoSize = true;
            this.lbUsernameWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsernameWarning.ForeColor = System.Drawing.Color.Red;
            this.lbUsernameWarning.Location = new System.Drawing.Point(175, 84);
            this.lbUsernameWarning.Name = "lbUsernameWarning";
            this.lbUsernameWarning.Size = new System.Drawing.Size(123, 16);
            this.lbUsernameWarning.TabIndex = 14;
            this.lbUsernameWarning.Text = "Username Warning";
            // 
            // lbPasswordWarning
            // 
            this.lbPasswordWarning.AutoSize = true;
            this.lbPasswordWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordWarning.ForeColor = System.Drawing.Color.Red;
            this.lbPasswordWarning.Location = new System.Drawing.Point(175, 130);
            this.lbPasswordWarning.Name = "lbPasswordWarning";
            this.lbPasswordWarning.Size = new System.Drawing.Size(120, 16);
            this.lbPasswordWarning.TabIndex = 15;
            this.lbPasswordWarning.Text = "Password Warning";
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Location = new System.Drawing.Point(419, 179);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(62, 20);
            this.cbShow.TabIndex = 16;
            this.cbShow.Text = "Show";
            this.cbShow.UseVisualStyleBackColor = true;
            this.cbShow.CheckedChanged += new System.EventHandler(this.cbShow_CheckedChanged);
            // 
            // formCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 268);
            this.Controls.Add(this.cbShow);
            this.Controls.Add(this.lbPasswordWarning);
            this.Controls.Add(this.lbUsernameWarning);
            this.Controls.Add(this.lbConfirmWarning);
            this.Controls.Add(this.llbLogin);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.lbConfirmPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Name = "formCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formCreateAccount_FormClosed);
            this.Load += new System.EventHandler(this.formCreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.LinkLabel llbLogin;
        private System.Windows.Forms.Label lbConfirmWarning;
        private System.Windows.Forms.Label lbUsernameWarning;
        private System.Windows.Forms.Label lbPasswordWarning;
        private System.Windows.Forms.CheckBox cbShow;
    }
}