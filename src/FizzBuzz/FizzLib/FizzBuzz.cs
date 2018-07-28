using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzLib
{
    public class FizzBuzz
    {
        public Dictionary<int,string> GetFizzBuzz(List<Tuple<int, string>> evaluations,int min = 1, int max = 100)
        {
            var data = new Dictionary<int,string>();
            for (int i = min; i <= max; i++)
            {
                evaluations = evaluations.OrderBy(x => x.Item1).ToList();

                string result = "";
                foreach (var evaluation in evaluations)
                {
                    if (i % evaluation.Item1 == 0)
                        result += evaluation.Item2;
                }
                if (result == "")
                    result = i.ToString();
                data.Add((int)i,result);
                if(i == Int32.MaxValue)
                    break;
            }
            return data;
        }
    }
}
