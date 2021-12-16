using System;

namespace MoveMe
{
    public class Vehicle : IVehicle
    {

        private bool _motorState = false;

        public void MotorStart()
        {
            throw new System.NotImplementedException();
        }

        public void MotorStop()
        {
            throw new System.NotImplementedException();
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
