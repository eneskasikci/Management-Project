﻿namespace Login_with_DataBase
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(75, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(175, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(75, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(175, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(242, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(720, 460);
            this.Controls.Add(this.icon2Button);
            this.Controls.Add(this.icon1Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button icon1Button;
        private System.Windows.Forms.Button icon2Button;
    }
}