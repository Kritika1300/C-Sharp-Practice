using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //interface IPrinter 
    //{
    //    public void Print();
    //    public void Scan();
    //    public void Fax();
    //    public void PrintDuplexContent();
    //}

    interface IPrinter
    {
        public void Print();
        public void Scan();
        public void Fax();
    }

    interface IPrintDuplexContent
    {
        public void PrintDuplexContent();
    }


    class HPLaserPrinter : IPrinter, IPrintDuplexContent
    {
        public void Fax()
        {
            Console.WriteLine("Fax");
        }

        public void Print()
        {
            Console.WriteLine("Print");

        }

        public void PrintDuplexContent()
        {
            Console.WriteLine("Duplex");

        }

        public void Scan()
        {
            Console.WriteLine("Scan");

        }
    }

    class HPPrinter : IPrinter
    {
        public void Fax()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }
    }


    class HelloWorld
    {
        public static void Main()
        {
           
        }

    }

}







