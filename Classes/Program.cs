using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    
    public class Company
    {
        List<Employee> listofemployees;

        public Company()
        {
             listofemployees = new List<Employee>();
             listofemployees.Add(new Employee(){ Id = 1, Gender = "Female", Name = "Kritika"});
             listofemployees.Add(new Employee() { Id = 2, Gender = "Male", Name = "Raj" });
             listofemployees.Add(new Employee() { Id = 3, Gender = "Female", Name = "Kriti" });
             listofemployees.Add(new Employee() { Id = 4, Gender = "Male", Name = "Rahul" });
        }

        public string this[int id] //indexer
        {
            get { return listofemployees.FirstOrDefault(emp => emp.Id == id).Name;  }

            set { listofemployees.FirstOrDefault(emp => emp.Id == id).Name = value; }
        
        }

        public static void Main()
        {
            Company c = new Company();
            c[2] = "Neha";
            Console.WriteLine(c[3]);
        }



    }
}
