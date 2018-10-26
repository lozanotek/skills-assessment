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

            fizzBuzz.GetFizzBuzz(95);
            fizzBuzz.GetFizzBuzz(max: int.MaxValue);
            fizzBuzz.GetFizzBuzz(int.MinValue, int.MaxValue);

            Console.WriteLine("Press any key to quit.");
            Console.ReadLine();
        }
    }
}
