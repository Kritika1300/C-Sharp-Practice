using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Linq;



namespace Restraunt
{
    
    class Program 
    {
       
        static void Main(string[] args)
        {
            Order order = new Order() { OrderId = 21 };
            OrderProcessing op = new OrderProcessing();
            Email email = new Email();
            Text text = new Text();


            op.OrderProcessed += email.SendEmail;
            op.OrderProcessed += text.SendText;
            op.ProcessOrder(order);


        }
       
    
    }            

 }
