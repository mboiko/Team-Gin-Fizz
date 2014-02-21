namespace TheGame.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    abstract class GameStats
    {
        #region Fields and Properties

        private List<Skill> skills;
        private int currentEnergy;
        private int maxEnergy; //level up -> increase
        private int level;
        private double currentExperience;
        private double maxExpirience; //when is reached -> level up
        private double efficiency;

        //TODO: Encapsulate with propeties
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
