namespace Login_with_DataBase
{
    partial class ReminderAlert
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
            this.reminderAlertCloseBtn = new System.Windows.Forms.Button();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reminderAlertCloseBtn
            // 
            this.reminderAlertCloseBtn.Location = new System.Drawing.Point(142, 103);
            this.reminderAlertCloseBtn.Name = "reminderAlertCloseBtn";
            this.reminderAlertCloseBtn.Size = new System.Drawing.Size(75, 23);
            this.reminderAlertCloseBtn.TabIndex = 0;
            this.reminderAlertCloseBtn.Text = "Close";
            this.reminderAlertCloseBtn.UseVisualStyleBackColor = true;
            this.reminderAlertCloseBtn.Click += new System.EventHandler(this.reminderAlertCloseBtn_Click);
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Location = new System.Drawing.Point(158, 56);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(35, 13);
            this.summaryLabel.TabIndex = 1;
            this.summaryLabel.Text = "label1";
            // 
            // ReminderAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 152);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.reminderAlertCloseBtn);
            this.Name = "ReminderAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReminderAlert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reminderAlertCloseBtn;
        private System.Windows.Forms.Label summaryLabel;
    }
}