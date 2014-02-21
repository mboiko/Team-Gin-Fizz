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
            if (!File.Exists("users.txt"))
            {
                CreateUser(username, password);
            }

            string line;
            bool result = false;
            StreamReader reader = new StreamReader("users.txt");
            line = reader.ReadToEnd();
            if (line.IndexOf(username) > -1 && line.IndexOf(password) > -1)
            {
                result = true;

            }

            reader.Close();

            if (!result)
            {
                CreateUser(username, password);
            }

            return result;
        }

        private static void CreateUser(string username, string password)
        {
            System.Windows.Forms.MessageBox.Show(username);
            StreamWriter writer = new StreamWriter("users.txt", true);
            writer.WriteLine(username + "," + password);
            writer.Close();
        }

    }
}
