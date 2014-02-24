namespace TheGame.Classes.Actions
{
    public class Тrouble : Action
    {
        public Тrouble(string name, int timeCost, int energyCost, bool isCompleted)
            : base(name, timeCost, energyCost, isCompleted)
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
