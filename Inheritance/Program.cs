using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPSConcept.Inheritance;

namespace OOPSConcept
{
    public class Program
    // one class acquies all properties and behaviour of its parent/base class is known as inheritance
    // it is used for code reusability
    {
        public static void Main(string[] args)
        {
            Class1 ex = new Class1();

            // single inheritance (one class inherits another class) 
            ex.Name(); // class1: class 2
            ex.ContactNo();

           // multi level inheritance(from a class to b class then b class to c class)
            ex.Address(); 

            // multiple inheritance is not possible in C# (1 sub class inherits 2 base class) C:A,B

            // hierachical in heritance. (2 sub class inherits one base class)  C:A & B:A

            Object6 obj = new Object6();
            obj.Child(); // hierachical in heritance.

            // hybrid Inheritance
          
        }
    }
}
