using System.Collections.Generic;
using FizzLib.Models;

namespace FizzLib.Services
{
    public interface IFizzBuzz
    {
        IEnumerable<string> GetFizzBuzz(int min = 1, int max = 100, List<DivisorReplacement> replacements = null);
    }
}
