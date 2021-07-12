using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Classes
{


    class Customer 
    { 
        public int Age { get; set; }

        public string Name { get; set; }


        public override string ToString() //overriding the ToString Method to return a meaningful string.
        {
            return $"{Name} {Age}";
        }

    }

    class Program
        {
            static void Main(string[] args)
            {
                int i = 3;
                Console.WriteLine(i.ToString());

                Customer c = new Customer();
                c.Name = "Kritika";
                c.Age = 21;
                Console.WriteLine(c.ToString());
           
            }

           


       }

    


}

