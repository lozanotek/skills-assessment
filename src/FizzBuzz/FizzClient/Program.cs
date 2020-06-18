using FizzLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int startval = 1;
            int endval = 100;
            int rangediff = 100;
            try
            {
                if (args.Length > 0)
                {
                    startval = int.Parse(args[0]);
                }
                if (args.Length > 1)
                {
                    endval = int.Parse(args[1]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Format: FizzClient <minval> <maxval> (use valid int32 values)");
                return;
            }
            int irangestart = 0;
            int irangeend = 0;
            FizzBuzz fizzBuzz = new FizzBuzz();
            irangestart = startval;
            // use this so that if int32.MaxValue is selected, it won't overflow
            irangeend = (endval - irangestart < rangediff) ? endval : irangestart + rangediff;
            while (irangeend <= endval)
            {
                //Console.WriteLine("Start {0}, End {1}", irangestart, irangeend);
                foreach (string sval in fizzBuzz.GetFizzBuzz(irangestart, irangeend))
                {
                    Console.WriteLine(sval);
                }
                // set next start and end values
                if (irangeend < endval)
                {
                    irangestart = irangeend + 1;
                    irangeend = (endval - irangestart < rangediff) ? endval : irangestart + rangediff;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
