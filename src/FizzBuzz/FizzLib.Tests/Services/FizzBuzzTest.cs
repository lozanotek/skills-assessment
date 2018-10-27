using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using FizzLib.Models;
using FizzLib.Services;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzLib.Tests.Services
{
    [TestClass]
    public class FizzBuzzTest
    {
        private IFizzBuzz _fizzBuzz;
        private Randomizer _random;

        [TestInitialize]
        public void BeforeEach()
        {
            _random = new Randomizer();

            _fizzBuzz = new FizzBuzz();
        }

        [TestClass]
        public class GetFizzBuzzTest : FizzBuzzTest
        {
            [TestMethod]
            public void ShouldReturnOutputForEveryNumberInRangeInclusive()
            {
                var expectedMin = _random.Number(1, 100);
                var expectedMax = expectedMin + _random.Number(1, 100);
                var expectedCount = expectedMax - expectedMin + 1;

                var actualCount = _fizzBuzz.GetFizzBuzz(expectedMin, expectedMax).Count();

                actualCount.Should().Be(expectedCount);
            }

            [TestMethod]
            public void ShouldReturnFizzWhenNumberIsDivisibleByThree()
            {
                var expectedNumber = _random.Number(1, 10) * 3;

                var actualOutput = _fizzBuzz.GetFizzBuzz(expectedNumber, expectedNumber).First();

                actualOutput.Should().Contain("Fizz");
            }

            [TestMethod]
            public void ShouldReturnBuzzWhenNumberIsDivisibleByFive()
            {
                var expectedNumber = _random.Number(1, 10) * 5;

                var actualOutput = _fizzBuzz.GetFizzBuzz(expectedNumber, expectedNumber).First();

                actualOutput.Should().Contain("Buzz");
            }

            [TestMethod]
            public void ShouldReturnFizzBuzzWhenNumberIsDivisibleByThreeAndFive()
            {
                var expectedNumber = _random.Number(1, 10) * 3 * 5;

                var actualOutput = _fizzBuzz.GetFizzBuzz(expectedNumber, expectedNumber).First();

                actualOutput.Should().Be("FizzBuzz");
            }

            [TestMethod]
            public void ShouldReturnIntegerValueWhenNumberIsNotDivisibleByAnyKey()
            {
                var expectedNumber = (_random.Number(1, 10) * 3 * 5) + 1;

                var actualOutput = _fizzBuzz.GetFizzBuzz(expectedNumber, expectedNumber).First();

                actualOutput.Should().Be(expectedNumber.ToString());
            }

            [TestMethod]
            public void ShouldReturnValueForAnyCustomRulesPassedIn()
            {
                var expectedReplacement1 = new DivisorReplacement
                {
                    Divisor = _random.Number(1, 10),
                    ReplaceWith = _random.String2(_random.Number(1, 10))
                };
                var expectedReplacement2 = new DivisorReplacement
                {
                    Divisor = expectedReplacement1.Divisor + 1,
                    ReplaceWith = _random.String2(_random.Number(1, 10))
                };
                var expectedMinMax = expectedReplacement1.Divisor * expectedReplacement2.Divisor;
                var expectedReplacements = new List<DivisorReplacement> { expectedReplacement1, expectedReplacement2 };

                var actualOutput = _fizzBuzz.GetFizzBuzz(expectedMinMax, expectedMinMax, expectedReplacements).First();

                actualOutput.Should().Contain(expectedReplacement1.ReplaceWith + expectedReplacement2.ReplaceWith);
            }

            [TestMethod]
            public void ShouldNotTryToDivideByZeroIfCustomRuleIsPassedInWithZeroAsKey()
            {
                var expectedReplacements = new List<DivisorReplacement>
                {
                    new DivisorReplacement {Divisor = 0 , ReplaceWith = _random.String(_random.Number(1, 10))}
                };

                _fizzBuzz.GetFizzBuzz(replacements: expectedReplacements);
            }

            [TestMethod]
            public void ShouldReturnAfterMaxIntegerValueIsFizzBuzzed()
            {
                var actualCount = _fizzBuzz.GetFizzBuzz(int.MaxValue, int.MaxValue).Count();

                actualCount.Should().Be(1);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void ShouldThrowArgumentExceptionWhenMinExceedsMax()
            {
                var expectedMin = _random.Number(100);

                _fizzBuzz.GetFizzBuzz(expectedMin, expectedMin - 1).ToList();
            }
        }
    }
}
