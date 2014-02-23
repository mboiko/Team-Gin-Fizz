namespace TheGame.Classes.Actions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TheGame.Classes.Items;

    public class Quest : GameObject
    {
        #region Fields and Properties

        private List<Action> requirmets;
        private List<Item> gifts;
        private bool isComplited;

        public bool IsComplited
        {
            get { return isComplited; }
            private set { isComplited = value; }
        }

        #endregion

        #region Constructor

        public Quest(string name, string description, List<Action> requiremets, List<Item> gifts)
            :base(name, description)
        {
            //TODO: encapsulte and validate these two
            this.requirmets = requirmets;
            this.gifts = gifts;

            this.isComplited = false;
        }

        #endregion

        #region Methods

        //if the quest isn't complited returns null
        public List<Item> GetReward()
        {
            if (this.IsComplited)
            {
                return this.gifts;
            }
            return null;
        }

        public void CheckForAction(Action action)
        {
            for (int i = 0; i < this.requirmets.Count; i++)
            {
                if (action.Equals(this.requirmets[i]))
                {
                    this.requirmets[i].IsCompleted = true;
                }
            }

            if (this.IsComplitedQuest();)
            {
                this.isComplited = true;
                //onQuestComplited();
            }
        }

        private bool IsComplitedQuest()
        {
            return this.requirmets.Count(action => action.IsCompleted) == this.requirmets.Count;
        }

        #endregion
       
    }
}
