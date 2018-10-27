using System;
using System.Collections.Generic;
using System.Linq;
using FizzLib.Models;

namespace FizzLib.Services
{
    public class FizzBuzz : IFizzBuzz
    {
        private readonly DivisorReplacement _fizzReplacement = new DivisorReplacement
        {
            Divisor = 3,
            ReplaceWith = "Fizz"
        };
        private readonly DivisorReplacement _buzzReplacement = new DivisorReplacement
        {
            Divisor = 5,
            ReplaceWith = "Buzz"
        };

        public IEnumerable<string> GetFizzBuzz(int min = 1, int max = 100, List<DivisorReplacement> replacements = null)
        {
            if (max < min)
                throw new ArgumentException("max must be greater than or equal to min");

            replacements = replacements ?? new List<DivisorReplacement>();
            if (replacements.FirstOrDefault(x => x.Divisor == 3) == null)
                replacements.Add(_fizzReplacement);
            if (replacements.FirstOrDefault(x => x.Divisor == 5) == null)
                replacements.Add(_buzzReplacement);

            for (long i = min; i <= max; i++)
            {
                var result = string.Join("", replacements
                    .Where(x => x.Divisor != 0 && i % x.Divisor == 0)
                    .Select(x => x.ReplaceWith)
                    .ToList());

                yield return string.IsNullOrEmpty(result) ? i.ToString() : result;
            }
        }
    }
}
