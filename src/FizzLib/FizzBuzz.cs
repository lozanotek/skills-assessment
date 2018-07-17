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

            try
            {
                for (var x = min; x <= max; x++)
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

                    dictionary.Add(x, resultString);
                }
            }
            catch (Exception ex)
            {
                //log the exception - in real life - since I'm not actually using the variable, resharper throws a compiler warning - I could turn that off

                //I could bubble up the exception - or not catch it here at all and let it bubble up depending on the pattern the team follows
                dictionary.Clear();
            }

            return dictionary;
        }
    }
}
