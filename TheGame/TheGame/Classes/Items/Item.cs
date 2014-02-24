﻿namespace TheGame.Classes.Items
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Item : GameObject
    {
        #region Fields and Properties

        private List<Skill> bonusSkills;
        private bool isEquiped;
        //private string description;

        //public string Description
        //{
        //    get { return description; }
        //    protected set { description = value; }
        //}
        //TODO: Encapsulation with properties

        public bool IsEquiped 
        {
            get
            {
                return this.isEquiped;
            }
            set
            {
                //TODO - validation ??
                this.isEquiped = value;
            }
        }

        public List<Skill> BonusSkills 
        {
            get
            {
                return new List<Skill>(this.bonusSkills);
            }
            protected set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("bonusSkills");
                }
                this.bonusSkills = value;
            }
        }

        #endregion
        
        #region Constructors

        //TODO: Construcors
        public Item(string name, List<Skill> bonusSkills)
            : base(name)
        {
            this.BonusSkills = bonusSkills;
           // this.Description = description;
        }

        #endregion

        #region Methods

        //TODO: Override ToString, Equals, GetHashCode

        public void AddSkill(Skill newSkill)
        {
            this.bonusSkills.Add(newSkill);
        }

        public override string ToString()
        {
            StringBuilder allBonuses = new StringBuilder();
            foreach (var bonus in bonusSkills)
            {
                allBonuses.AppendLine(bonus.Name);
            }
            return string.Format("{0} {1}", this.Name, string.Join(" ", allBonuses));
        }

        public override bool Equals(object obj)
        {
            var item= obj as Item;

            if (item ==null)
	        {
		        throw new ArgumentException("Passed object is not Item");
	        }

            if ((this.Name == item.Name) && (this.IsEquiped == item.IsEquiped))
	        {
		        return true;
	        }

            return false;
        }

        public static bool operator ==(Item first, Item second)
        {
            return object.Equals(first, second);
        }

        public static bool operator !=(Item first, Item second)
        {
            return !object.Equals(first, second);
        }

        //public override int GetHashCode()
        //{
        //    return this.Name.GetHashCode() ^ this.Description.GetHashCode();
        //}

        #endregion
    }
}
