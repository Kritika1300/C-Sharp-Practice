using System;

namespace Classes
{
    class Employee
    {
        public static  string firstName;
        public static string lastName;

        static Employee()
        {
            firstName = "Kritika";
            lastName = "Kaur";
        }
        public void FullName() //instance method
        {
            Greeting();
            Console.WriteLine(firstName + " " + lastName);

        }

        public static void Greeting()
        {
            Console.WriteLine($"Hey {firstName} {lastName}");
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.FullName();
            Employee.Greeting();

        }
    }
}