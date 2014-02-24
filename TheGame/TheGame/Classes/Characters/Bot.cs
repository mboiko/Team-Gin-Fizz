namespace TheGame.Classes.Characters
{
    using System;
    using System.Collections.Generic;

    public class Bot : Character
    {
        private List<string> lines;
        private List<string> sounds;

        public Bot(string nickname, List<string> lines, List<string>sounds): base(nickname)
        {
            this.lines = lines;
            this.sounds = sounds;
        }

        //methods
        public string GetLine()
        {
            return lines[RandomGenerator.GetRandomNumber(0, lines.Count)];
        }

        public string GetSound()
        {
            return sounds[RandomGenerator.GetRandomNumber(0, sounds.Count)];
        }

    }
}
