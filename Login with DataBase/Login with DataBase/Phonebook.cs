using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_with_DataBase
{
    public class Phonebook
    {
        private string name;
        private string surname;
        private string phonenumber;
        private string email;
        private string description;
        private string address;

        public Phonebook(string name, string surname, string phonenumber, string email, string description, string address)
        {
            this.name = name;
            this.surname = surname;
            this.phonenumber = phonenumber;
            this.email = email;
            this.description = description;
            this.address = address;         
        }

        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public string Phonenumber { get { return phonenumber; } set { phonenumber = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Email { get { return email; } set { email = value; } }
    }
}
