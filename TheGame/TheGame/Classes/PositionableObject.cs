using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGame.Classes
{
    abstract class PositionableObject : GameObject, IPositionable
    {
        public Point2D Position { get; protected set; }

        public PositionableObject(string name, Point2D position)
            : base(name)
        {
            this.Position = position;
        }
    }
}
