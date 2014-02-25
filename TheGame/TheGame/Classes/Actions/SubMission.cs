namespace TheGame.Classes.Actions
{
    using System;
    using System.Collections.Generic;

    public class SubMission : Action
    {
        public string Description { get; private set; }

        public SubMission(string name, string description, int energiCost, int timeCost, bool isComplete)
            : base(name, energiCost, timeCost, isComplete)
        {
            this.Description = description;
        }
    }
}
