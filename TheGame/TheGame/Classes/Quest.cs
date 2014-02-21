namespace TheGame
{
    using System;

    public class Quest : Action
    {
        public Quest(string name, string description, ActionType actionType, int timeCost, int energyCost, bool isCompleted)
            : base(name, description, actionType, timeCost, energyCost, isCompleted)
        {

        }

        public override void CompleteAction()
        {
            throw new NotImplementedException();
        }
    }
}
