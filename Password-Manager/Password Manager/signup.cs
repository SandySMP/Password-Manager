using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Password_Manager
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
            button1.Click += label1_Click_1;
        }
        private void signup_load(object sender, EventArgs e)
        {
            label4.Visible = false;
            LoadUser();
        }
        public class user
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        private List<user> userList = new List<user>();
        private void LoadUser()
        {
            string filePath = "user.json";
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                userList = JsonConvert.DeserializeObject<List<user>>(json);
            }
            else
            {
                userList = new List<user>();
            }
        }
        private void SaveUser()
        {
            string json = JsonConvert.SerializeObject(userList);
            File.WriteAllText("user.json", json);
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            string newusername = txtusername.Text;
            string newpassword = textpassword.Text;
            string confirmpassword = textconfirmpassword.Text;
            LoadUser();
            var existinguser = userList.FirstOrDefault(u => u.Username == newusername);
            if (existinguser != null)
            {
                label4.Text = "Username already exists";
                label4.Visible = true;
            }
            else if (newpassword != confirmpassword)
            {
                label4.Text = "Passwords do not match";
                label4.Visible = true;
            }
            else
            {
                userList.Add(new user { Username = newusername, Password = newpassword });
                SaveUser();
                var form = new Form1();
                form.Show();
                this.Hide();
            }
            user newUser = new user
            {
                Username = newusername,
                Password = newpassword
            };
            userList.Add(newUser);
            SaveUser();

        }
        private void label2_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();
            this.Hide();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            label4.Visible = false;
        }
    }
}



