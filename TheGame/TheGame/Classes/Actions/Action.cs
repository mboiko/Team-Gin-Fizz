namespace TheGame.Classes.Actions
{
    public abstract class Action
    {
        //TODO: Encapsolated and validate fields
        public string Name { get; private set; }
        public bool IsCompleted { get; set; }

        // constructor
        public Action(string name, bool isCompleted)
        {
            this.Name = name;
            this.IsCompleted = isCompleted;
        }

        //methods
        public abstract int GetEnergyCost();

        public abstract int GetTimeCost();

    }
}
