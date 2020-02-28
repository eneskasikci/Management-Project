using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Application
{
    public partial class Form1 : Form
    {
        class User
        {
            string username;
            string password;

            public User(string username, string password)
            {
                this.username = username;
                this.password = password;
            }

            public string getUsername()
            {
                return username;
            }

            public string getPassword()
            {
                return password;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User log = new User("Test", "password");

            if (usernameTextBox.Text == log.getUsername() && passwordTextBox.Text == log.getPassword())
            {
                messageLabel.ForeColor = Color.Green;
                messageLabel.Text = "Success";
                timer1.Start();
            }
            else
            {
                messageLabel.ForeColor = Color.Red;
                messageLabel.Text = "Incorrect Username or Password";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            messageLabel.Text = "";
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
