namespace TheGame.Classes
{
    public class Тrouble : Action
    {
        public Тrouble(string name, string description, ActionType actionType, int timeCost, int energyCost, bool isCompleted)
            : base(name, description, actionType, timeCost, energyCost, isCompleted)
        {

        }


        public override void CompleteAction()
        {
            throw new System.NotImplementedException();
        }
    }
}
