namespace TheGame.Classes
{
    using System;
    using System.Collections.Generic;

    public class Quest : Action
    {
        private List<GameObject> gifts;

        public Quest(string name, string description, ActionType actionType, int timeCost, int energyCost, bool isCompleted)
            : base(name, description, actionType, timeCost, energyCost, isCompleted)
        {

        }

        //methods
        public void DropGift()
        {
            //to implement later
        }

        public override void CompleteAction()
        {
            throw new NotImplementedException();
        }
    }
}
