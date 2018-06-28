using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzLib
{
    public static class ExtensionsAndHelpers
    {
        public static bool IsDivisibleBy(this Int32 sourceNumber, Int32 targetNumber)
        {
            return (sourceNumber % targetNumber) == 0;
        }

        public static void Add<T1, T2>(this IList<Tuple<T1, T2>> list,
            T1 item1, T2 item2)
        {
            list.Add(Tuple.Create(item1, item2));
        }
    }

    public class FizzBuzzResult
    {
        public int InputValue { get; set; }
        public string OutputValue { get; set; }
    }

    public class FizzBuzz
    {
        public IEnumerable<FizzBuzzResult> GetFizzBuzz(List<Tuple<int, string>> evaluations, Int32 minVal = 1, Int32 maxVal = 100)
        {
            IEnumerable<FizzBuzzResult> result = new List<FizzBuzzResult>();

            return LongRange(minVal, maxVal).Select(k => new FizzBuzzResult
            {
                InputValue = (Int32)k,
                OutputValue = Evaluate(evaluations, (Int32)k)
            });
        }

        public string Evaluate(List<Tuple<int, string>> evaluations, Int32 val)
        {
            var evaluatedDivisibleOutput = String.Empty;

            if (evaluations.Any(j => val.IsDivisibleBy(j.Item1)))
            {
                evaluatedDivisibleOutput = evaluations.Where(j => val.IsDivisibleBy(j.Item1)).Select(h => h.Item2).Aggregate((a, b) => a + b);
            }

            return string.IsNullOrEmpty(evaluatedDivisibleOutput) ? val.ToString() : evaluatedDivisibleOutput;
        }

        public static IEnumerable<long> LongRange(long minVal, long maxVal)
        {
            for (long x = minVal; x <= maxVal; x++)
                yield return x;
        }
    } 
}
