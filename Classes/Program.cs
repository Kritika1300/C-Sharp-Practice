using System;
public class Employee
{
    public string firstName;
    public string lastName;
    public string email;

    public Employee()
    {
        Console.WriteLine("Base class constructor"); 
    }
    public Employee(string message)
    {
        Console.WriteLine(message);
    }
}
class FullTimeEmployee : Employee {
   
    public FullTimeEmployee() : base("Derived class constructor controlling base class constructor")
    {
        Console.WriteLine("Child class constructor");
    }

}

class Test
{
    public static void Main(string[] args)
    {
        Employee FTE = new FullTimeEmployee();
        FTE.firstName = "Kritika";
        FTE.lastName = "Kaur";
        FTE.email = "k@gmail.com";
    }
}