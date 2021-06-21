using System;
using System.Collections.Generic;

namespace Classes
{
    class Manager
    {

        private string name;
        public Manager(string name)
        {
            this.name = name;
        }
    }
    
    class Program
    {
        public static void Main()
        {
            Manager m = new Manager("Kritika");
            Console.WriteLine(value: m.name);

         
        }
    }


}