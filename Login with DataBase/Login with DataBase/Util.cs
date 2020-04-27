using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace Login_with_DataBase
{
    public static class Util
    {
        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static void LoadCsv(List<User> userlist, string csvpath)
        {
            if (!File.Exists(@csvpath))
            {
                StreamWriter create = File.CreateText(@csvpath);
                create.Close();
            }
            StreamReader reader = new StreamReader(csvpath);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line != "")
                {
                    var values = line.Split(',');
                    userlist.Add(new User(values[0], values[1], values[2]));
                }
            }
            reader.Close();
        }

        public static void Loadphonebook(List<User> userlist, string csvname)
        {
            if (!File.Exists(@csvname))
            {
                StreamWriter create = File.CreateText(@csvname);
                create.Close();
            }
            foreach (User user in userlist)
                user.Phonebook.Clear();

            StreamReader reader = new StreamReader(csvname);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line != "")
                {
                    var values = line.Split(',');
                    userlist[int.Parse(values[0])].Phonebook.Add(new Phonebook(values[1], values[2], values[3], values[4], values[5], values[6]));
                }
            }
            reader.Close();
        }
        public static void SaveUserCsv(List<User> userlist, string usercsv)
        {
            StreamWriter userwrite = File.CreateText(usercsv);
            foreach (User user in userlist)
                userwrite.WriteLine(user.Username + "," + user.Password + "," + user.Usertype);
            userwrite.Close();
        }
        public static void SavePhonebookCsv(List<User> userlist, string csvname)
        {
            StreamWriter phonebookwrite = File.CreateText(@csvname);
            for (int i = 0; i < userlist.Count; i++)
            {
                User user = userlist[i];
                if (user.Phonebook.Count != 0)
                {
                    for (int j = 0; j < user.Phonebook.Count; j++)
                    {
                        phonebookwrite.WriteLine(i + "," + user.Phonebook[j].Name + "," +
                                                 user.Phonebook[j].Surname + "," + user.Phonebook[j].Phonenumber + "," +
                                                 user.Phonebook[j].Email + "," + user.Phonebook[j].Description + "," +
                                                 user.Phonebook[j].Address);
                    }
                }
            }
            phonebookwrite.Close();
        }
        public static bool IsDoubleUsername(string username)
        {
            foreach (User user in LoginForm.userList)
            {
                if (user.Username == username)
                    return true;
            }
            return false;
        }

        public static void LoadNotes(List<User> userlist, string csvname)
        {
            if (!File.Exists(@csvname))
            {
                StreamWriter create = File.CreateText(@csvname);
                create.Close();
            }
            foreach (User user in userlist)
                user.Notes.Clear();

            StreamReader reader = new StreamReader(csvname);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line != "")
                {
                    var values = line.Split(',');
                    userlist[int.Parse(values[0])].Notes.Add(values[1]);
                }
            }
            reader.Close();
        }
        public static void SaveNotesCsv(List<User> userlist, string csvname)
        {
            StreamWriter noteswrite = File.CreateText(csvname);
            for (int i = 0; i < userlist.Count; i++)
            {
                User user = userlist[i];
                if (user.Notes.Count != 0)
                {
                    for (int j = 0; j < user.Notes.Count; j++)
                        noteswrite.WriteLine(i + "," + user.Notes[j]);
                }
            }
            noteswrite.Close();
        }
        public static void LoadPersonalInformation(List<User> userlist, string csvname)
        {
            if (!File.Exists(@csvname))
            {
                StreamWriter create = File.CreateText(@csvname);
                create.Close();
            }
            StreamReader reader = new StreamReader(csvname);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line != "")
                {
                    var values = line.Split(',');
                    userlist[int.Parse(values[0])].Personinf.Name = values[1];
                    userlist[int.Parse(values[0])].Personinf.Surname = values[2];
                    userlist[int.Parse(values[0])].Personinf.Phonenumber = values[3];
                    userlist[int.Parse(values[0])].Personinf.Email = values[4];
                    userlist[int.Parse(values[0])].Personinf.Address = values[5];
                    userlist[int.Parse(values[0])].Personinf.Image = values[6];
                }
            }
            reader.Close();
        }
        
        public static void savePersonalInformation(List<User> userlist, string csvname)
        {
            StreamWriter personalInformationWrite = File.CreateText(@csvname);
            for (int i = 0; i < userlist.Count; i++)
            {
                User user = userlist[i];
                if (user.Personinf.Name != "")
                {
                    personalInformationWrite.WriteLine(i + "," + user.Personinf.Name + "," +
                                         user.Personinf.Surname + "," + user.Personinf.Phonenumber + "," +
                                         user.Personinf.Email + "," + user.Personinf.Address + ',' + user.Personinf.Image);
                }
            }
            personalInformationWrite.Close();
        }

        public static bool IsPboxNullOrEmpty(this PictureBox pb)
        {
            return pb == null || pb.Image == null;
        }

        public static string ImageToBase64(PictureBox picture)
        {
            byte[] imageArray = System.IO.File.ReadAllBytes(@picture.ImageLocation);
            string base64ImageRepresentation = Convert.ToBase64String(imageArray);
            return base64ImageRepresentation;
        }
    }
}
