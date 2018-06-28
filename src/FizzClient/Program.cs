using FizzLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzClient
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            List<Tuple<int, string>> evaluations = new List<Tuple<int, string>>();
            evaluations.Add(3, "Fizz");
            evaluations.Add(5, "Buzz");
            //add as many evaluations as desired
            //evaluations.Add(2, "Foo");  


            //Run with default min(1), max(100)
            foreach (var result in fizzBuzz.GetFizzBuzz(evaluations))
            {
                Console.WriteLine("[{0}] - {1}", result.InputValue, result.OutputValue);
            }

            //Run with min(1), max(Int32.MaxValue)
            foreach (var result in fizzBuzz.GetFizzBuzz(evaluations, 1, Int32.MaxValue))
            {
                Console.WriteLine("[{0}] - {1}", result.InputValue, result.OutputValue);
            }

            //Run with min(Int32.MinValue), max(Int32.MaxValue)
            foreach (var result in fizzBuzz.GetFizzBuzz(evaluations, Int32.MinValue, Int32.MaxValue))
            {
                Console.WriteLine("[{0}] - {1}", result.InputValue, result.OutputValue);
            }

            Console.ReadLine();
        }
    }
}
