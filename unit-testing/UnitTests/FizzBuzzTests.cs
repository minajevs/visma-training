using System;
using System.Collections.Generic;
using System.Text;
using UnitTesting;
using Xunit;

namespace UnitTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void GetOutput_DivisableBy3And5_ReturnsFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void GetOutput_DivisableOnlyBy3_ReturnsFizz()
        {
            var result = FizzBuzz.GetOutput(6);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void GetOutput_DivisableOnlyBy5_ReturnsBuzz()
        {
            var result = FizzBuzz.GetOutput(10);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void GetOutput_NotDivisableBy3And5_ReturnsNumber()
        {
            var result = FizzBuzz.GetOutput(7);

            Assert.Equal("7", result);
        }
    }
}
