using System;


namespace Classes
{
    public delegate string PrintHandler(string message);
    class Program
    {

        //public static string Print(string message)
        //{
        //   return "Hey your message is : " + message ;
        //}
        public static void Main()
        {
            PrintHandler obj = delegate(string message)           //ANONYMOUS METHOD
            {
                return "Hey check this message : " + message;
            };
            string str = obj.Invoke("Test message");
            Console.WriteLine(str);

        }

    }
}




