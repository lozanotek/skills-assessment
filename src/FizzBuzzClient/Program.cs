using System;
using System.Collections.Generic;
using FizzBuzzLib;

namespace FizzBuzzClient
{
    class Program
    {
        private static IDictionary<int, string> _evalList = GetEvalList();
        private static int RunLimit = 10000;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Press enter key twice to evaluate 1 - 100");
            Console.ReadLine();
            ExecuteRange(1, 100);

            Console.WriteLine("Press enter key twice to evaluate 1 - Int32.MaxValue");
            Console.ReadLine();
            ExecuteRange(1, Int32.MaxValue);

            Console.WriteLine("Press enter key twice to evaluate Int32.MinValue - Int32.MaxValue");
            Console.ReadLine();
            ExecuteRange(Int32.MinValue, Int32.MaxValue);

            Console.WriteLine("Press enter key twice to quit.");
            Console.ReadLine();
        }

        private static void ExecuteRange(int minVal, int maxVal)
        {
            // Creating blocks of runs to prevent Out of Memory errors.
            var start = minVal;
            var end = minVal >= 0 && maxVal <= Int32.MaxValue && maxVal <= RunLimit
                ? maxVal
                : minVal >= 0 && maxVal <= Int32.MaxValue && maxVal > RunLimit
                    ? RunLimit
                    : minVal + RunLimit < maxVal
                        ? minVal + RunLimit
                        : maxVal;

            for (var i = minVal; i <= maxVal; i++)
            {
                var evalResult = FizzBuzz.GetFizzBuzz(_evalList, start, end);
                foreach (var result in evalResult)
                {
                    Console.WriteLine(string.Format("{0}: {1}", result.Key, result.Value));
                }

                start = end + 1;
                end = start + RunLimit < RunLimit && start + RunLimit < maxVal
                    ? start + RunLimit
                    : start + RunLimit < maxVal
                        ? start + RunLimit
                        : maxVal;

                if (start - 1 == end) break;
            }
        }

        private static IDictionary<int, string> GetEvalList()
        {
            // Extensible for future expression evaluation. For example, we can easily add an evaluation like, Foo for multiples of 2, without modifying the FizzBuzz class.
            var evalList = new Dictionary<int, string>();
            evalList.Add(3, "Fizz");
            evalList.Add(5, "Buzz");
            // evalList.Add(2, "Foo");

            return evalList;
        }
    }
}
