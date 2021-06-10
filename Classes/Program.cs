﻿using System;
public class Employee
{
    public string firstName;
    public string lastName;
    public string email;

    public void fullName()
    {
        Console.WriteLine($"{firstName} {lastName}");
    }
}
class FullTimeEmployee : Employee {
    public float YearlySalary;
    public new void fullName()
    {
        Console.WriteLine($"{firstName} {YearlySalary} :- Method hiding");
    }

}
class PartTimeEmployee : Employee {
    public float HourlySalary;
}
class Test
{
    public static void Main(string[] args)
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.firstName = "Kritika";
        FTE.lastName = "Kaur";
        FTE.email = "k@gmail.com";
        FTE.YearlySalary = 45000.50f;
        FTE.fullName();
    }
}