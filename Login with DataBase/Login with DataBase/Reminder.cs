using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_with_DataBase
{
    public class Reminder
    {
        private DateTime datetime;
        private string summary;
        private string description;
        private string remindertype;

        public Reminder(DateTime datetime, string summary, string description, string remindertype)
        {
            this.datetime = datetime;
            this.summary = summary;
            this.description = description;
            this.remindertype = remindertype;
        }

        public DateTime Datetime { get { return datetime; } set { datetime = value; } }
        public string Summary { get { return summary; } set { summary = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Remindertype { get { return remindertype; } set { remindertype = value; } }
    }
}
