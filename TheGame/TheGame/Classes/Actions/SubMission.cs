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

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}{4}", this.Name, this.Description, this.EnergyCost, this.TimeCost, this.IsCompleted);
        }
    }
}
