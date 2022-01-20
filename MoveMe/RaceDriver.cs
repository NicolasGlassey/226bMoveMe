using System;

namespace MoveMe
{
    public class RaceDriver : Driver
    {
        public RaceDriver(string licence):base(licence){}

        public override string Eat() 
        {
            if (!_car.MotorState)
            {
                return base.Eat();
            }
            throw new EatForbiddenException();
        } 
    }
}

public class RaceDriverException : Exception{ }

public class EatForbiddenException : RaceDriverException { }
