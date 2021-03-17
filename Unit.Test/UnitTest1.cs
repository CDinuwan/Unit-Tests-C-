using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit.Test
{
    [TestClass]
    class Reservation
    {
        public string MadeBy { get; set; }
        public bool CanBeCancelledBy(string name)
        {
            if (name == "chanuka")
            {
                return true;
            }
            if (name == "dinuwan")
            {
                return true;
            }
            return false;
        }
        public class ReservationTest
    {
        public void CanBeCancelledBy_User_Return()
        {
            
        }
        //Arrange
        Reservation reservation = new Reservation();
            //Act

            //Assert
        }
    }
   
}
