using System;
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
            userindex = loginuserindex;
            label1.Text = "Welcome " + LoginForm.userList[loginuserindex].Username;
            listView1.Sorting = SortOrder.Ascending;
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
            listView1.Items.Clear();

            for (int i = 0; i < LoginForm.userList[userindex].Size; i++)
            {
                ListViewItem item = new ListViewItem(LoginForm.userList[userindex].Phonebook[i].Name, 0);
                item.SubItems.Add(LoginForm.userList[userindex].Phonebook[i].Surname);
                item.SubItems.Add(LoginForm.userList[userindex].Phonebook[i].Phonenumber);
                item.SubItems.Add(LoginForm.userList[userindex].Phonebook[i].Email);
                item.SubItems.Add(LoginForm.userList[userindex].Phonebook[i].Description);
                item.SubItems.Add(LoginForm.userList[userindex].Phonebook[i].Address);
                listView1.Items.Add(item);
            }

            phonebookPanel.Visible = true;
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && surnameTextBox.Text != ""
            && phoneTextBox.Text != "" && emailTextBox.Text != ""
            && descriptionTextBox.Text != "" && addressTextBox.Text != "")
            {
                if (listView1.Items.Count > 200)
                {
                    MessageBox.Show("Your Phone Book is Full", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ListViewItem item = new ListViewItem(nameTextBox.Text, 0);
                item.SubItems.Add(surnameTextBox.Text);

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
        public static string formatPhoneNumber(string phoneNum)
        {
            string phoneFormat = "(###) ### ## ##";

            // First, remove everything except of numbers
            Regex regexObj = new Regex(@"[^\d]");
            phoneNum = regexObj.Replace(phoneNum, "");

            // Second, format numbers to phone string
            if (phoneNum.Length > 0)
            {
                phoneNum = Convert.ToInt64(phoneNum).ToString(phoneFormat);
            }
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
                surnameTextBox.Text = listView1.SelectedItems[0].SubItems[1].Text;
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
                listView1.SelectedItems[0].SubItems[1].Text = surnameTextBox.Text;
                listView1.SelectedItems[0].SubItems[2].Text = phoneTextBox.Text;
                listView1.SelectedItems[0].SubItems[3].Text = emailTextBox.Text;
                listView1.SelectedItems[0].SubItems[4].Text = descriptionTextBox.Text;
                listView1.SelectedItems[0].SubItems[5].Text = addressTextBox.Text;
                listView1.Sorting = SortOrder.Ascending;
            }
            else
                MessageBox.Show("Select an item from list", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            LoginForm.userList[userindex].Size = listView1.Items.Count;
            LoginForm.userList[userindex].Phonebook = new Phonebook[listView1.Items.Count];
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                LoginForm.userList[userindex].Phonebook[i] = new Phonebook();
                LoginForm.userList[userindex].Phonebook[i].Name = listView1.Items[i].SubItems[0].Text;
                LoginForm.userList[userindex].Phonebook[i].Surname = listView1.Items[i].SubItems[1].Text;
                LoginForm.userList[userindex].Phonebook[i].Phonenumber = listView1.Items[i].SubItems[2].Text;
                LoginForm.userList[userindex].Phonebook[i].Email = listView1.Items[i].SubItems[3].Text;
                LoginForm.userList[userindex].Phonebook[i].Description = listView1.Items[i].SubItems[4].Text;
                LoginForm.userList[userindex].Phonebook[i].Address = listView1.Items[i].SubItems[5].Text;
            }
            MessageBox.Show("Saved successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void notesButton_Click(object sender, EventArgs e)
        {
            phonebookPanel.Visible = false;
            yourNotePanel.Visible = true;
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
            string[] list = System.IO.File.ReadAllLines("notes.csv");
            noteBox.Items.AddRange(list);
        }
        private void saveFileButton_Click(object sender, EventArgs e)
        {
            File.WriteAllLines("notes.csv", noteBox.Items.Cast<string>());
        }
        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (noteBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a note to delete");
                }
                else
                {
                    int selectedNote = noteBox.SelectedIndex;
                    noteBox.Items.RemoveAt(selectedNote);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateNoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (noteBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a note to update");
                }
                else
                {
                    if (yourNoteTxtBox.Text == "")
                    {
                        MessageBox.Show("Updated notes cannot be blank");
                    }
                    else
                    {
                        int selectedNote = noteBox.SelectedIndex;
                        noteBox.Items.RemoveAt(selectedNote);
                        noteBox.Items.Insert(selectedNote, yourNoteTxtBox.Text);
                        yourNoteTxtBox.Text = "";
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}