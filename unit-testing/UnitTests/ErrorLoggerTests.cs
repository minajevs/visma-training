using System;
using System.Collections.Generic;
using System.Text;
using UnitTesting;
using Xunit;

namespace UnitTests
{
    public class ErrorLoggerTests
    {
        [Fact]
        public void Log_IsCalledWithErrorString_SetTheLastErrorProperty()
        {
            // Arrange
            var errorLogger = new ErrorLogger();

            // Act
            errorLogger.Log("test-error");

            // Assert
            Assert.Equal("test-error", errorLogger.LastError);
        }

        [Fact]
        public void Log_IsCalledWithEmptyString_ThrowsAnNullArguementException()
        {
            var errorLogger = new ErrorLogger();

            Assert.Throws<ArgumentNullException>(() => errorLogger.Log(""));
        }
    }
}
