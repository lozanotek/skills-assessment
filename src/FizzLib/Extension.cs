using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzLib
{
    public static class FizzBuzzExtension
    {

        public static void getExtensible(this FizzBuzz Buzz, List<string> calval)
        {

            
            for (int i = Buzz.Start; i <= Buzz.End; i++)
            {
                if (i % 2 == 0)
                    calval.Add("Foo");
            }

            
        }
    }
}
