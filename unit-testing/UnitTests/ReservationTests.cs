using System;
using UnitTesting;
using Xunit;

namespace UnitTests
{
    public class ReservationTests
    {
        [Fact]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();
            var user = new User{IsAdmin = true};

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CanBeCancelledBy_MadeByAUser_ReturnsTrue()
        {
            // Arrange
            var user = new User { IsAdmin = false };
            var reservation = new Reservation{MadeBy = user};

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CanBeCancelledBy_NotMadeByAUserAndNotAdmin_ReturnsFalse()
        {
            // Arrange
            var user = new User { IsAdmin = false };
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.False(result);
        }
    }
}
