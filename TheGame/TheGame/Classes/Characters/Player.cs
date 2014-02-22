namespace TheGame.Classes.Characters
{
    using System;
    using System.Collections.Generic;
    using TheGame.Classes;
    using TheGame.Classes.Items;

    public class Player : Character
    {
        public int Level { get; private set; }
        public int Score { get; private set; }
        public List<Skill> Skills { get; private set; }
       // public List<Mission> currentMissions { get; private set; }
        public PlayerType PlayerType { get; private set; }
        public char Gender { get; private set; }
        public List<Item> Inventory { get; private set; }
        public List<Item> EquippedItems { get; private set; }
        public int EquippedItemsSize { get; private set; }
        public double Efficiency { get; private set; }
        //public Location location { get; private set; }

        // Must be added Mission and location
        public Player(string nickName, int Level, int score, List<Skill> skills, PlayerType playerType,
            char gender,  List<Item> inventory, List<Item> equippedItems,
            int equippedItemsSize, double efficiency) : base(nickName)
        {
            this.Level = Level;
            this.Score = score;
            this.Skills = skills;
            this.PlayerType = playerType;
            this.Gender = gender;
            this.Inventory = inventory;
            this.EquippedItems = equippedItems;
            this.EquippedItemsSize = equippedItemsSize;
            this.Efficiency = efficiency;
        }
    }
}
