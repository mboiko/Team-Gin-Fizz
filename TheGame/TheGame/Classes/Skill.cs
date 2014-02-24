namespace TheGame.Classes
{
    using System;

    public class Skill
    {
        #region Fields and Propeties

        string name;
        int baseSkillValue;
        int skillCurrentValue;


        public string Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int SkillCurrentValue 
        {
            get
            {
                return this.skillCurrentValue;
            }
            set
            {
                this.skillCurrentValue = value;
            }
        }

        public int BaseSkillValue
        {
            get { return this.baseSkillValue; }
            set
            {
                this.baseSkillValue = value;
            }
        }

        #endregion

        #region Constructor

        public Skill(string name, int baseSkillValue, int skillCurrentValue)
        {
            this.Name = name;
            this.BaseSkillValue = baseSkillValue;
            this.SkillCurrentValue = skillCurrentValue;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.Name, this.BaseSkillValue, this.SkillCurrentValue);
        }

        public override bool Equals(object obj)
        {
            var skill = obj as Skill;

            if (skill == null)
            {
                return false;
            }

            if ((this.Name == skill.Name) && (this.skillCurrentValue == skill.skillCurrentValue))
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
            return this.Name.GetHashCode() ^ this.SkillCurrentValue.GetHashCode();
        }

        #endregion
    }
}
