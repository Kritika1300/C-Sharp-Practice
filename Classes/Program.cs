using System;
public class Employee
{
    public string firstName;
    public string lastName;
    public string email;

    public virtual void fullName()
    {
        Console.WriteLine($"Base class: {firstName} {lastName}");
    }
}
class FullTimeEmployee : Employee {
    public float YearlySalary;
    public override void fullName()
    {
        Console.WriteLine($"{firstName} Method overriding");
    }

}
class PartTimeEmployee : Employee {
    public float HourlySalary;
}
class Test
{
    public static void Main(string[] args)
    {
        Employee FTE = new FullTimeEmployee();
        FTE.firstName = "Kritika";
        FTE.lastName = "Kaur";
        FTE.email = "k@gmail.com";
        FTE.fullName();
    }
}