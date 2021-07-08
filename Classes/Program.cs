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

            Dictionary<int, Customer> dictOfEmployees = new Dictionary<int, Customer>();
            dictOfEmployees.Add(c1.ID,c1);
            dictOfEmployees.Add(c2.ID, c2);
            dictOfEmployees.Add(c3.ID, c3);

            Console.WriteLine(dictOfEmployees.Count); //no. of items in dictionary
            
            Console.WriteLine(dictOfEmployees.Count(kvp => kvp.Value.Salary < 53500)); // Dictionary with LINQ

        }
    }

    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
    }


}
