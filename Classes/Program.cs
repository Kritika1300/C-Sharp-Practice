using System;

namespace Classes
{

    public interface ICustomer1
    {
        void Print1();
    }

    public interface ICustomer2
    {
        void Print2();
    }
    public class Customer : ICustomer1,ICustomer2
    {
        public void Print1()
        {
            Console.WriteLine("Print1");
        }

        public void Print2()
        {
            Console.WriteLine("Print2");
        }
    }

    class Program
    {
        public static void Main()
        {
            Customer c = new Customer();
            c.Print1();
            c.Print2();

        }
    }
    
}

