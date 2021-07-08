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

            List<Customer> customerList = new List<Customer>();
            customerList.Add(c1);
            customerList.Add(c2);
            customerList.Add(c3);
            customerList.Add(c2);
            customerList.Insert(0, new Customer() { ID = 4, Name = "Kiitu", Salary = 5000 });
            Console.WriteLine(customerList.IndexOf(c2)); // returns first occurance of c2
            Console.WriteLine(customerList.IndexOf(c2,3)); // starts searching for c2 from index 3 and thus returns 4
            Console.WriteLine(customerList.IndexOf(c2, 0,1)); // starts searching for c2 from index 0 to index 1 
            // contains,find,findall,findlastindex,exists,..

            Customer[] arr = customerList.ToArray(); //list to array
            foreach(var i in arr)
            {
                Console.WriteLine(i.Name);
            }
            foreach (var d in customerList)
            {
                Console.WriteLine(d.ID + " " + d.Name);
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
