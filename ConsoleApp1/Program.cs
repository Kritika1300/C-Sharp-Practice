using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    
    class HelloWorld
    {
        static void Main()
        {
            PartialCustomer p = new PartialCustomer();
            p.FirstName = "Kritika";
            p.LastName = "Kaur";
            p.FullName();

            Customer c = new Customer();
            c.FirstName = "Kritika";
            c.LastName = "Kaur";
            c.FullName();
        }
    }


}