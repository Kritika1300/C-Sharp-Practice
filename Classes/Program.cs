using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace Classes
{
    class Program
    {

        static void Main(string[] args)
        {
            Customer c1 = new Customer()
            {
                ID = 1,
                Name = "Kritika",
                Salary = 55000
            };

            Customer c2 = new Customer()
            {
                ID = 2,
                Name = "Kriti",
                Salary = 35000
            };

            Customer c3 = new Customer()
            {
                ID = 3,
                Name = "Ritika",
                Salary = 45000
            };

            Customer[] customerArray = new Customer[3];
            customerArray[0] = c1;
            customerArray[1] = c2;
            customerArray[2] = c3;

            Dictionary<int,Customer> dict = customerArray.ToDictionary(customerArray => customerArray.ID, customerArray => customerArray);

            foreach(var d in dict)
            {
                Console.WriteLine(d.Value.ID + " " + d.Value.Name);
            }

        }
    }

    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
    }


}
