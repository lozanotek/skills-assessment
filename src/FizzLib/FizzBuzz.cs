using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzLib
{
    public class FizzBuzz
    {
        public int Start { get; set; }
        public int End { get; set; }
        public IEnumerable<string> GetFizzBuzz(int start = 1, int end = 100)
        {
            this.Start = start;
            this.End = end;
            List<string> retVal = new List<string>();

            try
            {
                for (int i = start; i <= end; i++)
                {
                    if (i % 5 == 0 && i % 3 == 0)
                        retVal.Add("FizzBuzz");
                    else if (i % 3 == 0)
                        retVal.Add("Fizz");
                    else if (i % 5 == 0)
                        retVal.Add("Buzz");
                    
                }

                FizzBuzzExtension.getExtensible(this, retVal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retVal;
        }
    }
}
