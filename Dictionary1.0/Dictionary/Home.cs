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
    public partial class formDictionary : Form
    {
        public formDictionary()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formAddWord addWord = new formAddWord(this);
            addWord.Show();
            this.Hide();
        }

        private void formDictionary_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            formSearchWord searchWord = new formSearchWord(this);
            searchWord.Show();
            this.Hide();
        }
    }
}
