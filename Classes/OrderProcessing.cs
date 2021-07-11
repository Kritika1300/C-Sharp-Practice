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
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle c1 = new Vehicle("honda");
           
        }
    }

}

//class Car : Vehicle
//{
//    public string model;
//    public Car(string m) : base("tata")  // explicit call to the base constructor is reqd if its not parameterless otherwise => compilation error.
//    {

//        model = m;

//    }


//}