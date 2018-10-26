using System.Collections.Generic;

namespace FizzLib.Services
{
    public interface IFizzBuzz
    {
        IEnumerable<string> GetFizzBuzz(int min = 1, int max = 100, Dictionary<int, string> additionalRules = null);
    }
}
