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

                this.skillCost = value;
            }
        }
        #endregion

        #region Constructor

        //TODO: Implement constructor
        public Skill(string name, int scillCost)
        {
            this.Name = name;
            this.SkillCost = scillCost;
        }

        #endregion

        #region Methods

        //TODO: Override ToString, Equals, GetHashCode

        public override string ToString()
        {
            return string.Format("Scill name: {0}, cost: {1}", this.Name, this.SkillCost);
        }

        public override bool Equals(object obj)
        {
            var skill = obj as Skill;

            if (skill == null)
            {
                throw new ArgumentException("Passed object is not Skill");
            }

            if ((this.Name == skill.Name) && (this.skillCost == skill.skillCost))
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Skill first, Skill second)
        {
            return object.Equals(first, second);
        }

        public static bool operator !=(Skill first, Skill second)
        {
            return !object.Equals(first, second);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.SkillCost.GetHashCode();
        }

        #endregion
    }
}
