namespace Login_with_DataBase
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.exitButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.userMangementButton = new System.Windows.Forms.Button();
            this.phonebookButton = new System.Windows.Forms.Button();
            this.phonebookPanel = new System.Windows.Forms.Panel();
            this.listPhonebookButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.createButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.notesButton = new System.Windows.Forms.Button();
            this.notesPanel = new System.Windows.Forms.Panel();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.yourNotePanel = new System.Windows.Forms.Panel();
            this.deleteNoteButton = new System.Windows.Forms.Button();
            this.yourNoteTxtBox = new System.Windows.Forms.TextBox();
            this.yourNoteLbl = new System.Windows.Forms.Label();
            this.updateNoteButton = new System.Windows.Forms.Button();
            this.createNoteButton = new System.Windows.Forms.Button();
            this.listNotesButton = new System.Windows.Forms.Button();
            this.noteBox = new System.Windows.Forms.ListBox();
            this.PInfPanel = new System.Windows.Forms.Panel();
            this.makePassUnvisibleButton = new System.Windows.Forms.Button();
            this.makePassVisibleButton = new System.Windows.Forms.Button();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.addresLbl = new System.Windows.Forms.Label();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.savedetailsButton = new System.Windows.Forms.Button();
            this.perInfPasswordTextbox = new System.Windows.Forms.TextBox();
            this.PInfButton = new System.Windows.Forms.Button();
            this.perInfNameRichTextbox = new System.Windows.Forms.RichTextBox();
            this.perInfSurnameRichTextbox = new System.Windows.Forms.RichTextBox();
            this.perInfEmailRichTextbox = new System.Windows.Forms.RichTextBox();
            this.perInfPhoneRichTextbox = new System.Windows.Forms.RichTextBox();
            this.perInfAddressRichTextbox = new System.Windows.Forms.RichTextBox();
            this.phonebookPanel.SuspendLayout();
            this.notesPanel.SuspendLayout();
            this.yourNotePanel.SuspendLayout();
            this.PInfPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.AutoSize = true;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(1063, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 25);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.AutoSize = true;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logOutButton.Location = new System.Drawing.Point(988, 650);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(90, 30);
            this.logOutButton.TabIndex = 7;
            this.logOutButton.Text = "LOG OUT";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome";
            // 
            // userMangementButton
            // 
            this.userMangementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userMangementButton.AutoSize = true;
            this.userMangementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userMangementButton.Location = new System.Drawing.Point(22, 650);
            this.userMangementButton.Name = "userMangementButton";
            this.userMangementButton.Size = new System.Drawing.Size(156, 30);
            this.userMangementButton.TabIndex = 11;
            this.userMangementButton.Text = "User Management";
            this.userMangementButton.UseVisualStyleBackColor = true;
            this.userMangementButton.Click += new System.EventHandler(this.userMangementButton_Click);
            // 
            // phonebookButton
            // 
            this.phonebookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phonebookButton.Location = new System.Drawing.Point(36, 103);
            this.phonebookButton.Name = "phonebookButton";
            this.phonebookButton.Size = new System.Drawing.Size(132, 40);
            this.phonebookButton.TabIndex = 12;
            this.phonebookButton.Text = "Phone Book";
            this.phonebookButton.UseVisualStyleBackColor = true;
            this.phonebookButton.Click += new System.EventHandler(this.phonebookButton_Click);
            // 
            // phonebookPanel
            // 
            this.phonebookPanel.BackColor = System.Drawing.SystemColors.Control;
            this.phonebookPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phonebookPanel.Controls.Add(this.listPhonebookButton);
            this.phonebookPanel.Controls.Add(this.saveButton);
            this.phonebookPanel.Controls.Add(this.listView1);
            this.phonebookPanel.Controls.Add(this.createButton);
            this.phonebookPanel.Controls.Add(this.updateButton);
            this.phonebookPanel.Controls.Add(this.deleteButton);
            this.phonebookPanel.Controls.Add(this.addressTextBox);
            this.phonebookPanel.Controls.Add(this.descriptionTextBox);
            this.phonebookPanel.Controls.Add(this.emailTextBox);
            this.phonebookPanel.Controls.Add(this.phoneTextBox);
            this.phonebookPanel.Controls.Add(this.surnameTextBox);
            this.phonebookPanel.Controls.Add(this.nameTextBox);
            this.phonebookPanel.Controls.Add(this.addressLabel);
            this.phonebookPanel.Controls.Add(this.descriptionLabel);
            this.phonebookPanel.Controls.Add(this.mailLabel);
            this.phonebookPanel.Controls.Add(this.numberLabel);
            this.phonebookPanel.Controls.Add(this.surnameLabel);
            this.phonebookPanel.Controls.Add(this.nameLabel);
            this.phonebookPanel.Location = new System.Drawing.Point(227, 103);
            this.phonebookPanel.Name = "phonebookPanel";
            this.phonebookPanel.Size = new System.Drawing.Size(823, 485);
            this.phonebookPanel.TabIndex = 13;
            this.phonebookPanel.Visible = false;
            // 
            // listPhonebookButton
            // 
            this.listPhonebookButton.Location = new System.Drawing.Point(36, 435);
            this.listPhonebookButton.Name = "listPhonebookButton";
            this.listPhonebookButton.Size = new System.Drawing.Size(95, 23);
            this.listPhonebookButton.TabIndex = 17;
            this.listPhonebookButton.Text = "List Phonebook";
            this.listPhonebookButton.UseVisualStyleBackColor = true;
            this.listPhonebookButton.Click += new System.EventHandler(this.listPhonebookButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(711, 418);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save All";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(36, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(404, 382);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Surname";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone Number";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E-Mail";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Description";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Address";
            this.columnHeader6.Width = 100;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(515, 370);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 14;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(614, 370);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(711, 370);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(601, 254);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(185, 84);
            this.addressTextBox.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(601, 174);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(185, 56);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(601, 140);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(185, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(601, 106);
            this.phoneTextBox.MaxLength = 10;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(185, 20);
            this.phoneTextBox.TabIndex = 2;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(601, 72);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(185, 20);
            this.surnameTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(601, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(185, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addressLabel.Location = new System.Drawing.Point(512, 257);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(64, 17);
            this.addressLabel.TabIndex = 5;
            this.addressLabel.Text = "Address:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.descriptionLabel.Location = new System.Drawing.Point(493, 177);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description:";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailLabel.Location = new System.Drawing.Point(525, 143);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(51, 17);
            this.mailLabel.TabIndex = 3;
            this.mailLabel.Text = "E-Mail:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberLabel.Location = new System.Drawing.Point(469, 109);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(107, 17);
            this.numberLabel.TabIndex = 2;
            this.numberLabel.Text = "Phone Number:";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameLabel.Location = new System.Drawing.Point(496, 75);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(80, 17);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Last Name:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.Location = new System.Drawing.Point(496, 41);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(80, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "First Name:";
            // 
            // notesButton
            // 
            this.notesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notesButton.Location = new System.Drawing.Point(36, 157);
            this.notesButton.Name = "notesButton";
            this.notesButton.Size = new System.Drawing.Size(132, 40);
            this.notesButton.TabIndex = 14;
            this.notesButton.Text = "Notes";
            this.notesButton.UseVisualStyleBackColor = true;
            this.notesButton.Click += new System.EventHandler(this.notesButton_Click);
            // 
            // notesPanel
            // 
            this.notesPanel.BackColor = System.Drawing.SystemColors.Control;
            this.notesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesPanel.Controls.Add(this.saveFileButton);
            this.notesPanel.Controls.Add(this.yourNotePanel);
            this.notesPanel.Controls.Add(this.listNotesButton);
            this.notesPanel.Controls.Add(this.noteBox);
            this.notesPanel.Location = new System.Drawing.Point(227, 103);
            this.notesPanel.Name = "notesPanel";
            this.notesPanel.Size = new System.Drawing.Size(823, 485);
            this.notesPanel.TabIndex = 17;
            this.notesPanel.Visible = false;
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(676, 435);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(113, 23);
            this.saveFileButton.TabIndex = 10;
            this.saveFileButton.Text = "Save File";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // yourNotePanel
            // 
            this.yourNotePanel.Controls.Add(this.deleteNoteButton);
            this.yourNotePanel.Controls.Add(this.yourNoteTxtBox);
            this.yourNotePanel.Controls.Add(this.yourNoteLbl);
            this.yourNotePanel.Controls.Add(this.updateNoteButton);
            this.yourNotePanel.Controls.Add(this.createNoteButton);
            this.yourNotePanel.Location = new System.Drawing.Point(488, 38);
            this.yourNotePanel.Name = "yourNotePanel";
            this.yourNotePanel.Size = new System.Drawing.Size(301, 337);
            this.yourNotePanel.TabIndex = 9;
            // 
            // deleteNoteButton
            // 
            this.deleteNoteButton.Location = new System.Drawing.Point(92, 143);
            this.deleteNoteButton.Name = "deleteNoteButton";
            this.deleteNoteButton.Size = new System.Drawing.Size(113, 23);
            this.deleteNoteButton.TabIndex = 6;
            this.deleteNoteButton.Text = "Delete a Note";
            this.deleteNoteButton.UseVisualStyleBackColor = true;
            this.deleteNoteButton.Click += new System.EventHandler(this.deleteNoteButton_Click);
            // 
            // yourNoteTxtBox
            // 
            this.yourNoteTxtBox.Location = new System.Drawing.Point(37, 34);
            this.yourNoteTxtBox.Multiline = true;
            this.yourNoteTxtBox.Name = "yourNoteTxtBox";
            this.yourNoteTxtBox.Size = new System.Drawing.Size(232, 69);
            this.yourNoteTxtBox.TabIndex = 7;
            // 
            // yourNoteLbl
            // 
            this.yourNoteLbl.AutoSize = true;
            this.yourNoteLbl.Location = new System.Drawing.Point(122, 18);
            this.yourNoteLbl.Name = "yourNoteLbl";
            this.yourNoteLbl.Size = new System.Drawing.Size(55, 13);
            this.yourNoteLbl.TabIndex = 8;
            this.yourNoteLbl.Text = "Your Note";
            // 
            // updateNoteButton
            // 
            this.updateNoteButton.Location = new System.Drawing.Point(156, 114);
            this.updateNoteButton.Name = "updateNoteButton";
            this.updateNoteButton.Size = new System.Drawing.Size(113, 23);
            this.updateNoteButton.TabIndex = 3;
            this.updateNoteButton.Text = "Update a Note";
            this.updateNoteButton.UseVisualStyleBackColor = true;
            this.updateNoteButton.Click += new System.EventHandler(this.updateNoteButton_Click);
            // 
            // createNoteButton
            // 
            this.createNoteButton.Location = new System.Drawing.Point(37, 114);
            this.createNoteButton.Name = "createNoteButton";
            this.createNoteButton.Size = new System.Drawing.Size(113, 23);
            this.createNoteButton.TabIndex = 0;
            this.createNoteButton.Text = "Create a Note";
            this.createNoteButton.UseVisualStyleBackColor = true;
            this.createNoteButton.Click += new System.EventHandler(this.createNoteButton_Click);
            // 
            // listNotesButton
            // 
            this.listNotesButton.Location = new System.Drawing.Point(12, 9);
            this.listNotesButton.Name = "listNotesButton";
            this.listNotesButton.Size = new System.Drawing.Size(470, 23);
            this.listNotesButton.TabIndex = 5;
            this.listNotesButton.Text = "List Notes";
            this.listNotesButton.UseVisualStyleBackColor = true;
            this.listNotesButton.Click += new System.EventHandler(this.listNotesButton_Click);
            // 
            // noteBox
            // 
            this.noteBox.FormattingEnabled = true;
            this.noteBox.Location = new System.Drawing.Point(12, 38);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(470, 420);
            this.noteBox.TabIndex = 4;
            this.noteBox.SelectedIndexChanged += new System.EventHandler(this.noteBox_SelectedIndexChanged);
            // 
            // PInfPanel
            // 
            this.PInfPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PInfPanel.Controls.Add(this.perInfAddressRichTextbox);
            this.PInfPanel.Controls.Add(this.perInfPhoneRichTextbox);
            this.PInfPanel.Controls.Add(this.perInfEmailRichTextbox);
            this.PInfPanel.Controls.Add(this.perInfSurnameRichTextbox);
            this.PInfPanel.Controls.Add(this.perInfNameRichTextbox);
            this.PInfPanel.Controls.Add(this.makePassUnvisibleButton);
            this.PInfPanel.Controls.Add(this.makePassVisibleButton);
            this.PInfPanel.Controls.Add(this.selectImageButton);
            this.PInfPanel.Controls.Add(this.addresLbl);
            this.PInfPanel.Controls.Add(this.ProfilePictureBox);
            this.PInfPanel.Controls.Add(this.phoneLbl);
            this.PInfPanel.Controls.Add(this.emailLbl);
            this.PInfPanel.Controls.Add(this.surnameLbl);
            this.PInfPanel.Controls.Add(this.LabelName);
            this.PInfPanel.Controls.Add(this.PasswordLabel);
            this.PInfPanel.Controls.Add(this.savedetailsButton);
            this.PInfPanel.Controls.Add(this.perInfPasswordTextbox);
            this.PInfPanel.Location = new System.Drawing.Point(227, 103);
            this.PInfPanel.Name = "PInfPanel";
            this.PInfPanel.Size = new System.Drawing.Size(823, 489);
            this.PInfPanel.TabIndex = 18;
            this.PInfPanel.Visible = false;
            // 
            // makePassUnvisibleButton
            // 
            this.makePassUnvisibleButton.AutoSize = true;
            this.makePassUnvisibleButton.BackgroundImage = global::Login_with_DataBase.Properties.Resources.show2;
            this.makePassUnvisibleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.makePassUnvisibleButton.FlatAppearance.BorderSize = 0;
            this.makePassUnvisibleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makePassUnvisibleButton.Location = new System.Drawing.Point(202, 103);
            this.makePassUnvisibleButton.Name = "makePassUnvisibleButton";
            this.makePassUnvisibleButton.Size = new System.Drawing.Size(29, 24);
            this.makePassUnvisibleButton.TabIndex = 19;
            this.makePassUnvisibleButton.UseVisualStyleBackColor = true;
            this.makePassUnvisibleButton.Click += new System.EventHandler(this.makePassUnvisibleButton_Click);
            // 
            // makePassVisibleButton
            // 
            this.makePassVisibleButton.AutoSize = true;
            this.makePassVisibleButton.BackgroundImage = global::Login_with_DataBase.Properties.Resources.show1;
            this.makePassVisibleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.makePassVisibleButton.FlatAppearance.BorderSize = 0;
            this.makePassVisibleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makePassVisibleButton.Location = new System.Drawing.Point(202, 103);
            this.makePassVisibleButton.Name = "makePassVisibleButton";
            this.makePassVisibleButton.Size = new System.Drawing.Size(29, 24);
            this.makePassVisibleButton.TabIndex = 18;
            this.makePassVisibleButton.UseVisualStyleBackColor = true;
            this.makePassVisibleButton.Click += new System.EventHandler(this.makePassVisibleButton_Click);
            // 
            // selectImageButton
            // 
            this.selectImageButton.Location = new System.Drawing.Point(462, 347);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(115, 29);
            this.selectImageButton.TabIndex = 6;
            this.selectImageButton.Text = "Select Image";
            this.selectImageButton.UseVisualStyleBackColor = true;
            this.selectImageButton.Click += new System.EventHandler(this.selectImageButton_Click);
            // 
            // addresLbl
            // 
            this.addresLbl.AutoSize = true;
            this.addresLbl.Location = new System.Drawing.Point(77, 287);
            this.addresLbl.Name = "addresLbl";
            this.addresLbl.Size = new System.Drawing.Size(39, 13);
            this.addresLbl.TabIndex = 14;
            this.addresLbl.Text = "Adress";
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePictureBox.Location = new System.Drawing.Point(369, 92);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(206, 230);
            this.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePictureBox.TabIndex = 13;
            this.ProfilePictureBox.TabStop = false;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(74, 248);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(38, 13);
            this.phoneLbl.TabIndex = 11;
            this.phoneLbl.Text = "Phone";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(74, 209);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(32, 13);
            this.emailLbl.TabIndex = 10;
            this.emailLbl.Text = "Email";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Location = new System.Drawing.Point(74, 170);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(49, 13);
            this.surnameLbl.TabIndex = 9;
            this.surnameLbl.Text = "Surname";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(74, 131);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 13);
            this.LabelName.TabIndex = 8;
            this.LabelName.Text = "Name";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(74, 92);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Password";
            // 
            // savedetailsButton
            // 
            this.savedetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedetailsButton.Location = new System.Drawing.Point(677, 423);
            this.savedetailsButton.Name = "savedetailsButton";
            this.savedetailsButton.Size = new System.Drawing.Size(116, 40);
            this.savedetailsButton.TabIndex = 7;
            this.savedetailsButton.Text = "Save";
            this.savedetailsButton.UseVisualStyleBackColor = true;
            this.savedetailsButton.Click += new System.EventHandler(this.savedetailsButton_Click);
            // 
            // perInfPasswordTextbox
            // 
            this.perInfPasswordTextbox.Location = new System.Drawing.Point(77, 108);
            this.perInfPasswordTextbox.Name = "perInfPasswordTextbox";
            this.perInfPasswordTextbox.Size = new System.Drawing.Size(119, 20);
            this.perInfPasswordTextbox.TabIndex = 0;
            this.perInfPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // PInfButton
            // 
            this.PInfButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PInfButton.Location = new System.Drawing.Point(36, 213);
            this.PInfButton.Name = "PInfButton";
            this.PInfButton.Size = new System.Drawing.Size(132, 40);
            this.PInfButton.TabIndex = 18;
            this.PInfButton.Text = "Personal Information";
            this.PInfButton.UseVisualStyleBackColor = true;
            this.PInfButton.Click += new System.EventHandler(this.PInfButton_Click);
            // 
            // perInfNameRichTextbox
            // 
            this.perInfNameRichTextbox.Location = new System.Drawing.Point(77, 147);
            this.perInfNameRichTextbox.Name = "perInfNameRichTextbox";
            this.perInfNameRichTextbox.Size = new System.Drawing.Size(119, 20);
            this.perInfNameRichTextbox.TabIndex = 20;
            this.perInfNameRichTextbox.Text = "";
            // 
            // perInfSurnameRichTextbox
            // 
            this.perInfSurnameRichTextbox.Location = new System.Drawing.Point(77, 185);
            this.perInfSurnameRichTextbox.Name = "perInfSurnameRichTextbox";
            this.perInfSurnameRichTextbox.Size = new System.Drawing.Size(119, 20);
            this.perInfSurnameRichTextbox.TabIndex = 21;
            this.perInfSurnameRichTextbox.Text = "";
            // 
            // perInfEmailRichTextbox
            // 
            this.perInfEmailRichTextbox.Location = new System.Drawing.Point(77, 225);
            this.perInfEmailRichTextbox.Name = "perInfEmailRichTextbox";
            this.perInfEmailRichTextbox.Size = new System.Drawing.Size(119, 20);
            this.perInfEmailRichTextbox.TabIndex = 22;
            this.perInfEmailRichTextbox.Text = "";
            // 
            // perInfPhoneRichTextbox
            // 
            this.perInfPhoneRichTextbox.Location = new System.Drawing.Point(77, 264);
            this.perInfPhoneRichTextbox.Name = "perInfPhoneRichTextbox";
            this.perInfPhoneRichTextbox.Size = new System.Drawing.Size(119, 20);
            this.perInfPhoneRichTextbox.TabIndex = 23;
            this.perInfPhoneRichTextbox.Text = "";
            // 
            // perInfAddressRichTextbox
            // 
            this.perInfAddressRichTextbox.Location = new System.Drawing.Point(77, 303);
            this.perInfAddressRichTextbox.Name = "perInfAddressRichTextbox";
            this.perInfAddressRichTextbox.Size = new System.Drawing.Size(181, 74);
            this.perInfAddressRichTextbox.TabIndex = 24;
            this.perInfAddressRichTextbox.Text = "";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.PInfPanel);
            this.Controls.Add(this.PInfButton);
            this.Controls.Add(this.notesButton);
            this.Controls.Add(this.phonebookButton);
            this.Controls.Add(this.userMangementButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.notesPanel);
            this.Controls.Add(this.phonebookPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.phonebookPanel.ResumeLayout(false);
            this.phonebookPanel.PerformLayout();
            this.notesPanel.ResumeLayout(false);
            this.yourNotePanel.ResumeLayout(false);
            this.yourNotePanel.PerformLayout();
            this.PInfPanel.ResumeLayout(false);
            this.PInfPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userMangementButton;
        private System.Windows.Forms.Button phonebookButton;
        private System.Windows.Forms.Panel phonebookPanel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button notesButton;
        private System.Windows.Forms.Panel notesPanel;
        private System.Windows.Forms.Button updateNoteButton;
        private System.Windows.Forms.Button createNoteButton;
        private System.Windows.Forms.Button listNotesButton;
        private System.Windows.Forms.ListBox noteBox;
        private System.Windows.Forms.Panel yourNotePanel;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.TextBox yourNoteTxtBox;
        private System.Windows.Forms.Label yourNoteLbl;
        private System.Windows.Forms.Button deleteNoteButton;
        private System.Windows.Forms.Button listPhonebookButton;
        private System.Windows.Forms.Panel PInfPanel;
        private System.Windows.Forms.Button PInfButton;
        private System.Windows.Forms.TextBox perInfPasswordTextbox;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button savedetailsButton;
        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.Label addresLbl;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.Button makePassVisibleButton;
        private System.Windows.Forms.Button makePassUnvisibleButton;
        private System.Windows.Forms.RichTextBox perInfNameRichTextbox;
        private System.Windows.Forms.RichTextBox perInfSurnameRichTextbox;
        private System.Windows.Forms.RichTextBox perInfEmailRichTextbox;
        private System.Windows.Forms.RichTextBox perInfPhoneRichTextbox;
        private System.Windows.Forms.RichTextBox perInfAddressRichTextbox;
    }
}