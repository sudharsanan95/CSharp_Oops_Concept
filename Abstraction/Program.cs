using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Abstraction
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Abstract 
            Son obj = new Son();
            obj.name();
            obj.Age();
            obj.Degree();
            obj.ContNo();
            obj.Address();

            // interface

           Object3 obj3 = new Object3();
            obj3.Menu();

        }
    }
}
