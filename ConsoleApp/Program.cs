using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    class Vehicle
    {
        //common functionality
    }

    //class Car : Vehicle
    //{
    //    public override void StartEngine()
    //    {
    //        Console.WriteLine("starting...");
    //    }
    //}

    //class Cycle : Vehicle 
    //{
    //    public override void StartEngine()
    //    {
    //        throw new Exception("Engine not found");
    //    }

    //}

    class VehicleWithEngine : Vehicle {
        public virtual void StartEngine()
        {
            Console.WriteLine("Engine starting...");
        }
    }

    class VehicleWithoutEngine : Vehicle { }

    class Car : VehicleWithEngine { }

    class Cycle : VehicleWithoutEngine { }

    class HelloWorld
    {
        public static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Car());
            vehicles.Add(new Cycle());

            foreach(var vehicle in vehicles)
            {
                vehicle.StartEngine();
            }
        }

    }

}







