using System;
using FizzLib;

namespace FizzClient
{
    class Program
    {
        public static void Main(string[] args)
        {
            foreach (string i in FizzBuzz.GetFizzBuzz(1, 100))
            {
                Console.Write(i);
            }

            foreach (string i in FizzBuzz.GetFizzBuzz(1, int.MaxValue))
            {
                Console.Write(i);
            }

            foreach (string i in FizzBuzz.GetFizzBuzz(int.MinValue, int.MaxValue))
            {
                Console.Write(i);
            }
        }
    }
}
