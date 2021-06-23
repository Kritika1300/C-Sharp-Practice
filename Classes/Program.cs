using System;
using System.Linq;

namespace Classes
{

    class Program
    {
        public static void Main()
        {
            Database db = new Database();
            IdCardGenerator id = new IdCardGenerator();
            EmailGenerator eg = new EmailGenerator();

            UserProcessor.UserProcessorEvent += db.SaveToDb;
            UserProcessor.UserProcessorEvent += id.GenerateIdCard;
            UserProcessor.UserProcessorEvent += eg.GenerateEmail;

            Console.WriteLine("Commands Accepted :");
            Console.WriteLine("1. new : Add new user");
            Console.WriteLine("2. exit : Close the Application");

            while (true)
            {
                Console.WriteLine("\nEnter command :");
                string cmdInput = Console.ReadLine();

                if (cmdInput.Equals("exit")) break;
                else if(cmdInput.Equals("new"))
                {
                    Console.WriteLine("Enter name:");
                    var name = Console.ReadLine();

                    Console.WriteLine("Enter age:");
                    var age =int.Parse(Console.ReadLine());

                    UserProcessor.ProcessUser(name, age);

                }
                else
                {
                    Console.WriteLine("Invalid command");
                }
            }


        }
    }

    public class UserProcessor
    {
        public static event EventHandler<UserArgs> UserProcessorEvent;

        public static void ProcessUser(string name, int age)
        {
            UserArgs args = new UserArgs();
            args.Name = name;
            args.Age = age;

            UserProcessorEvent?.Invoke(null, args);

        }
    }

    public class UserArgs : EventArgs
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Database
    {
        public void SaveToDb(object sender, EventArgs e)
        {
            Console.WriteLine("Saved to db");
        }
    }

    public class IdCardGenerator
    {
        public void GenerateIdCard(object sender, EventArgs e)
        {
            Console.WriteLine("Id card generated");
        }
    }

    public class EmailGenerator
    {
        public void GenerateEmail(object sender, EventArgs e)
        {
            Console.WriteLine("Email generated");
        }
    }


}




