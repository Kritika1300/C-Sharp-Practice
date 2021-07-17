using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    class MovieTicket
    {
        public double Price { get; set; }
        public string MovieName { get; set; }

    }

    class MovieArgs : EventArgs 
    {
      
        public double MPrice { get; set; }
        public string MName { get; set; }

    }
    class TicketProcessing
    {
        public delegate void TicketsBookingHandler(object source, MovieArgs e);

        public event TicketsBookingHandler TicketBooked;
        public void BookTickets(MovieTicket mt)
        {
            Console.WriteLine("Ticket Booked");

            OnTicketBooked(mt);
        }

        protected virtual void OnTicketBooked(MovieTicket mt)
        {
            if(TicketBooked != null)
            {
                TicketBooked(this, new MovieArgs() { MName = mt.MovieName, MPrice = mt.Price }); 
            }
        }
    
    
    }

    class Email
    {
        public void SendEmail(object sender, MovieArgs e)
        {
            Console.WriteLine("Sending Email......" + e.MName);
        }

    }

    class Text
    {
        public void SendText(object sender, MovieArgs e)
        {
            Console.WriteLine("Sending Text......"  + e.MName);
        }

    }

    class HelloWorld
    {
        public static void Main()
        {
            Email e = new Email();
            Text t = new Text();
            TicketProcessing m = new TicketProcessing();

            MovieTicket mt = new MovieTicket() { MovieName = "Soul", Price = 3 };
            MovieTicket mt1 = new MovieTicket() { MovieName = "Soul 2", Price = 4 };

            m.TicketBooked += e.SendEmail;
            m.TicketBooked += t.SendText;

            m.BookTickets(mt);
            m.BookTickets(mt1);
        }

    }

}







