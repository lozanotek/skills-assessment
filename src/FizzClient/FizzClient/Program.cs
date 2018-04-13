using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzLib;

namespace FizzClient
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz buz = new FizzBuzz();
            try
            {

                List<string> buzval = buz.GetFizzBuzz().ToList();
                foreach(var item in buzval)
                {
                    Console.WriteLine(item);
                }
               
                List<string> buzMaxVal = buz.GetFizzBuzz(1, int.MaxValue).ToList();

                foreach (var item in buzMaxVal)
                {
                    Console.WriteLine(item);
                }

                List<string> buzMinMaxVal = buz.GetFizzBuzz(int.MinValue, int.MaxValue).ToList();

                foreach (var item in buzMinMaxVal)
                {
                    Console.WriteLine(item);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
