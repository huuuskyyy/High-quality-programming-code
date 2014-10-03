using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolExample.Test
{
    [TestClass]
    public class GeneratorTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Generator created student numbers out of the max limit")]
        public void TestIfGeneratorThrowsProperExceptionWhenReachesLimitForGeneratedNumber()
        {
            int testIntValue;

            for (int i = 0; i < 91000; i++)
			{
			    testIntValue = Generator.GenerateUniqueNumber();
			}
        }
    }
}
