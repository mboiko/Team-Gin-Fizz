namespace TheGame
{
    using System;
    using System.Collections.Generic;

    using TheGame.Classes.Characters;
    using TheGame.Classes;

    public class Building
    {
        private string name;
        private Point2D location;
        private Character person;

        public Building(string initialName, Point2D initialLocation, Character initialPerson)
        {
            this.Name = initialName;
            this.location = initialLocation;
            this.person = initialPerson;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Bilding name cannot be null or empty!");
                }

                this.name = value;
            }
        }
    }
}
