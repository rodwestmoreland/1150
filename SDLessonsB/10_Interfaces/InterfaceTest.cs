using _10_Interfaces.Fruits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _10_Interfaces
{
    [TestClass]
    public class InterfaceTest
    {
        [TestMethod]
        public void FruitTest()
        {
            Banana banana = new Banana();
            Orange orange = new Orange(true);
            Grape grape = new Grape();
            Tomato tomato = new Tomato();
            orange.Peel();
            Mandarin mandarin = new Mandarin(true);
            List<IFruit> basket = new List<IFruit>();

            basket.Add(banana);
            basket.Add(grape);
            basket.Add(orange);
            basket.Add(mandarin);
            basket.Add(tomato);

            foreach (IFruit fruit in basket)
            {
                Console.WriteLine(fruit.Name != "grape" || fruit.Name != "tomato"
                                                ? fruit.Peel() 
                                                : $"Can't peel {fruit.Name}"); ;
            }
        }
    }
}
