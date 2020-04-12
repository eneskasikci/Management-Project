using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

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
            StreamReader reader = new StreamReader(csvpath);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line !="")
                {
                    var values = line.Split(',');
                    userlist.Add(new User(values[0], values[1], values[2])); 
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

        public static bool IsDoubleUsername(string username)
        {
            foreach (User user in LoginForm.userList)
            {
                if (user.Username == username)
                    return true;
            }
            return false;
        }
    }
}
