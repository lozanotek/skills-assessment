using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class FizzBuzz
    {
        public IDictionary<int, string> GetFizzBuzz(IDictionary<int, string> evalList, int minVal = 1, int maxVal = 100)
        {
            
            var fizzBuzzResult = new Dictionary<int, string>();

            // Adding a default setting but making it...
            // Extensible for future expression evaluation. For example, we can easily add an evaluation like, Foo for multiples of 2, without modifying the FizzBuzz class.
            if (evalList == null || evalList.Count == default(int))
            {
                evalList = new Dictionary<int, string>();
                evalList.Add(3, "Fizz");
                evalList.Add(5, "Buzz");
            }

            for(var i = minVal; i <= maxVal; i++)
            {
                var evalResult = string.Empty;
                foreach (var item in evalList)
                {
                    evalResult += EvaluateNumber(i, item.Key, item.Value);
                }

                fizzBuzzResult.Add(i, evalResult);
            }

            return fizzBuzzResult;
        }

        private string EvaluateNumber(int value, int evalNumber, string message)
        {
            var evalResult = value % evalNumber == 0 ? message : "";

            return evalResult;
        }
    }
}
