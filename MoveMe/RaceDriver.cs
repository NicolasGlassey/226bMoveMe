using System;

namespace MoveMe
{
    public class RaceDriver : Driver
    {
        public RaceDriver(string licence):base(licence){}

        public override string Eat() 
        {
            throw new NotImplementedException();
        } 
    }
}

public class RaceDriverException : Exception{ }

public class EatForbiddenException : RaceDriverException { }
