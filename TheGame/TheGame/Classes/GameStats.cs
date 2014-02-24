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
            protected set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Argument maxTime cannot be negative or equal to zero.");
                }
                this.maxTime = value;
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
                if (value < 0)
                {
                    throw new ArgumentException("Argument currentTime cannot be negative.");
                }
                this.currentTime = value;
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
                if (value < 0)
                {
                    throw new ArgumentException("Argument currentEnergy cannot be negative.");
                }
                this.currentEnergy = value;
            }
        }

        public int MaxEnergy
        {
            get
            {
                return maxEnergy;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Argument maxEnergy cannot be negative or equal to zero.");
                }
                this.maxEnergy = value;
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
                    throw new ArgumentException("Argument level cannot be negative or equal to zero.");
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
                if (value < 0)
                {
                    throw new ArgumentException("Cannot add negative value to experience.");
                }

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
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Argument maxExperience cannot be negative or equal to zero.");
                }
                this.maxExperience = value;
            }
        }

        public List<Skill> Skills
        {
            get
            {
                return new List<Skill>(this.skills);
            }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("skills");
                }
                this.skills = value;
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

        #region Constructors

        public GameStats(List<Skill> skills, int currentEnergy, int maxEnergy, int level,
            double currentExperience, double maxExperience, int currentTime, int maxTime)
        {
            this.Skills = skills;
            this.CurrentEnergy = currentEnergy;
            this.MaxEnergy = maxEnergy;
            this.Level = level;
            this.currentExperience = currentExperience;
            this.MaxExperience = maxExperience;
            this.CurrentTime = currentTime;
            this.MaxTime = maxTime;
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
                    this.skills[i].SkillCurrentValue += value;
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
