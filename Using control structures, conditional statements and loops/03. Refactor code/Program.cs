using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorCode
{
    class Program
    {
        public static void Main()
        {
            int[] arrayExample = new int[100];
            int searchedNumber = 666;

            for (int i = 0; i < arrayExample.Length; i++)
            {
                Console.WriteLine(arrayExample[i]);

                if (i % 10 == 0)
                {
                    if (arrayExample[i] == searchedNumber)
                    {
                        Console.WriteLine("Value Found");
                    }
                }
            }
    }
}
