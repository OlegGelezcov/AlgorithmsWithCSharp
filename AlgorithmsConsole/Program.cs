using System;

namespace AlgorithmsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //CardDeckTool deckTool = new CardDeckTool(5, 5);
            //deckTool.MakeGroups();

            DiceTool diceTool = new DiceTool(1000000, 5);
            int barCount = 120;
            var result = diceTool.RollPercent(barCount);
            BarDrawer drawer = new BarDrawer();
            drawer.PrintDictionaryBar(2, 2, result, barCount);
        }
    }
}
