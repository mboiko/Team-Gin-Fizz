namespace TheGame.Classes.Actions
{
    public class Тrouble : Action
    {
        public Point2D Location { get; private set; }

        public Тrouble(string name, int energyCost, int timeCost, bool isCompleted, Point2D location)
            : base(name, energyCost, timeCost, isCompleted)
        {
            this.Location = location;
        }
    }
}
