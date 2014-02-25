namespace TheGame.Classes.Items
{
    using System;
    using System.Collections.Generic;
    using TheGame.Classes.Characters;

    public class Item : GameObject, IUseble
    {
        #region Fields and Properties

        private List<Skill> bonusSkills;
        private List<Equipment> equipments;
        private bool isEquiped;

        #region Constructors

        public Item(string name, List<Skill> bonusSkills, bool isEquiped)
            : base(name)
        {
            this.BonusSkills = bonusSkills;
            this.IsEquiped = isEquiped;
        }

        #endregion

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

        public List<Equipment> Equipments
        {
            get
            {
                return new List<Equipment>(this.equipments);
            }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("equipments is null");
                }
                this.equipments = value;
            }
        }

        #endregion
        
        
        #region Methods

        public void AddSkill(Skill newSkill)
        {
            this.bonusSkills.Add(newSkill);
        }

        public void AddEquipment(Equipment equipment)
        {
            this.Equipments.Add(equipment);
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.Name, string.Join("|", this.BonusSkills), this.IsEquiped);
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

        public void UseItem(Hero hero)
        {
            for (int skill = 0; skill < hero.Skills.Count; skill++)
            {
                hero.Skills[skill].SkillCurrentValue += BonusSkills[skill].SkillCurrentValue;
            }
        }

        #endregion
    }
}
