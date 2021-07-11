using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Classes
{
    class Vehicle
    {
        public string BrandName;

        public string ModelName;

        public Vehicle() : this("Tata","Nano")
        {
         
        }
        public Vehicle(string bname) : this(bname,"Nano")
        {
          
        }
        public Vehicle(string bname,string mname)
        {
            BrandName = bname;
            ModelName = mname;

            Console.WriteLine(BrandName + ":" + ModelName);
         
        }


    }

    class Car : Vehicle
    {
        public Car() : base()
        {

        }

        public Car(string bname) : base(bname)
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Car c1 = new Car("honda");
           
        }
    }

}

