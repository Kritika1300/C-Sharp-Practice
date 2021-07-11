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

    class ElectricCar : Car 
    {
        public int mileage = 400;

        public void recharge()
        {
            Console.WriteLine("Recharging...");
        }

    }

    class FuelCar : Car
    {
        public int mileage = 300;
        public void refuel()
        {
            Console.WriteLine("Refuelling...");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            FuelCar c = new FuelCar();
            Console.WriteLine(c.BrandName +" "+ c.NoOfWheels());

            ElectricCar e = new ElectricCar();
            


        }
    }

}