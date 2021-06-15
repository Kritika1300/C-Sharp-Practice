using System;

namespace Classes
{

    public interface ICustomer1
    {
        void Print1();
    }

    public interface ICustomer2: ICustomer1
    {
        void Print2();
    }
    public class Customer : ICustomer2
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
            ICustomer1 c1 = new Customer();
            ICustomer2 c2 = new Customer(); 
            c1.Print1(); // c1 is of type ICustomer1 so it has access to only Print1()
            c2.Print1(); c2.Print2(); // ICustomer2 is inheriting from interface ICustomer1 thus c2 which is of type ICustomer2 can access both Print1() and Print2()
            c.Print1();
            c.Print2();

        }
    }
    
}

