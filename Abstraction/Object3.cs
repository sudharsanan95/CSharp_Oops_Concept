using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Abstraction
{
    public class Object3 : Object1,Object2  // here we can achieve multiple inheritance
    {
        public void Menu()
        {
            Console.WriteLine("Idly and sambar");
        }
    }
}
