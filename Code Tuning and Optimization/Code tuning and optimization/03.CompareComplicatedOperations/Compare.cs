using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareComplicatedOperations
{
    class Compare
    {
        static void Main()
        {
            double doubleNumber = 60481729d;
            float floatNumber = 60481729f;
            decimal decimalNumber = 60481729m;

            Stopwatch floatStopwatch = new Stopwatch();
            Stopwatch doubleStopwatch = new Stopwatch();
            Stopwatch decimalStopwatch = new Stopwatch();

            floatStopwatch.Start();
            floatNumber = (float)Math.Sqrt(floatNumber);
            floatStopwatch.Stop();

            doubleStopwatch.Start();
            doubleNumber = Math.Sqrt(doubleNumber);
            doubleStopwatch.Stop();

            decimalStopwatch.Start();
            decimalNumber = (decimal)Math.Sqrt((double)decimalNumber);
            decimalStopwatch.Stop();

            Console.WriteLine("Float sqrt "+floatStopwatch.Elapsed.Ticks);
            Console.WriteLine("Double sqrt " + doubleStopwatch.Elapsed.Ticks);
            Console.WriteLine("Decimal sqrt " + decimalStopwatch.Elapsed.Ticks);
            Console.WriteLine();

            doubleNumber = 60481729d;
            floatNumber = 60481729f;
            decimalNumber = 60481729m;

            floatStopwatch.Start();
            floatNumber = (float)Math.Log(floatNumber);
            floatStopwatch.Stop();

            doubleStopwatch.Start();
            doubleNumber = Math.Log(doubleNumber);
            doubleStopwatch.Stop();

            decimalStopwatch.Start();
            decimalNumber = (decimal)Math.Log((double)decimalNumber);
            decimalStopwatch.Stop();

            Console.WriteLine("Float log " + floatStopwatch.Elapsed.Ticks);
            Console.WriteLine("Double log " + doubleStopwatch.Elapsed.Ticks);
            Console.WriteLine("Decimal log " + decimalStopwatch.Elapsed.Ticks);
            Console.WriteLine();

            doubleNumber = 60481729d;
            floatNumber = 60481729f;
            decimalNumber = 60481729m;

            floatStopwatch.Start();
            floatNumber = (float)Math.Sin(floatNumber);
            floatStopwatch.Stop();

            doubleStopwatch.Start();
            doubleNumber = Math.Sin(doubleNumber);
            doubleStopwatch.Stop();

            decimalStopwatch.Start();
            decimalNumber = (decimal)Math.Sin((double)decimalNumber);
            decimalStopwatch.Stop();

            Console.WriteLine("Float sin " + floatStopwatch.Elapsed.Ticks);
            Console.WriteLine("Double sin " + doubleStopwatch.Elapsed.Ticks);
            Console.WriteLine("Decimal sin " + decimalStopwatch.Elapsed.Ticks);
            Console.WriteLine();
        }
    }
}
