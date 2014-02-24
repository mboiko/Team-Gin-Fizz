using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGame.Classes
{
    abstract class StaticObject : PositionableObject
    {
        string description;

        public string Description
        {
            get { return description; }
            protected set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("description");
                }
                this.description = value; 
            }
        }

        public StaticObject(string name, Point2D position, string desctiprtion)
            :base(name, position)
        {
            this.Description = description;
        }
    }
}
