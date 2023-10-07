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
    public partial class formLogin : Form
    {
        private bool RememberMe = false;
        private void SaveAccount(string un, string pass)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5VQ1AK2J\\SQLEXPRESS;Initial Catalog=LoginPage;Integrated Security=True");
            con.Open();

            string query =
                "UPDATE rememberme " +
                "SET username = @Username, password = @Password " +
                "WHERE id = 1";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Username", un);
            cmd.Parameters.AddWithValue("@Password", pass);
            cmd.ExecuteNonQuery();
        }
        private void RetrieveAccount()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5VQ1AK2J\\SQLEXPRESS;Initial Catalog=LoginPage;Integrated Security=True");
            con.Open();

            string query =
                "SELECT username, password " +
                "FROM rememberme " +
                "WHERE id = 1";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string username = reader["username"].ToString();
            string password = reader["password"].ToString();
            tbUsername.Text = username;
            tbPassword.Text = password; 
        }
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lbUsernameWarning.Text = "";
            lbPasswordWarning.Text = "";
            bool UsernameValid = true, PasswordValid = true;

            if(tbUsername.Text == "")
            {
                lbUsernameWarning.Text = "Please enter username";
                UsernameValid = false;
            }
            if(tbPassword.Text == "")
            {
                lbPasswordWarning.Text = "Please enter password";
                PasswordValid = false;
            }
            if (!UsernameValid || !PasswordValid) return;


            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5VQ1AK2J\\SQLEXPRESS;Initial Catalog=LoginPage;Integrated Security=True");
            con.Open();

            string query =
            "SELECT COUNT(*) " +
            "FROM accounts " +
            "WHERE username = @Username AND password = @Password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Username", tbUsername.Text);
            cmd.Parameters.AddWithValue("@Password", tbPassword.Text);

            int count = (int)cmd.ExecuteScalar();

            if(count > 0)
            {
                MessageBox.Show(
                    "Login Successful. Click OK to see treasure.", 
                    "Success", 
                    MessageBoxButtons.OK
                    );
                if(RememberMe)
                    SaveAccount(tbUsername.Text, tbPassword.Text );
                formTreasure Treasure = new formTreasure(this);
                Treasure.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Account does not exist.",
                    "Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShow.Checked == true)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            lbUsernameWarning.Text = "";
            lbPasswordWarning.Text = "";
            RetrieveAccount();
        }

        private void llbCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formCreateAccount formCreateAcc = new formCreateAccount(this);
            formCreateAcc.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked == true)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void cbRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRemember.Checked == true)
            {
                RememberMe = true;
            }
            else
            {
                RememberMe = false;
            }
        }
    }
}
