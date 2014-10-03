using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class TestSelectionSort
    {
        public static void Test(int[] intExample, double[] doubleExample, string[] stringExample, Stopwatch timer)
        {
            RandomTest(intExample, doubleExample, stringExample, timer);
            SortedTest(intExample, doubleExample, stringExample, timer);
            ReversedTest(intExample, doubleExample, stringExample, timer);  
        }

        private static void ReversedTest(int[] intExample, double[] doubleExample, string[] stringExample, Stopwatch timer)
        {
            Console.WriteLine();
            Console.WriteLine("REVERSED ARRAYS");
            Console.WriteLine();
            Console.WriteLine("Selection sort");

            intExample.Reverse();
            doubleExample.Reverse();
            stringExample.Reverse();

            timer.Reset();
            timer.Start();
            SelectionSort(intExample);
            timer.Stop();

            Console.WriteLine("Integer array sorting time = > " + timer.Elapsed.Ticks);

            timer.Reset();
            timer.Start();
            SelectionSort(doubleExample);
            timer.Stop();

            Console.WriteLine("Double array sorting time = > " + timer.Elapsed.Ticks);

            timer.Reset();
            timer.Start();
            SelectionSort(stringExample);
            timer.Stop();

            Console.WriteLine("String array sorting time = > " + timer.Elapsed.Ticks);
        }

        private static void SortedTest(int[] intExample, double[] doubleExample, string[] stringExample, Stopwatch timer)
        {
            Console.WriteLine();
            Console.WriteLine("SORTED ARRAYS");
            Console.WriteLine();
            Console.WriteLine("Selection sort");

            timer.Reset();
            timer.Start();
            SelectionSort(intExample);
            timer.Stop();

            Console.WriteLine("Integer array sorting time = > " + timer.Elapsed.Ticks);

            timer.Reset();
            timer.Start();
            SelectionSort(doubleExample);
            timer.Stop();

            Console.WriteLine("Double array sorting time = > " + timer.Elapsed.Ticks);

            timer.Reset();
            timer.Start();
            SelectionSort(stringExample);
            timer.Stop();

            Console.WriteLine("String array sorting time = > " + timer.Elapsed.Ticks);

        }

        private static void RandomTest(int[] intExample, double[] doubleExample, string[] stringExample, Stopwatch timer)
        {
            Console.WriteLine();
            Console.WriteLine("RANDOM ARRAYS");
            Console.WriteLine();
            Console.WriteLine("Selection sort");

            timer.Start();
            SelectionSort(intExample);
            timer.Stop();

            Console.WriteLine("Integer array sorting time = > " + timer.Elapsed.Ticks);

            timer.Reset();
            timer.Start();
            SelectionSort(doubleExample);
            timer.Stop();

            Console.WriteLine("Double array sorting time = > " + timer.Elapsed.Ticks);

            timer.Reset();
            timer.Start();
            SelectionSort(stringExample);
            timer.Stop();

            Console.WriteLine("String array sorting time = > " + timer.Elapsed.Ticks);
        }

        private static void SelectionSort<T>(T[] array) where T : IComparable<T>
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[min]) < 0)
                    {
                        min = j;
                    }
                }

                if (array[min].CompareTo(array[i]) != 0)
                {
                    T temp = array[min];
                    array[min] = array[i];
                    array[i] = temp;
                }
            }
        }

    }
}
