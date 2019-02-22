using System;
using System.Collections.Generic;
using System.Text;
using UnitTesting;
using Xunit;

namespace UnitTests
{
    public class DateHelperTests
    {
        [Fact]
        public void FirstOfNextMonth_CalledForDecember_ReturnsNextYearNextMonthCorrectDay()
        {
            var date = new DateTime(2019, 12, 24);

            var result = DateHelper.FirstOfNextMonth(date);

            Assert.Equal(2020, result.Year);
            Assert.Equal(1, result.Month);
            Assert.Equal(1, result.Day);
        }

        [Fact]
        public void FirstOfNextMonth_CalledForNormalMonths_ReturnsNextMonthCorrectDay()
        {
            var date = new DateTime(2019, 02, 24);

            var result = DateHelper.FirstOfNextMonth(date);

            Assert.Equal(2019, result.Year);
            Assert.Equal(3, result.Month);
            Assert.Equal(1, result.Day);
        }
    }
}
