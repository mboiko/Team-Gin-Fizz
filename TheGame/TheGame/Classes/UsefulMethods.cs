namespace TheGame.Classes
{
    using System;

    public static class UsefulMethods
    {
        public static Random randomInt = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            return randomInt.Next(min, max + 1);
        }

    }
}
