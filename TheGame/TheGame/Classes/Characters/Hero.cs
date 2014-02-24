namespace TheGame.Classes.Characters
{
    using System.Collections.Generic;
    using TheGame.Classes.Actions;
    using TheGame.Classes.Items;

    public class Hero : Character
    {
        public int Level { get; private set; }
        public int Experience { get; private set; }
        public List<Skill> Skills { get; private set; }
        public List<Quest> CurrentQuests { get; private set; }
        public PlayerType PlayerType { get; private set; }
        public char Gender { get; private set; }
        public List<Item> EquippedItems { get; private set; }
        public int EquippedItemsSize { get; private set; }

        //public Location location { get; private set; }

        // Must be added location
        public Hero(string name, int level, int experience, List<Skill> skills, PlayerType playerType,
            char gender, List<Item> equippedItems, int equippedItemsSize, List<Quest> curentQuest) 
            : base(name)
        {
            this.Level = level;
            this.Experience = experience;
            this.PlayerType = playerType;
            this.Gender = gender;
            this.EquippedItems = equippedItems;
            this.EquippedItemsSize = equippedItemsSize;
            this.CurrentQuests = curentQuest;
        }

        public void GetQuest(Quest quest)
        {
            CurrentQuests.Add(quest);
        }

        public void UseItem(Item item)
        {
            for (int skillIndex = 0; skillIndex < this.Skills.Count; skillIndex++)
            {
                this.Skills[skillIndex].SkillCurrentValue += item.BonusSkills[skillIndex].SkillCurrentValue;
            }
        }
    }
}
