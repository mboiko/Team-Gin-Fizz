namespace TheGame.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

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

        //TODO: Encapsulate with propeties
        public int CurrentEnergy 
        {
            get
            {
                return this.currentEnergy;
            }
            set
            {
                //TODO - ?? validation
                this.currentEnergy = value;
            }
        }

        public int MaxEnergy 
        {
            get
            {
                return this.maxEnergy;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Max Energy cannot be negative.");
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
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Level cannot be 0 or negative.");
                }

                this.level = value;
            }
        }

        public double CurrentExperience 
        {
            get
            {
                return this.currentExperience;
            }
            set
            {
                //TODO - ?? validation
                this.currentExperience = value;
            }
        }

        public double MaxExperience 
        {
            get
            {
                return this.maxExperience;
            }
            set
            {
                 if (value < 0)
                {
                    throw new ArgumentException("Max Experience cannot be negative.");
                }

                this.maxExperience = value;
            }
        }

        public double Efficiency 
        {
            get
            {
                return this.efficiency;
            }
            set
            {
                //TODO - ?? validation
                this.efficiency = value;
            }
        }

        #endregion

        #region Methods

        public void AddSkill(Skill skillToAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateSkill(string name, int value)
        {
            throw new NotImplementedException();
        }

        public virtual double GetEfficiencyCoef()
        {
            throw new NotImplementedException();
        }

        public void UpdateExperience(double amount)
        {
            //check if exp is enough for the next level
            throw new NotImplementedException();
        }

        public void UpdateEnergy(int amount)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
