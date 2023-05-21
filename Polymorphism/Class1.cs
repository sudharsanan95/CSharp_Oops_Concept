using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Polymorphism
{
    public class Class1
    {
        public void MethodOverloading()
        {
            Console.WriteLine(" I am MethodOverloading");
        }
        public void MethodOverloading(int age) // change in no.of.parameters
        {
            Console.WriteLine(" I am MethodOverloading with change in parameter / my age is " + age);
        }
        public void MethodOverloading(int a, int b) // // change in no.of.parameters
        {
            Console.WriteLine(" I am MethodOverloading with change in parameter / a is " + a+" b is "+b);
        }
        public void MethodOverloading(string a, int b) // // change in datatypes
        {
            Console.WriteLine(" I am MethodOverloading with change in datatype / name is " + a + " age is " + b);
        }
        public void MethodOverloading(int b, string a) // // change in no.of.orders
        {
            Console.WriteLine(" I am MethodOverloading with change in order / age is " + b + " name is " + a);
        }

    }
}

