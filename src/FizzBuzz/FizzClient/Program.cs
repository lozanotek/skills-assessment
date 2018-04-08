using System;
using System.Collections.Generic;
using FizzLib;

namespace FizzClient
{
    class Program
    {
        private const int ITERATOR_MAX = 5000;

        static void Main(string[] args)
        {
            RunForRange(1, 100);

            RunForRange(1, Int32.MaxValue);

            RunForRange(Int32.MinValue, Int32.MaxValue);

            Console.WriteLine(@"Press Enter To Close...");
            Console.ReadLine();
        }

        private static void RunForRange(int min, int max)
        {
            Console.WriteLine($"Running from {min} to {max}");
            Console.WriteLine();

            var i = min;
            while (i <= max)
            {
                var iterMin = i;
                i += ITERATOR_MAX;
                var iterMax = Math.Min(i, max);

                var run = new FizzBuzz().GetFizzBuzz(iterMin, iterMax);
                PrintValues(run);
            }

            Console.WriteLine();
        }

        private static void PrintValues(IDictionary<int, string> run)
        {
            foreach (var row in run)
            {
                Console.WriteLine($"{row.Key}: {row.Value}");
            }
        }
    }
}
