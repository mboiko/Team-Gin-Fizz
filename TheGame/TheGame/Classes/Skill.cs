namespace TheGame.Classes
{
    using System;

    public class Skill
    {
        #region Fields and Propeties

        string name;
        int skillValue;

        public string Name 
        {
            get
            {
                return this.name;
            }
            protected set
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

        public int SkillValue 
        {
            get
            {
                return this.skillValue;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Skill value cannot be 0 or negative.");
                }

                this.skillValue = value;
            }
        }
        #endregion

        #region Constructor

        public Skill(string name, int skillBaseValue, int scillValue)
        {
            this.Name = name;
            this.SkillBaseValue = skillBaseValue;
            this.SkillValue = scillValue;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("Scill name: {0}, value: {1}", this.Name, this.SkillValue);
        }

        public override bool Equals(object obj)
        {
            var skill = obj as Skill;

            if (skill == null)
            {
                return false;
            }

            if ((this.Name == skill.Name) && (this.skillValue == skill.skillValue))
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
            return this.Name.GetHashCode() ^ this.SkillValue.GetHashCode();
        }

        #endregion
    }
}
