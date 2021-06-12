using System;

namespace Classes {
    class Program
    {

        public static void Main(string[] args)
        {
            Customer c = new Customer();
            Order o = new Order();
            c.list.Add(o);
            Console.WriteLine(c.id);
            Console.WriteLine(c.name);

        }
    }

}

