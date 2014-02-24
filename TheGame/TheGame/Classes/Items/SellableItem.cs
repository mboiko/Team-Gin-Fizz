namespace TheGame.Classes.Items
{
    using System;
    using System.Collections.Generic;

    public class SellableItem : Item
    {
        #region Fields and Properties

        private double price;

        //TODO: Encapsulation with properties   дс

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

        public SellableItem(string name, List<Skill> bonusSkills, double price, bool isEnquiped)
            : base(name, bonusSkills, isEnquiped)
        {
            this.Price = price;
        }

        #endregion

        #region Methods

        //TODO: Equals, GetHashCode
        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.Name, string.Join("|", this.BonusSkills), this.IsEquiped);
        }

        #endregion

    }
}
