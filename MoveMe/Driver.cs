using System;

namespace MoveMe
{
    public class Driver:Person
    {
        private string _licence;
        private Car _car = null;
        private bool _drive = false;
        private bool _engine = false;

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
                //TODO avoid 
                throw new NotImplementedException();
            }
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Engine
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Sleep()
        {
            throw new NotImplementedException();
        }

        public void StartEngine()
        {
            //TODO protect engine if already running
        }

        private void StopEngine()
        {
            //TODO protect engine if already running
        }
    }
}
