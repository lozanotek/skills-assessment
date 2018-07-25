using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class FizzBuzz
    {
        public static IDictionary<int, string> GetFizzBuzz(IDictionary<int, string> evalList, int minVal = 1, int maxVal = 100)
        {            
            var fizzBuzzResult = new Dictionary<int, string>();

            // Adding a default setting 
            if (evalList == null || evalList.Count == default(int))
            {
                evalList = new Dictionary<int, string>();
                evalList.Add(3, "Fizz");
                evalList.Add(5, "Buzz");
            }

            for(int i = minVal; i <= maxVal; i++)
            {
                var evalResult = string.Empty;
                foreach (var item in evalList)
                {
                    evalResult += EvaluateNumber(i, item.Key, item.Value);
                }

                fizzBuzzResult.Add(i, evalResult == string.Empty ? i.ToString() : evalResult);
            }

            return fizzBuzzResult;
        }

        private static string EvaluateNumber(int value, int evalNumber, string message)
        {
            var evalResult = value % evalNumber == 0 ? message : "";

            return evalResult;
        }
    }
}
