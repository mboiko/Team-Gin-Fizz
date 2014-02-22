namespace TheGame.Classes.Characters
{
    using System.Collections.Generic;
    using TheGame.Classes.Actions;

    public class Trainer //: Bot
    {
        public List<Quest> questToGive;

        //constructor
        public Quest GiveQuest()
        {
            for (int i = 0; i < questToGive.Count; i++)
            {
                if (!questToGive[i].IsCompleted)
                {
                    return questToGive[i];
                }
            }

            return new Quest("Game Over", "Turn off the game and try your skills at the real Telerik Academy!",
                ActionType.Primary, 3000, 1000, true);
        }
    }
}
