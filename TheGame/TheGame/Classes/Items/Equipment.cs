namespace TheGame.Classes.Items
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Forms;

    using TheGame.Classes.Characters;

    public class Equipment : Item, IWearable
    {
        //constructor
        public Equipment(string name, List<Skill> skills, bool isEnquiped)
            : base(name, skills, isEnquiped)
        {

        }

        //method
        public void Compare(Item initialItem)
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format("{0} : {1}", this.Name.PadLeft(32), initialItem.Name.PadRight(32)));
            result.AppendLine();

            for (int skill = 0; skill < this.BonusSkills.Count; skill++)
            {
                string skillName = this.BonusSkills[skill].Name; 
                int firstItemValue = this.BonusSkills[skill].BaseSkillValue;
                int secondItemValue = initialItem.BonusSkills[skill].BaseSkillValue;

                result.AppendLine(string.Format("{0} {1} : {2}",
                    skillName.PadLeft(31 - firstItemValue.ToString().Length - skillName.Length),
                    firstItemValue, secondItemValue.ToString().PadRight(32)));
            }

            MessageBox.Show(result.ToString(), "Equipment Comparison", MessageBoxButtons.OK);
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.Name, string.Join("|", this.BonusSkills), this.IsEquiped);
        }
    }
}
