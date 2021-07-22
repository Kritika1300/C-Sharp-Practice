using System;

namespace Aggreagation
{
    class USBMouse
    {
        public void Navigate()
        {
            Console.WriteLine("Scrolling...");
        }

    }

    class Laptop
    {
        private USBMouse _mouse;
        public Laptop(USBMouse mouse)
        {
            _mouse = mouse;
        }
        public void Operate()
        {
            _mouse.Navigate();
        }
       
    }

    class MainClass
    {
            
        static void Main(string[] args)
        {

            Laptop laptop = new Laptop(new USBMouse());
            laptop.Operate();
            
        }
    }

}
