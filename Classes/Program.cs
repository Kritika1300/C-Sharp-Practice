using System;

namespace Classes
{
    class Employee
    {
        public  string firstName;
        public string lastName;

        public Employee(string fname, string lname)
        {
            firstName = fname;
            lastName = lname;
        }
        public void FullName() //instance method
        {
        
            Console.WriteLine(firstName + " " + lastName);

        }


    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Kritika","Kaur");
            emp1.FullName();

        }
    }
}