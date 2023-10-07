using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class formCreateAccount : Form
    {
        private formLogin loginForm;

        public formCreateAccount(formLogin loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            lbUsernameWarning.Text = "";
            lbPasswordWarning.Text = "";
            lbConfirmWarning.Text = "";
            bool UsernameValid = true, PasswordValid = true;
            if (tbUsername.Text == "")
            {
                lbUsernameWarning.Text = "Please enter username";
                UsernameValid = false;
            }
            if (tbPassword.Text == "")
            {
                lbPasswordWarning.Text = "Please enter password";
                PasswordValid = false;
            }
            if(tbPassword.Text != tbConfirmPassword.Text)
            {
                lbConfirmWarning.Text = "Password does not match";
                PasswordValid = false;
            }
            if (!UsernameValid || !PasswordValid) return;

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5VQ1AK2J\\SQLEXPRESS;Initial Catalog=LoginPage;Integrated Security=True");
            con.Open();

            string query =
            "INSERT INTO accounts (username, password) " +
            "SELECT @Username, @Password " +
            "WHERE NOT EXISTS (SELECT 1 FROM accounts WHERE username = @Username)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Username", tbUsername.Text);
            cmd.Parameters.AddWithValue("@Password", tbPassword.Text);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected == 1)
            {
                MessageBox.Show(
                    "Account Created.",
                    "Success",
                    MessageBoxButtons.OK
                    );
            }
            else
            {
                MessageBox.Show(
                    "Username already taken.",
                    "Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void formCreateAccount_Load(object sender, EventArgs e)
        {
            lbUsernameWarning.Text = "";
            lbPasswordWarning.Text = "";
            lbConfirmWarning.Text = "";
            
        }

        private void llbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();
            tbConfirmPassword.Clear();
        }

        private void formCreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if (tbUsername.Text.Length < 6)
                lbUsernameWarning.Text = "Username must be at least 6 characters";
            else
                lbUsernameWarning.Text = "";
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked == true)
            {
                tbPassword.UseSystemPasswordChar = false;
                tbConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
                tbConfirmPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
