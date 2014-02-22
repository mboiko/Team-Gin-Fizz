namespace TheGame.Classes.Characters
{
    using System;
    using System.Collections.Generic;
    using TheGame.Classes;

    public class Player : Character
    {
        public int Level { get; private set; }
        public int Score { get; private set; }
        public List<Skill> Skills { get; private set; }
        //public List<Mission> currentMissions { get; private set; }
        public PlayerType PlayerType { get; private set; }
        public char Gender { get; private set; }
        //public Set<Item> Inventory { get; private set; }
        //public Set<Item> EquippedItems { get; private set; }
        public int EquippedItemsSize { get; private set; }
        public double Efficiency { get; private set; }
        //public Location location { get; private set; }

        public Player(string nickName, int score, List<Skill> skills, PlayerType playerType,
            char gender, int equippedItemsSize, double efficiency)
        {
            this.Nickname = nickName;
            this.Score = score;
            this.Skills = skills;
            this.PlayerType = playerType;
            this.Gender = gender;
            this.EquippedItemsSize = equippedItemsSize;
            this.Efficiency = efficiency;
        }
    }
}
