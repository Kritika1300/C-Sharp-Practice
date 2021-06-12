using System.Collections.Generic;

namespace Classes
{
    class Customer
    {
        public string name;
        public int id;
        public List<Order> list;

        public Customer()
        {

        }

        public Customer(int id)
        {
            this.id = id;
        }

        public Customer(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}
