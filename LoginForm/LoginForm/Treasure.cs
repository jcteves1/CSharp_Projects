using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formTreasure : Form
    {
        private formLogin loginForm;
        public formTreasure(formLogin loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void formTreasure_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
        }
    }
}
