using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExample
{
    public static class Generator
    {
        private static int endNumber = 99999;
        private static int nextNumber = 10000;
        public static int GenerateUniqueNumber()
        {
            nextNumber++;
            if (nextNumber < endNumber)
            {
                return nextNumber;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Database numbers reached. Remove old data");
            }
        }
    }
}
