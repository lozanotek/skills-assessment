using System;
using System.Collections.Generic;
using Bogus;
using FizzLib.Services;
using FizzLib.Wrappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FizzLib.Tests.Services
{
    [TestClass]
    public class FizzBuzzTest
    {
        private IFizzBuzz _fizzBuzz;
        private Mock<IConsoleWrapper> _consoleMock;
        private Randomizer _random;
        [TestInitialize]
        public void BeforeEach()
        {
            _random = new Randomizer();

            _consoleMock = new Mock<IConsoleWrapper>();

            _fizzBuzz = new FizzBuzz(_consoleMock.Object);
        }

        [TestClass]
        public class GetFizzBuzzTest : FizzBuzzTest
        {
            [TestMethod]
            public void ShouldWriteMinAndMaxValuesToConsole()
            {
                var expectedMin = _random.Number(100);
                var expectedMax = expectedMin + _random.Number(100);

                _fizzBuzz.GetFizzBuzz(expectedMin, expectedMax);

                _consoleMock.Verify(con => con.WriteLine($"min: {expectedMin}, max: {expectedMax}"));
            }

            [TestMethod]
            public void ShouldWriteToConsoleForEveryNumberInRangeInclusivePlusOneForRangeValues()
            {
                var expectedMin = _random.Number(1, 100);
                var expectedMax = expectedMin + _random.Number(1, 100);
                var expectedCallCount = expectedMax - expectedMin + 2;

                _fizzBuzz.GetFizzBuzz(expectedMin, expectedMax);

                _consoleMock.Verify(con => con.WriteLine(It.IsAny<object>()), Times.Exactly(expectedCallCount));
            }

            [TestMethod]
            public void ShouldWriteFizzWhenNumberIsDivisibleByThree()
            {
                var expectedNumber = _random.Number(1, 10) * 3;

                _fizzBuzz.GetFizzBuzz(expectedNumber, expectedNumber);

                _consoleMock.Verify(con => con.WriteLine(It.Is<string>(value => value.Contains("Fizz"))));
            }

            [TestMethod]
            public void ShouldWriteBuzzWhenNumberIsDivisibleByFive()
            {
                var expectedNumber = _random.Number(1, 10) * 5;

                _fizzBuzz.GetFizzBuzz(expectedNumber, expectedNumber);

                _consoleMock.Verify(con => con.WriteLine(It.Is<string>(value => value.Contains("Buzz"))));
            }

            [TestMethod]
            public void ShouldWriteFizzBuzzWhenNumberIsDivisibleByThreeAndFive()
            {
                var expectedNumber = _random.Number(1, 10) * 3 * 5;

                _fizzBuzz.GetFizzBuzz(expectedNumber, expectedNumber);

                _consoleMock.Verify(con => con.WriteLine("FizzBuzz"));
            }

            [TestMethod]
            public void ShouldWriteValueForAnyCustomRulesPassedIn()
            {
                var expectedKey1 = _random.Number(1, 10);
                var expectedKey2 = expectedKey1 + _random.Number(1, 10);
                var expectedMinMax = expectedKey1 * expectedKey2;
                var expectedRules = new Dictionary<int, string>
                {
                    [expectedKey1] = _random.String2(_random.Number(1, 10)),
                    [expectedKey2] = _random.String2(_random.Number(1, 10))
                };

                _fizzBuzz.GetFizzBuzz(expectedMinMax, expectedMinMax, expectedRules);

                _consoleMock.Verify(con => con.WriteLine(It.Is<string>(value => value.Contains(expectedRules[expectedKey1] + expectedRules[expectedKey2]))));
            }

            [TestMethod]
            public void ShouldNotTryToDivideByZeroIfCustomRuleIsPassedInWithZeroAsKey()
            {
                var expectedRules = new Dictionary<int, string>
                {
                    [0] = _random.String(_random.Number(1, 10))
                };

                _fizzBuzz.GetFizzBuzz(additionalRules: expectedRules);
            }

            [TestMethod]
            public void ShouldReturnAfterMaxIntegerValueIsFizzBuzzed()
            {
                _fizzBuzz.GetFizzBuzz(int.MaxValue, int.MaxValue);

                _consoleMock.Verify(con => con.WriteLine(It.IsAny<object>()), Times.Exactly(2));
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void ShouldThrowArgumentExceptionWhenMinExceedsMax()
            {
                var expectedMin = _random.Number(100);

                _fizzBuzz.GetFizzBuzz(expectedMin, expectedMin - 1);
            }
        }
    }
}
