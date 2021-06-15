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
        public void InterfaceMethod()
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
            c.InterfaceMethod();

        }
    }
    
}

