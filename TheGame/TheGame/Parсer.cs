namespace TheGame
{
    using System;
    using TheGame.Classes;
    using System.Collections.Generic;
    using System.IO;

    public static class Parсer
    {
        public static List<Skill> GetAllSkills()
        {
            List<Skill> skills = new List<Skill>();
            StreamReader sr = new StreamReader("../Skills.txt");


            return skills;
        }

    }
}
