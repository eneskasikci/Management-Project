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
        private List<string> notes = new List<string>();
        private Personalnformation personinf = new Personalnformation();

        public User(string username, string password, string usertype)
        {
            this.username = username;
            this.password = password;
            this.usertype = usertype;
        }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Usertype { get { return usertype; } set { usertype = value; } }
        public List<string> Notes { get { return notes; } set { notes = value; } }
        public List<Phonebook> Phonebook { get { return phonebook; } set { phonebook = value; } }
        public Personalnformation Personinf{ get { return personinf; } set { personinf = value; } }

        public bool IsValid(string username, string password)
        {
            return this.username.Equals(username) && this.password.Equals(password);
        }


    }
}
