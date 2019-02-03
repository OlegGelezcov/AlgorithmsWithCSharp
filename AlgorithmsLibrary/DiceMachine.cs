using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsLibrary
{
    public class DiceMachine
    {
        private List<Dice> dices = new List<Dice>();

        public Dictionary<int, int> RollCounts { get; } = new Dictionary<int, int>();
        public Dictionary<int, double> RollPercents { get; } = new Dictionary<int, double>();

        public int TriesCount { get; set; } = 1;

        public DiceMachine(int diceCount, int diceMinValue = 1, int diceMaxValue = 6)
        {
            dices = new List<Dice>(diceCount);
            for(int i = 0; i < diceCount; i++ )
            {
                dices.Add(new Dice(diceMinValue, diceMaxValue));
            }
        }

        public int Min
            => dices.Sum(d => d.Min);

        public int Max
            => dices.Sum(d => d.Max);

        public int RollValue
            => dices.Sum(d => d.RollValue);

        private void PrepareRollCounts()
        {
            RollCounts.Clear();
            for(int i = Min; i <= Max; i++ )
            {
                RollCounts.Add(i, 0);
            }
        }

        private void CollectStatistics()
        {
            RollPercents.Clear();
            for(int i = Min; i <= Max; i++ )
            {
                RollPercents.Add(i, (double)RollCounts[i] / TriesCount);
            }
        }

        public void MakeRolls()
        {
            PrepareRollCounts();
            for(int i = 0; i < TriesCount; i++ )
            {
                RollCounts[RollValue]++;
            }
            CollectStatistics();
        }

        public Dictionary<int, int> GetPrintablePercents(int barSliceCount)
        {
            Dictionary<int, int> slices = new Dictionary<int, int>();
            foreach(var kvp in RollPercents )
            {
                slices.Add(kvp.Key, (int)(kvp.Value * barSliceCount));
            }
            return slices;
        }

    }
}
