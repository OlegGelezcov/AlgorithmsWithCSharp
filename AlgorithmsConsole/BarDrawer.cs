using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsConsole
{
    public class BarDrawer
    {
        private void PrintValue(int x, int y, int barCount )
        {
            Console.SetCursorPosition(x, y);
            for(int i = 0; i < barCount; i++ )
            {
                Console.Write("=");
            }
        }

        public void PrintDictionaryBar(int startX, int startY, Dictionary<int, int> dict, int totalCount)
        {
            Console.Clear();
            Console.SetBufferSize(200, 1000);
            //Console.SetWindowSize(80, 100);

            int currentX = startX;
            int currentY = startY;
            
            foreach(int key in dict.Keys.OrderBy(k => k))
            {
                int percent = (int)(100 * (double)dict[key] / totalCount);
                Console.SetCursorPosition(currentX, currentY);
                Console.Write($"{key.ToString("00")}:({percent.ToString("00")}%)");
                currentX += 20;
                PrintValue(currentX, currentY, dict[key]);
                currentX = startX;
                currentY++;
            }
            Console.WriteLine();
        }
    }
}
