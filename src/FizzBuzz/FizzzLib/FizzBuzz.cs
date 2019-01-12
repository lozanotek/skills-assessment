using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzzLib
{
    public class FizzBuzz
    {
        public IEnumerable<string> GetFizzBuzz(int min =1, int max = 100)
        {
            var output = new List<string>();

            for (int i = min; i <= max; i++)
            {
                output.Add(FizzBuzzLogic(i));
            }

            return output;
        }

        private string FizzBuzzLogic(int number)
        {
            var divisibleBy3 = IsDivisibleBy(number, 3);
            var divisibleBy5 = IsDivisibleBy(number, 5);

            if (divisibleBy3 && divisibleBy5)
                return "Fizz Buzz";
            if (divisibleBy3)
                return "Fizz";
            if (divisibleBy5)
                return "Buzz";
            return number.ToString();
             
        }

        private bool IsDivisibleBy(int numerator, int denominator)
        {
            return numerator % denominator == 0;
        }
    }
}
