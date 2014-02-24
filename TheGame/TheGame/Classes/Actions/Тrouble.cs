namespace TheGame.Classes.Actions
{
    public class Тrouble : Action
    {
        public Тrouble(string name, bool isCompleted)
            : base(name, isCompleted)
        {

        }


        public override int GetEnergyCost()
        {
            throw new System.NotImplementedException();
        }

        public override int GetTimeCost()
        {
            throw new System.NotImplementedException();
        }
    }
}
