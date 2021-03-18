using System;
using NUnit.Framework;

namespace Unit.Test
{
    [TestFixture]
    class ReservationTest
    {
        [Test]
        public void CanBeCancelledBy_UserISAdmin_ReturnTrue()
        {
            //Arrange
            var reservation = new Unit_Tests.Reservation();

            //Act
            var result=reservation.CanBeCancelledBy(new Unit_Tests.User { IsAdmin=true });

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanCancelledBy_SameUserCancellingReservation_ReturnTrue()
        {
            var user = new Unit_Tests.User();
            var reservation = new Unit_Tests.Reservation();

            var result=reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUser_ReturnFalse()
        {
            var user = new Unit_Tests.User();
            var reservation = new Unit_Tests.Reservation();

            var result=reservation.CanBeCancelledBy(user);

            Assert.IsFalse(result);
        }
        
    }
}
   


