namespace TheGame.Classes.Items
{
    using System;
    using System.Collections.Generic;
    using TheGame.Classes.Characters;

    public class Equipment : Item, IWearable
    {
        //constructor
        public Equipment(string name, List<Skill> skills, bool isEnquiped)
            : base(name, skills, isEnquiped)
        {

        }

        //method
        public void IncreaseBaseSkill(Hero hero)
        {
            for (int skill = 0; skill < hero.Skills.Count; skill++)
            {
                hero.Skills[skill].BaseSkillValue += BonusSkills[skill].BaseSkillValue;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.Name, string.Join("|", this.BonusSkills), this.IsEquiped);
        }
    }
}
