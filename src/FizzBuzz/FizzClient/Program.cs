namespace FizzClient
{
    using FizzLib;

    public class Program
    {
        public static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();

            fizzBuzz.GetFizzBuzz();
            fizzBuzz.GetFizzBuzz(1, int.MaxValue);
            fizzBuzz.GetFizzBuzz(int.MinValue, int.MaxValue);
        }
    }
}
