using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVars
{
    [TestClass]
    public class ValTypeExamples
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool isDeclared;
            isDeclared = true;
        }
        public void Chars()
        {
            char character = 'a';
            char specialChar = '\n';
        }
        public void WholeNums()
        {
            byte byteExample = 255;
            int intMin = -2147483648;
            int intMax =  2147483647;
            long longEx = 9222000000;
            Console.WriteLine(intMax);

        }
        [TestMethod]
        public void Decimal()
        {
            float floatEx = 1.04f;
            decimal decimalEx = 0.0001m;
            double doubleEx = 1.04d;

        }
        enum Pastry {cake,cupcake,eclaire,danish}
        [TestMethod]
        public void Enums()
        {
            Pastry pastryType = Pastry.danish;
            Pastry another = Pastry.cake;
            Console.WriteLine(pastryType);
            Console.WriteLine(another);
        }
        [TestMethod]
        public void Structs()
        {
            Int32 age = 30;
            Console.WriteLine(DateTime.Today);
        }
     
    }
}
