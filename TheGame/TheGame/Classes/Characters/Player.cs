namespace TheGame.Classes
{
    using System;
    using System.Collections.Generic;

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
     
    }
}
