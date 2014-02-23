namespace TheGame.Classes.Items
{
    using System;
    using System.Collections.Generic;

    public class SellableItem : Item
    {
        #region Fields and Properties

        private double price;

        //TODO: Encapsulation with properties

        public double Price 
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)//?? <=0 or <0
                {
                    throw new ArgumentException("Price cannot be 0 or negative.");
                }
                this.price = value;
            }
        }

        #endregion

        #region Constructors

        //TODO: Construcors

        public SellableItem(string name, string description, List<Skill> bonusSkills, double price)
            :base(name, description, bonusSkills)
        {
            this.Price = price;
        }

        #endregion

        #region Methods

        //TODO: Override ToString, Equals, GetHashCode
        

        #endregion

    }
}
