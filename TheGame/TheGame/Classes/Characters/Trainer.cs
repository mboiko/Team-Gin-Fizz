namespace TheGame.Classes.Characters
{
    using System.Collections.Generic;
    using TheGame.Classes.Actions;

    public class Trainer : Character
    {
        public List<Quest> questToGive;

        public Trainer(string name, List<Quest> quests)
            : base(name)
        {
            this.questToGive = quests;
        }

        //constructor
        public Quest GiveQuest()
        {
            for (int i = 0; i < questToGive.Count; i++)
            {
                if (!questToGive[i].IsComplеted)
                {
                    return questToGive[i];
                }
            }

            return new Quest("Game Over", "Turn off the game and try your skills at the real Telerik Academy!",
                new List<Action>(), new List<Items.Item>());
        }
    }
}
