namespace TheGame.Classes.Characters
{
    using System.Collections.Generic;
    using TheGame.Classes;
    using TheGame.Classes.Items;

    public class Player : Character
    {
        private GameStats gameStats;

        //TODO: Add fields and validate them with properties
       // public List<Mission> currentMissions { get; private set; }
        public PlayerType PlayerType { get; private set; }
        public char Gender { get; private set; }
        public List<Item> Inventory { get; private set; }
        public List<Item> EquippedItems { get; private set; }
        public int EquippedItemsSize { get; private set; }

        //public Location location { get; private set; }

        // Must be added Mission and location
        public Player(string nickName, GameStats gameStats, PlayerType playerType,
            char gender,  List<Item> inventory, List<Item> equippedItems,
            int equippedItemsSize) : base(nickName)
        {
            this.PlayerType = playerType;
            this.Gender = gender;
            this.Inventory = inventory;
            this.EquippedItems = equippedItems;
            this.EquippedItemsSize = equippedItemsSize;
        }
    }
}
