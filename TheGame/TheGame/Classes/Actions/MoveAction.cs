using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGame.Classes.Actions
{
    class MoveAction : Action
    {
        private Point2D destination;

        public MoveAction(string name, int timeCost, int energyCost, bool isCompleted, Point2D destination)
            : base(name, timeCost, energyCost, isCompleted)
        {
            this.destination = destination;
        }
        public override int GetEnergyCost()
        {
            return 0;
        }

        public override int GetTimeCost()
        {
            return destination.X * destination.Y; 
        }
    }
}
