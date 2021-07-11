using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Classes
{
    class Vehicle
    {
        public string BrandName = "Tata";

        public void Honk()
        {
            Console.WriteLine("Peep..peep !");
        }

    }

    class Car : Vehicle
    {
        public int NoOfWheels()
        {
            return 4;
        }

    }

    class Truck : Vehicle 
    {
        public int NoOfWheels()
        {
            return 10;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Console.WriteLine(c.BrandName +" "+ c.NoOfWheels());
           
            Truck t = new Truck();
            Console.WriteLine(t.BrandName + " " + t.NoOfWheels());


        }
    }

}