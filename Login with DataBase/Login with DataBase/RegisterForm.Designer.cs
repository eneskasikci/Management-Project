namespace Login_with_DataBase
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.icon2Button = new System.Windows.Forms.Button();
            this.icon1Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(684, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(24, 25);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create Account";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.Location = new System.Drawing.Point(75, 115);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 20);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Username";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTextBox.Location = new System.Drawing.Point(175, 115);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(142, 26);
            this.nameTextBox.TabIndex = 0;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLabel.Location = new System.Drawing.Point(75, 162);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(79, 20);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox.Location = new System.Drawing.Point(175, 162);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(142, 26);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // createButton
            // 
            this.createButton.AutoSize = true;
            this.createButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.createButton.Location = new System.Drawing.Point(242, 217);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 30);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // icon2Button
            // 
            this.icon2Button.AutoSize = true;
            this.icon2Button.BackgroundImage = global::Login_with_DataBase.Properties.Resources.show2;
            this.icon2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon2Button.FlatAppearance.BorderSize = 0;
            this.icon2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icon2Button.Location = new System.Drawing.Point(323, 163);
            this.icon2Button.Name = "icon2Button";
            this.icon2Button.Size = new System.Drawing.Size(29, 24);
            this.icon2Button.TabIndex = 6;
            this.icon2Button.UseVisualStyleBackColor = true;
            this.icon2Button.Click += new System.EventHandler(this.icon2Button_Click);
            // 
            // icon1Button
            // 
            this.icon1Button.AutoSize = true;
            this.icon1Button.BackgroundImage = global::Login_with_DataBase.Properties.Resources.show1;
            this.icon1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon1Button.FlatAppearance.BorderSize = 0;
            this.icon1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icon1Button.Location = new System.Drawing.Point(323, 163);
            this.icon1Button.Name = "icon1Button";
            this.icon1Button.Size = new System.Drawing.Size(29, 24);
            this.icon1Button.TabIndex = 6;
            this.icon1Button.UseVisualStyleBackColor = true;
            this.icon1Button.Click += new System.EventHandler(this.icon1Button_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(720, 460);
            this.Controls.Add(this.icon2Button);
            this.Controls.Add(this.icon1Button);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button icon1Button;
        private System.Windows.Forms.Button icon2Button;
    }
}