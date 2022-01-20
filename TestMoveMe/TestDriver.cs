using NUnit.Framework;
using MoveMe;


namespace TestMoveMe
{
    public class TestDriver
    {
        [Test]
        public void Car_NominalCase_Success()
        {
            //given
            Car car = new Car();
            Driver driver = new Driver("MyLicenceNumber");

            //when
            driver.Car = car;

            //then
            Assert.IsNotNull(driver.Car);
        }

        [Test]
        public void StartEngine_NominalCase_Success()
        {
            //given
            Car car = new Car();
            Driver driver = new Driver("MyLicenceNumber");
            driver.Car = car;

            //when
            driver.StartEngine();

            //then
            Assert.IsTrue(car.MotorState);
        }

        [Test]
        public void Sleep_EngineStarted_Success()
        {
            //given
            Car car = new Car();
            Driver driver = new Driver("MyLicenceNumber");
            driver.Car = car;
            driver.StartEngine();

            string expectedMessage = "Je dors";
            string actualMessage = "";

            //when
            actualMessage = driver.Sleep();

            //then
            Assert.IsFalse(car.MotorState);
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}