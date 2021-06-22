using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        public static void Main()
        {
            List<Employee> listofemployees = new List<Employee>() 
            { 
                new Employee() {Id = 1, Name = "Kritika", Salary = 50000, Experience = 5},
                new Employee() {Id = 2, Name = "Kriti", Salary = 90000, Experience = 7},
                new Employee() {Id = 3, Name = "Roy", Salary = 70000, Experience = 8},
                new Employee() {Id = 4, Name = "Karan", Salary = 60000, Experience = 4},
            };
            IsPromotable isPromotable = new IsPromotable(Promotion);
            Employee.PromoteEmployee(listofemployees,isPromotable);

             bool Promotion(Employee employee)
            {
                if (employee.Experience >= 5) return true;
                else return false;
            }
        }
    }

    delegate bool IsPromotable(Employee employee);
    class Employee
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> listofemployees, IsPromotable IsEligibleToPromote)
        {
            foreach(var employee in listofemployees)
            {
                if(IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }

        }

      
    }



}

    
        

