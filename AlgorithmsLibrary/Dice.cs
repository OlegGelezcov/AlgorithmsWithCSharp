using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class Dice
    {
        private static readonly Random random = new Random();

        public int Min { get; }
        public int Max { get; }

        public Dice(int minValue = 1, int maxValue = 6)
        {
            Min = minValue;
            Max = maxValue;
        }

        public int RollValue
            => random.Next(Min, Max + 1);

    }
}
