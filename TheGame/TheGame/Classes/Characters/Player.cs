using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheGame.Classes.Actions;
using TheGame.Classes.Items;

namespace TheGame.Classes.Characters
{
    public class Player : Hero, IControlable
    {
        public string Username { get; protected set; }

        public string Password { get; protected set; }

        public Player(string name, string username, string password, int level, int experience, List<Skill> skills, PlayerType playerType,
            char gender, List<Item> equippedItems, int equippedItemsSize, List<Quest> curentQuest) 
            : base(name, level, experience, skills, playerType, gender, equippedItems, equippedItemsSize, curentQuest)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
