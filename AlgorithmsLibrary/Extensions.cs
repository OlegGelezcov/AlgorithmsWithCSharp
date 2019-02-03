using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public static class Extensions
    {
        
        public static T[] Randomize<T>(this T[] arr, int? seed = null)
        {
            Random random = seed.HasValue ? new Random(seed.Value) : new Random();
            T[] copyArr = new T[arr.Length];
            Array.Copy(arr, copyArr, arr.Length);

            for(int i = 0; i < copyArr.Length - 1; i++ )
            {
                int j = random.Next(i + 1, copyArr.Length);
                T temp = copyArr[i];
                copyArr[i] = copyArr[j];
                copyArr[j] = temp;
            }
            return copyArr;
        }
    }
}
