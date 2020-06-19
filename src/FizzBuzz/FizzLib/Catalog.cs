using System;
using System.Collections.Generic;

namespace FizzLib
{
    public class Catalog
    {
        public List<Spec> specs;
        public class Spec
        {
            internal int divisor;
            internal string output;
        }
        public Catalog()
        {
            this.specs = new List<Spec>();
        }
        public void Add(int Divisor, string Output)
        {
            this.specs.Add(new Spec() { divisor = Divisor, output = Output });
        }
        internal string ToString(long Number)
        {
            string outputstring = "";
            foreach (var x in specs)
            {
                outputstring += Number % x.divisor == 0 ? x.output : "";
            }
            return String.IsNullOrWhiteSpace(outputstring) ? Number.ToString() : outputstring;
        }
    }
}
