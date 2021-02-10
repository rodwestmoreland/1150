using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(1970, 10, 10);
            HowOld(date);
            

            string someText = "101";
            SomeText(someText);

            Console.ReadLine();
        }

        public static void HowOld(DateTime date)
        {
            TimeSpan dateDifference = DateTime.Now - date;
            var age = (int)(dateDifference.Days / 365.2425);
            Console.WriteLine(age);
        }

     public static void SomeText(string aNumber)
        {
            if (Int32.TryParse(aNumber, out int num))
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("cannot convert");

            
        }

    }
}
