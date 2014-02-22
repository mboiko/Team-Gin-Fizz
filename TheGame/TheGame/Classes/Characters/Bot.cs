namespace TheGame.Classes
{
    using System;
    using System.Collections.Generic;

    public class Bot : Character
    {
        private List<string> lines;
        private List<string> sounds;

        public Bot(List<string> lines, List<string>sounds)
        {
            this.lines = lines;
            this.sounds = sounds;
        }

        //methods
        public string GetLine()
        {
            return lines[GetRandomNumber(0, lines.Count)];
        }

        public string GetSound()
        {
            return sounds[GetRandomNumber(0, sounds.Count)];
        }

    }
}
