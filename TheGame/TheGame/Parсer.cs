namespace TheGame
{
    using System;
    using TheGame.Classes;
    using TheGame.Classes.Items;
    using System.Collections.Generic;
    using System.IO;

    public static class Parсer
    {
        public static List<Skill> GetAllSkills()
        {
            List<Skill> skills = new List<Skill>();
            StreamReader sr = new StreamReader("../../Skills.txt");

            try
            {
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
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("File Skills.txt is not found.");
            }

            return skills;
        }

        public static List<Item> GetAllConsumableItems()
        {
            List<Item> ConsumableItems = new List<Item>();
            StreamReader sr = new StreamReader("../../ConsumableItems.txt");

            try
            {
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
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("File Skills.txt is not found.");
            }

            return ConsumableItems;
        }

        public static List<Equipment> GetAllEquipments()
        {
            List<Equipment> equipments = new List<Equipment>();
            StreamReader sr = new StreamReader("../../Equipment.txt");

            try
            {
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
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("File Skills.txt is not found.");
            }

            return equipments;
        }

    }
}
