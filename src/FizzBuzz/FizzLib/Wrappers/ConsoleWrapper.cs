using System;

namespace FizzLib.Wrappers
{
    public class ConsoleWrapper : IConsoleWrapper
    {
        public void WriteLine(object value)
        {
            Console.WriteLine(value);
        }
    }
}
