using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_with_DataBase
{
    public partial class ReminderAlert : Form
    {
        public ReminderAlert(Reminder rem)
        {
            InitializeComponent();
            summaryLabel.Text = rem.Summary;
            this.Text = "Your " + rem.Remindertype + " at " + rem.Datetime;
        }

        private void reminderAlertCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}