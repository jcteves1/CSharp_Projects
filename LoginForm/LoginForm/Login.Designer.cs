namespace WindowsFormsApp1
{
    partial class formLogin
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.llbCreateAcc = new System.Windows.Forms.LinkLabel();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.lbUsernameWarning = new System.Windows.Forms.Label();
            this.lbPasswordWarning = new System.Windows.Forms.Label();
            this.cbRemember = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(110, 114);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(70, 16);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(110, 161);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(67, 16);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(198, 111);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(298, 22);
            this.tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(198, 158);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(298, 22);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(224, 41);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(162, 38);
            this.lbWelcome.TabIndex = 4;
            this.lbWelcome.Text = "Welcome";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(421, 256);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(321, 256);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "No Account?";
            // 
            // llbCreateAcc
            // 
            this.llbCreateAcc.AutoSize = true;
            this.llbCreateAcc.Location = new System.Drawing.Point(195, 263);
            this.llbCreateAcc.Name = "llbCreateAcc";
            this.llbCreateAcc.Size = new System.Drawing.Size(98, 16);
            this.llbCreateAcc.TabIndex = 8;
            this.llbCreateAcc.TabStop = true;
            this.llbCreateAcc.Text = "Create Account";
            this.llbCreateAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCreateAcc_LinkClicked);
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Location = new System.Drawing.Point(334, 206);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(62, 20);
            this.cbShow.TabIndex = 9;
            this.cbShow.Text = "Show";
            this.cbShow.UseVisualStyleBackColor = true;
            this.cbShow.CheckedChanged += new System.EventHandler(this.cbShow_CheckedChanged);
            // 
            // lbUsernameWarning
            // 
            this.lbUsernameWarning.AutoSize = true;
            this.lbUsernameWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsernameWarning.ForeColor = System.Drawing.Color.Red;
            this.lbUsernameWarning.Location = new System.Drawing.Point(203, 137);
            this.lbUsernameWarning.Name = "lbUsernameWarning";
            this.lbUsernameWarning.Size = new System.Drawing.Size(114, 15);
            this.lbUsernameWarning.TabIndex = 10;
            this.lbUsernameWarning.Text = "Username Warning";
            // 
            // lbPasswordWarning
            // 
            this.lbPasswordWarning.AutoSize = true;
            this.lbPasswordWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordWarning.ForeColor = System.Drawing.Color.Red;
            this.lbPasswordWarning.Location = new System.Drawing.Point(202, 184);
            this.lbPasswordWarning.Name = "lbPasswordWarning";
            this.lbPasswordWarning.Size = new System.Drawing.Size(110, 15);
            this.lbPasswordWarning.TabIndex = 11;
            this.lbPasswordWarning.Text = "Password Warning";
            // 
            // cbRemember
            // 
            this.cbRemember.AutoSize = true;
            this.cbRemember.Location = new System.Drawing.Point(198, 206);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(119, 20);
            this.cbRemember.TabIndex = 12;
            this.cbRemember.Text = "Remember me";
            this.cbRemember.UseVisualStyleBackColor = true;
            this.cbRemember.CheckedChanged += new System.EventHandler(this.cbRemember_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Login to see Treasure";
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRemember);
            this.Controls.Add(this.lbPasswordWarning);
            this.Controls.Add(this.lbUsernameWarning);
            this.Controls.Add(this.cbShow);
            this.Controls.Add(this.llbCreateAcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.MaximumSize = new System.Drawing.Size(639, 368);
            this.MinimumSize = new System.Drawing.Size(639, 368);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llbCreateAcc;
        private System.Windows.Forms.CheckBox cbShow;
        private System.Windows.Forms.Label lbUsernameWarning;
        private System.Windows.Forms.Label lbPasswordWarning;
        private System.Windows.Forms.CheckBox cbRemember;
        private System.Windows.Forms.Label label2;
    }
}

