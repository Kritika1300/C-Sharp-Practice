using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace Classes
{

    public enum Gender
    {
        Unknown,
        Female,
        Male
    }
    class Program
    {

        static void Main(string[] args)
        {
            Customer c1 = new Customer()
            {
                ID = 1,
                Name = "Kritika",
                Salary = 55000,
                Gender = Gender.Female

            };

            Customer c2 = new Customer()
            {
                ID = 25,
                Name = "Arif",
                Salary = 35000,
                Gender = Gender.Male
            };

            Customer c3 = new Customer()
            {
                ID = 13,
                Name = "Ritika",
                Salary = 45000,
                Gender = Gender.Unknown
            };

            Customer[] cust = new Customer[3]
            {
                c1,
                c2,
                c3
            };

            foreach (var customer in cust)
            {
                Console.WriteLine(GetGender(customer.Gender));
            }


            static string GetGender(Gender gender)
            {
                switch (gender)
                {
                    case Gender.Unknown: return "Unknown";
                    case Gender.Female: return "Female";
                    case Gender.Male: return "Male";
                    default: return "Invalid";
                }

            }

        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        public Gender Gender { get; set; }

    }


}
