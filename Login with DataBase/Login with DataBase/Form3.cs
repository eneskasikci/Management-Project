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
    public partial class Form3 : Form
    {
        public Form3(string log)
        {
            InitializeComponent();
            label1.Text = "Welcome " + log;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserName = "Username";
            Properties.Settings.Default.Password = "Password";
            Properties.Settings.Default.Remme = "no";
            Properties.Settings.Default.Save();
            label1.Visible = false;
            label2.Visible = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
    }
}
