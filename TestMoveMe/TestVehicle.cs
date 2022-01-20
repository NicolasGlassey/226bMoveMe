using NUnit.Framework;
using MoveMe;


namespace TestMoveMe
{
    public class TestVehicle
    {
        [Test]
        public void MotorStart_NominalCase_Success()
        {
            //given
            Vehicle vehicle = new Vehicle();

            //when
            vehicle.MotorStart();

            //then
            Assert.IsTrue(vehicle.MotorState);
        }

        [Test]
        public void MotorStop_NominalCase_Success()
        {
            //given
            Vehicle vehicle = new Vehicle();
            vehicle.MotorStart();

            //when
            Assert.Throws<MotorStartException>(delegate
            {
                vehicle.MotorStart();
            });

            //then
            //Exception thrown
        }
    }
}