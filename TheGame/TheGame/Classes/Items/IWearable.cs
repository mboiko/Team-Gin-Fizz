namespace TheGame
{
    using TheGame.Classes.Characters;

    interface IWearable
    {
        int SkillBaseValue { get; set; }
        void IncreaseBaseSkill(Hero hero);
    }
}
