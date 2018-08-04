using System.Collections.Generic;
using System.Linq;

namespace FizzLib
{
    public class FizzBuzz
    {
        public IEnumerable<string> GetFizzBuzz(int min = 1, int max = 100)
        {
            IDictionary<int, string> defaultValues = new Dictionary<int, string>();
            defaultValues.Add(3, "Fizz");
            defaultValues.Add(5, "Buzz");
            defaultValues.Add(15, "FizzBuzz");

            return GetFizzBuzz(defaultValues, min, max);
        }

        public IEnumerable<string> GetFizzBuzz(IDictionary<int, string> displayValues, int min = 1, int max = 100)
        {
            var list = Enumerable.Range(min, max)
                .Select(n => {
                    foreach(int i in displayValues.Keys.OrderByDescending(key => key))
                    {
                        if(n % i == 0)
                        {
                            return displayValues.FirstOrDefault(s => s.Key == i).Value;
                        }
                    }

                    return n.ToString();
                });

            return list;
        }
    }
}
