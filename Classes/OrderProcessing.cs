using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Classes
{
    class Vehicle
    {
        public string BrandName;

        public Vehicle(string bname)
        {
            BrandName = bname;
        }


    }

    class Car : Vehicle
    {
        public string model;
        public Car(string m) : base("tata")  // explicit call to the base constructor is reqd if its not parameterless otherwise => compilation error.
        {
           
            model = m;

        }
        
        
    }


    class Program
    {
        static void Main(string[] args)
        {

            Car c1 = new Car("ge");
           
            Console.WriteLine(c1.model + " " + c1.BrandName);
        }
    }

}