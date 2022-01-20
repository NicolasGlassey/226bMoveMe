using System;

namespace MoveMe
{
    public class Vehicle : IVehicle
    {

        private bool _motorState = false;

        public void MotorStart()
        {
            _motorState = true;
        }

        public void MotorStop()
        {
            _motorState = false;
        }

        public bool MotorState
        {
            get
            {
                return _motorState;
            }
        }
    }

    public class VehicleException : Exception { }

    public class MotorStartException : VehicleException { };
}
