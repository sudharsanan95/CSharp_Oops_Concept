using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Polymorphism
{
    public class Mother : Father // hierarical inheritance
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("i am a mother");
        }
    }
}
