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
            lbSearchWord.Text = "";
            lbSearchDef.Text = "";
            lbSearchDate.Text = "";
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
                lbSearchWord.Text = word;
                lbSearchDef.Text = definition;
                lbSearchDate.Text = date;
            }
            else
            {
                lbSearchWord.Text = "Word not found.";
                lbSearchDef.Text = "";
                lbSearchDate.Text = "";
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
            lbSearchWord.Text = "";
            lbSearchDef.Text = "";
            lbSearchDate.Text = "";
            lbSearchSearchWarning.Text = "";
        }

        
    }
}
