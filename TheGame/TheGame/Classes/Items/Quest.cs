namespace TheGame.Classes.Actions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TheGame.Classes.Items;
    using TheGame.Classes.Characters;

    public class Quest : GameObject
    {
        #region Fields and Properties

        public string Description { get; private set; }
        private List<SubMission> requirments;
        private Equipment gift;
        private bool isComplеted;

        public bool IsComplеted
        {
            get { return isComplеted; }
            private set { isComplеted = value; }
        }

        #endregion

        #region Constructor

        public Quest(string name, string description, List<SubMission> requiremets, Equipment gift, bool isComplete)
            : base(name)
        {
            //TODO: encapsulte and validate these two
            this.requirments = requiremets;
            this.gift = gift;
            this.Description = description;
            this.IsComplеted = isComplete;
        }

        #endregion

        #region Methods

        //if the quest isn't complited returns null
        public Item GetReward()
        {
            if (this.IsComplеted)
            {
                return this.gift;
            }
            return null;
        }

        public void CheckForAction(Action action)
        {
            for (int i = 0; i < this.requirments.Count; i++)
            {
                if (action.Equals(this.requirments[i]))
                {
                    this.requirments[i].IsCompleted = true;
                }
            }

            if (this.IsComplitedQuest())
            {
                this.isComplеted = true;
                //onQuestComplited();
            }
        }

        private bool IsComplitedQuest()
        {
            return this.requirments.Count(req => req.IsCompleted) == this.requirments.Count;
        }

        #endregion
    }
}
