namespace Password_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }
        private void Button1_Click(object sender, EventArgs e) //login system 
        {
            ;
            if (txtUserName.Text == "Admin" && txtPassword.Text == "Admin")
            {
                MessageBox.Show("Correct Password");
                MessageBox.Show("Welcome back Admin");
                passwords settingsForm = new passwords();
                settingsForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            button2.Click += Button2_Click;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}