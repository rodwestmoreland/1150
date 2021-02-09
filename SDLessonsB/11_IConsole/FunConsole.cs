using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_IConsole
{
    class FunConsole : IConsole
    {
        private Random _random = new Random();

        public ConsoleColor PickRandomColor()
        {
            int choice = _random.Next(0,6);
            switch (choice)
            {
                case 0: return ConsoleColor.Red;
                case 1: return ConsoleColor.Blue;
                case 2: return ConsoleColor.Green;
                case 3: return ConsoleColor.Cyan;
                case 4: return ConsoleColor.Yellow;
                case 5: return ConsoleColor.Magenta;
                default: return ConsoleColor.White;
            }
        }
        public void Clear()
        {
            throw new NotImplementedException();
        }

        public ConsoleKeyInfo ReadKey()
        {
            throw new NotImplementedException();
        }

        public string ReadLine()
        {
            throw new NotImplementedException();
        }

        public void Write(string s)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(string s)
        {
            Console.BackgroundColor = PickRandomColor();
            Console.ForegroundColor = PickRandomColor();

            Console.WriteLine(_random.Next(0,3) == 0 
                                ? s.ToUpper() 
                                : s.ToLower());
        }

        public void WriteLine(object o)
        {
            throw new NotImplementedException();
        }
    }
}
