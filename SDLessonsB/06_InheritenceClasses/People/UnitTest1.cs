﻿using _06_InheritenceClasses.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_InheritenceClasses
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testThis()
        {
            int[] arr = new int[] {};
            
            Array.Sort(arr);
            int pair = 0;
            int x = 0;
            bool test = false;

            foreach(int el in arr)
            {  
                if (test)               //used for moving forward if match is found
                {
                    test = false;
                    continue;           //shift or skip one foreach iteration
                }
                
                if( x+1 < arr.Length)
                {                    
                    if (el == arr[x+1])
                    {
                        Console.WriteLine("match " + el);
                        pair++;
                        x+=2;           //shift over matches
                        test = true;
                        continue;       //break out of loop
                    }
                    test = false;
                    x++;
                }
            }
            Console.WriteLine("matches = " + pair);


        }
        

        
        [TestMethod]
        public void TestMethod1()
        {
            User newUser = new User("r@emal.io");
            //string randId = newUser.setId(); without static
            User.setId();
            //Console.WriteLine(randId);
            Console.WriteLine(User.setId());

           
            for (int i = 0; i < 35; i++)
            {
                if (i % 3 ==0)
                {
                    Console.WriteLine("Fizz");
                } else if (i % 5 ==0)
                {
                    Console.WriteLine("Buzz");
                } else if (i % 3 == 0 && i % 5 == 0)
                { Console.WriteLine("FizzBuzz"); }
                  

               
                }

            
            }
        public void Divide(int num1, int num2)
        {
            double result = Convert.ToDouble(num1) / Convert.ToDouble(num2);
            Console.WriteLine(result);

        }

        public int Converted(string notNum)
        {
            int converted = Convert.ToInt32(notNum);
            return converted;
        }

        public int Bigger(int one, int two)
        {
            return (one > two) ? one : two;
        }

        public void HowOld(DateTime date)
        {
            TimeSpan ageSpan = DateTime.Now - date;
            Console.WriteLine(ageSpan);
        }
    }
    }

