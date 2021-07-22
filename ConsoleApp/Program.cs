using System;

namespace Composition
{
    class Touchpad
    {
        public void Navigate()
        {
            Console.WriteLine("Scrolling...");
        }

    }

    class Laptop
    {
        private Touchpad _touchpad;
        public Laptop(Touchpad touchpad)
        {
            _touchpad = touchpad;
        }
        public void Operate()
        {
            _touchpad.Navigate();
        }
       
    }

    class MainClass
    {
            
        static void Main(string[] args)
        {

            Laptop laptop = new Laptop(new Touchpad());
            laptop.Operate();
        }
    }

}
