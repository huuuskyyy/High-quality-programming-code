using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
   public static class TestQuickSort
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
           Console.WriteLine("Quicksort");

           intExample.Reverse();
           doubleExample.Reverse();
           stringExample.Reverse();

           timer.Reset();
           timer.Start();
           intExample = QuickSort(intExample);
           timer.Stop();

           Console.WriteLine("Integer array sorting time = > " + timer.Elapsed.Ticks);

           timer.Reset();
           timer.Start();
           doubleExample = QuickSort(doubleExample);
           timer.Stop();

           Console.WriteLine("Double array sorting time = > " + timer.Elapsed.Ticks);

           timer.Reset();
           timer.Start();
           stringExample = QuickSort(stringExample);
           timer.Stop();

           Console.WriteLine("String array sorting time = > " + timer.Elapsed.Ticks);
       }
       private static void RandomTest(int[] intExample, double[] doubleExample, string[] stringExample, Stopwatch timer)
       {
           Console.WriteLine("RANDOM ARRAYS");
           Console.WriteLine();
           Console.WriteLine("Quicksort");

           timer.Start();
           intExample = QuickSort(intExample);
           timer.Stop();

           Console.WriteLine("Integer array sorting time = > " + timer.Elapsed.Ticks);

           timer.Reset();
           timer.Start();
           doubleExample = QuickSort(doubleExample);
           timer.Stop();

           Console.WriteLine("Double array sorting time = > " + timer.Elapsed.Ticks);

           timer.Reset();
           timer.Start();
           stringExample = QuickSort(stringExample);
           timer.Stop();

           Console.WriteLine("String array sorting time = > " + timer.Elapsed.Ticks);
       }

       private static void SortedTest(int[] intExample, double[] doubleExample, string[] stringExample, Stopwatch timer)
       {
           Console.WriteLine();
           Console.WriteLine("SORTED ARRAYS");
           Console.WriteLine();
           Console.WriteLine("Quicksort");

           timer.Reset();
           timer.Start();
           intExample = QuickSort(intExample);
           timer.Stop();

           Console.WriteLine("Integer array sorting time = > " + timer.Elapsed.Ticks);

           timer.Reset();
           timer.Start();
           doubleExample = QuickSort(doubleExample);
           timer.Stop();

           Console.WriteLine("Double array sorting time = > " + timer.Elapsed.Ticks);

           timer.Reset();
           timer.Start();
           stringExample = QuickSort(stringExample);
           timer.Stop();

           Console.WriteLine("String array sorting time = > " + timer.Elapsed.Ticks);
       }

       private static T[] QuickSort<T>(T[] array) where T : IComparable<T>
       {
           int pivotIndex = array.Length / 2;

           if (pivotIndex == 0)
           {
               return array;
           }

           List<T> smaller = new List<T>();
           List<T> bigger = new List<T>();
           T pivotElement = array[pivotIndex];

           int pivotCounter = 0;

           for (int i = 0; i < array.Length; i++)
           {

               if (array[i].CompareTo(pivotElement) == 0 &&
               pivotCounter > 0)
               {
                   smaller.Add(array[i]);
               }
               else if (array[i].CompareTo(pivotElement) < 0)
               {
                   smaller.Add(array[i]);
               }
               else if (array[i].CompareTo(pivotElement) == 0)
               {
                   pivotCounter++;
               }
               else
               {
                   bigger.Add(array[i]);
               }

           }
           T[] left = smaller.ToArray();

           T[] right = bigger.ToArray();

           List<T> returnArray = ResultArray(QuickSort(left),
           QuickSort(right), pivotElement);
           return returnArray.ToArray();
       }

       private static List<T> ResultArray<T>(T[] arrayLeft, T[] arrayRight, T middle)
       where T : IComparable<T>
       {

           List<T> result = new List<T>();

           for (int i = 0; i < arrayLeft.Length; i++)
           {
               result.Add(arrayLeft[i]);
           }
           result.Add(middle);

           for (int i = 0; i < arrayRight.Length; i++)
           {
               result.Add(arrayRight[i]);

           }
           return result;
       }

    }
}
