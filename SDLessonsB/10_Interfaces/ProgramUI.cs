using _10_Interfaces.Fruits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces
{
    class ProgramUI
    {
        private readonly IConsole _console;

        public ProgramUI(IConsole console) =>_console = console;

        public void Run()
        {
            List<IFruit> fruitSalad = new List<IFruit>();
            Banana banana = new Banana();
            Orange orange = new Orange(false);
            Grape  grape =  new Grape();

            fruitSalad.Add(banana);
            fruitSalad.Add(orange);
            fruitSalad.Add(grape);
            foreach (IFruit fruit in fruitSalad)
            {
                Console.WriteLine($"This is a {fruit.Name}");
                Console.WriteLine(fruit.Peel());
            }
        }
    }
}
