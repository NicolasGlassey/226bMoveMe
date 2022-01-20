using System;

namespace MoveMe
{
    public class Driver:Person
    {
        private string _licence;
        protected Car _car = null;

        public Driver (string licence)
        {
            _licence = licence;
        }

        public string Licence
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Car Car
        {
            set
            {
                //TODO avoid multiple cars attribution
                _car = value;
            }
            get
            {
                return _car;
            }
        }

        public override string Sleep()
        {
            if (_car.MotorState)
            {
                _car.MotorStop();
            }
            return base.Sleep();
        }

        public void StartEngine()
        {
            //TODO protect engine if already running
            _car.MotorStart();
        }

        private void StopEngine()
        {
            _car.MotorStop();
        }
    }
}
