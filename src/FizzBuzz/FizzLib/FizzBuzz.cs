namespace FizzLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FizzBuzz
    {
        public List<Tuple<int, string>> ExpressionEvaluation { get; set; } =
            new List<Tuple<int, string>> { new Tuple<int, string>(3, "Fizz"), new Tuple<int, string>(5, "Buzz") };

        public void GetFizzBuzz(int min = 1, int max = 100)
        {
            for (int i = min; i <= max; i++)
            {
                List<Tuple<int, string>> matchingExpressionEvaluation =
                    ExpressionEvaluation.Where(t => (i % t.Item1 == 0)).ToList();

                if (matchingExpressionEvaluation.Any())
                {
                    Console.WriteLine(string.Join("", matchingExpressionEvaluation.Select(c => c.Item2)));
                }
            }

            Console.ReadLine();
        }
    }
}
