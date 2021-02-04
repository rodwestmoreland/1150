using _10_Interfaces.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _10_Interfaces
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void PennyTest()
        {
            //Arrange
            ICurrency penny = new Penny();

            //Act


            //Assert
            Assert.AreEqual(0.01m, penny.Value);
            Assert.AreEqual("Penny", penny.Name);
        }

        [DataTestMethod]
        [DataRow(105.73)]
        [DataRow(2.66)]
        [DataRow(111000.33)]
        public void EPayTest(double value)
        {
            //Arrange 
            decimal convertDouble = Convert.ToDecimal(value);
            var ePayment = new ElectronicPayment(convertDouble);

            //Act

            //Assert
            Assert.AreEqual(convertDouble, ePayment.Value);
            Assert.AreEqual("ElectronicPayment", ePayment.Name);


        }
    }
}
