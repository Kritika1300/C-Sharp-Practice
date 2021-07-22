using System;

namespace Composition
{
    class Compressor
    {
        public void Cooling()
        {
            Console.WriteLine("Cooling...");
        }
            
    }
    class AirConditioner 
    {
        private Compressor _compressor;
        public AirConditioner(Compressor compressor)
        {
            _compressor = compressor;
        }
        public void PowerOn()
        {
            _compressor.Cooling();
        }     

    }
    class MainClass
    {
            
        static void Main(string[] args)
        {
            AirConditioner airConditioner = new AirConditioner(new Compressor());
            airConditioner.PowerOn(); 

        }
    }

}
