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
        class MobilePhone
        {
            public string BrandName = "Nokia";

            public string ModelName = "Asha";

            public virtual void Call(string phonenumber)
            {
               
                Console.WriteLine("Calling... " + phonenumber);

            }

        }

        class FiveGMobilePhone : MobilePhone
        {
            public override void Call(string phonenumber)
            {

                Console.WriteLine("Calling via 5G... " + phonenumber);

            }

        }

        class FourGMobilePhone : MobilePhone
        {
            public override void Call(string phonenumber)
            {

                Console.WriteLine("Calling via 4G... " + phonenumber);

            }

        }

        class Program
        {
            static void Main(string[] args)
            {
                FiveGMobilePhone five = new FiveGMobilePhone();
                FourGMobilePhone four = new FourGMobilePhone();
                MobilePhone m = new MobilePhone();

                five.Call("43322222222222");
                four.Call("42111111111111");
                m.Call("23444444444");

            }
        }

    }


}

