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
        private string address;
        private string description;
        private string email;

        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public string Phonenumber { get { return phonenumber; } set { phonenumber = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Email { get { return email; } set { email = value; } }
    }
}
