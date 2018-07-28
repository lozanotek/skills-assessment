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
        private static readonly FizzBuzz FizzBuzz = new FizzBuzz();
        private const int maxBatchSize = 10000;
        private static Tuple<int, string> three = new Tuple<int, string>(3, "Fizz");
        private static Tuple<int, string> five = new Tuple<int, string>(5, "Buzz");
        //private static Tuple<int, string> two = new Tuple<int, string>(2, "Foo");
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Print 1 - 100");
                Run(1, 100);
                Console.WriteLine("Print 1 - Int32.MaxValue");
                Run(1, Int32.MaxValue);
                Console.WriteLine(" Print Int32.MinValue - Int32.MaxValue");
                Run(Int32.MinValue, Int32.MaxValue);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void Run(int min, int max)
        {
            int batchStart = min;
            int batchEnd = max <= (min + maxBatchSize) ? max : min + maxBatchSize;
            int checkIntMaxOut = Int32.MaxValue - maxBatchSize;
            List<Tuple<int, string>> evaluationList = new List<Tuple<int, string>>();
            evaluationList.Add(three);
            evaluationList.Add(five);
            //evaluationList.Add(two);

            while (batchEnd <= max)
            {
                var dictionary = FizzBuzz.GetFizzBuzz(evaluationList, batchStart, batchEnd);
                foreach (KeyValuePair<int, string> pair in dictionary)
                    Print(pair.Value);
                if (max == batchEnd)
                    break;
                batchStart = batchEnd + 1;
                if (batchEnd >= checkIntMaxOut)
                    batchEnd += Math.Abs(max - batchEnd);
                else
                    batchEnd = batchStart + maxBatchSize >= max ? max : batchEnd + maxBatchSize;
            }
        }

        public static void Print(string dataToPrint)
        {
            Console.WriteLine(dataToPrint);
        }
    }
}
