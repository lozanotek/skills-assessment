using FizzLib;
using System;
using System.Collections.Generic;

namespace FizzClient
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            IEnumerable<string> list = fizzBuzz.GetFizzBuzz();
            foreach(string val in list)
            {
                Console.WriteLine(val);
            }

            IEnumerable<string> list2 = fizzBuzz.GetFizzBuzz(1, Int32.MaxValue);
            foreach (string val in list2)
            {
                Console.WriteLine(val);
            }

            IEnumerable<string> list3 = fizzBuzz.GetFizzBuzz(Int32.MinValue, Int32.MaxValue);
            foreach (string val in list3)
            {
                Console.WriteLine(val);
            }
        }
    }
}
