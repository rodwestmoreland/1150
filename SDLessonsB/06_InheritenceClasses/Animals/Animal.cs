using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InheritenceClasses.Animals
{
    public enum DietType { Herbivore, Carnivore, Omnivore }

    public abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine($"This is {GetType().Name} new constructor");
        }
        public int      NumOfLegs { get; set; }
        public int      MyProperty { get; set; }
        public DietType DietType { get; set; }
        public bool     IsHungry { get; set; }

        public virtual void Move()
        {
            Console.WriteLine($"{GetType().Name} NEW moves");
        }
    }
}
