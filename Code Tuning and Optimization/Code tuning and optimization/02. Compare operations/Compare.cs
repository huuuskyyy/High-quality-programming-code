using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Compare_operations
{
    class Program
    {
        static void Main()
        {
            int intNumber = 1;
            float floatNumber = 1f;
            double doubleNumber = 1d;
            decimal decimalNumber = 1m;
            long longNumber = 1L;

            Stopwatch intStopwatch = new Stopwatch();
            Stopwatch floatStopwatch = new Stopwatch();
            Stopwatch doubleStopwatch = new Stopwatch();
            Stopwatch decimalStopwatch = new Stopwatch();
            Stopwatch longStopwatch = new Stopwatch();

            intStopwatch.Start();

            for (int i = 0; i < 1000000; i++)
            {
                intNumber += 1;
            }

            intStopwatch.Stop();
            Console.WriteLine("Intiger add time "+intStopwatch.Elapsed.Ticks);

            floatStopwatch.Start();

            for (int i = 0; i < 1000000; i++)
            {
                floatNumber += 1f;
            }

            floatStopwatch.Stop();
            Console.WriteLine("Float add time " + floatStopwatch.Elapsed.Ticks);


            doubleStopwatch.Start();

            for (int i = 0; i < 1000000; i++)
            {
                doubleNumber += 1d;
            }

            doubleStopwatch.Stop();
            Console.WriteLine("Double add time " + doubleStopwatch.Elapsed.Ticks);

            decimalStopwatch.Start();

            for (int i = 0; i < 1000000; i++)
            {
                decimalNumber += 1m;
            }

            decimalStopwatch.Stop();
            Console.WriteLine("Decimal add time " + decimalStopwatch.Elapsed.Ticks);

            longStopwatch.Start();

            for (int i = 0; i < 1000000; i++)
            {
                longNumber += 1L;
            }

            longStopwatch.Stop();
            Console.WriteLine("Long add time " + longStopwatch.Elapsed.Ticks);

            Console.WriteLine();

            intStopwatch.Start();

            for (int i = 0; i < 1000000; i++)
            {
                intNumber -= 1;
            }

            intStopwatch.Stop();
            Console.WriteLine("Intiger substract time " + intStopwatch.Elapsed.Ticks);

            floatStopwatch.Start();

            for (int i = 0; i < 1000000; i++)
            {
                floatNumber -= 1f;
            }

            floatStopwatch.Stop();
            Console.WriteLine("Float substract time " + floatStopwatch.Elapsed.Ticks);


            doubleStopwatch.Start();

            for (int i = 0; i < 1000000; i++)
            {
                doubleNumber -= 1d;
            }

            doubleStopwatch.Stop();
            Console.WriteLine("Double substract time " + doubleStopwatch.Elapsed.Ticks);

            decimalStopwatch.Start();

            for (int i = 0; i < 1000000; i++)
            {
                decimalNumber -= 1m;
            }

            decimalStopwatch.Stop();
            Console.WriteLine("Decimal substract time " + decimalStopwatch.Elapsed.Ticks);

            longStopwatch.Start();

            for (int i = 0; i < 1000000; i++)
            {
                longNumber -= 1L;
            }

            longStopwatch.Stop();
            Console.WriteLine("Long substract time " + longStopwatch.Elapsed.Ticks);

            Console.WriteLine();

            intStopwatch.Start();

            for (int i = 0; i < 1000000; i++)
            {
                intNumber++;
            }

            intStopwatch.Stop();
            Console.WriteLine("Intiger increment time " + intStopwatch.Elapsed.Ticks);

            floatStopwatch.Start();

            for (int i = 0; i < 1000000; i++)
            {
                floatNumber++;
            }

            floatStopwatch.Stop();
            Console.WriteLine("Float increment time " + floatStopwatch.Elapsed.Ticks);


            doubleStopwatch.Start();

            for (int i = 0; i < 1000000; i++)
            {
                doubleNumber++;
            }

            doubleStopwatch.Stop();
            Console.WriteLine("Double increment time " + doubleStopwatch.Elapsed.Ticks);

            decimalStopwatch.Start();

            for (int i = 0; i < 1000000; i++)
            {
                decimalNumber++;
            }

            decimalStopwatch.Stop();
            Console.WriteLine("Decimal increment time " + decimalStopwatch.Elapsed.Ticks);

            longStopwatch.Start();

            for (int i = 0; i < 1000000; i++)
            {
                longNumber++;
            }

            longStopwatch.Stop();
            Console.WriteLine("Long increment time " + longStopwatch.Elapsed.Ticks);

            Console.WriteLine();

            intNumber = 1;
            floatNumber = 1f;
            doubleNumber = 1d;
            decimalNumber = 1m;
            longNumber = 1L;

            intStopwatch.Start();

            for (int i = 0; i < 50; i++)
            {
                intNumber*=2;
            }

            intStopwatch.Stop();
            Console.WriteLine("Intiger multiply time " + intStopwatch.Elapsed.Ticks);

            floatStopwatch.Start();

            for (int i = 0; i < 50; i++)
            {
                floatNumber *= 2f;
            }

            floatStopwatch.Stop();
            Console.WriteLine("Float multiply time " + floatStopwatch.Elapsed.Ticks);


            doubleStopwatch.Start();

            for (int i = 0; i < 50; i++)
            {
                doubleNumber *= 2d;
            }

            doubleStopwatch.Stop();
            Console.WriteLine("Double multiply time " + doubleStopwatch.Elapsed.Ticks);

            decimalStopwatch.Start();

            for (int i = 0; i < 50; i++)
            {
                decimalNumber *= 2m;
            }

            decimalStopwatch.Stop();
            Console.WriteLine("Decimal multiply time " + decimalStopwatch.Elapsed.Ticks);

            longStopwatch.Start();

            for (int i = 0; i < 50; i++)
            {
                longNumber *= 2L;
            }

            longStopwatch.Stop();
            Console.WriteLine("Long multiply time " + longStopwatch.Elapsed.Ticks);

            Console.WriteLine();

            for (int i = 0; i < 50; i++)
            {
                intNumber /= 2;
            }

            intStopwatch.Stop();
            Console.WriteLine("Intiger divide time " + intStopwatch.Elapsed.Ticks);

            floatStopwatch.Start();

            for (int i = 0; i < 50; i++)
            {
                floatNumber /= 2f;
            }

            floatStopwatch.Stop();
            Console.WriteLine("Float divide time " + floatStopwatch.Elapsed.Ticks);


            doubleStopwatch.Start();

            for (int i = 0; i < 50; i++)
            {
                doubleNumber /= 2d;
            }

            doubleStopwatch.Stop();
            Console.WriteLine("Double divide time " + doubleStopwatch.Elapsed.Ticks);

            decimalStopwatch.Start();

            for (int i = 0; i < 50; i++)
            {
                decimalNumber /= 2m;
            }

            decimalStopwatch.Stop();
            Console.WriteLine("Decimal divide time " + decimalStopwatch.Elapsed.Ticks);

            longStopwatch.Start();

            for (int i = 0; i < 50; i++)
            {
                longNumber /= 2L;
            }

            longStopwatch.Stop();
            Console.WriteLine("Long divide time " + longStopwatch.Elapsed.Ticks);

            Console.WriteLine();
        }

    }
}
