using System;
using System.Collections.Generic;
using System.Diagnostics;
using FizzzLib;

namespace FizzClient
{
    class Program
    {
        private const int ITERATOR_MAX = 10000;

        static void Main(string[] args)
        {
            RunFizzBuzz(1, 100);

            //RunFizzBuzz(1, Int32.MaxValue);

            //RunFizzBuzz(Int32.MinValue, Int32.MaxValue);

            Console.WriteLine(@"It's finally done!");
            Console.ReadLine();
        }

        private static void RunFizzBuzz(int min, int max)
        {
            Console.WriteLine($"Running FizBuzz for {min} to {max}");
            Console.WriteLine("---");

            var i = min;
            while(i < max)
            {
                var iteratorMin = i;
                i += ITERATOR_MAX;
                var iteratorMax = Math.Min(i, max);

                var fizzBuzz = new FizzBuzz().GetFizzBuzz(iteratorMin, iteratorMax);
                PrintValues(fizzBuzz);
            }

            Console.WriteLine("---");
        }

        private static void PrintValues(IEnumerable<string> values)
        {
            foreach (var value in values){
                Console.WriteLine(value.ToString());
            }
        }
    }
}
