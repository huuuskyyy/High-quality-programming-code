using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Test
{
    class SortingCompare
    {
        static void Main()
        {
            int[] intExample = new int[5000];
            double[] doubleExample = new double[5000];
            string[] stringExample = new string[5000];
            int length = 5000;
           
            Stopwatch timer = new Stopwatch();

            RandomizeTestArrays(intExample, doubleExample, stringExample, length);

            TestQuickSort.Test(intExample, doubleExample, stringExample, timer);

            RandomizeTestArrays(intExample, doubleExample, stringExample, length);

            TestSelectionSort.Test(intExample, doubleExample, stringExample, timer);

            RandomizeTestArrays(intExample, doubleExample, stringExample, length);

            TestInsertionSort.Test(intExample, doubleExample, stringExample, timer);
        }

        public static void RandomizeTestArrays(int[] intExample, double[] doubleExample, string[] stringExample, int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            int min = 0;
            int max = 100000;
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                intExample[i] = random.Next(min, max);
                doubleExample[i] = (double)random.Next(min, max);
                stringExample[i] = chars[random.Next(chars.Length)].ToString();
            }
        }
    }
}
