using System;
using System.Collections.Generic;
using System.Text;
using UnitTesting;
using Xunit;

namespace UnitTests
{
    public class PhoneNumberTests
    {
        [Fact]
        public void Parse_CalledEmptyString_ThrowsAnException()
        {
            Assert.Throws<ArgumentException>(() => PhoneNumber.Parse(""));
        }

        [Fact]
        public void Parse_CalledWithStringWhichIsNot10Long_ThrowsAnException()
        {
            Assert.Throws<ArgumentException>(() => PhoneNumber.Parse("123456"));
        }

        [Fact]
        public void Parse_CalledWithCorrectString_ParsesPropertiesCorrectly()
        {
            var phoneNumber = PhoneNumber.Parse("1112223333");

            Assert.Equal("111", phoneNumber.Area);
            Assert.Equal("222", phoneNumber.Major);
            Assert.Equal("3333", phoneNumber.Minor);
        }

        [Fact]
        public void ToString_CalledOnPhone_ReturnsFormattedString()
        {
            var phoneNumber = PhoneNumber.Parse("1112223333");

            var result = phoneNumber.ToString();

            Assert.Equal("(111)222-3333", result); // Probably too specific!
        }
    }
}
