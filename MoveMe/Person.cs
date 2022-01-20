using System;

namespace MoveMe
{
    public class Person : IPerson
    {
        public virtual string Eat()
        {
            return "Je mange";
        }

        public string Drink() 
        {
            return "Je bois";
        }

        public virtual string Sleep() 
        {
            return "Je dors";
        }
    }
}
