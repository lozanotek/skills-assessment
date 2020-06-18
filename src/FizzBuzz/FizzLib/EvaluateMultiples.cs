using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzLib
{
    static class EvaluateMultiples
    {
        static public string EvaluateInt(int ival)
        {
            string resultval = string.Empty;
            if (ival % 3 == 0)
            {
                resultval += "Fizz";
            }
            if (ival % 5 == 0)
            {
                resultval += "Buzz";
            }
            if (resultval.Length == 0)
            {
                resultval = ival.ToString();
            }
            return (resultval);
        }
    }
}
