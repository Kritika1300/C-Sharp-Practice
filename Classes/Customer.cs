using System;
using System.Collections.Generic;

namespace Classes
{
    class Customer {

        //auto-implemented property
        public DateTime Birthdate { get; private set; }

        public Customer(DateTime birthdate)
        {
            Birthdate = birthdate;

        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
        public static void Main()
        {
            Customer c = new Customer(new DateTime(2000,1,11));
            Console.WriteLine(c.Age);
        }



    }
}
