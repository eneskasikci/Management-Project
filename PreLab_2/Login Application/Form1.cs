using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Login_Application
{
    public partial class Form1 : Form
    {
        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }

        public static string GenerateSHA256String(string inputString)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha256.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }


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
            User log = new User("admin", "03AC674216F3E15C761EE1A5E255F067953623C8B388B4459E13F978D7C846F4");

            if (usernameTextBox.Text == log.getUsername() && GenerateSHA256String(passwordTextBox.Text) == log.getPassword())
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
