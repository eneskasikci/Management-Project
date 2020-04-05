using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_with_DataBase
{
    public partial class userManagementForm : Form
    {
        public userManagementForm()
        {
            InitializeComponent();

            for(int i=0; i<LoginForm.userList.Count; i++)
            {
                User user = LoginForm.userList[i];
                ListViewItem item = new ListViewItem(user.Username, 0);
                item.SubItems.Add(user.Password);
                item.SubItems.Add(user.Usertype);
                listView1.Items.Add(item);   
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }   

            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                usernameTextBox.Text = listView1.SelectedItems[0].SubItems[0].Text;
                passwordTextBox.Text = listView1.SelectedItems[0].SubItems[1].Text;
                string type = listView1.SelectedItems[0].SubItems[2].Text;

                if (type == "admin")
                    usertypeComboBox.SelectedIndex = 0;

                else if (type == "user")
                    usertypeComboBox.SelectedIndex = 1;

                else
                    usertypeComboBox.SelectedIndex = 2;
            }       
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = usernameTextBox.Text;
                listView1.SelectedItems[0].SubItems[1].Text = passwordTextBox.Text;
                listView1.SelectedItems[0].SubItems[2].Text = usertypeComboBox.SelectedItem.ToString();
            }
        }

        private void saveListButton_Click(object sender, EventArgs e)
        {
            LoginForm.userList.Clear();
            foreach (ListViewItem item in listView1.Items)
            {
                User user = new User(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text);
                LoginForm.userList.Add(user);
            }
            MessageBox.Show("List saved successfully");
        }
    }
}
