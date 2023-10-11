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
using System.Text.RegularExpressions;

namespace Dictionary
{
    public partial class formSearchWord : Form
    {
        private formDictionary home;
        public formSearchWord(formDictionary home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void formSearch_Load(object sender, EventArgs e)
        {
            tbSearchSearch.Clear();
            tbResult.Clear();
            lbSearchSearchWarning.Text = "";
        }

        private void btnSearchSearch_Click(object sender, EventArgs e)
        {
            lbSearchSearchWarning.Text = "";

            if (string.IsNullOrWhiteSpace(tbSearchSearch.Text))
            {
                lbSearchSearchWarning.Text = "Please input word.";
                return;
            }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I3TO6HF;Initial Catalog=Dictionary;Integrated Security=True");
            con.Open();

            string query =
                "SELECT COUNT(*) " +
                "FROM dictionary " +
                "WHERE word = @Word ";
                
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Word", tbSearchSearch.Text);

            int count = (int)cmd.ExecuteScalar();

            if(count > 0)
            {
                string query2 =
                    "SELECT * " +
                    "FROM dictionary " +
                    "WHERE word = @Word";

                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@Word", tbSearchSearch.Text);
                SqlDataReader reader = cmd2.ExecuteReader();
                reader.Read();
                string word = reader.GetString(0);
                word = char.ToUpper(word[0]) + word.Substring(1);
                string definition = reader.GetString(1);
                string date = reader.GetString(2);
                tbResult.Text = $"{word}     {date}\r\n\r\n{definition}\r\n\r\n";
            }
            else
            {
                tbResult.Text = "Word not found.";
            }
           
        }

        private void formSearchWord_FormClosed(object sender, FormClosedEventArgs e)
        {
            home.Show();
        }

        private void llbSearchBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            tbSearchSearch.Clear();
            tbResult.Clear();
            lbSearchSearchWarning.Text = "";
        }

        private void tbSearchSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearchSearch.Text))
            {
                tbResult.Clear();
                return;
            }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I3TO6HF;Initial Catalog=Dictionary;Integrated Security=True");
            con.Open();

            tbResult.Text = "";
            string searchText = tbSearchSearch.Text.Trim(),
                   word,
                   definition,
                   date;

            string query =
                "SELECT TOP 5 word, definition, date " +
                "FROM dictionary " +
                "WHERE word LIKE @Word + '%'";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Word", searchText);

                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    word = rdr.GetString(0);
                    word = char.ToUpper(word[0]) + word.Substring(1); //capitalize the word
                    definition = rdr.GetString(1);
                    date = rdr.GetString(2);

                    tbResult.AppendText(word);

                    int startIndex = word.IndexOf(searchText, StringComparison.OrdinalIgnoreCase);
                    if (startIndex >= 0)
                    {
                        tbResult.Select(tbResult.Text.Length - word.Length, searchText.Length);
                        tbResult.SelectionBackColor = Color.Yellow;
                        tbResult.DeselectAll();
                    }
                    tbResult.AppendText($"      {date}\r\n\r\n{definition}\r\n\r\n\r\n");
                    tbResult.Select(word.Length, tbResult.Text.Length - word.Length);
                    tbResult.SelectionBackColor = tbResult.BackColor;
                    tbResult.DeselectAll();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "An error occured while querying the database " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}
