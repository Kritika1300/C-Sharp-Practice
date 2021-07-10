using System;
using System.Collections.Generic;

namespace Restraunt
{
    public class Email
    {

        public void SendEmail(object sender,OrderArgs e)
        {
            Console.WriteLine("Sending email " + e.OrderId);
        }
     
    }

   
}