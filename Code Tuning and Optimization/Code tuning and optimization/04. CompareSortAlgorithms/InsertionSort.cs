using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class TestInsertionSort
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
            InsertionSort(intExample);
            timer.Stop();

            Console.WriteLine("Integer array sorting time = > " + timer.Elapsed.Ticks);

            timer.Reset();
            timer.Start();
            InsertionSort(doubleExample);
            timer.Stop();

            Console.WriteLine("Double array sorting time = > " + timer.Elapsed.Ticks);

            timer.Reset();
            timer.Start();
            InsertionSort(stringExample);
            timer.Stop();

            Console.WriteLine("String array sorting time = > " + timer.Elapsed.Ticks);
        }

        private static void SortedTest(int[] intExample, double[] doubleExample, string[] stringExample, Stopwatch timer)
        {
            Console.WriteLine();
            Console.WriteLine("SORTED ARRAYS");
            Console.WriteLine();
            Console.WriteLine("Insertion sort");

            timer.Reset();
            timer.Start();
            InsertionSort(intExample);
            timer.Stop();

            Console.WriteLine("Integer array sorting time = > " + timer.Elapsed.Ticks);

            timer.Reset();
            timer.Start();
            InsertionSort(doubleExample);
            timer.Stop();

            Console.WriteLine("Double array sorting time = > " + timer.Elapsed.Ticks);

            timer.Reset();
            timer.Start();
            InsertionSort(stringExample);
            timer.Stop();

            Console.WriteLine("String array sorting time = > " + timer.Elapsed.Ticks);
        }

        private static void RandomTest(int[] intExample, double[] doubleExample, string[] stringExample, Stopwatch timer)
        {
            Console.WriteLine();
            Console.WriteLine("RANDOM ARRAYS");
            Console.WriteLine();
            Console.WriteLine("Insertion sort");

            timer.Start();
            InsertionSort(intExample);
            timer.Stop();

            Console.WriteLine("Integer array sorting time = > " + timer.Elapsed.Ticks);

            timer.Reset();
            timer.Start();
            InsertionSort(doubleExample);
            timer.Stop();

            Console.WriteLine("Double array sorting time = > " + timer.Elapsed.Ticks);

            timer.Reset();
            timer.Start();
            InsertionSort(stringExample);
            timer.Stop();

            Console.WriteLine("String array sorting time = > " + timer.Elapsed.Ticks);
        }

        private static void InsertionSort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 1; i < array.Length; i++)
            {
                T current = array[i];
                int j = i - 1;

                while (j >= 0 && (array[j].CompareTo(current) > 0))
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = current;
            }
        }
    }
}
