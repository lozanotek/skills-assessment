using System;
using System.Collections.Generic;

namespace FizzLib
{
    public class FizzBuzz
    {
        //resharper does not like all caps variables, even for constants
        private const string Fzz = "Fizz";
        private const string Bzz = "Buzz";
        private const string Fzzbzz = "FizzBuzz";

        //allow intentional overrides of the method in the case of a derived class
        public virtual IDictionary<int, string> GetFizzBuzz(int min = 1, int max = 100)
        {
            var dictionary = new Dictionary<int, string>();

            //using a long because x++ will increment beyond int.MaxValue causing x to rollover to int.MinValue
            for (long x = min; x <= max; x++)
            {
                var resultString = string.Empty;

                // mod 15 is equivalent to numbers that are multiples of both 3 and 5
                if (x % 15 == 0)
                {
                    resultString = Fzzbzz;
                }
                else if (x % 3 == 0)
                {
                    resultString = Fzz;
                }
                else if (x % 5 == 0)
                {
                    resultString = Bzz;
                }

                dictionary.Add((int)x, resultString);
            }

            return dictionary;
        }
    }
}
