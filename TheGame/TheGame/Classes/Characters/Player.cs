using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGame.Classes.Characters
{
    public class Player : Hero, IControlable
    {
        public string Username { get; protected set; }

        public string Password { get; protected set; }

        public Player(string username, string password, string name, int Level, int experience, List<Skill> skills, PlayerType playerType,
            char gender, List<Items.Item> equippedItems, int equippedItemsSize)
            : base(name, Level, experience, skills, playerType, gender, equippedItems, equippedItemsSize)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
