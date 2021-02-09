using _10_Interfaces.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _10_Interfaces
{
    [TestClass]
    public class TransactionTests
    {
        private decimal _debt;
        private void PayDebt(ICurrency payment)
        {
            _debt = payment.Value;
            Console.WriteLine($"You paid {payment.Value}");
        }

        [TestInitialize]
        public void Arrange() => _debt = 9000.01m;
    
        [TestMethod]
        public void PayDebtTest()
        {
            //Arrange
            PayDebt(new Dollar());
            PayDebt(new Dime());
            PayDebt(new ElectronicPayment(300.50m));
            decimal expectedDebt = 9000.01m - 301.6m;

            //Assert
            //Assert.AreEqual(expectedDebt, _debt);

        }

        public void InjectionTest()
        {
            //Arrange
            var dollar =        new Dollar();
            var ePayment =      new ElectronicPayment(123.45m);
            
            // ** dependency injection - ICurrency depends on some value (ICurrency) 
            // ** which is injected into the object
            var firstTrans =    new Transaction(dollar);
            var secondTrans =   new Transaction(ePayment);

            Console.WriteLine(firstTrans.GetTransactionType()) ;
            Console.WriteLine(secondTrans.GetTransactionType());
        }
    
    
    }
}
