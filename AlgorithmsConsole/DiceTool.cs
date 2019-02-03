using AlgorithmsLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsConsole
{
    public class DiceTool
    {
        private DiceMachine machine;

        public DiceTool(int triesCount, int diceCount = 2)
        {
            machine = new DiceMachine(diceCount)
            {
                TriesCount = triesCount
            };
            machine.MakeRolls();
        }

        public Dictionary<int, int> RollPercent(int totalPrinttableBarCount = 30)
            => machine.GetPrintablePercents(totalPrinttableBarCount);

    }
}
