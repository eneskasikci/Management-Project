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

        private void button1_Click(object sender, EventArgs e)
        {

            if (nameTextBox.Text != "" || textBox2.Text != "")
            {
                try
                {
                    if(LoginForm.userList.Count==0)
                    {
                        User user = new User(nameTextBox.Text, Util.ComputeSha256Hash(textBox2.Text), "admin");
                        LoginForm.userList.Add(user);
                    }
                    else
                    {
                        User user = new User(nameTextBox.Text, Util.ComputeSha256Hash(textBox2.Text), "user");
                        LoginForm.userList.Add(user);
                    }
                                  
                    MessageBox.Show("Data saved successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nameTextBox.Text = "";
                    textBox2.Text = "";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Fields can not be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }//end-method

        private void icon1Button_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar)
            {
                textBox2.UseSystemPasswordChar = false;
                icon2Button.BringToFront();
            }
            else
                textBox2.UseSystemPasswordChar = true;
                icon2Button.BringToFront();
        }

        private void icon2Button_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar)
            {
                textBox2.UseSystemPasswordChar = false;
                icon1Button.BringToFront();
            }
            else
                textBox2.UseSystemPasswordChar = true;
                icon1Button.BringToFront();
        }
    }
}
