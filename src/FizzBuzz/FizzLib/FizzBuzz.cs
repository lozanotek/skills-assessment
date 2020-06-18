using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzLib
{
    public class FizzBuzz
    {
        public IEnumerable<string> GetFizzBuzz(int min = 1, int max = 100)
        {
            List<string> listOfInts = new List<string>();
            for (long ival = min; ival <= max; ival ++)  // use long to avoid overflow at int32.MaxValue
            {
                //listOfInts.Add(ival.ToString());
                listOfInts.Add(EvaluateMultiples.EvaluateInt((int) ival));
            }
            return listOfInts;
        }
    }
}
