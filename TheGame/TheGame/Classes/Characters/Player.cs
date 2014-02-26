using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheGame.Classes.Actions;
using TheGame.Classes.Items;
using System.IO;

namespace TheGame.Classes.Characters
{
    public class Player : Hero, IControlable
    {
        public string Username { get; protected set; }

        public string Password { get; protected set; }

        public Player(string name, string username, int level, int experience, List<Skill> skills, PlayerType playerType,
            char gender, List<Item> equippedItems, int equippedItemsSize, List<Quest> curentQuest) 
            : base(name, level, experience, skills, playerType, gender, equippedItems, equippedItemsSize, curentQuest)
        {
            this.Username = username;

        }

        public void AddEquipment(Equipment equipment)
        {
            this.EquippedItems.Add(equipment);
        }

        public void Save()
        {
            StreamWriter str = new StreamWriter("../../SaveFiles/" + Username + ".txt", false);
            try
            {
                using (str)
                {
                    str.WriteLine(Username);
                    str.WriteLine(Name);
                    str.WriteLine(Level);
                    str.WriteLine(Experience);
                    foreach (var skill in Skills)
                    {
                        str.WriteLine(skill.ToString());
                    }
                    str.WriteLine();
                    str.WriteLine(PlayerType);
                    str.WriteLine(Gender.ToString());
                    foreach (var equippedItem in EquippedItems)
                    {
                        str.WriteLine(equippedItem.ToString());
                    }
                    str.WriteLine();
                    str.WriteLine(EquippedItemsSize);
                   foreach (var quest in CurrentQuests)
                   {
                       str.WriteLine(quest.ToString());
                   }

                }
            }
            catch (IOException)
            {

                throw new IOException("Cannot write in save.txt");
            }
            
        }
    }
}
