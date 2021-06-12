using System;

namespace Classes
{
    class Customer
    {
        public string name;
        public int id;

        public static void Main()
        {
            Customer c = new Customer
            {
                name = "Kritika",
                id = 1
            };

            Console.WriteLine(c.id);
            Console.WriteLine(c.name);


        }
    }

}
