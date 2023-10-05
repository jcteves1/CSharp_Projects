namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            lbWelcome.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String firstName = tbFirstName.Text;
            String lastName = tbLastName.Text;
            lbWelcome.Text = "Hi, " + firstName + " " + lastName + "!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "";
        }
    }
}