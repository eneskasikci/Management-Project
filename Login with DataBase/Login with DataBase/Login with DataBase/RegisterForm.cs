using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Login_with_DataBase
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" || passwordTextBox.Text != "")
            {
                try
                {
                    if (!Util.IsDoubleUsername(nameTextBox.Text))
                    {
                        if (LoginForm.userList.Count == 0)
                        {
                            User user = new User(nameTextBox.Text, Util.ComputeSha256Hash(passwordTextBox.Text), "admin");
                            LoginForm.userList.Add(user);
                        }
                        else
                        {
                            User user = new User(nameTextBox.Text, Util.ComputeSha256Hash(passwordTextBox.Text), "user");
                            LoginForm.userList.Add(user);
                        }

                        MessageBox.Show("Sign Up successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nameTextBox.Text = "";
                        passwordTextBox.Text = "";
                    }

                    else
                        MessageBox.Show("Such username exists", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Fields can not be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }//end-method

        private void icon1Button_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                icon2Button.BringToFront();
            }
            else
                passwordTextBox.UseSystemPasswordChar = true;
                icon2Button.BringToFront();
        }

        private void icon2Button_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                icon1Button.BringToFront();
            }
            else
                passwordTextBox.UseSystemPasswordChar = true;
                icon1Button.BringToFront();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
