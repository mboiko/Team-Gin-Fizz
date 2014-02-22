namespace TheGame.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Skill
    {
        #region Fields and Propeties

        string name;
        int skillCost;

        //TODO: Encapsulate with properties
        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty.");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Name cannot be less than 2 symbols");
                }

                this.name = value;
            }
        }

        public int SkillCost 
        {
            get
            {
                return this.skillCost;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Scill cost cannot be 0 or negative.");
                }
            }
        }
        #endregion

        #region Constructor

        //TODO: Implement constructor


        #endregion

        #region Methods

        //TODO: Override ToString, Equals, GetHashCode

        #endregion
    }
}
