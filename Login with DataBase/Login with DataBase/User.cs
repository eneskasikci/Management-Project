using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_with_DataBase
{
    public class User
    {
        private string username;
        private string password;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }

        public bool IsValid(string username, string password)
        {
            return this.username.Equals(username) && this.password.Equals(password);
        }

        public bool IsAdmin(string username, string password)
        {
            return this.username.Equals(username) && this.password.Equals(password);
        }
    }
}
