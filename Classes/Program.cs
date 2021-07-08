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
                Name = "Arti",
                Salary = 35000
            };

            Customer c3 = new Customer()
            {
                ID = 3,
                Name = "Ritika",
                Salary = 45000
            };

            List<Customer> customerList = new List<Customer>();
            customerList.Add(c1);
            customerList.Add(c2);
            customerList.Add(c3);
            

            foreach (var d in customerList)
            {
                Console.WriteLine(d.ID + " " + d.Name + " "+  d.Salary);
            }

            customerList.Sort();
            customerList.Reverse();

            foreach (var d in customerList)
            {
                Console.WriteLine( d.Salary);
            }

        }
    }

    class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }

        public int CompareTo(Customer other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }


}
