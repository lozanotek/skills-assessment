using System;
using System.Collections.Generic;
using Autofac;
using FizzClient.DependencyModule;
using FizzLib.Services;

namespace FizzClient
{
    public class FizzClient
    {
        static void Main(string[] args)
        {
            var container = Bootstrapper.Bootstrap();

            var fizzBuzz = container.Resolve<IFizzBuzz>();

            WriteRange(1, 100);
            WriteFizzBuzzToConsole(fizzBuzz.GetFizzBuzz());

            WriteRange(1, int.MaxValue);
            WriteFizzBuzzToConsole(fizzBuzz.GetFizzBuzz(max: int.MaxValue));

            WriteRange(int.MinValue, int.MaxValue);
            WriteFizzBuzzToConsole(fizzBuzz.GetFizzBuzz(int.MinValue, int.MaxValue));

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }

        private static void WriteRange(int min, int max)
        {
            Console.WriteLine($"min: {min}, max: {max}");
        }

        private static void WriteFizzBuzzToConsole(IEnumerable<string> results)
        {
            foreach (var result in results)
                Console.WriteLine(result);
        }
    }
}
