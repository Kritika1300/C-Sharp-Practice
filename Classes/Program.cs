using System;

namespace Classes
{
    class Customer
    {
        private Customer()
        {

        }
        public static string fname;
        public static string lname;

        public static void FullName()
        {
            Console.WriteLine(fname + " " + lname);
        }

    }
    
    class Program
    {
        public static void Main()
        {

            //Customer c = new Customer(); //compile time error

            Customer.fname = "Kritika";
            Customer.lname = "Kaur";
            Customer.FullName();



        }
    }


}