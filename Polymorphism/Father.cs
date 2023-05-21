using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Polymorphism
{
    public class Father
    {
        public virtual void Display()
        // sealed public virtual void Display() (if we do not want to override class or method we should use sealed keyword)
        {
            Console.WriteLine("i am a father");
        }
    }
}
