using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVars
{
    [TestClass]
    public class RefTypeExamples
    {
        [TestMethod]
        public void Strings()
        {
            string strEx = "a string";
            string next = "put together";
            Console.WriteLine($"{strEx}... {next}");
            Console.WriteLine(string.Format("{0}... {1}",strEx,next));

        }
        [TestMethod]
        public void Collections()
        {
            string strEx = "hi there";
            string[] strArr = { "one", "two", "three", strEx };
            foreach(string item in strArr)
            {
                Console.WriteLine(item);
            }
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("one");
            listOfStrings.Add("two");

            Queue<string> fifo = new Queue<string>();
            fifo.Enqueue("1");
            fifo.Enqueue("two");
            fifo.Enqueue("drei");
            var first = fifo.Dequeue();
            Console.WriteLine(first);
            Console.WriteLine(fifo.Dequeue());

            Dictionary<int, string> keysAndValues = new Dictionary<int, string>();
            keysAndValues.Add(42, "answer to everything");
            keysAndValues.Add(8, "lucky");
            var val = keysAndValues[42] ;
            Console.WriteLine( val);
            SortedList<int, string> sorted = new SortedList<int, string>();
            sorted.Add(42, "this");
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> stackList = new Stack<string>();
            stackList.Push("first");
            stackList.Push("second");
            stackList.Push("third");
            Console.WriteLine(stackList.Pop());
        }
        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();
            int rand = rng.Next(0,20);
            Console.WriteLine(rand);
            Console.WriteLine(rand); //same number
        }
    }
}
