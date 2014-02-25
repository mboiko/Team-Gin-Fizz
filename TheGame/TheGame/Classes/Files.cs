using System;
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

            bool result = false;
            StreamReader reader = new StreamReader("../../users.txt");
            
            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    string[] words = reader.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    if (username==words[0]&&password==words[1])
                    {
                        result = true;
                    }
                }
            }

            reader.Close();

            return result;
        }

        public static void CreateUser(string username, string password)
        {

            StreamWriter writer = new StreamWriter("../../users.txt", true);
            writer.WriteLine((username +","+ password).Trim());
            writer.Close();
        }

        public static string GetSkills(string hero)
        {
            string line;
            StreamReader reader = new StreamReader("../../"+hero+".txt");
            line = reader.ReadToEnd();
            reader.Close();
            return line.ToString();
        }

        public static bool HaveAHero(string name)
        {
            if (!File.Exists("../../" + name + ".txt"))
            {
                return false;
            }
            return true;
        }
    }
}
