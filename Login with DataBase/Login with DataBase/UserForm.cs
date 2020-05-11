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
        private Queue<Reminder> ReminderQueue = new Queue<Reminder>();

        public UserForm(int loginuserindex)
        {            
            InitializeComponent();
            userindex = loginuserindex;
            label1.Text = "Welcome " + LoginForm.userList[loginuserindex].Username;
            listView1.Sorting = SortOrder.Ascending;
            KeyPreview = true;
            perInfNameRichTextbox.KeyDown += perInfNameRichTextbox_KeyDown;
            perInfSurnameRichTextbox.KeyDown += perInfSurnameRichTextbox_KeyDown;
            perInfEmailRichTextbox.KeyDown += perInfEmailRichTextbox_KeyDown;
            perInfAddressRichTextbox.KeyDown += perInfAddressRichTextbox_KeyDown;
            perInfPhoneRichTextbox.KeyDown += perInfPhoneRichTextbox_KeyDown;
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
            PInfPanel.Visible = false;
            PInfButton.Visible = false;
            salaryInfPanel.Visible = false;
            reminderPanel.Visible = false;
            reminderButton.Visible = false;
            salaryInfButton.Visible = false;
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
            salaryInfPanel.Visible = false;
            reminderPanel.Visible = false;
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
            salaryInfPanel.Visible = false;
            reminderPanel.Visible = false;
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
            salaryInfPanel.Visible = false;
            reminderPanel.Visible = false;
            Util.LoadPersonalInformation(LoginForm.userList, "PersonalInformation.csv");
            perInfPasswordTextbox.Text = LoginForm.password;
            perInfNameRichTextbox.Text = LoginForm.userList[userindex].Personinf.Name;
            perInfSurnameRichTextbox.Text = LoginForm.userList[userindex].Personinf.Surname;
            perInfPhoneRichTextbox.Text = LoginForm.userList[userindex].Personinf.Phonenumber;
            perInfEmailRichTextbox.Text = LoginForm.userList[userindex].Personinf.Email;
            perInfAddressRichTextbox.Text = LoginForm.userList[userindex].Personinf.Address;
            if (LoginForm.userList[userindex].Personinf.Image != "")
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(LoginForm.userList[userindex].Personinf.Image)));
                ProfilePictureBox.Image = img;
            }
            PInfPanel.Visible = true;
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

        private void savedetailsButton_Click(object sender, EventArgs e)
        {
            if (perInfNameRichTextbox.Text != "" && perInfSurnameRichTextbox.Text != ""
            && perInfPhoneRichTextbox.Text != "" && perInfEmailRichTextbox.Text != ""
            && perInfAddressRichTextbox.Text != "")
            {
                if (!IsAllDigits(perInfPhoneRichTextbox.Text))
                {
                    MessageBox.Show("Numbers must contain only digits", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (perInfPhoneRichTextbox.Text.Length != 10)
                {
                    MessageBox.Show("Wrong number size", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!IsValidMail(perInfEmailRichTextbox.Text))
                {
                    MessageBox.Show("Wrong Email Format", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Util.IsPboxNullOrEmpty(ProfilePictureBox))
                {
                    MessageBox.Show("Please Select a Picture", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                else
                {
                    LoginForm.userList[userindex].Password = Util.ComputeSha256Hash(perInfPasswordTextbox.Text);
                    LoginForm.password = perInfPasswordTextbox.Text;
                    LoginForm.userList[userindex].Personinf.Name = perInfNameRichTextbox.Text;
                    LoginForm.userList[userindex].Personinf.Surname = perInfSurnameRichTextbox.Text;
                    LoginForm.userList[userindex].Personinf.Email = perInfEmailRichTextbox.Text;
                    LoginForm.userList[userindex].Personinf.Phonenumber = perInfPhoneRichTextbox.Text;
                    LoginForm.userList[userindex].Personinf.Address = perInfAddressRichTextbox.Text;
                    if (LoginForm.userList[userindex].Personinf.Image=="")
                        LoginForm.userList[userindex].Personinf.Image = Util.ImageToBase64(ProfilePictureBox);
                    Util.savePersonalInformation(LoginForm.userList, "PersonalInformation.csv");
                    MessageBox.Show("Data saved successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Fields can not be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void makePassUnvisibleButton_Click(object sender, EventArgs e)
        {
            if (perInfPasswordTextbox.UseSystemPasswordChar)
            {
                perInfPasswordTextbox.UseSystemPasswordChar = false;
                makePassVisibleButton.BringToFront();
            }
            else
                perInfPasswordTextbox.UseSystemPasswordChar = true;
                makePassVisibleButton.BringToFront();
        }

        private void makePassVisibleButton_Click(object sender, EventArgs e)
        {
            if (perInfPasswordTextbox.UseSystemPasswordChar)
            {
                perInfPasswordTextbox.UseSystemPasswordChar = false;
                makePassUnvisibleButton.BringToFront();
            }   
            else
                perInfPasswordTextbox.UseSystemPasswordChar = true;
                makePassUnvisibleButton.BringToFront();
        }
        private void perInfNameRichTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Z)
            {
                perInfNameRichTextbox.Undo();
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Y)
            {
                perInfNameRichTextbox.Redo();
            }
        }
        private void perInfSurnameRichTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Z)
            {
                perInfSurnameRichTextbox.Undo();
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Y)
            {
                perInfSurnameRichTextbox.Redo();
            }
        }
        private void perInfEmailRichTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Z)
            {
                perInfEmailRichTextbox.Undo();
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Y)
            {
                perInfEmailRichTextbox.Redo();
            }
        }
        private void perInfAddressRichTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Z)
            {
                perInfAddressRichTextbox.Undo();
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Y)
            {
                perInfAddressRichTextbox.Redo();
            }
        }
        private void perInfPhoneRichTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Z)
            {
                perInfPhoneRichTextbox.Undo();
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Y)
            {
                perInfPhoneRichTextbox.Redo();
            }
        }

        private void salaryInfButton_Click(object sender, EventArgs e)
        {
            phonebookPanel.Visible = false;
            notesPanel.Visible = false;
            PInfPanel.Visible = false;
            reminderPanel.Visible = false;
            deneyimCumboBox.SelectedIndex = LoginForm.userList[userindex].Personinf.Deneyim;
            ilComboBox.SelectedIndex = LoginForm.userList[userindex].Personinf.Il;
            dereceCumboBox.SelectedIndex = LoginForm.userList[userindex].Personinf.Derece;
            dilComboBox.SelectedIndex = LoginForm.userList[userindex].Personinf.Dil;
            gorevComboBox.SelectedIndex = LoginForm.userList[userindex].Personinf.Gorev;
            aileComboBox.SelectedIndex = LoginForm.userList[userindex].Personinf.Aile;

            salaryInfPanel.Visible = true;
        }

        private void saveSalaryInfButton_Click(object sender, EventArgs e)
        {
            if (deneyimCumboBox.SelectedIndex<0)
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

            LoginForm.userList[userindex].Personinf.Deneyim = deneyimCumboBox.SelectedIndex;
            LoginForm.userList[userindex].Personinf.Il = ilComboBox.SelectedIndex;
            LoginForm.userList[userindex].Personinf.Derece = dereceCumboBox.SelectedIndex;
            LoginForm.userList[userindex].Personinf.Dil = dilComboBox.SelectedIndex;
            LoginForm.userList[userindex].Personinf.Gorev = gorevComboBox.SelectedIndex;
            LoginForm.userList[userindex].Personinf.Aile = aileComboBox.SelectedIndex;
            MessageBox.Show("Data saved succesfully");
        }

        private void reminderButton_Click(object sender, EventArgs e)
        {
            phonebookPanel.Visible = false;
            PInfPanel.Visible = false;
            salaryInfPanel.Visible = false;
            notesPanel.Visible = false;
            reminderPanel.Visible = true;
        }

        private void currentdateTimePickerReminder_Validating(object sender, CancelEventArgs e)
        {
            if (Date.Value < DateTime.Today)
            {
                MessageBox.Show("You can't choose this date!");
                e.Cancel = true;
            }
        }
        private void addReminderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (summaryReminderBox.Text == "" && descriptionReminderBox.Text == "")
                {
                    MessageBox.Show("Fields can't be empty.");
                    return;
                }
                if (Date.Value <= DateTime.Now && Time.Value <= DateTime.Now)
                {
                    MessageBox.Show("Alarm time cannot be earlier.", "Error");
                    return;
                }
                if (reminderComboBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select Reminder Type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                else
                {
                    ListViewItem item = new ListViewItem(Date.Text, 0);
                    item.SubItems.Add(Time.Text);
                    item.SubItems.Add(descriptionReminderBox.Text);
                    item.SubItems.Add(summaryReminderBox.Text);
                    item.SubItems.Add(reminderComboBox.SelectedItem.ToString());
                    reminderList.Items.Add(item);
                    DateTime date = new DateTime(Date.Value.Year, Date.Value.Month, Date.Value.Day, 
                        Time.Value.Hour, Time.Value.Minute, Time.Value.Second);
                    LoginForm.userList[userindex].Remind.Add(new Reminder(date, summaryReminderBox.Text, 
                        descriptionReminderBox.Text, reminderComboBox.SelectedItem.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectedTimePickerReminder_MouseDown(object sender, MouseEventArgs e)
        {
            Time.CustomFormat = "HH:mm:ss";
        }

        private void reminderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reminderList.SelectedItems.Count > 0)
            {
                Date.Value = LoginForm.userList[userindex].Remind[reminderList.SelectedItems[0].Index].Datetime;
                Time.Value = LoginForm.userList[userindex].Remind[reminderList.SelectedItems[0].Index].Datetime;
                descriptionReminderBox.Text = LoginForm.userList[userindex].Remind[reminderList.SelectedItems[0].Index].Description;
                summaryReminderBox.Text = LoginForm.userList[userindex].Remind[reminderList.SelectedItems[0].Index].Summary;
                string type = reminderList.SelectedItems[0].SubItems[4].Text;
                if (type == "meeting")
                    reminderComboBox.SelectedIndex = 0;
                else
                    reminderComboBox.SelectedIndex = 1;
            }
        }

        private void deleteReminderBtn_Click(object sender, EventArgs e)
        {
            if (reminderList.SelectedItems.Count > 0)
            {
                LoginForm.userList[userindex].Remind.RemoveAt(reminderList.SelectedItems[0].Index);
                reminderList.Items.Remove(reminderList.SelectedItems[0]);
            }
        }

        private void updateReminderBtn_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(Date.Value.Year, Date.Value.Month, Date.Value.Day, Time.Value.Hour, Time.Value.Minute, Time.Value.Second);
            LoginForm.userList[userindex].Remind[reminderList.SelectedItems[0].Index].Datetime = date;
            LoginForm.userList[userindex].Remind[reminderList.SelectedItems[0].Index].Description = descriptionReminderBox.Text;
            LoginForm.userList[userindex].Remind[reminderList.SelectedItems[0].Index].Summary = summaryReminderBox.Text;
            if (reminderComboBox.SelectedIndex ==0)
                LoginForm.userList[userindex].Remind[reminderList.SelectedItems[0].Index].Remindertype = "meeting";
            else
                LoginForm.userList[userindex].Remind[reminderList.SelectedItems[0].Index].Remindertype = "task";
            reminderList.Items.Clear();
            for (int i = 0; i < LoginForm.userList[userindex].Remind.Count; i++)
            {
                ListViewItem item = new ListViewItem(LoginForm.userList[userindex].Remind[i].Datetime.ToString("yyyy/MM//dd"), 0);
                item.SubItems.Add(LoginForm.userList[userindex].Remind[i].Datetime.ToString("HH:mm:ss"));
                item.SubItems.Add(LoginForm.userList[userindex].Remind[i].Description);
                item.SubItems.Add(LoginForm.userList[userindex].Remind[i].Summary);
                item.SubItems.Add(LoginForm.userList[userindex].Remind[i].Remindertype);
                reminderList.Items.Add(item);
            }
        }

        private void saveRemainderButton_Click(object sender, EventArgs e)
        {
            Util.SaveReminder(LoginForm.userList, "reminder.csv");
            MessageBox.Show("Data saved successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (Reminder rem in LoginForm.userList[userindex].Remind)
            {
                if (DateTime.Now <= rem.Datetime)
                    ReminderQueue.Enqueue(rem);
            }
        }

        private void listReminderBtn_Click(object sender, EventArgs e)
        {
            reminderList.Items.Clear();
            Util.LoadReminder(LoginForm.userList, "reminder.csv");

            for (int i = 0; i < LoginForm.userList[userindex].Remind.Count; i++)
            {
                ListViewItem item = new ListViewItem(LoginForm.userList[userindex].Remind[i].Datetime.ToString("yyyy/MM/dd"), 0);
                item.SubItems.Add(LoginForm.userList[userindex].Remind[i].Datetime.ToString("HH:mm:ss"));
                item.SubItems.Add(LoginForm.userList[userindex].Remind[i].Description);
                item.SubItems.Add(LoginForm.userList[userindex].Remind[i].Summary);
                item.SubItems.Add(LoginForm.userList[userindex].Remind[i].Remindertype);
                reminderList.Items.Add(item);
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            Util.LoadReminder(LoginForm.userList, "reminder.csv");
            foreach (Reminder rem in LoginForm.userList[userindex].Remind)
                ReminderQueue.Enqueue(rem);
        }

        private void currenttimeTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            if (ReminderQueue.Count != 0)
            {
                Reminder rem = ReminderQueue.Peek();
                ReminderAlert RA = new ReminderAlert(rem);
                if (DateTime.Now.Year == rem.Datetime.Year && DateTime.Now.Month == rem.Datetime.Month &&
                    DateTime.Now.Day == rem.Datetime.Day && DateTime.Now.Hour == rem.Datetime.Hour &&
                    DateTime.Now.Minute == rem.Datetime.Minute && DateTime.Now.Second == rem.Datetime.Second)
                {
                    if (ReminderQueue.Count != 0)
                    {
                        ReminderQueue.Dequeue();
                        RA.Show();
                        for (int i = 0; i < 700; i++)
                        {
                            RA.Left += 2;
                            RA.Left -= 2;
                        }
                    }
                }
                if (DateTime.Now > rem.Datetime)
                {
                    if (ReminderQueue.Count != 0)
                    {
                        ReminderQueue.Dequeue();
                        MessageBox.Show("Description: " + rem.Description, "Your are late for your " + rem.Remindertype + " that was at " + rem.Datetime);
                    }     
                }
            }
        }
    }
}