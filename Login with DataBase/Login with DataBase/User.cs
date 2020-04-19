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
        private string usertype;
        private List<Phonebook> phonebook = new List<Phonebook>();

        public User(string username, string password, string usertype)
        {
            this.username = username;
            this.password = password;
            this.usertype = usertype;
        }

        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Usertype { get { return usertype; } set { usertype = value; } }
        public List<Phonebook> Phonebook { get { return phonebook; } set { phonebook = value; } }

        public bool IsValid(string username, string password)
        {
            return this.username.Equals(username) && this.password.Equals(password);
        }
    }
}
