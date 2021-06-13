using System;
using System.Collections.Generic;

namespace Classes
{
    class Customer {

        //auto-implemented property
        public DateTime Birthdate { get; set; }
        public static void Main()
        {
            Customer c = new Customer();
            c.Birthdate = new DateTime(2021, 1, 11);
            Console.WriteLine(c.Birthdate);
        }



    }
}
