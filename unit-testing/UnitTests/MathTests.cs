using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Math = UnitTesting.Math;

namespace UnitTests
{
    public class MathTests
    {
        [Fact]
        public void Add_CalledWithTwoNumber_ReturnsSumOfTwoNumbers()
        {
            // Arrange
            var math = new Math();

            // Act
            var result = math.Add(1, 2);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Max_FirstNumberGreaterThanSecond_ReturnFirst()
        {
            var math = new Math();

            var result = math.Max(2, 1);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Max_FirstNumberLessThanSecond_ReturnSecond()
        {
            var math = new Math();

            var result = math.Max(1, 2);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Max_FirstNumberEqualsSecond_ReturnSameValue()
        {
            var math = new Math();

            var result = math.Max(2, 2);

            Assert.Equal(2, result);
        }
    }
}
