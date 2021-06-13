using System;
using System.Collections.Generic;

namespace Classes
{
    class Customer {

        public string name;
        public int id;
        public readonly List<Orders> list = new List<Orders>();

        public Customer(int id)
        {
            this.id = id;
        }

        public Customer(int id,string name) : this(id)
        {
            this.name = name;
        }

        public void Promote()
        {
            list = new List<Orders>(); // this will give an error as we are trying to assign something to a READONLY FIELD
        }

        public static void Main()
        {
            Customer c = new Customer(1);
            c.list.Add(new Orders());
            c.list.Add(new Orders());
            c.list.Add(new Orders());
            c.list.Add(new Orders());
            c.Promote();
            Console.WriteLine(c.list.Count);


        }



    }
}
