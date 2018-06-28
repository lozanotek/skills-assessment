using System;
using System.Collections.Generic;
using System.Linq;
using FizzLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private readonly List<Tuple<int, string>> _evaluations = SeedEvaluations();
        private FizzBuzz _fizzBuzz = new FizzBuzz();

        [TestMethod]
        public void NineIsDivisibleByThree()
        {
            int nine = 9;
            Assert.IsTrue(nine.IsDivisibleBy(3));
        }

        [TestMethod]
        public void NineIsNotDivisibleByFour()
        {
            int nine = 9;
            Assert.IsFalse(nine.IsDivisibleBy(4));
        }

        [TestMethod]
        public void ReturnFizzWhenDivisibleByThree()
        {
            Assert.IsTrue(_fizzBuzz.GetFizzBuzz(_evaluations).Single(k => k.InputValue == 3).OutputValue == "Fizz");
        }

        [TestMethod]
        public void ReturnBuzzWhenDivisibleByFive()
        {
            Assert.IsTrue(_fizzBuzz.GetFizzBuzz(_evaluations).Single(k => k.InputValue == 5).OutputValue == "Buzz");
        }

        [TestMethod]
        public void ReturnFizzAndBuzzWhenDivisibleByThreeAndFive()
        {
            Assert.IsTrue(_fizzBuzz.GetFizzBuzz(_evaluations).Single(k => k.InputValue == 15).OutputValue == "FizzBuzz");
        }

        [TestMethod]
        public void ReturnValueWhenNotDivisibleByThreeOrFive()
        {
            Assert.IsTrue(_fizzBuzz.GetFizzBuzz(_evaluations).Single(k => k.InputValue == 7).OutputValue == "7");
        }

        public static List<Tuple<int, string>> SeedEvaluations()
        {
            List<Tuple<int, string>> evaluations = new List<Tuple<int, string>>();
            evaluations.Add(3, "Fizz");
            evaluations.Add(5, "Buzz");
            evaluations.Add(2, "Foo");

            return evaluations;
        }
    }
}
