using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void TestMethod1()
        {
            int sum = 9 + 13;
            int sub = 9 - 13;
            int mult = 9 * 13;
            double div = 9.0 / 13.0;
            Console.WriteLine($"{sum} {sub} {mult} {Math.Round(div,2)}");
        }
    }
}
