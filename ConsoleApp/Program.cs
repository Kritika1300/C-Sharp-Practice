using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO; 

namespace ConsoleApp1
{


    class Test
    {
        static void Main(string[] args)
        {
            AmusementParkRides a = new AmusementParkRides();
            a.AgeCheck(12);
            
        }

    }
    class AgeInvalidException : Exception
    {

        public AgeInvalidException(string message) : base(message)
        {
            Console.WriteLine(message);

        }

    }

    class AmusementParkRides
    { 
        public void AgeCheck(int age)
        {
            if(age > 18)
            {
                Console.WriteLine("You are allowed on the Roler Coaster");
            }
            else
            {
                throw new AgeInvalidException("You should be 18 yrs old");
            }
        }
    
    
    
    }



}





