using System;
using System.Collections.Generic;
using System.Linq.Expressions;

/// <summary>
/// Summary description for Class1
/// </summary>
public class FizzBuzz
{
    Dictionary<Predicate<int>, string> Settings = new Dictionary<Predicate<int>, string>();

    public FizzBuzz(Dictionary<Predicate<int>, string> settings)
    {
        Settings = settings;
    }

    public IEnumerable<string> GetFizzBuzz(int min = 1, int max = 100)
    {
        var result = new List<string>();

        for (int i = min; i <= max; i++)
        {
            //result.Add(FizzBuzzLightyear(i));
            result.Add(FizzBuzzExtension(i));
        }

        return result;
    }

    //easy way
    private string FizzBuzzLightyear(int number)
    {
        var divide3 = (number % 3) == 0;
        var divide5 = (number % 5) == 0;
        //var multiple2 = (number % 2) == 0;

        if (divide3 & divide5)
            return "Fizz Buzz";

        if (divide3)
            return "Fizz";

        if (divide5)
            return "Buzz";

        else
            return number.ToString();
    }

    //extension way
    private string FizzBuzzExtension(int number)
    {
        foreach(var rule in Settings)
        {
            if(rule.Key.Invoke(number))
            {
                return rule.Value;
            }
        }

        return number.ToString();
    }

}
