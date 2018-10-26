using System;
using System.Collections.Generic;
using FizzLib.Wrappers;

namespace FizzLib.Services
{
    public class FizzBuzz : IFizzBuzz
    {
        private readonly IConsoleWrapper _consoleWrapper;

        public FizzBuzz(IConsoleWrapper consoleWrapper)
        {
            _consoleWrapper = consoleWrapper;
        }

        public void GetFizzBuzz(int min = 1, int max = 100, Dictionary<int, string> additionalRules = null)
        {
            if (max < min)
                throw new ArgumentException("max must be greater than or equal to min");

            _consoleWrapper.WriteLine($"min: {min}, max: {max}");

            for (var i = min; i <= max; i++)
            {
                var output = "";
                if (i % 3 == 0) output += "Fizz";
                if (i % 5 == 0) output += "Buzz";

                foreach (var keyValuePair in additionalRules ?? new Dictionary<int, string>())
                {
                    if (keyValuePair.Key != 0 && i % keyValuePair.Key == 0) output += keyValuePair.Value;
                }

                _consoleWrapper.WriteLine(output == "" ? i.ToString() : output);

                if (i == int.MaxValue)
                    return;
            }
        }
    }
}
