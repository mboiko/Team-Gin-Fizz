using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGame.Classes.Actions
{
    class MoveAction : Action
    {
        private Point2D destination;

        public MoveAction(string name, int energyCost, int timeCost, bool isCompleted, Point2D destination)
            : base(name, energyCost, timeCost, isCompleted)
        {
            this.destination = destination;
        }
    }
}
