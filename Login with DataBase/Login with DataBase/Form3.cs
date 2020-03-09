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

        private void logOutButton_Click(object sender, EventArgs e)
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "mydb.tsv";
            string[] lines = File.ReadAllLines("mydb.csv");
            StreamWriter sw = File.AppendText(save.FileName); 

			if (save.ShowDialog()==DialogResult.OK)
			{
				for (int i = 0; i < lines.Length; i++)
				{
					string[] words = lines[i].Split(',');   
					sw.WriteLine(words[0] + "\tab" + words[1]);
				}

                MessageBox.Show("Data saved successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            sw.Close();
        }
    }
}
