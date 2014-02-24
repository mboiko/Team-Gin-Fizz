namespace TheGame.Classes.Actions
{
    public class Тrouble : Action
    {
        public Тrouble(string name, bool isCompleted)
            : base(name, isCompleted)
        {

        }

        public override void getEnergyCost()
        {
            throw new System.NotImplementedException();
        }

        public override void getTimeCost()
        {
            throw new System.NotImplementedException();
        }
    }
}
