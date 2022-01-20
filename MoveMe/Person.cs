using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMe
{
    public class Person : IPerson
    {
        public virtual void Eat(){ }

        public void Drink() { }

        public void Sleep() { }

    }
}
