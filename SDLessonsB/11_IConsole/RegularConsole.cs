using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_IConsole
{
    class RegularConsole : IConsole
    {
        public void Clear() => Console.Clear();
        public ConsoleKeyInfo ReadKey() => Console.ReadKey();
        public string ReadLine() => Console.ReadLine();

        public void Write(string s)
        {
            Console.Write(s); 
        }

        public void WriteLine(string s)
        {
            Console.WriteLine(s);
        }

        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }
    }
}
