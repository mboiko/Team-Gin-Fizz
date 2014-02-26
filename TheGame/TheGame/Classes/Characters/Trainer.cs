namespace TheGame.Classes.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using TheGame.Classes.Actions;

    public class Trainer : Character
    {
        private List<Quest> questToGive;

        public Trainer(string name, List<Quest> quests)
            : base(name)
        {
            this.questToGive = quests;
        }

        public bool CheckQuestCompletion(Player player)
        {
            foreach (Quest quest in player.CurrentQuests)
            {
                if (!quest.IsComplеted)
                {
                    return false;
                }
            }

            return true;
        }

        public Quest GiveQuest(Player player)
        {
            if (CheckQuestCompletion(player))
            {
                for (int i = 0; i < questToGive.Count; i++)
                {
                    if (!questToGive[i].IsComplеted)
                    {
                        return questToGive[i];
                    }
                }

                MessageBox.Show("Game Over", "Turn off the game and try your skills at the real Telerik Academy!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;            
            }
            else
            {
                MessageBox.Show("You have  a lot of work to do.", "When you're ready I'll give you new homework.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }
    }
}
