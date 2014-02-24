namespace TheGame.Classes.Items
{
    using System;
    using System.Collections.Generic;
    using TheGame.Classes.Characters;

    public class Equipment : Item, IWearable
    {
        public int SkillBaseValue
        {
            get { return this.SkillBaseValue; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Skill value cannot be 0 or negative.");
                }

                this.SkillBaseValue = value;
            }
        }

        public void IncreaseBaseSkill(Hero hero)
        {
            for (int skill = 0; skill < hero.Skills.Count; skill++)
            {
                hero.Skills[skill].BaseSkillValue += BonusSkills[skill].BaseSkillValue;
            }
        }
    }
}
