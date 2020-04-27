﻿using System;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Login_with_DataBase
{
    public partial class UserForm : Form
    {
        public int userindex;
        public UserForm(int loginuserindex)
        {
            InitializeComponent();
            KeyPreview = true;
            piNamerichTxt.KeyDown += piNamerichTxt_KeyDown;
            userindex = loginuserindex;
            label1.Text = "Welcome " + LoginForm.userList[loginuserindex].Username;
            listView1.Sorting = SortOrder.Ascending;
        }

        private void piNamerichTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Z)
            {
                nameTxtbox.Undo();
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Y)
            {
                piNamerichTxt.Redo();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            phonebookPanel.Visible = false;
            phonebookButton.Visible = false;
            userMangementButton.Visible = false;
            notesPanel.Visible = false;
            notesButton.Visible = false;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
        private void userMangementButton_Click(object sender, EventArgs e)
        {
            if (LoginForm.userList[userindex].Usertype =="admin")
            {
                userManagementForm window = new userManagementForm();
                window.ShowDialog();
            }
            else
                MessageBox.Show("Only admins have access to this page", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void phonebookButton_Click(object sender, EventArgs e)
        {
            notesPanel.Visible = false;
            PInfPanel.Visible = false;
            phonebookPanel.Visible = true;
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && surnameTxtBox.Text != ""
            && phoneTextBox.Text != "" && emailTextBox.Text != ""
            && descriptionTextBox.Text != "" && addressTextBox.Text != "")
            {
                if (listView1.Items.Count > 200)
                {
                    MessageBox.Show("Your Phone Book is Full", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ListViewItem item = new ListViewItem(nameTextBox.Text, 0);
                item.SubItems.Add(surnameTxtBox.Text);

                if (!IsAllDigits(phoneTextBox.Text))
                {
                    MessageBox.Show("Numbers must contain only digits", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (phoneTextBox.Text.Length!=10)
                {
                    MessageBox.Show("Wrong number size", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                item.SubItems.Add(formatPhoneNumber(phoneTextBox.Text));

                if (!IsValidMail(emailTextBox.Text))
                {
                    MessageBox.Show("Wrong Email Format", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                item.SubItems.Add(emailTextBox.Text);
                item.SubItems.Add(descriptionTextBox.Text);
                item.SubItems.Add(addressTextBox.Text);
                listView1.Items.Add(item);
                listView1.Sorting = SortOrder.Ascending;
            }

            else
                MessageBox.Show("Fields can not be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
              
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                nameTextBox.Text = listView1.SelectedItems[0].SubItems[0].Text;
                surnameTxtBox.Text = listView1.SelectedItems[0].SubItems[1].Text;
                phoneTextBox.Text = listView1.SelectedItems[0].SubItems[2].Text;
                emailTextBox.Text = listView1.SelectedItems[0].SubItems[3].Text;
                descriptionTextBox.Text = listView1.SelectedItems[0].SubItems[4].Text;
                addressTextBox.Text = listView1.SelectedItems[0].SubItems[5].Text;
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = nameTextBox.Text;
                listView1.SelectedItems[0].SubItems[1].Text = surnameTxtBox.Text;
                listView1.SelectedItems[0].SubItems[2].Text = phoneTextBox.Text;
                listView1.SelectedItems[0].SubItems[3].Text = emailTextBox.Text;
                listView1.SelectedItems[0].SubItems[4].Text = descriptionTextBox.Text;
                listView1.SelectedItems[0].SubItems[5].Text = addressTextBox.Text;
            }
            else
                MessageBox.Show("Select an item from list", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            listView1.Sorting = SortOrder.Ascending;
            LoginForm.userList[userindex].Phonebook.Clear();
            
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                LoginForm.userList[userindex].Phonebook.Add(new Phonebook(listView1.Items[i].SubItems[0].Text
                    , listView1.Items[i].SubItems[1].Text
                    , listView1.Items[i].SubItems[2].Text
                    , listView1.Items[i].SubItems[3].Text
                    , listView1.Items[i].SubItems[4].Text
                    , listView1.Items[i].SubItems[5].Text));
            }
            MessageBox.Show("Saved successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Util.SavePhonebookCsv(LoginForm.userList, @"phonebook.csv");
        }
        private void notesButton_Click(object sender, EventArgs e)
        {
            phonebookPanel.Visible = false;
            PInfPanel.Visible = false;
            notesPanel.Visible = true;       
        }
        private void createNoteButton_Click(object sender, EventArgs e)
        {
            if (yourNoteTxtBox.Text != "")
            {
                noteBox.Items.Add(yourNoteTxtBox.Text);
                yourNoteTxtBox.Text = "";
            }
        }
        private void listNotesButton_Click(object sender, EventArgs e)
        {
            noteBox.Items.Clear();
            Util.LoadNotes(LoginForm.userList, "notes.csv");
            for (int i = 0; i < LoginForm.userList[userindex].Notes.Count; i++)
                noteBox.Items.Add(LoginForm.userList[userindex].Notes[i]);
        }
        private void saveFileButton_Click(object sender, EventArgs e)
        {
            LoginForm.userList[userindex].Notes.Clear();
            for (int i = 0; i < noteBox.Items.Count; i++)
                LoginForm.userList[userindex].Notes.Add(noteBox.Items[i].ToString());
            MessageBox.Show("Saved successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Util.SaveNotesCsv(LoginForm.userList, "notes.csv");
        }
        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (noteBox.SelectedIndex < 0)
                    MessageBox.Show("Please select a note to delete");
                else
                {
                    noteBox.Items.RemoveAt(noteBox.SelectedIndex);
                    yourNoteTxtBox.Text = "";
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateNoteButton_Click(object sender, EventArgs e)
        {
            if (noteBox.SelectedIndex >= 0)
            {
                int index = noteBox.SelectedIndex;
                noteBox.Items.RemoveAt(index);
                noteBox.Items.Insert(index, yourNoteTxtBox.Text);
            }
            else if (yourNoteTxtBox.Text == "")
                MessageBox.Show("Updated notes cannot be blank");
            else
                MessageBox.Show("Please select a note to update");
        }

        private void noteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = noteBox.SelectedIndex;
            if (index!=-1)
                yourNoteTxtBox.Text = noteBox.SelectedItem.ToString();     
        }

        private void listPhonebookButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Util.Loadphonebook(LoginForm.userList, @"phonebook.csv");
            for (int i = 0; i < LoginForm.userList[userindex].Phonebook.Count; i++)
            {
                ListViewItem item = new ListViewItem(LoginForm.userList[userindex].Phonebook[i].Name, 0);
                item.SubItems.Add(LoginForm.userList[userindex].Phonebook[i].Surname);
                item.SubItems.Add(LoginForm.userList[userindex].Phonebook[i].Phonenumber);
                item.SubItems.Add(LoginForm.userList[userindex].Phonebook[i].Email);
                item.SubItems.Add(LoginForm.userList[userindex].Phonebook[i].Description);
                item.SubItems.Add(LoginForm.userList[userindex].Phonebook[i].Address);
                listView1.Items.Add(item);
            }
        }

        public static string formatPhoneNumber(string phoneNum)
        {
            string phoneFormat = "(###) ### ## ##";

            // First, remove everything except of numbers
            Regex regexObj = new Regex(@"[^\d]");
            phoneNum = regexObj.Replace(phoneNum, "");

            // Second, format numbers to phone string
            if (phoneNum.Length > 0)
                phoneNum = Convert.ToInt64(phoneNum).ToString(phoneFormat);
            return phoneNum;
        }
        bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
        bool IsValidMail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }

        private void PInfButton_Click(object sender, EventArgs e)
        {
            phonebookPanel.Visible = false;
            notesPanel.Visible = false;
            Util.LoadPersonalInformation(LoginForm.userList, "PersonalInformation.csv", userindex);
            passwordTxtbox.Text = LoginForm.password;
            nameTxtbox.Text = LoginForm.userList[userindex].Person.Name;
            piSurnameTxt.Text = LoginForm.userList[userindex].Person.Surname;
            phoneTxtbox.Text = LoginForm.userList[userindex].Person.Phonenumber;
            emailTxtbox.Text = LoginForm.userList[userindex].Person.Email;
            addressTxtbox.Text = LoginForm.userList[userindex].Person.Address;
            if (LoginForm.userList[userindex].Person.Image != "")
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(LoginForm.userList[userindex].Person.Image)));
                ProfilePictureBox.Image = img;
            }
            PInfPanel.Visible = true;
        }

        private void emailLbl_Click(object sender, EventArgs e)
        {

        }

        private void ProfilePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                ProfilePictureBox.ImageLocation = ofd.FileName;
            }
        }

        private void makePassVisible_Click(object sender, EventArgs e)
        {
            if (passwordTxtbox.UseSystemPasswordChar)
            {
                passwordTxtbox.UseSystemPasswordChar = false;
            }
            else
                passwordTxtbox.UseSystemPasswordChar = true;
        }

        private void savedetailsButton_Click(object sender, EventArgs e)
        {
            if (nameTxtbox.Text != "" && surnameTxtbox.Text != ""
            && phoneTxtbox.Text != "" && emailTxtbox.Text != ""
            && addressTxtbox.Text != "")
            {
                if (!IsAllDigits(phoneTxtbox.Text))
                {
                    MessageBox.Show("Numbers must contain only digits", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (phoneTxtbox.Text.Length != 10)
                {
                    MessageBox.Show("Wrong number size", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!IsValidMail(emailTxtbox.Text))
                {
                    MessageBox.Show("Wrong Email Format", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Util.IsPboxNullOrEmpty(ProfilePictureBox))
                {
                    MessageBox.Show("Please Select a Picture", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LoginForm.userList[userindex].Person.Name = nameTxtbox.Text;
                LoginForm.userList[userindex].Person.Surname = surnameTxtbox.Text;
                LoginForm.userList[userindex].Person.Email = emailTxtbox.Text;
                LoginForm.userList[userindex].Person.Phonenumber = phoneTxtbox.Text;
                LoginForm.userList[userindex].Person.Address = addressTxtbox.Text;
                LoginForm.userList[userindex].Person.Image = Util.ImageToBase64(ProfilePictureBox);
                Util.savePersonalInformation(LoginForm.userList, "PersonalInformation.csv", userindex);
               
                if(passwordTxtbox.Text != LoginForm.password)
                {
                    LoginForm.userList[userindex].Password = Util.ComputeSha256Hash(passwordTxtbox.Text);
                    Util.ChangePassword(LoginForm.userList, "user.csv", userindex);
                }

            }
                else
                MessageBox.Show("Fields can not be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
    }
}