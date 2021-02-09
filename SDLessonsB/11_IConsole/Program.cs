using _10_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_IConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IConsole regularConsole = new FunConsole();
            ProgramUI ui = new ProgramUI(regularConsole);

            ui.Run();
            Console.Read();
            
        }
    }
}
