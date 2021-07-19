using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    //class OrderProcessor  A single class having 3 responsibilities...
    //{
    //    public void Validate()
    //    {

    //    }
    //    public void Save()
    //    {

    //    }
    //    public void SendNotification()
    //    {

    //    }

    //}

    class OrderProcessor
    {
        private readonly ValidateOrder validateOrder;
        private readonly SaveOrder saveOrder;
        private readonly SendOrderNotification sendNotificationOrder;

        public OrderProcessor(ValidateOrder validateOrder, SaveOrder saveOrder, SendOrderNotification sendNotificationOrder)
        {
            this.validateOrder = validateOrder;
            this.saveOrder = saveOrder;
            this.sendNotificationOrder = sendNotificationOrder;
        }

        public void Process()
        {
            validateOrder.Validate();
            saveOrder.Save();
            sendNotificationOrder.SendNotification();
        }

    }

    public class ValidateOrder
    {
        public void Validate()
        {
            Console.WriteLine("Validating...");
        }
    }
    public class SaveOrder
    {
        public void Save()
        {
            Console.WriteLine("Saving...");
        }

    }
    public class SendOrderNotification
    {
        public void SendNotification()
        {
            Console.WriteLine("Sending notification....");
        }
    }

    public class HelloWorld
    {
        public static void Main()
        {
            OrderProcessor o = new OrderProcessor(new ValidateOrder(),new SaveOrder(), new SendOrderNotification());
            o.Process();

        }

    }

}







