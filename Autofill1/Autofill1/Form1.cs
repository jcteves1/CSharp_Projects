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

namespace Autofill1
{
    public partial class Form1 : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=LAPTOP-5VQ1AK2J\\SQLEXPRESS;Initial Catalog=Dictionary;Integrated Security=True");
        //SqlCommand cmd;
        //SqlDataReader rdr;

        public Form1()
        {
            InitializeComponent();
        }

        private void tbTest_TextChanged(object sender, EventArgs e)
        {
            if (tbTest.Text == "")
            {
                tbResult.Clear();
                return;
            }
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5VQ1AK2J\\SQLEXPRESS;Initial Catalog=Dictionary;Integrated Security=True");
            con.Open();

            //if (rdr != null && !rdr.IsClosed)
            //{
            //    rdr.Close();
            //}
            tbResult.Text = "";
            string searchText = tbTest.Text,
                   word,
                   definition,
                   date;
            string query =
                "SELECT TOP 5 word, definition, date " +
                "FROM dictionary " +
                "WHERE word LIKE @Word + '%' ";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Word", searchText);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    word = rdr.GetString(0);
                    definition = rdr.GetString(1);
                    date = rdr.GetString(2);
                    tbResult.Text += $"{word}         {date}\r\n{definition}\r\n";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "An error occurred while querying the database: " + ex.Message,
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
              
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5VQ1AK2J\\SQLEXPRESS;Initial Catalog=Dictionary;Integrated Security=True");
            con.Open();
            string query =
                "SELECT word " +
                "FROM dictionary";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                string suggestion = rdr.GetString(0);
                tbTest.AutoCompleteCustomSource.Add(suggestion);
            }
            rdr.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
