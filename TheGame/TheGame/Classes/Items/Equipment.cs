namespace TheGame.Classes.Items
{
    using System;
    using System.Collections.Generic;
    using TheGame.Classes.Characters;

    public class Equipment : Item, IWearable
    {
        //constructor
        public Equipment(string name, string description, List<Skill> skills) : base(name, description, skills)
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
    }
}
