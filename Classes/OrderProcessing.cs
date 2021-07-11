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
               
                Console.WriteLine("Connecting to tower");

            }

        }

        class FiveGMobilePhone : MobilePhone
        {
            public override void Call(string phonenumber)
            {
                base.Call(phonenumber);

                Console.WriteLine("Calling");

            }


        }

        class FourGMobilePhone : MobilePhone
        {
          

        }
        class Program
        {
            static void Main(string[] args)
            {
                FiveGMobilePhone five = new FiveGMobilePhone();
                five.Call("2311111111111");
            }
        }

    }


}

