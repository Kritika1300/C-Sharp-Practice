using System;

namespace Classes
{
    class Manager
    {
        public void Enter(SwipeCard obj)
        {
            obj.Swipe(this);
        }

        public void GetManagerName()
        {
            Console.WriteLine("Manager name");
        }

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
         
            SwipeCard objSwipe = new SwipeCard();

         
        }
    }


}