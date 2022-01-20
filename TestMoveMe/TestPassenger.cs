using NUnit.Framework;
using MoveMe;


namespace TestMoveMe
{
    public class TestPassenger
    {
        [Test]
        public void LookLandscap_NominalCase_Success()
        {
            //given
            string expectedMessage = "Je profite du paysage";
            string actualMessage = "";
            Passenger passenger = new Passenger();

            //when
            actualMessage = passenger.LookLandscap();

            //then
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}