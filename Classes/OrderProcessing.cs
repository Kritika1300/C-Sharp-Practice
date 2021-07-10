using System;

namespace Restraunt
{
    public class OrderArgs : EventArgs 
    {
        public int OrderId{ get; set; }
    }


    public class OrderProcessing
    {
    

       public  event EventHandler<OrderArgs> OrderProcessed;
       public void ProcessOrder(Order order)
       {


            Console.WriteLine("Processing order");

            OnOrderProcessed(order.OrderId);

       }
       protected virtual void OnOrderProcessed(int OrderId)
       {
            if(OrderProcessed != null)
            {
                OrderProcessed(this, new OrderArgs() { OrderId = OrderId});
            }
       }

    }
}
