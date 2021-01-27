using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    class Calculator
    {
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }
        public double Add(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        public int Sub(int numOne, int numTwo)
        {
            int sub = numOne - numTwo;
            return sub;
        }
    }
}
