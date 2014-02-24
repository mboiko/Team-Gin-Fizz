namespace TheGame.Classes.Actions
{
    public abstract class Action
    {
        //TODO: Encapsolated and validate fields
        public string Name { get; private set; }
        public int EnergyCost { get; private set; }
        public int TimeCost { get; private set; }
        public bool IsCompleted { get; set; }

        // constructor
        public Action(string name, int energyCost, int timeCost, bool isCompleted)
        {
            this.Name = name;
            this.EnergyCost = energyCost;
            this.TimeCost = timeCost;
            this.IsCompleted = isCompleted;
        }
    }
}
