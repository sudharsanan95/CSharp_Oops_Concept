using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Abstraction
{
    public abstract class Father

    // abstract class denotes by "abstarct" keyword , Its a restricted class and we can't create object for this class
    // in abstract class, both abstract and non-abstract methods will come
    // abstract method -- without body
    // have to inherit the abstract class from another class then we should give implementation with "override" keyword
    {
        public abstract void name();
        public void Age()
        {
            Console.WriteLine("27");
        }
        public abstract void Degree();
        public abstract void ContNo();
        public abstract void Address();

    }
}
