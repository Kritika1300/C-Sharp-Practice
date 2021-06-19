using System;
using System.Collections.Generic;

namespace Classes
{
    class Manager
    {

        List<Workers> listofworkers = new List<Workers>(); //owner of workers can be only 1 and that is Manager in this case
        public void Enter(SwipeCard obj)
        {
            obj.Swipe(this);
        }

        public void GetManagerName()
        {
            Console.WriteLine("Manager name");
        }

    }

    class Workers
    {
        public string workername = "";
    }

    class SwipeCard
    {
        public void Swipe(Manager obj)
        {
      
        }

        public void MakeofSwipeCard()
        {
            Console.WriteLine("Company name");
        }
    }
    
    class Program
    {
        public static void Main()
        {
            Manager objManager = new Manager();
            Workers w = new Workers(); //workers can exist independently.
         
            SwipeCard objSwipe = new SwipeCard();

         
        }
    }


}