using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGame.Classes
{
    public static class RandomGenerator
    {
        public static int GetRandomNumber(int min, int max)
        {
            Random randomInt = new Random();
            return randomInt.Next(min, max + 1);
        }
    }
}
