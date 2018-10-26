using System;
using System.Collections.Generic;

namespace FizzLib.Services
{
    public class FizzBuzz : IFizzBuzz
    {
        public IEnumerable<string> GetFizzBuzz(int min = 1, int max = 100, Dictionary<int, string> additionalRules = null)
        {
            if (max < min)
                throw new ArgumentException("max must be greater than or equal to min");

            additionalRules = additionalRules ?? new Dictionary<int, string>();

            for (long i = min; i <= max; i++)
            {
                var output = "";
                if (i % 3 == 0) output += "Fizz";
                if (i % 5 == 0) output += "Buzz";

                foreach (var keyValuePair in additionalRules)
                {
                    if (keyValuePair.Key != 0 && i % keyValuePair.Key == 0) output += keyValuePair.Value;
                }

                yield return string.IsNullOrEmpty(output) ? i.ToString() : output;
            }
        }
    }
}
