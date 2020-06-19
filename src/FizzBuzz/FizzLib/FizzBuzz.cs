using System.Collections.Generic;

namespace FizzLib
{
    public class FizzBuzz
    {
        public IEnumerable<string> GetFizzBuzz(Catalog catalog, long min = 1, long max = 100) 
        {
            List<string> outlist = new List<string>();
            for (long x = min; x <= max; ++x)
            {
                outlist.Add(catalog.ToString(x));
            }

            return outlist;
        }
    }
}
