using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces.Currency
{
    public class Penny:ICurrency
    {
        public string Name => GetType().Name;
        public decimal Value => 0.01m;

    }

    public class Dime : ICurrency
    {
        public string Name => GetType().Name;
        public decimal Value => 0.10m;

    }

    public class Dollar : ICurrency
    {
        public string Name => GetType().Name;
        public decimal Value => 1.00m;

    }

    public class ElectronicPayment : ICurrency
    {
        public string Name => GetType().Name;
        public decimal Value { get; }
        public ElectronicPayment(decimal value)
        {
            Value = value;
        }

    }
}
