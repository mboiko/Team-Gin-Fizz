namespace TheGame.Classes
{
    using System;
    using System.Collections.Generic;

    public abstract class GameStats
    {
        #region Fields and Properties

        private List<Skill> skills;
        private int currentEnergy;
        private int maxEnergy; //level up -> increase
        private int level;
        private double currentExperience;
        private double maxExperience; //when is reached -> level up
        private double efficiency;
        private int currentTime;
        private int maxTime;

        public int MaxTime
        {
            get
            {
                return maxTime;
            }
        }

        public int CurrentTime
        {
            get
            {
                return currentTime;
            }
            protected set
            {
                currentTime = value;
            }
        }

        public int CurrentEnergy
        {
            get
            {
                return this.currentEnergy;
            }
            protected set
            {
                this.currentEnergy = value;
            }
        }

        public int MaxEnergy
        {
            get
            {
                return maxEnergy;
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Level cannot be 0 or negative.");
                }

                this.level = value;
                //onLevelUp()
            }
        }

        public double CurrentExperience
        {
            get
            {
                return this.currentExperience;
            }
            protected set
            {
                this.currentExperience = value;
                if (this.currentExperience >= this.maxExperience)
                {
                    this.currentExperience -= this.maxExperience;
                    this.level++;
                }
            }
        }

        public double MaxExperience
        {
            get
            {
                return this.maxExperience;
            }
        }

        public List<Skill> Skills
        {
            get
            {
                return new List<Skill>(this.skills);
            }
        }

        public double Efficiency
        {
            get
            {
                this.CalculateEfficiency();
                return this.efficiency;
            }
        }


        #endregion

        #region Methods

        protected abstract void CalculateEfficiency();

        public void AddSkill(Skill skillToAdd)
        {
            if (skillToAdd == null)
            {
                throw new ArgumentNullException("skillToAdd");
            }

            this.skills.Add(skillToAdd);
        }

        public void UpdateSkill(string name, int value)
        {
            for (int i = 0; i < this.skills.Count; i++)
            {
                if (this.skills[i].Name == name)
                {
                    this.skills[i].SkillValue += value;
                    break;
                }
            }
        }

        public void IncreaseExperience(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Argument amount cannot be negative.");
            }

            this.CurrentExperience += amount;
        }

        public void UpdateEnergy(int amount)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
