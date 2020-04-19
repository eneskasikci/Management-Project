using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Login_with_DataBase
{
    public partial class LoginForm : Form
    {
        public static List<User> userList = new List<User>();
        public int loginuserindex;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            Util.LoadCsv(userList, @"user.csv");

            if (Properties.Settings.Default.UserName != string.Empty)
            {
                if (Properties.Settings.Default.Remme == "yes")
                {
                    usernameTextBox.Text = Properties.Settings.Default.UserName;
                    passwordTextBox.Text = Properties.Settings.Default.Password;
                    rememberCheckBox.Checked = true;
                }
            }
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Username")
                usernameTextBox.Text = "";
        }
        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
                usernameTextBox.Text = "Username";
        }
        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
                passwordTextBox.Text = "";
        }
        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
                passwordTextBox.Text = "Password";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Util.SaveUserCsv(userList, @"user.csv");
            this.Close();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            RegisterForm signup = new RegisterForm();
            signup.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
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

            for(int i=0; i<userList.Count; i++)
            {
                User user = userList[i];
                if (user.IsValid(usernameTextBox.Text, Util.ComputeSha256Hash(passwordTextBox.Text)))
                {
                    messageLabel.ForeColor = Color.Green;
                    messageLabel.Text = "Success";
                    loginuserindex = i;
                    loginDelay.Start();
                    return;
                }
            }
            messageLabel.ForeColor = Color.Red;
            messageLabel.Text = "Incorrect Username or Password";
        }

        private void loginDelay_Tick(object sender, EventArgs e)
        {
            loginDelay.Stop();
            UserForm login = new UserForm(loginuserindex);
            login.ShowDialog();
            messageLabel.Text = "";

            if (rememberCheckBox.Checked == false)
            {
                usernameTextBox.Text = "Username";
                passwordTextBox.Text = "Password";
            }
        }
    }
}
