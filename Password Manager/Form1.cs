using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Password_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }
        public class User //json file to store log in info will be changed later
        {
            public string Username { get; set; } 
            public string Password { get; set; }
        }
        private List<User> user;
        private void LoadUser()
        {
            string filePath = "user.json";
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                user = JsonConvert.DeserializeObject<List<User>>(json);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            var founduser = user.FirstOrDefault(u => u.Username == txtUserName.Text && u.Password == txtPassword.Text);
            if (founduser != null) //successful login
            {
                label4.Visible = false;
                var form = new Form2();
                form.Show();
                this.Hide();
            }
            else //failed login
            {
                label4.Visible = true;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            LoadUser();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            button2.Click += Button2_Click;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var form = new signup();
            form.Show();
            this.Hide();
        }
    }
}