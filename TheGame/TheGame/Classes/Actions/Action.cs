namespace TheGame.Classes.Actions
{
    public abstract class Action
    {
        //TODO: Encapsolated and validate fields
        public string Name { get; private set; }
        public int TimeCost { get; private set; }
        public int EnergyCost { get; private set; }
        public bool IsCompleted { get; set; }

        // constructor
        public Action(string name, int timeCost, int energyCost, bool isCompleted)
        {
            this.Name = name;
            this.TimeCost = timeCost;
            this.EnergyCost = energyCost;
            this.IsCompleted = isCompleted;
        }

        //methods

    }
}
