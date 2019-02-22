using System;
using System.Collections.Generic;
using System.Text;
using UnitTesting;
using Xunit;

namespace UnitTests
{
    public class DemeritPointsCalculatorTests
    {
        [Fact]
        public void CalculateDemeritPoints_BelowZeroSpeed_ThrowException()
        {
            var calc = new DemeritPointsCalculator();

            Assert.Throws<ArgumentOutOfRangeException>(() => calc.CalculateDemeritPoints(-10));
        }

        [Fact]
        public void CalculateDemeritPoints_Above300Speed_ThrowException()
        {
            var calc = new DemeritPointsCalculator();

            Assert.Throws<ArgumentOutOfRangeException>(() => calc.CalculateDemeritPoints(301));
        }

        [Fact]
        public void CalculateDemeritPoints_SpeedLessThanALimit_Returns0()
        {
            var calc = new DemeritPointsCalculator();

            var result = calc.CalculateDemeritPoints(50);

            Assert.Equal(0, result);
        }

        [Fact]
        public void CalculateDemeritPoints_SpeedHigherThanALimit_ReturnsCalculatedAmount()
        {
            var calc = new DemeritPointsCalculator();

            var result = calc.CalculateDemeritPoints(85);

            // over speed limit: 20
            // points = 20/5 = 4
            Assert.Equal(4, result);
        }
    }
}
