﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_with_DataBase
{
    public class Personalnformation
    {
        private string name;
        private string surname;
        private string phonenumber;
        private string email;
        private string address;
        public Personalnformation() {
            this.name = "";
            this.surname = "";
            this.phonenumber = "";
            this.email = "";
            this.address = "";
        }
        public Personalnformation(string name, string surname, string phonenumber, string email, string address)
        {
            this.name = name;
            this.surname = surname;
            this.phonenumber = phonenumber;
            this.email = email;
            this.address = address;
        }

        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public string Phonenumber { get { return phonenumber; } set { phonenumber = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Email { get { return email; } set { email = value; } }
    }
}