namespace TheGame.Classes.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Linq;

    using System.IO;
    using TheGame.Classes.Actions;
    using TheGame.Classes.Items;

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

        //methods
        public void AddEquipment(Item equipment)
        {
            if (EquippedItemsSize > 0)
            {
                this.EquippedItems.Add(equipment);
                this.EquippedItemsSize--;
            }
            else
            {
                MessageBox.Show("Your inventory is full!", "You can't wear more items.",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void RemoveItem(Item item)
        {
            if (this.EquippedItems.Contains(item))
            {
                this.EquippedItems.Remove(item);
                this.EquippedItemsSize++;
            }
            else
            {
                MessageBox.Show("You tried to remove unexisted item!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GoToTheBed(int time)
        {
            Skills[PlayerTime].SkillCurrentValue -= time;
            int energyToAdd = (time / 60) * (Skills[PlayerEnergy].BaseSkillValue / 8);
            
            if (Skills[PlayerEnergy].SkillCurrentValue + energyToAdd > Skills[PlayerEnergy].BaseSkillValue)
            {
                Skills[PlayerEnergy].SkillCurrentValue = Skills[PlayerEnergy].BaseSkillValue;
            }
            else
            {
                Skills[PlayerEnergy].SkillCurrentValue += energyToAdd;
            }
        }
    }
}
