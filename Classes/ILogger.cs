using System;
using System.Collections.Generic;

namespace Classes
{
    public interface ILogger {

        public void LogInfo(string message);
        public void LogError(string message);

    }
}

//class Manager
//{

//    private string _name;
//    public Manager(string name)
//    {
//        this._name = name;
//    }

//    public string Name { get; private set; }
//}

//class Program
//{
//    public static void Main()
//    {
//        Manager m = new Manager("Kritika");
//        Console.WriteLine(m.Name);


//    }
//}