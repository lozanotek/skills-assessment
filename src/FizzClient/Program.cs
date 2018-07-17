using System;
using FizzLib;
using System.Collections.Generic;

namespace FizzClient
{
    class Program
    {
        private static readonly FizzBuzz FizzBuzz = new FizzBuzz();

        //resharper does not like all caps variables, even for constants - I did not have an issue running in increments of 10000... 
        //...but could reduce if out of memory error's occur
        private const int MaxIteration = 10000;

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This program will print...");
                Console.WriteLine("'Fizz' for multiples of 3");
                Console.WriteLine("'Buzz' for multiples of 5");
                Console.WriteLine("'FizzBuzz' for multiples of 3 and 5");
                Console.WriteLine();
                Console.WriteLine("Test 1: Print the output for numbers 1 through 100.");
                Run(1, 100);

                Console.WriteLine("Test 2: Print the output for numbers 1 through Int32.MaxValue which is {0}.", int.MaxValue);
                Run(1, int.MaxValue);

                Console.WriteLine("Test 3: Print the output for numbers Int32.MinValue which is {0}, through Int32.MaxValue which is {1}.", int.MinValue, int.MaxValue);
                Run(int.MinValue, int.MaxValue);
            }
            catch (Exception ex)
            {
                //allowing all exceptions to bubble up to here...

                //would never display technical details back to the user, keeping here for my testing purposes
                Console.WriteLine("Something bad happened!  Here are the technical details: " + ex.Message);
            }
        }

        private static void Run(int min, int max)
        {
            //started with recursion for the sake of demonstrating I know how it works... however, it leads to out of memory problems every time...
            //...normally I would not check in commented out code, but chose to keep it here as a painful memory, haha!

            //var start = min;

            ////do not want to exceed the max value but need to run incrementally to avoid out of memory errors
            //var end = start + MaxIteration < max ? start + MaxIteration : max;

            //var results = FizzBuzz.GetFizzBuzz(start, end);

            //Print(results);

            //if (end < max)
            //{
            //    //setup our next incremental run
            //    end++;

            //    //recursively call run until we have reached the max value - could have also performed a loop
            //    Run(end, max);
            //}

            var start = min;

            //do not want to exceed the max value but need to run incrementally to avoid out of memory errors
            var end = start + MaxIteration < max ? start + MaxIteration : max;

            while (end <= max)
            {
                var results = FizzBuzz.GetFizzBuzz(start, end);

                Print(results);

                //adding 1 to int.MaxValue will cause it to go to int.MinValue, we do not want that or we'll end up in an infinite loop!
                if (end == max) break;

                //setup our next incremental run
                end++;
                start = end;
                end = start + MaxIteration < max ? start + MaxIteration : max;
            }
        }

        private static void Print(IDictionary<int, string> results)
        {
            if (results != null && results.Count > 0)
            {
                foreach (var result in results)
                {
                    Console.WriteLine("{0}: {1}", result.Key, result.Value);
                }
            }
            else
            {
                Console.WriteLine("No results returned!");
            }

        }
    }
}
