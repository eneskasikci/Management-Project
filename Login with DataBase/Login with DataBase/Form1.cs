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
using System.IO;

namespace Login_with_DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Username")
            {
                usernameTextBox.Text = "";
            }
        }
        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                usernameTextBox.Text = "Username";
            }
        }
        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";
            }
        }
        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Password";
            }
        }

        private bool searchLogData(string username, string password)
        {
            string[] lines = File.ReadAllLines("mydb.csv");

            for (int i = 0; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(',');

                if (words[0] == username && words[1] == password)
                    return true;
            }

            return false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (searchLogData(usernameTextBox.Text, GenerateSHA256String(passwordTextBox.Text)))
            {
                messageLabel.ForeColor = Color.Green;
                messageLabel.Text = "Success";

                if (rememberCheckBox.Checked == false)
                {
                    Properties.Settings.Default.UserName = "";
                    Properties.Settings.Default.Password = "";                  
                    Properties.Settings.Default.Remme = "no";
                    Properties.Settings.Default.Save();
                }

                if (rememberCheckBox.Checked == true)
                {
                    Properties.Settings.Default.UserName = usernameTextBox.Text;
                    Properties.Settings.Default.Password = passwordTextBox.Text;
                    Properties.Settings.Default.Remme = "yes";
                    Properties.Settings.Default.Save();
                }
                timer1.Start();
            }
            else
            {
                messageLabel.ForeColor = Color.Red;
                messageLabel.Text = "Incorrect Username or Password";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Form3 login = new Form3(usernameTextBox.Text);
            login.ShowDialog();

            if (rememberCheckBox.Checked == false)
            {
                usernameTextBox.Text = "Username";
                passwordTextBox.Text = "Password";
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            Form2 signup = new Form2();
            signup.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText("mydb.csv");
            sw.Close();
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                if(Properties.Settings.Default.Remme == "yes")
                {
                    usernameTextBox.Text = Properties.Settings.Default.UserName;
                    passwordTextBox.Text = Properties.Settings.Default.Password;
                    rememberCheckBox.Checked = true;
                } 
            }
        }
    }
}
