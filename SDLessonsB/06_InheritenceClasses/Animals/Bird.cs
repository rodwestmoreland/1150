using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InheritenceClasses.Animals
{
    public class Bird : Animal
    {
        public Bird()
        {
            Console.WriteLine($"this is bird constructor");
        }
        public double WingSpan { get; set; }

        public override void Move()
        {
            //ignores override and calls base method (in Animal class)
            Console.WriteLine("I fly");
            
        }

    }
    public class Eagle : Bird
    {
        public Eagle()
        {
            Console.WriteLine("This is eagle constructor");
        }
    }
}
