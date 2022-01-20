using System;

namespace MoveMe
{
    public class Person : IPerson
    {
        public virtual string Eat()
        {
            throw new NotImplementedException();
        }

        public string Drink() 
        {
            throw new NotImplementedException();
        }

        public string Sleep() 
        {
            throw new NotImplementedException();
        }

    }
}
