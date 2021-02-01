using _06_InheritenceClasses.Animals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_InheritenceClasses.AnimalTests
{
    [TestClass]
    public class BirdTests
    {
        [TestMethod]
        public void AnimalTest1()
        {
            {
                //Animal animal = new Animal(); //Abstract: now only used for inheritance
                //animal.NumOfLegs = 4;
                //animal.Move();
                Console.WriteLine("---------------------");

                Bird bird = new Bird();
                bird.WingSpan = 4.5;
                Console.WriteLine("---------------------");

                Eagle eagle = new Eagle();
                eagle.WingSpan = 8;
                eagle.Move();
                Console.WriteLine("---------------------");
            }
        }
    }
}
