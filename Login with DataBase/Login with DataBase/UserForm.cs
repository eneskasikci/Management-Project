using System;
using System.Windows.Forms;
using System.IO;

namespace Login_with_DataBase
{
    public partial class UserForm : Form
    {
        public User thisuser;
        public UserForm(User user)
        {
            InitializeComponent();
            thisuser = user;
            label1.Text = "Welcome " + user.Username;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void userMangementButton_Click(object sender, EventArgs e)
        {
            if (thisuser.Usertype =="admin")
            {
                userManagementForm window = new userManagementForm();
                window.ShowDialog();
            }
            else
                MessageBox.Show("Only admins have access to this page", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
