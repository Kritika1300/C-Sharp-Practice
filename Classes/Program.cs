using System;

namespace Classes
{

    public interface ICustomer1
    {
        void InterfaceMethod();
    }

    public interface ICustomer2
    {
        void InterfaceMethod();
    }
    public class Customer : ICustomer2, ICustomer1
    {
        void ICustomer1.InterfaceMethod()
        {
            Console.WriteLine("1");
        }

        void ICustomer2.InterfaceMethod()
        {
            Console.WriteLine("2");
        }

    }

    class Program
    {
        public static void Main()
        {
            Customer c = new Customer();
            //((ICustomer1)c).InterfaceMethod(); Explicitly implemented members are accessed using INTERFACE REF. VARIABLES

            //((ICustomer2)c).InterfaceMethod();

            // ------------OR------------------
            ICustomer1 i1 = new Customer();
            i1.InterfaceMethod();

            ICustomer2 i2 = new Customer();
            i2.InterfaceMethod();

        }
    }
    
}

