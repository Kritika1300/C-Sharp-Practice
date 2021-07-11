using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Classes
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    namespace Classes
    {
        class Vehicle
        {
            public string BrandName;

            public string ModelName;

           
            protected private Vehicle(string bname, string mname)
            {
                BrandName = bname;
                ModelName = mname;

                Console.WriteLine(BrandName + ":" + ModelName);

            }


        }

        class Car : Vehicle
        {

            public Car(string bname, string mname) : base(bname, mname)
            {

            }

        }

        class Program
        {
            static void Main(string[] args)
            {

               Car c1 = new Car("honda","psa");

            }
        }

    }


}

