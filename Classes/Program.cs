using System;
using System.Collections.Generic;

namespace Classes
{
    class Employee
    {
        private int _id;
        private string _name;
    
        public int ID
        {
            get; set;
        }
        public string Name { get; set; }


    }
    class Program
    {

        
        public static void Main()
        {
            List<Employee> listofemployees = new List<Employee>()
            {
                new Employee(){ID = 101, Name = "Kritika"},
                new Employee(){ID = 102, Name = "Kritz"},
                new Employee(){ID = 103, Name = "Kriti"},


            };
            Employee employee = listofemployees.Find(emp => emp.ID == 102);
            Console.WriteLine(employee.Name);

        }

        
        
        

      
    }
   
}




