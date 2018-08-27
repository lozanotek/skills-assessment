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
            //var yourMin = int.MinValue;
            var yourMin = 1;
            var yourMax = 100;
            //var yourMax = int.MaxValue;

            var expressions = new Dictionary<Predicate<int>, string>();

            Predicate<int> divide3 = x => (x % 3 == 0);
            Predicate<int> divide5 = x => (x % 5 == 0);
            Predicate<int> divide3and5 = x => (x % 5 == 0) && (x % 3 == 0);
            //Predicate<int> multiple2 = x => (x % 2 == 0);

            //add expression and its wanted output. order here by priority of evaluation, first hit case is what is printed.
            expressions.Add(divide3and5, "FizzBuzz");
            expressions.Add(divide3, "Fizz");
            expressions.Add(divide5, "Buzz");
            //expressions.Add(multiple2, "**Foo**");

            FizzBuzzThings(yourMin, yourMax, expressions);

            Console.WriteLine("Press Any Key");
            Console.ReadKey();
        }

        private static void FizzBuzzThings(int min, int max, Dictionary<Predicate<int>,string> settings)
        {
            //avoid out of memory
            int threshold = 400000;

            var fizzBuzz = new FizzBuzz(settings);

            for (int i = min; i <= max; i++)
            {
                //dont go to far
                var end = (i + threshold) > max ?
                    max : (i + threshold);

                var result = fizzBuzz.GetFizzBuzz(i, end);

                //jump forward in the loop, let ++ go to next spot for us
                i = end;

                foreach (var r in result)
                {
                    Console.WriteLine(r);
                }
            }
            
        }
    }
}
