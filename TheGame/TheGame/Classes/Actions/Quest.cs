namespace TheGame
{
    using System;
    using System.Collections.Generic;
    using TheGame.Classes;

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
