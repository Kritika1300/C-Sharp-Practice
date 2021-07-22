using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobile2 m = new Mobile2();
           

        }
            
        
    }
    public abstract class MobilePhone
    {
        public abstract void Calling();
        public abstract void SendSMS();
       
    }

    public class Mobile1 : MobilePhone
    {
        public override void  Calling()
        {
            Console.WriteLine("Calling");
        }
        public override void SendSMS()
        {
            Console.WriteLine("SMS");
        }
    }

    public class Mobile2 : MobilePhone
    {
        public override void Calling()
        {
            Console.WriteLine("Calling");
        }
        public override void SendSMS()
        {
            Console.WriteLine("SMS");
        }
        public void FMRadio()
        {
            Console.WriteLine("FM");
        }
        public void Camera()
        {
            Console.WriteLine("Camera");
        }
        public void Recording()
        {
            Console.WriteLine("Recording");
        }
        public void ReadAndSendEmails()
        {
            Console.WriteLine("Emails");
        }
    }

  
}