using NUnit.Framework;
using MoveMe;


namespace TestMoveMe
{
    public class TestRaceDriver
    {
        [Test]
        public void Eat_ForbiddenDuringRace_ThrowException()
        {
            //given
            RaceDriver raceDriver = new RaceDriver("MyDriverLicence");
            Car car = new Car();
            raceDriver.Car = car;
            raceDriver.StartEngine();

            //when
            Assert.Throws<EatForbiddenException>(delegate
            {
                raceDriver.Eat();
            });

            //then
            //Exception thrown
        }
    }
}