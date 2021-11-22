using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftDigital.Tasks
{
    public static class Task2
    {
        public static int minSplit(int amount)
        {
            int result = 0;
            int fifties = amount / 50;
            result += fifties;

            int leftFromFifties = amount % 50;

            int twenties = leftFromFifties / 20;
            result += twenties;

            int leftFromTwenties = leftFromFifties % 20;

            int tens = leftFromTwenties / 10;

            result += tens;

            int leftFromTens = leftFromTwenties % 10;

            int fives = leftFromTens / 5;

            result += fives;

            int lefFromFives = leftFromTens % 5;

            result += lefFromFives;

            return result;
        }
    }
}
