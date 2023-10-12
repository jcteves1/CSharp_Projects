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

namespace Dictionary
{
    public partial class formAddWord : Form
    {
        private string lbWordFormat_default;
        private string tbDefFormat_default;
        private string connection_string = "Data Source=LAPTOP-5VQ1AK2J\\SQLEXPRESS;Initial Catalog=Dictionary;Integrated Security=True";
        private formDictionary home;
        public formAddWord(formDictionary home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void formAddWord_Load(object sender, EventArgs e)
        {
            lbAddWordWarning.Text = "";
            lbAddDefWarning.Text = "";
            lbWordFormat_default = lbWordFormat.Text;
            tbDefFormat_default = tbDefFormat.Text;
        }

        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            lbAddWordWarning.Text = "";
            lbAddDefWarning.Text = "";

            bool valid = true;
            if (string.IsNullOrWhiteSpace(tbAddWord.Text))
            {
                lbAddWordWarning.Text = "Please input word";
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(tbAddDef.Text))
            {
                lbAddDefWarning.Text = "Please input definition";
                valid = false;
            }
            if(tbAddWord.Text.Trim().Contains(" "))
            {
                lbAddWordWarning.Text = "Word must not contain spaces in between.";
                valid = false;
            }
            if (!valid) return;
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            SqlConnection con = new SqlConnection(connection_string);
            con.Open();

            string query =
                "INSERT INTO dictionary (word, definition, date) " +
                "SELECT LOWER(@Word), @Definition, @Date " +
                "WHERE NOT EXISTS (SELECT 1 FROM dictionary WHERE word = LOWER(@Word)) ";

            //for testing purposes, add word to examples table instead (for generate examples)
            //string query =
            //    "INSERT INTO examples (word, definition, date) " +
            //    "SELECT LOWER(@Word), @Definition, @Date " +
            //    "WHERE NOT EXISTS (SELECT 1 FROM examples WHERE word = LOWER(@Word)) ";

            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@Word", tbAddWord.Text.Trim());
            cmd.Parameters.AddWithValue("@Definition", tbAddDef.Text);
            cmd.Parameters.AddWithValue("Date", date);

            int rowsAffected = cmd.ExecuteNonQuery();
            if(rowsAffected == 1)
            {
                MessageBox.Show(
                    "Word added Successfully.",
                    "Success",
                    MessageBoxButtons.OK
                    );
            }
            else
            {
                MessageBox.Show(
                    "Word already in the dictionary.",
                    "Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            con.Close();
        }

        private void btnAddClear_Click(object sender, EventArgs e)
        {
            tbAddDef.Clear();
            tbAddWord.Clear();
            lbAddWordWarning.Text = "";
            lbAddDefWarning.Text = "";
            lbWordFormat.Text = lbWordFormat_default;
            lbWordFormat.Show();
            tbDefFormat.Text = tbDefFormat_default;
            tbDefFormat.Show();
        }

        private void llbAddBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void formAddWord_FormClosed(object sender, FormClosedEventArgs e)
        {
            home.Show();
        }

        private void tbAddDef_TextChanged(object sender, EventArgs e)
        {
            if (tbAddDef.Text == "")
            {
                tbDefFormat.Show();
                return;
            }
            else
                tbDefFormat.Hide();

        }

        private void tbAddWord_TextChanged(object sender, EventArgs e)
        {
            if (tbAddWord.Text == "")
            {
                lbWordFormat.Show();
                return;
            }
            else
                lbWordFormat.Hide();
            
        }

        private void lbWordFormat_Click(object sender, EventArgs e)
        {
            lbWordFormat.Hide();
            tbAddWord.Focus();
            if (string.IsNullOrWhiteSpace(tbAddDef.Text)) tbDefFormat.Show();
        }

        private void llbExample_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbAddWordWarning.Text = "";
            lbAddDefWarning.Text = "";

            string word, definition;
            SqlConnection con = new SqlConnection(connection_string);
            con.Open();

            string query =
                "SELECT word, definition " +
                "FROM examples " +
                "ORDER BY NEWID()";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if(!rdr.Read())
            {
                lbWordFormat.Text = "No example word available.";
                tbDefFormat.Text = "No example definition available.";
                return;
            }
            rdr.Read();
            word = rdr.GetString(0);
            while(lbWordFormat.Text != "Word" && lbWordFormat.Text == word)
            {
                rdr.Read();
                word = rdr.GetString(0);
            }
            word = char.ToUpper(word[0]) + word.Substring(1); //capitalize the word
            definition = rdr.GetString(1);
            lbWordFormat.Text = word;
            tbDefFormat.Text = definition;
            tbDefFormat.Show();
            lbWordFormat.Show();
        }

        private void tbDefFormat_Click(object sender, EventArgs e)
        {
            tbDefFormat.Hide();
            tbAddDef.Focus();
            if (string.IsNullOrWhiteSpace(tbAddWord.Text)) lbWordFormat.Show();
        }

        private void tbAddDef_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAddWord.Text)) lbWordFormat.Show();
        }

        private void tbAddWord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAddDef.Text)) tbDefFormat.Show();
        }

        private void formAddWord_MouseClick(object sender, MouseEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbAddWord.Text))
                lbWordFormat.Show();
            if (string.IsNullOrWhiteSpace(tbAddDef.Text))
                tbDefFormat.Show();
        }
    }
}
