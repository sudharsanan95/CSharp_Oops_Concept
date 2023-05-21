using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Abstraction
{
    public class Son : Father
    {
        public override void name()
        {
            Console.WriteLine("sudharsanan");
        }
        public override void Degree()
        {
            Console.WriteLine("B.E in Mech and Prod");
        }
        public override void ContNo()
        {
            Console.WriteLine("7299565763");
        }
        public override void Address()
        {
            Console.WriteLine("velachery, chennai");
        }
    }
}
