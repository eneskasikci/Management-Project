using System;
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
        private string image;
        private int deneyim_index=-1;
        private int il_index=-1;
        private int derece_index=-1;
        private int dil_index=-1;
        private int gorev_index=-1;
        private int aile_index=-1;

        public Personalnformation() {
            this.name = "";
            this.surname = "";
            this.phonenumber = "";
            this.email = "";
            this.address = "";
            this.image = "";
        }
        public Personalnformation(string name, string surname, string phonenumber, string email, string address, string image)
        {
            this.name = name;
            this.surname = surname;
            this.phonenumber = phonenumber;
            this.email = email;
            this.address = address;
            this.image = image;
        }

        public double MinimumSalary()
        {
            double deneyim_katsayi=0;
            double il_katsayi=0;
            double derece_katsayi=0;
            double dil_katsayi=0;
            double gorev_katsayi=0;
            double aile_katsayi=0;

            switch (deneyim_index)
            {
                case 0:
                    deneyim_katsayi = 0.60;
                    break;
                case 1:
                    deneyim_katsayi = 1.00;
                    break;
                case 2:
                    deneyim_katsayi = 1.20;
                    break;
                case 3:
                    deneyim_katsayi = 1.35;
                    break;
                case 4:
                    deneyim_katsayi = 1.50;
                    break;
            }

            switch (il_index)
            {
                case 0:
                    il_katsayi = 0.15;
                    break;
                case 1:
                    il_katsayi = 0.10;
                    break;
                case 2:
                    il_katsayi = 0.10;
                    break;
                case 3:
                    il_katsayi = 0.05;
                    break;
                case 4:
                    il_katsayi = 0.05;
                    break;
                case 5:
                    il_katsayi = 0.03;
                    break;
                case 6:
                    il_katsayi = 0.03;
                    break;
                case 7:
                    il_katsayi = 0.03;
                    break;
                case 8:
                    il_katsayi = 0.03;
                    break;
                case 9:
                    il_katsayi = 0.03;
                    break;
                case 10:
                    il_katsayi = 0.03;
                    break;
            }

            switch (derece_index)
            {
                case 0:
                    derece_katsayi = 0.10;
                    break;
                case 1:
                    derece_katsayi = 0.30;
                    break;
                case 2:
                    derece_katsayi = 0.35;
                    break;
                case 3:
                    derece_katsayi = 0.05;
                    break;
                case 4:
                    derece_katsayi = 0.15;
                    break;
            }

            switch (dil_index)
            {
                case 0:
                    dil_katsayi = 0.20;
                    break;
                case 1:
                    dil_katsayi = 0.20;
                    break;
                case 2:
                    dil_katsayi = 0.05;
                    break;
            }

            switch (gorev_index)
            {
                case 0:
                    gorev_katsayi = 0.50;
                    break;
                case 1:
                    gorev_katsayi = 0.75;
                    break;
                case 2:
                    gorev_katsayi = 0.85;
                    break;
                case 3:
                    gorev_katsayi = 1.00;
                    break;
                case 4:
                    gorev_katsayi = 0.40;
                    break;
                case 5:
                    gorev_katsayi = 0.60;
                    break;
            }

            switch (aile_index)
            {
                case 0:
                    aile_katsayi = 0.20;
                    break;
                case 1:
                    aile_katsayi = 0.20;
                    break;
                case 2:
                    aile_katsayi = 0.30;
                    break;
                case 3:
                    aile_katsayi = 0.40;
                    break;
            }

            double sum = deneyim_katsayi + il_katsayi + derece_katsayi + dil_katsayi + gorev_katsayi + aile_katsayi;
            double salary;
            return salary = 4500 * (sum + 1);
        }

        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public string Phonenumber { get { return phonenumber; } set { phonenumber = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Image{ get { return image; } set { image = value; } }
        public int Deneyim { get { return deneyim_index; } set { deneyim_index = value; } }
        public int Il { get { return il_index; } set { il_index = value; } }
        public int Derece { get { return derece_index; } set { derece_index = value; } }
        public int Dil { get { return dil_index; } set { dil_index = value; } }
        public int Gorev { get { return gorev_index; } set { gorev_index = value; } }
        public int Aile { get { return aile_index; } set { aile_index = value; } }
    }
}
