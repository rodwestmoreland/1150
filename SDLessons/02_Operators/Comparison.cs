using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void Compare()
        {
            int age = 35;
            bool equals = age == 42;
            Console.WriteLine("what? " + equals);
        }
    }
}
