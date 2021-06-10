using System;

namespace Classes
{
    class Employee
    {
        public static  string firstName;
        public static string lastName;

        public void FullName() //instance method
        {
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
            Employee.firstName = "Kritika";
            Employee.lastName = "Kaur";
            emp1.FullName();
            Employee.Greeting();

        }
    }
}