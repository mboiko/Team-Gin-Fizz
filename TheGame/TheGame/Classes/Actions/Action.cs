namespace TheGame.Classes.Actions
{
    public abstract class Action
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public ActionType ActionType { get; private set; }
        public int TimeCost { get; private set; }
        public int EnergyCost { get; private set; }
        private bool isCompleted;

        public bool IsCompleted
        {
            get { return this.isCompleted; }
            set { this.isCompleted = value; }
        }

        // constructor
        public Action(string name, string description, ActionType actionType, int timeCost, int energyCost, bool isCompleted)
        {
            this.Name = name;
            this.Description = description;
            this.ActionType = actionType;
            this.TimeCost = timeCost;
            this.EnergyCost = energyCost;
            this.IsCompleted = isCompleted;
        }

        //methods
        public abstract void CompleteAction();

    }
}
