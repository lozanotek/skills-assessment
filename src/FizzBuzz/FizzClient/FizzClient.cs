using System;
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
            fizzBuzz.GetFizzBuzz();

            WriteRange(1, int.MaxValue);
            fizzBuzz.GetFizzBuzz(max: int.MaxValue);

            WriteRange(int.MinValue, int.MaxValue);
            fizzBuzz.GetFizzBuzz(int.MinValue, int.MaxValue);

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }

        private static void WriteRange(int min, int max)
        {
            Console.WriteLine($"min: {min}, max: {max}");
        }
    }
}
