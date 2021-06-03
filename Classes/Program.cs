using System;
namespace Classes
{
  
    public enum ShippingMethod { 
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId);

            var methodName = "RegularAirMail";
            var str = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(str);
        }
    }
}
