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
            if (!valid) return;
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I3TO6HF;Initial Catalog=Dictionary;Integrated Security=True");
            con.Open();

            string query =
                "INSERT INTO dictionary (word, definition, date) " +
                "SELECT LOWER(@Word), @Definition, @Date " +
                "WHERE NOT EXISTS (SELECT 1 FROM dictionary WHERE word = LOWER(@Word)) ";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@Word", tbAddWord.Text);
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
               
        }

        private void btnAddClear_Click(object sender, EventArgs e)
        {
            tbAddDef.Clear();
            tbAddWord.Clear();
            lbAddWordWarning.Text = "";
            lbAddDefWarning.Text = "";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
