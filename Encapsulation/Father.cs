using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Encapsulation
{
    internal class Father

        // Encapsulation - wrapping of datas into a sinle unit. Eg. Class
        // It is used to increase protcetion level.
        // we can increase protection level by Access modifiers and getter and setter
    {
        public void ATMP_Pin()
        {
            Property obj = new Property();
            obj.Password = 7598;
            Console.WriteLine("Hi, Received ATM pin");
            obj.CardNumber = 4980524643211696;
            Console.WriteLine("Card Number is: " + obj.CardNumber);
        }
        public static void Main(string[] args)
        {
             Father obj1 = new Father();
             obj1.ATMP_Pin();

        }
    }
}
