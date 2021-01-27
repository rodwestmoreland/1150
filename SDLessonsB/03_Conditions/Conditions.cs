using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditions
{
    [TestClass]
    public class Conditions
    {
        [TestMethod]
        public void TestMethod1()
        {
            int count=0;
            string text = "Supercalifragilisticexpialidocious";

            foreach (char letter in text)
            {
                count++;
                Console.WriteLine(letter);
            }

            Console.WriteLine(count);

            for (int i = 0; i<text.Length; i++)
            {
                if(text[i]=='i')
                {
                    Console.WriteLine($"found an i: {text[i]}");
                }
                else if (text[i]=='l')
                {
                    Console.WriteLine($"found an L: {text[i]}");
                }

            }
        }
    }
}
