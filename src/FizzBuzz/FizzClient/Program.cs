using FizzLib;
using System;

namespace FizzClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            catalog.Add(3, "Fizz");
            catalog.Add(5, "Buzz");

            FizzBuzz _fizzBuzz = new FizzBuzz();

            // First Run
            int minValue = 1;
            int maxValue = 100;
            var outputs = _fizzBuzz.GetFizzBuzz(catalog, minValue, maxValue);
            foreach (var output in outputs)
            {
                Console.WriteLine(output);
            }

            // Second Run
            int minValue2 = 1;
            int maxValue2 = Int32.MaxValue;
            var outputs2 = _fizzBuzz.GetFizzBuzz(catalog, minValue2, maxValue2);
            foreach (var output in outputs2)
            {
                Console.WriteLine(output);
            }

            // Third Run
            int minValue3 = Int32.MaxValue;
            int maxValue3= Int32.MaxValue;
            var outputs3 = _fizzBuzz.GetFizzBuzz(catalog, minValue3, maxValue3);
            foreach (var output in outputs3)
            {
                Console.WriteLine(output);
            }
        }
    }
}
