namespace TheGame
{
    using System;
    using TheGame.Classes;
    using TheGame.Classes.Items;
    using System.Collections.Generic;
    using System.Collections;
    using TheGame.Classes.Actions;
    using System.Linq;
    using System.IO;
    using System.Windows.Forms;

    public static class Parser
    {
        public static List<Skill> GetAllSkills(string file = "Skills")
        {
            List<Skill> skills = new List<Skill>();

            if (File.Exists("../../" + file + ".txt"))
            {
                StreamReader sr = new StreamReader("../../" + file + ".txt");
                using (sr)
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (line.Length > 0)
                        {
                            skills.Add(new Skill(line[0], int.Parse(line[1]), int.Parse(line[2])));
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("File " + file + ".txt cannot be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return skills;
        }

        public static List<Item> GetAllConsumableItems()
        {
            List<Item> ConsumableItems = new List<Item>();

            if (File.Exists("../../ConsumableItems.txt"))
            {
                StreamReader sr = new StreamReader("../../ConsumableItems.txt");
                using (sr)
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                        if (line.Length > 0)
                        {
                            ConsumableItems.Add(new Item(line[0], new List<Skill>() 
                        { 
                        new Skill(line[1], 0, int.Parse(line[2])),
                        new Skill(line[3], 0, int.Parse(line[4])),
                        new Skill(line[5], 0, int.Parse(line[6])),
                        new Skill(line[7], 0, int.Parse(line[8])),
                        new Skill(line[9], 0, int.Parse(line[10])),
                        new Skill(line[11], 0, int.Parse(line[12])),
                        new Skill(line[13], 0, int.Parse(line[14]))
                        }, bool.Parse(line[15])));
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("File ConsumableItems.txt cannot be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ConsumableItems;
        }

        public static List<Equipment> GetAllEquipments()
        {
            List<Equipment> equipments = new List<Equipment>();

            if (File.Exists("../../Equipment.txt"))
            {
                StreamReader sr = new StreamReader("../../Equipment.txt");
                using (sr)
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                        if (line.Length > 0)
                        {
                            equipments.Add(new Equipment(line[0],
                       new List<Skill>(){ new Skill(line[1], int.Parse(line[2]), 0),
                                          new Skill(line[3], int.Parse(line[4]), 0),
                                          new Skill(line[5], int.Parse(line[6]), 0),
                                          new Skill(line[7], int.Parse(line[8]), 0),
                                          new Skill(line[9], int.Parse(line[10]), 0),
                                          new Skill(line[11], int.Parse(line[12]), 0)},
                                          bool.Parse(line[13])));
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("File Equipment.txt cannot be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return equipments;
        }

        public static List<Quest> GetAllQuests()
        {
            List<Equipment> Equipments = GetAllEquipments();
            List<Quest> quests = new List<Quest>();

            if (File.Exists("../../Quests.txt"))
            {
                StreamReader sr = new StreamReader("../../Quests.txt");
                using (sr)
                {
                    while (!sr.EndOfStream)
                    {
                        List<string> line = sr.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        int start = -1, end = -1;
                        if (!line.Contains("Team Work Project") && !line.Contains("The Exam"))
                        {
                            start = 0;
                            end = 7;
                        }
                        else if (line.Contains("Team Work Project"))
                        {
                            start = 8;
                            end = 19;
                        }
                        else if (line.Contains("The Exam"))
                        {
                            start = 20;
                            end = 28;
                        }
                        Equipment gift = Equipments[RandomGenerator.GetRandomNumber(start, end)];
                        if (line.Count > 0)
                        {
                            quests.Add(new Quest(line[0], line[1],
                                new List<SubMission>() { new SubMission(line[2], line[3], int.Parse(line[4]), int.Parse(line[5]), bool.Parse(line[6])) },
                                gift, bool.Parse(line[7])));
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("The file Quests.txt cannot be found","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return quests;
        }
    }
}
