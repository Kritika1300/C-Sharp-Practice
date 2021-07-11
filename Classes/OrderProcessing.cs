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

           
            protected Vehicle(string bname, string mname)
            {
                BrandName = bname;
                ModelName = mname;

                Console.WriteLine(BrandName + ":" + ModelName);

            }

        }

        class Truck 
        {

            private string _month;
            public int year;
            public Truck(string month,int year)
            {
                this._month = month;
                this.year = year;
            }

            public Truck(Truck t)
            {
                this._month = t._month;
                this.year = t.year;
            }
            

        }

        class Program
        {
            static void Main(string[] args)
            {

                Truck t = new Truck("May", 2020);
                Truck t1 = new Truck(t);




            }
        }

    }


}

