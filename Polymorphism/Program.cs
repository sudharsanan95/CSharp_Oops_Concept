using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Polymorphism
{
    public class Program
    {
        // Polymorphism - occuring in more than one form is known as polymorphism
        // Method overloading / compile time polymorphism
        // Method Overwriding / Run time polymorphism

        public static void Main(string[] args)
        {
            //  Method overloading / compile time polymorphism

            Class1 obj = new Class1();
            obj.MethodOverloading();
            obj.MethodOverloading(27);
            obj.MethodOverloading(2, 5);
            obj.MethodOverloading("sudharsanan", 27);
            obj.MethodOverloading(27, "sudharsanan");

            // Method overwrding  // keywords -- virtual, override, base.

            Father obj1 = new Son(); // (Father - reference class/base class, Son - object created class)
                                     // hierarical inheritance
            
            obj1.Display();

            Father obj2 = new Mother(); // hierarical inheritance
            obj2.Display();

            // sealed public virtual void Display() (if we do not want to override class or method we should use sealed keyword)

        }
    }
}
