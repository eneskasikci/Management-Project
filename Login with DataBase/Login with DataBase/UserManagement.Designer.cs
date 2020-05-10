namespace Login_with_DataBase
{
    partial class userManagementForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passwordColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usertypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usertypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.userSalaryInfoButton = new System.Windows.Forms.Button();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.salaryGroupBox = new System.Windows.Forms.GroupBox();
            this.salaryInfPanel = new System.Windows.Forms.Panel();
            this.aileComboBox = new System.Windows.Forms.ComboBox();
            this.aileLabel = new System.Windows.Forms.Label();
            this.gorevComboBox = new System.Windows.Forms.ComboBox();
            this.yoneticilikLabel = new System.Windows.Forms.Label();
            this.dilComboBox = new System.Windows.Forms.ComboBox();
            this.dilLabel = new System.Windows.Forms.Label();
            this.dereceCumboBox = new System.Windows.Forms.ComboBox();
            this.dereceLabel = new System.Windows.Forms.Label();
            this.ilComboBox = new System.Windows.Forms.ComboBox();
            this.ilLabel = new System.Windows.Forms.Label();
            this.deneyimLabel = new System.Windows.Forms.Label();
            this.deneyimCumboBox = new System.Windows.Forms.ComboBox();
            this.saveSalaryInfButton = new System.Windows.Forms.Button();
            this.salaryGroupBox.SuspendLayout();
            this.salaryInfPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.AutoSize = true;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(1064, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(24, 25);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "User Management";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.passwordColumn,
            this.usertypeColumn});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(58, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(367, 525);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Username";
            this.nameColumn.Width = 100;
            // 
            // passwordColumn
            // 
            this.passwordColumn.Text = "Password";
            this.passwordColumn.Width = 100;
            // 
            // usertypeColumn
            // 
            this.usertypeColumn.Text = "User Type";
            this.usertypeColumn.Width = 100;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(521, 96);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(192, 20);
            this.usernameTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(521, 129);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(192, 20);
            this.passwordTextBox.TabIndex = 12;
            // 
            // usertypeComboBox
            // 
            this.usertypeComboBox.FormattingEnabled = true;
            this.usertypeComboBox.Items.AddRange(new object[] {
            "admin",
            "user",
            "part-time-user"});
            this.usertypeComboBox.Location = new System.Drawing.Point(521, 164);
            this.usertypeComboBox.Name = "usertypeComboBox";
            this.usertypeComboBox.Size = new System.Drawing.Size(192, 21);
            this.usertypeComboBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "User Type:";
            // 
            // removeButton
            // 
            this.removeButton.AutoSize = true;
            this.removeButton.Location = new System.Drawing.Point(631, 211);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(82, 23);
            this.removeButton.TabIndex = 17;
            this.removeButton.Text = "Remove User";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(523, 211);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 18;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salaryLabel.Location = new System.Drawing.Point(9, 35);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(131, 18);
            this.salaryLabel.TabIndex = 21;
            this.salaryLabel.Text = "Minimum Salary = ";
            // 
            // userSalaryInfoButton
            // 
            this.userSalaryInfoButton.Location = new System.Drawing.Point(21, 85);
            this.userSalaryInfoButton.Name = "userSalaryInfoButton";
            this.userSalaryInfoButton.Size = new System.Drawing.Size(119, 23);
            this.userSalaryInfoButton.TabIndex = 22;
            this.userSalaryInfoButton.Text = "Edit User Salary Info";
            this.userSalaryInfoButton.UseVisualStyleBackColor = true;
            this.userSalaryInfoButton.Click += new System.EventHandler(this.userSalaryInfoButton_Click);
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(146, 33);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 23;
            // 
            // salaryGroupBox
            // 
            this.salaryGroupBox.Controls.Add(this.salaryTextBox);
            this.salaryGroupBox.Controls.Add(this.userSalaryInfoButton);
            this.salaryGroupBox.Controls.Add(this.salaryLabel);
            this.salaryGroupBox.Location = new System.Drawing.Point(776, 96);
            this.salaryGroupBox.Name = "salaryGroupBox";
            this.salaryGroupBox.Size = new System.Drawing.Size(287, 132);
            this.salaryGroupBox.TabIndex = 24;
            this.salaryGroupBox.TabStop = false;
            this.salaryGroupBox.Text = "Salary";
            // 
            // salaryInfPanel
            // 
            this.salaryInfPanel.BackColor = System.Drawing.SystemColors.Control;
            this.salaryInfPanel.Controls.Add(this.aileComboBox);
            this.salaryInfPanel.Controls.Add(this.aileLabel);
            this.salaryInfPanel.Controls.Add(this.gorevComboBox);
            this.salaryInfPanel.Controls.Add(this.yoneticilikLabel);
            this.salaryInfPanel.Controls.Add(this.dilComboBox);
            this.salaryInfPanel.Controls.Add(this.dilLabel);
            this.salaryInfPanel.Controls.Add(this.dereceCumboBox);
            this.salaryInfPanel.Controls.Add(this.dereceLabel);
            this.salaryInfPanel.Controls.Add(this.ilComboBox);
            this.salaryInfPanel.Controls.Add(this.ilLabel);
            this.salaryInfPanel.Controls.Add(this.deneyimLabel);
            this.salaryInfPanel.Controls.Add(this.deneyimCumboBox);
            this.salaryInfPanel.Controls.Add(this.saveSalaryInfButton);
            this.salaryInfPanel.Location = new System.Drawing.Point(483, 286);
            this.salaryInfPanel.Name = "salaryInfPanel";
            this.salaryInfPanel.Size = new System.Drawing.Size(580, 284);
            this.salaryInfPanel.TabIndex = 25;
            this.salaryInfPanel.Visible = false;
            // 
            // aileComboBox
            // 
            this.aileComboBox.FormattingEnabled = true;
            this.aileComboBox.Items.AddRange(new object[] {
            "Evli ve eşi çalışmıyor",
            "0-6 yaş arası çocuk",
            "7-18 yaş arası çocuk",
            "18 yaş üstü çocuk (Üniversite lisans/ön lisans öğrencisi olmak koşuluyla)"});
            this.aileComboBox.Location = new System.Drawing.Point(319, 195);
            this.aileComboBox.Name = "aileComboBox";
            this.aileComboBox.Size = new System.Drawing.Size(221, 21);
            this.aileComboBox.TabIndex = 31;
            // 
            // aileLabel
            // 
            this.aileLabel.AutoSize = true;
            this.aileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.aileLabel.Location = new System.Drawing.Point(316, 176);
            this.aileLabel.Name = "aileLabel";
            this.aileLabel.Size = new System.Drawing.Size(80, 16);
            this.aileLabel.TabIndex = 30;
            this.aileLabel.Text = "Aile Durumu";
            // 
            // gorevComboBox
            // 
            this.gorevComboBox.FormattingEnabled = true;
            this.gorevComboBox.Items.AddRange(new object[] {
            "Takım Lideri/Grup Yöneticisi/Teknik Yönetici/Yazılım Mimarı",
            "Proje Yöneticisi",
            "Direktör/Projeler Yöneticisi",
            "CTO/Genel Müdür",
            "Bilgi İşlem Sorumlusu/Müdürü (Bilgi İşlem biriminde en çok 5 bilişim personeli va" +
                "rsa)",
            "Bilgi İşlem Sorumlusu/Müdürü (Bilgi İşlem biriminde 5\'ten çok bilişim personeli v" +
                "arsa)"});
            this.gorevComboBox.Location = new System.Drawing.Point(319, 125);
            this.gorevComboBox.Name = "gorevComboBox";
            this.gorevComboBox.Size = new System.Drawing.Size(221, 21);
            this.gorevComboBox.TabIndex = 29;
            // 
            // yoneticilikLabel
            // 
            this.yoneticilikLabel.AutoSize = true;
            this.yoneticilikLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.yoneticilikLabel.Location = new System.Drawing.Point(316, 105);
            this.yoneticilikLabel.Name = "yoneticilikLabel";
            this.yoneticilikLabel.Size = new System.Drawing.Size(112, 16);
            this.yoneticilikLabel.TabIndex = 28;
            this.yoneticilikLabel.Text = "Yöneticilik Görevi";
            // 
            // dilComboBox
            // 
            this.dilComboBox.FormattingEnabled = true;
            this.dilComboBox.Items.AddRange(new object[] {
            "Belgelendirilmiş İngilizce bilgisi",
            "İngilizce eğitim veren okul mezuniyeti",
            "Belgelendirilmiş diğer yabancı dil bilgisi (her dil için)"});
            this.dilComboBox.Location = new System.Drawing.Point(319, 55);
            this.dilComboBox.Name = "dilComboBox";
            this.dilComboBox.Size = new System.Drawing.Size(221, 21);
            this.dilComboBox.TabIndex = 27;
            // 
            // dilLabel
            // 
            this.dilLabel.AutoSize = true;
            this.dilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dilLabel.Location = new System.Drawing.Point(316, 34);
            this.dilLabel.Name = "dilLabel";
            this.dilLabel.Size = new System.Drawing.Size(188, 16);
            this.dilLabel.TabIndex = 26;
            this.dilLabel.Text = "Belgelenen Yabancı Dil Bilgisi";
            // 
            // dereceCumboBox
            // 
            this.dereceCumboBox.FormattingEnabled = true;
            this.dereceCumboBox.Items.AddRange(new object[] {
            "Meslek alanı ile ilgili yüksek lisans",
            "Meslek alanı ile ilgili doktora",
            "Meslek alanı ile ilgili doçentlik",
            "Meslek alanı ile ilgili olmayan yüksek lisans",
            "Meslek alanı ile ilgili olmayan doktora/doçentlik"});
            this.dereceCumboBox.Location = new System.Drawing.Point(38, 195);
            this.dereceCumboBox.Name = "dereceCumboBox";
            this.dereceCumboBox.Size = new System.Drawing.Size(221, 21);
            this.dereceCumboBox.TabIndex = 25;
            // 
            // dereceLabel
            // 
            this.dereceLabel.AutoSize = true;
            this.dereceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dereceLabel.Location = new System.Drawing.Point(35, 173);
            this.dereceLabel.Name = "dereceLabel";
            this.dereceLabel.Size = new System.Drawing.Size(157, 16);
            this.dereceLabel.TabIndex = 24;
            this.dereceLabel.Text = "Alınan Akademik Derece";
            // 
            // ilComboBox
            // 
            this.ilComboBox.FormattingEnabled = true;
            this.ilComboBox.Items.AddRange(new object[] {
            "TR10: İstanbul",
            "TR51: Ankara",
            "TR31: İzmir",
            "TR42: Kocaeli, Sakarya, Düzce, Bolu, Yalova",
            "TR21: Edirne, Kırklareli, Tekirdağ",
            "TR90: Trabzon, Ordu, Giresun, Rize, Artvin, Gümüşhane",
            "TR41: Bursa, Eskişehir, Bilecik",
            "TR32: Aydın, Denizli, Muğla",
            "TR62: Adana, Mersin",
            "TR22: Balıkesir, Çanakkale",
            "TR61: Antalya, Isparta, Burdur"});
            this.ilComboBox.Location = new System.Drawing.Point(38, 125);
            this.ilComboBox.Name = "ilComboBox";
            this.ilComboBox.Size = new System.Drawing.Size(221, 21);
            this.ilComboBox.TabIndex = 23;
            // 
            // ilLabel
            // 
            this.ilLabel.AutoSize = true;
            this.ilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ilLabel.Location = new System.Drawing.Point(35, 102);
            this.ilLabel.Name = "ilLabel";
            this.ilLabel.Size = new System.Drawing.Size(116, 16);
            this.ilLabel.TabIndex = 22;
            this.ilLabel.Text = "Yaşanılan İl Grubu";
            // 
            // deneyimLabel
            // 
            this.deneyimLabel.AutoSize = true;
            this.deneyimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.deneyimLabel.Location = new System.Drawing.Point(35, 31);
            this.deneyimLabel.Name = "deneyimLabel";
            this.deneyimLabel.Size = new System.Drawing.Size(103, 16);
            this.deneyimLabel.TabIndex = 9;
            this.deneyimLabel.Text = "Deneyim Suresi";
            // 
            // deneyimCumboBox
            // 
            this.deneyimCumboBox.FormattingEnabled = true;
            this.deneyimCumboBox.Items.AddRange(new object[] {
            "2-4",
            "5-9",
            "10-14",
            "15-20",
            "20 years and upper"});
            this.deneyimCumboBox.Location = new System.Drawing.Point(38, 55);
            this.deneyimCumboBox.Name = "deneyimCumboBox";
            this.deneyimCumboBox.Size = new System.Drawing.Size(221, 21);
            this.deneyimCumboBox.TabIndex = 8;
            // 
            // saveSalaryInfButton
            // 
            this.saveSalaryInfButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSalaryInfButton.Location = new System.Drawing.Point(459, 237);
            this.saveSalaryInfButton.Name = "saveSalaryInfButton";
            this.saveSalaryInfButton.Size = new System.Drawing.Size(80, 30);
            this.saveSalaryInfButton.TabIndex = 21;
            this.saveSalaryInfButton.Text = "Save";
            this.saveSalaryInfButton.UseVisualStyleBackColor = true;
            this.saveSalaryInfButton.Click += new System.EventHandler(this.saveSalaryInfButton_Click);
            // 
            // userManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.salaryInfPanel);
            this.Controls.Add(this.salaryGroupBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usertypeComboBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userManagementForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.salaryGroupBox.ResumeLayout(false);
            this.salaryGroupBox.PerformLayout();
            this.salaryInfPanel.ResumeLayout(false);
            this.salaryInfPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader passwordColumn;
        private System.Windows.Forms.ColumnHeader usertypeColumn;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ComboBox usertypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Button userSalaryInfoButton;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.GroupBox salaryGroupBox;
        private System.Windows.Forms.Panel salaryInfPanel;
        private System.Windows.Forms.ComboBox aileComboBox;
        private System.Windows.Forms.Label aileLabel;
        private System.Windows.Forms.ComboBox gorevComboBox;
        private System.Windows.Forms.Label yoneticilikLabel;
        private System.Windows.Forms.ComboBox dilComboBox;
        private System.Windows.Forms.Label dilLabel;
        private System.Windows.Forms.ComboBox dereceCumboBox;
        private System.Windows.Forms.Label dereceLabel;
        private System.Windows.Forms.ComboBox ilComboBox;
        private System.Windows.Forms.Label ilLabel;
        private System.Windows.Forms.Label deneyimLabel;
        private System.Windows.Forms.ComboBox deneyimCumboBox;
        private System.Windows.Forms.Button saveSalaryInfButton;
    }
}