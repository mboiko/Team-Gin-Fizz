using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TheGame
{
    public static class Files
    {
        public static bool ReadUsersFromFile(string username, string password)
        {
            string login = username.Trim() +","+ password.Trim();
            if (!File.Exists("../../users.txt"))
            {
                CreateUser(username, password);
            }

            string line;
            bool result = false;
            StreamReader reader = new StreamReader("../../users.txt");
            line = reader.ReadToEnd();

            if (line.IndexOf(login) > -1)
            {
                result = true;
            }
           
            reader.Close();


            return result;
        }

        private static void CreateUser(string username, string password)
        {
           // System.Windows.Forms.MessageBox.Show(username);
            StreamWriter writer = new StreamWriter("../../users.txt", true);
            writer.WriteLine((username +","+ password).Trim());
            writer.Close();
        }

        public static string GetSkills(string hero)
        {
            //if (!File.Exists("../../"+hero))
            //{
             
            

            string line;
            bool result = false;
            StreamReader reader = new StreamReader("../../"+hero+".txt");
            line = reader.ReadToEnd();

             reader.Close();


            return line.ToString();
        }
    }
}
