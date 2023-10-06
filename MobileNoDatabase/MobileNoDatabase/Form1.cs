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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool name_valid = true, mb_no_valid = true;
            if(tbName.Text.Length == 0)
            {
                lbNameWarning.Text = "Name cannot be empty";
                name_valid = false;
            }
            if (tbMobileNo.Text.Length == 0)
            {
                lbMobileNoWarning.Text = "Mobile Number cannot be empty.";
                mb_no_valid = false;
            }
            else if (tbMobileNo.Text.Length != 11)
            {
                lbMobileNoWarning.Text = "Mobile Number should be 11 digits.";
                mb_no_valid = false;
            }
            else if (tbMobileNo.Text.Substring(0, 2) != "09")
            {
                lbMobileNoWarning.Text = "Invalid Mobile Number.";
                mb_no_valid = false;
            }
            else if (!tbMobileNo.Text.All(char.IsDigit))
            {
                lbMobileNoWarning.Text = "Mobile Number must be composed of digits.";
                mb_no_valid = false;
            }
            if (name_valid)
                lbNameWarning.Text = "";
            if (mb_no_valid)
                lbMobileNoWarning.Text = "";
            if (!name_valid || !mb_no_valid)
                return;

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5VQ1AK2J\\SQLEXPRESS;Initial Catalog=MobileNoDatabase;Integrated Security=True");
            con.Open();

            string query = 
            "INSERT INTO person_number (name, mobile_no) " +
            "SELECT @Name, @MobileNo " +
            "WHERE NOT EXISTS (SELECT 1 FROM person_number WHERE mobile_no = @MobileNo)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", tbName.Text);
            cmd.Parameters.AddWithValue("@MobileNo", tbMobileNo.Text);
            
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected == 1 )
            {
                MessageBox.Show("Mobile Number Saved Succesfully!");
            }
            else
            {
                MessageBox.Show("Mobile Number already exists.");
            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbMobileNoWarning.Text = "";
            lbNameWarning.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbMobileNo.Text = "";
        }
    }
}
