using System;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace FizzLib
{
    public static class FizzBuzz
    {
        public static IDictionary<string, List<int>> Multiples = new Dictionary<string, List<int>>()
                                                                    {
                                                                        {"Fizz", new List<int> {3}},
                                                                        {"Buzz", new List<int> {5}},
                                                                        {"FizzBuzz", new List<int> {3, 5}} 
                                                                    };


        public static IEnumerable<string> GetFizzBuzz(int min = 1, int max = 100)
        {
            var result = "";
            bool isaMultiple = true;

            for (int i = min; i < max; i++)
            {
                result = i.ToString();
                foreach (var item in Multiples)
                {
                    foreach (var value in item.Value)
                    {
                        if (i % value != 0)
                        {
                            isaMultiple = false;
                        }
                    }

                    if (isaMultiple)
                    {
                        result = item.Key;
                    }
                    isaMultiple = true;
                }
                yield return result;
            }

        }
    }
}
