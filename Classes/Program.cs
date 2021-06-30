using System;
using System.Threading;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {


        public static void Main(string[] args)
        {
            Text text = new Text(); //subscriber
            Email email = new Email(); //subscriber
            Authentication auth = new Authentication();

            Authentication.AuthenticationEvent += text.SendText;
            Authentication.AuthenticationEvent += email.SendEmail;
            Authentication.AuthenticationEvent -= email.SendEmail;

            Console.WriteLine("Enter username");
            string uname = Console.ReadLine();

            Console.WriteLine("Enter email");
            string mail = Console.ReadLine();

            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            Console.WriteLine("Checking credentials......");

            auth.AuthenticationProcess(uname, mail, password);

        }


    }

    class PersonArgs : EventArgs //arguements
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }

    class Authentication
    {
        public static event EventHandler<PersonArgs> AuthenticationEvent;

        public void AuthenticationProcess(string uname,string mail, string pass) //subscriber
        {

            OnAuthenticationEvent(uname,mail,pass);

        }
        protected virtual void OnAuthenticationEvent(string uname, string mail, string pass)
        {
            AuthenticationEvent?.Invoke(this, new PersonArgs() { Username = uname, Email = mail, Password = pass});
        }
    }

    public class Email //subscriber
    {
        public void SendEmail(object sender, EventArgs e)
        {
            Console.WriteLine("Sending Email.....");
        }
    }

    public class Text //subscriber
    {
        public void SendText(object sender, EventArgs e)
        {
            Console.WriteLine("Sending Text.....");
        }
    }

}




