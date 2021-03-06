﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;

namespace Login_with_DataBase
{
    public partial class userManagementForm : Form
    {
        public userManagementForm()
        {
            InitializeComponent();

            foreach (User user in LoginForm.userList)
            {
                ListViewItem item = new ListViewItem(user.Username, 0);
                item.SubItems.Add(user.Password);
                item.SubItems.Add(user.Usertype);
                listView1.Items.Add(item);   
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Util.SavePhonebookCsv(LoginForm.userList, @"phonebook.csv");
            Util.SaveNotesCsv(LoginForm.userList, @"notes.csv");
            Util.savePersonalInformation(LoginForm.userList, @"PersonalInformation.csv");
            Util.SaveReminder(LoginForm.userList, @"reminder.csv");
            this.Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                LoginForm.userList.RemoveAt(listView1.SelectedItems[0].Index);
                listView1.Items.Clear();
                foreach (User user in LoginForm.userList)
                {
                    ListViewItem item = new ListViewItem(user.Username, 0);
                    item.SubItems.Add(user.Password);
                    item.SubItems.Add(user.Usertype);
                    listView1.Items.Add(item);
                }
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
            }
            else
                MessageBox.Show("Please select from List");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                usernameTextBox.Text = listView1.SelectedItems[0].SubItems[0].Text;
                passwordTextBox.Text = listView1.SelectedItems[0].SubItems[1].Text;

                double  salary = LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.MinimumSalary();
                if (LoginForm.userList[listView1.SelectedItems[0].Index].Usertype == "part-time-user")
                    salary /= 2;
                salaryTextBox.Text = salary.ToString();

                string type = listView1.SelectedItems[0].SubItems[2].Text;

                if (type == "admin")
                    usertypeComboBox.SelectedIndex = 0;

                else if (type == "user")
                    usertypeComboBox.SelectedIndex = 1;

                else
                    usertypeComboBox.SelectedIndex = 2;
            }
            
            if (saveSalaryInfButton.Visible == true && listView1.SelectedItems.Count > 0)
            {
                deneyimCumboBox.SelectedIndex = LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Deneyim;
                ilComboBox.SelectedIndex = LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Il;
                dereceCumboBox.SelectedIndex = LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Derece;
                dilComboBox.SelectedIndex = LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Dil;
                gorevComboBox.SelectedIndex = LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Gorev;
                aileComboBox.SelectedIndex = LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Aile;
            }    
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int count=0;
                foreach (User user in LoginForm.userList)
                {
                    if (user.Username == usernameTextBox.Text)
                        count++;
                }
                if (count<=1)
                {
                    LoginForm.userList[listView1.SelectedItems[0].Index].Username = usernameTextBox.Text;
                    if (passwordTextBox.Text != LoginForm.userList[listView1.SelectedItems[0].Index].Password)
                        LoginForm.userList[listView1.SelectedItems[0].Index].Password = Util.ComputeSha256Hash(passwordTextBox.Text);
                    LoginForm.userList[listView1.SelectedItems[0].Index].Usertype = usertypeComboBox.SelectedItem.ToString();
                    listView1.Items.Clear();
                    foreach (User user in LoginForm.userList)
                    {
                        ListViewItem item = new ListViewItem(user.Username, 0);
                        item.SubItems.Add(user.Password);
                        item.SubItems.Add(user.Usertype);
                        listView1.Items.Add(item);
                    }
                }
                else
                    MessageBox.Show("Such user already exists");
            }
            else
                MessageBox.Show("Please select from List");
        }

        private void userSalaryInfoButton_Click(object sender, EventArgs e)
        {
            deneyimCumboBox.SelectedIndex = LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Deneyim;
            ilComboBox.SelectedIndex = LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Il;
            dereceCumboBox.SelectedIndex = LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Derece;
            dilComboBox.SelectedIndex = LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Dil;
            gorevComboBox.SelectedIndex = LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Gorev;
            aileComboBox.SelectedIndex = LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Aile;
            salaryInfPanel.Visible = true;
        }

        private void saveSalaryInfButton_Click(object sender, EventArgs e)
        {
            if (deneyimCumboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select Deneyim Suresi", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ilComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select Il grubu", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dereceCumboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select Akademik Derece", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dilComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select Yabanci Dil Belgesi", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (gorevComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select Yonetici Gorevi", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (aileComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select Aile Durumu", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Deneyim = deneyimCumboBox.SelectedIndex;
            LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Il = ilComboBox.SelectedIndex;
            LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Derece = dereceCumboBox.SelectedIndex;
            LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Dil = dilComboBox.SelectedIndex;
            LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Gorev = gorevComboBox.SelectedIndex;
            LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Aile = aileComboBox.SelectedIndex;
            MessageBox.Show("Data saved succesfully");
            double salary = LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.MinimumSalary();
            if (LoginForm.userList[listView1.SelectedItems[0].Index].Usertype == "part-time-user")
                salary /= 2;
            salaryTextBox.Text = salary.ToString();
        }

        private void SendPassw2Email_Click(object sender, EventArgs e)
        {
            if (SendPassTxt.Text == "")
            {
                MessageBox.Show("Please Enter a Password");
                return;
            }
            if (listView1.SelectedItems.Count>0)
            {
                if (!File.Exists(@"PersonalInformation.csv"))
                {
                    StreamWriter create = File.CreateText(@"PersonalInformation.csv");
                    create.Close();
                }
                StreamReader reader = new StreamReader("PersonalInformation.csv");
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line != "")
                    {
                        var values = line.Split(',');
                        if (int.Parse(values[0]) == listView1.SelectedItems[0].Index)
                        {
                            LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Name = values[1];
                            LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Email = values[4];
                        }
                    }
                }
                reader.Close();
                if (LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Email == "")
                {
                    MessageBox.Show("There is no saved email for this user.") ;
                    return;
                }
                
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp-mail.outlook.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("ooplab2_23@outlook.com", "BoburshohEnesMurat");
                MailMessage eposta = new MailMessage();
                eposta.From = new MailAddress("ooplab2_23@outlook.com");
                eposta.To.Add(LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Email);
                eposta.Subject = "New Password";
                eposta.Body = "Hello " + LoginForm.userList[listView1.SelectedItems[0].Index].Personinf.Name + ", Your new password is; " + SendPassTxt.Text;
                int changedornot = 0;
                EmailProgressBar.Maximum = 100;
                EmailProgressBar.Step = 100;
                try
                {
                    EmailProgressBar.Visible = true;
                    smtp.Send(eposta);
                    EmailProgressBar.PerformStep();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured while sending email." + ex.Message);
                    changedornot = 1;
                }
                if (changedornot == 0)
                {
                    LoginForm.userList[listView1.SelectedItems[0].Index].Password = Util.ComputeSha256Hash(SendPassTxt.Text);
                    MessageBox.Show("Password Changed and Mail sent.");
                    passwordTextBox.Text = LoginForm.userList[listView1.SelectedItems[0].Index].Password;
                    listView1.SelectedItems[0].SubItems[1].Text = LoginForm.userList[listView1.SelectedItems[0].Index].Password;
                }
            }
            else
                MessageBox.Show("Please select from List");
            EmailProgressBar.Visible = false;
        }
    }
}